using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierClasses
{
    public class ProductGroup
    {
        public int PGId { get; set; }
        public string PGName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
