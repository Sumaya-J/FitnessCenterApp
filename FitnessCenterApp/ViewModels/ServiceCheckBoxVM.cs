using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCenterApp.ViewModels
{
    public class ServiceCheckBoxVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
        public bool IsSelected { get; set; }
    }
}