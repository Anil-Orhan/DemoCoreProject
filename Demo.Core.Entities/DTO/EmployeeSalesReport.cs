using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Entities.DTO
{
    public class EmployeeSalesReport:IDTO
    {
        public int EmployeeID { get; set; }    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderAmounth { get; set; }        
        public decimal TotalSale { get; set; }    

    }
}
