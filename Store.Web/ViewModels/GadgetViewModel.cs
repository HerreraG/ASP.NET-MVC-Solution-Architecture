﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.ViewModels {
    public class GadgetViewModel {
        public int GadgetID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryID { get; set; }
    }
}