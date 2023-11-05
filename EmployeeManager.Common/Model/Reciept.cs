using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager.Common.Model
{
    public class Reciept
    {
        public int Id { get; set; }

        public string Supplier { get; set; }

        public DateTimeOffset EntryDate { get; set; }

        public int Catagory { get; set; }

        public double Total { get; set; }

        public bool VAT { get; set; }

        public double VatValue { get; set; }

    }
}
