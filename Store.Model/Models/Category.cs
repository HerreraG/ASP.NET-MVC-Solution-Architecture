using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model {
    public class Category {
        public int CategoryID { get; set; }
        public String Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Gadget> Gadgets { get; set; }

        public Category() {
            this.DateCreated = DateTime.Now;
        }
    }
}
