using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model
{
    class AddonDecorator : Sandwich
    {
        Sandwich sandwich = null;

        public AddonDecorator(Sandwich _sandwich)
        {
            sandwich = _sandwich;
            AddonsList = new List<AddonDecorator>();
        }

        public override string Bread { get => sandwich.Bread; set => sandwich.Bread = value; }
        public override string Base { get => sandwich.Base; set => sandwich.Bread = value; }
        public override double Cost { get => sandwich.Cost; set => sandwich.Cost = value; }

        public List<AddonDecorator> AddonsList {
            get; set;
            
        }

        

        public override bool Equals(object obj)
        {
            AddonDecorator addon = (AddonDecorator)obj;
            if (this.AddonsList.Count != addon.AddonsList.Count) return false;

            for (int i = 0; i < AddonsList.Count; i++)
            {
                if (AddonsList[i] != addon.AddonsList[i]) return false;
            }
            return base.Equals(obj);
        }
    }
}
