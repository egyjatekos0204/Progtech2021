using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model.Addons
{
    class Ham : AddonDecorator
    {
        public Ham(Sandwich _sandwich) : base(_sandwich)
        {
            AddonsList.Add(this);
        }

        public override string ToString()
        {
            return $"{base.Base} with ham";
        }
    }
}
