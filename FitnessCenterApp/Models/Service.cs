using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApp.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        //public bool IsSelected { get; set; } //shouldn't be here cuz this variable depends on member
        //public bool IsExpired { get; set; }  //expiration should be calculated upon differance between 
        //JoiningDate of member (in Member model) and TodayDate 
        //considering MembershipPlan Duration (in MembershipType model) 
        //if ( ((Model.Member.JoiningDate.Date - DateTime.Now.Date).Days) > Model.MembershipType.DurationInDays ){
        // save selected service 
        // } else { 
        // show 'Already subscribed to this service' notification 
        //public virtual IList<MemberService> MemberServices { get; set; }
        public virtual ICollection<Member> Members { get; set; }

        //property that tells who the Service belongs to
        //public int MemberId { get; set; }
    }
}