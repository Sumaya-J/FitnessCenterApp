using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FitnessCenterApp.Models;

namespace FitnessCenterApp.ViewModels
{
    public class MemberFormVM
    {
        private DateTime joiningDate;

        public int? Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string GetFullName()
        {
            return String.Concat(string.Format("{0} {1}", FirstName, LastName));
        }

        [Display(Name = "Full Name")]
        public string DisplayFullName { get { return GetFullName(); } }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime JoiningDate {
            get
            {
                return (joiningDate == DateTime.MinValue) ? DateTime.Now : joiningDate;
            }
            set { joiningDate = value; }
        }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        [Required]
        public IList<ServiceCheckBoxVM> Services { get; set; }
    }
}