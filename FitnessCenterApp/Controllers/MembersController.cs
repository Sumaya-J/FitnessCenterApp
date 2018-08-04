using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FitnessCenterApp.Models;
using FitnessCenterApp.ViewModels;

namespace FitnessCenterApp.Controllers
{
    public class MembersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        public ActionResult ListMembers()
        {
            var members = db.MemberDbSet.Include(m => m.MembershipType).ToList();
            return View(members);
        }

        [Authorize]
        public ViewResult NewMember()
        {
            var vm = new MemberFormVM
            {
                MembershipTypes = db.MembershipTypeDbSet.ToList(),
                Services = db.ServiceDbSet.Select(s => new ServiceCheckBoxVM
                {
                    Id = s.Id,
                    Name = s.Name,
                    IsSelected = false
                }).ToList()
            };

            return View("AddMember", vm);
        }

        [HttpPost]
        public ActionResult SaveNew(MemberFormVM vm)
        {
            if (ModelState.IsValid)
            {
                var member = new Member
                {
                    FullName = vm.GetFullName(),
                    MembershipTypeId = vm.MembershipTypeId,
                    PhoneNumber = vm.PhoneNumber,
                    JoiningDate = vm.JoiningDate,
                    Services = new List<Service>()
                };

                foreach (var selectedService in vm.Services.Where(s => s.IsSelected))
                {
                    var service = new Service { Id = selectedService.Id };
                    db.ServiceDbSet.Attach(service);
                    member.Services.Add(service);
                }

                db.MemberDbSet.Add(member);
                db.SaveChanges();

                return RedirectToAction("ListMembers", "Members");
            }
            return View(vm);
        }

        public ActionResult InvoiceDetails(int id)
        {
            var data = db.MemberDbSet
                 .Where(m => m.Id == id)
                 .Select(m => new
                 {
                     vm = new InvoiceVM
                     {
                         BillToName = m.FullName,
                         MembershipTypeId = m.MembershipTypeId,
                         MembershipTypeName = m.MembershipType.Name,
                         MembershipTypeDiscount = m.MembershipType.DiscountRate,
                         MembershipTypeDuration = m.MembershipType.DurationInDays
                     },
                     ServiceIds = m.Services.Select(s => s.Id)
                 })
                 .SingleOrDefault();

            if (data == null)
                return HttpNotFound();

            data.vm.Services = db.ServiceDbSet
                .Select(ss => new ServiceCheckBoxVM
                {
                    Id = ss.Id,
                    Name = ss.Name,
                    Fee = ss.Fee
                })
                .ToList();

            foreach (var s in data.vm.Services)
                s.IsSelected = data.ServiceIds.Contains(s.Id);

            data.vm.FeeTotal = data.vm.Services.Where(s => s.IsSelected).Sum(f => f.Fee);
            data.vm.SubTotal = data.vm.FeeTotal * data.vm.MembershipTypeDuration;
            data.vm.Total = data.vm.SubTotal - (data.vm.SubTotal * data.vm.MembershipTypeDiscount / 100);
            return View("InvoiceDetails", data.vm);
        }
    }
}
