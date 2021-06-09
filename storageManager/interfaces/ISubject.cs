using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageManager.model;

namespace storageManager.interfaces
{
    interface ISubject
    {
        void addSandwich(string breadBase, string addon = null);
        void removeSandwich(Sandwich sandwich);
        void notifyObserver(Sandwich sandwich, double price);
    }
}
