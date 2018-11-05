using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public string Product { get; set; }

        public string UnitPrice { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
