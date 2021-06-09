using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model.Sandwiches
{
    class Cream_cheese_base : Sandwich
    {
        public override string Bread { get; set; }
        public override string Base { get; set; }
        public override double Cost { get; set; }

        public Cream_cheese_base()
        {
            Cost = 2.90;
            Bread = "White Bread";
            Base = "Cream Cheese";
        }

        public override string ToString()
        {
            return "Cream Cheese base";
        }
    }
}
