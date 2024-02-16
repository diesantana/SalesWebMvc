using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public ICollection<Department> Departments { get; set; }
        public Seller Seller { get; set; }

        public SellerFormViewModel(ICollection<Department> departmens)
        {
            Departments = departmens;
        }
    }
}
