using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApp.Models
{
    public class Invoice
    {
        public int Id { get; set; } //Invoice Number
        public DateTime InvoiceDate { get; set; }

        
        //public Member BilledTo { get; set; } //Member Name, can be accessed since i know the member id

        //property that tells who the Invoice belongs to
        //public int MemberId { get; set; }

        //public Service Service { get; set; }

        //public MembershipType MembershipType { get; set; }
    }
}