using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.model
{
    class Storage
    {
        static Storage instance;

        public Storage()
        {
            sandwichList = new List<Sandwich>();
        }

        public static Storage getInstance()
        {
            if (instance == null)
                instance = new Storage();
            return instance;
        }

        /* Methods */

        public void addSandwich(Sandwich sandwich)
        {
            instance.sandwichList.Add(sandwich);
        }

        public void removeSandwich(Sandwich sandwich)
        {
            instance.sandwichList.Remove(sandwich);
        }


        /* Properties */

        public int storageMaxSize { get; set; }
        public List<Sandwich> sandwichList { get; set; }
        
    }
}
