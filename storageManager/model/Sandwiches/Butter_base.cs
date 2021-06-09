using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model.Sandwiches
{
    class Butter_base : Sandwich
    {
        public override string Bread { get; set; }
        public override string Base { get; set; }
        public override double Cost { get; set; }

        public Butter_base()
        {
            Bread = "White Bread";
            Base = "Butter";
            Cost = 1.8;
        }

        public override string ToString()
        {
            return "Butter base";
        }
    }
}
