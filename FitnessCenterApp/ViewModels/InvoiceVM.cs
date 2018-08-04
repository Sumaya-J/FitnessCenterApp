using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCenterApp.Models;

namespace FitnessCenterApp.ViewModels
{
    public class InvoiceVM
    {
        public string BillToName { get; set; }
        public int MembershipTypeId { get; set; }
        public string MembershipTypeName { get; set; }
        public int MembershipTypeDiscount { get; set; }
        public int MembershipTypeDuration { get; set; }
        public IList<ServiceCheckBoxVM> Services { get; set; }
        public int FeeTotal { get; set; } 
        public int SubTotal { get; set; } 
        public Decimal Total { get; set; }
    }
}