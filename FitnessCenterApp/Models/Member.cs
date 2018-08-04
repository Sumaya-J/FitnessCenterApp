using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCenterApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name ="Joining Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime JoiningDate { get; set; }
        [Display(Name ="Membership Type")]
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}