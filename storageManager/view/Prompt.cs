using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager.view
{
    class Prompt
    {
        public string getStorageOptions()
        {
            return "\t\t\tSandwich Storage \n1. List Storage\n2. Sandwich bases\n3. Manage Price\n4. Fill Storage\n5. Buy sandwich\nq. Quit";
        }
        public string getSandwichBases()
        {
            return "\n1. Butter\n2. Cream Cheese\n3. Nutella";
        }
        public string needAddon()
        {
            return "Do you want some addon? (y/n)";
        }
        public string getAddons()
        {
            return "1. Cheese\n2. Ham\n3. Tomato";
        }
    }
}
