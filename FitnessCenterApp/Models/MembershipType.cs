using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FitnessCenterApp.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountRate { get; set; }
        public int DurationInDays { get; set; }
        
        //reference to list of including services
        
        //public virtual Member Member { get; set; }
        //property that tells who the MembershipType belongs to
        //public int MemberId { get; set; }
    }
}