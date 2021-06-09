using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model.Sandwiches
{
    class Nutella_base : Sandwich
    {
        public override string Bread { get; set; }
        public override string Base { get; set; }
        public override double Cost { get; set; }

        public Nutella_base()
        {
            Cost = 2.0;
            Bread = "White Bread";
            Base = "Nutella";
        }

        public override string ToString()
        {
            return "Nutella base";
        }
    }
}
