using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model.Addons
{
    class Cheese : AddonDecorator
    {
        public Cheese(Sandwich _sandwich) : base(_sandwich)
        {
            AddonsList.Add(this);
        }

        public override string ToString()
        {
            return "Cheese";
        }
    }
}
