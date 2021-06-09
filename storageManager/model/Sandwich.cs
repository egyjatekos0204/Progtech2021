using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageManager.interfaces;

namespace storageManager.model
{
    public abstract class Sandwich : IStorageObserver
    {
        abstract public string Bread { get; set; }
        abstract public string Base { get; set; }
        abstract public double Cost { get; set; }

        public override bool Equals(object obj)
        {
            Sandwich _sw = (Sandwich)obj;
            return _sw.Base == this.Base && _sw.Bread == this.Bread && _sw.Cost == this.Cost;
        }

        public void update(double price)
        {
            this.Cost = price;
        }
    }
}
