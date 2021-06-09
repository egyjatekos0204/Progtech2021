using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageManager.model;
using storageManager.model.Sandwiches;
using storageManager.model.Addons;

namespace storageManager.sandwichFactory
{
    class SandwichFactory
    {
        public static Sandwich MakeSandwich(string breadBase, string addon = null)
        {
            Sandwich sandwich = null;

            switch (breadBase)
            {
                case "Butter":
                    sandwich = new Butter_base();
                    break;

                case "Cream Cheese":
                    sandwich = new Cream_cheese_base();
                    break;

                case "Nutella":
                    sandwich = new Nutella_base();
                    break;

                default:
                    throw new Exception("Wrong breadBase!");
                    
            }

            switch (addon)
            {
                case "Cheese":
                    sandwich = new Cheese(sandwich);
                    break;

                case "Tomato":
                    sandwich = new Tomato(sandwich);
                    break;

                case "Ham":
                    sandwich = new Ham(sandwich);
                    break;

                default:
                    break;
            }


            return sandwich;
            


        }
    }
}
