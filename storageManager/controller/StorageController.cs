using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using storageManager.model;
using storageManager.interfaces;
using storageManager.sandwichFactory;
using storageManager.view;

namespace storageManager.controller
{
    public class StorageController : ISubject
    {
        static Storage storage;
        static Prompt prompt;

        public StorageController()
        {
            storage = Storage.getInstance();
            prompt = new Prompt();
        }

        public void handleUser()
        {
            Console.WriteLine(prompt.getStorageOptions());
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            switch (input)
            {
                case '1':
                    Console.WriteLine("\nSandwich storage:");

                    if(storage.sandwichList.Count == 0)
                    {
                        Console.WriteLine("There is no sandwich in the storage.");
                        break;
                    }
                        

                    foreach (Sandwich sandwich in storage.sandwichList)
                    {
                        Console.WriteLine($"{sandwich} ({sandwich.Cost})");
                    }
                    break;
                case '2':
                    Console.WriteLine("Currently available sandwich bases:");
                    Console.WriteLine(prompt.getSandwichBases());
                    break;
                case '3':
                    Console.WriteLine("Which sandwich base, do u want to change?");
                    Console.WriteLine(prompt.getSandwichBases());
                    char s = Console.ReadKey().KeyChar;

                    string sandwich_base = "";

                    switch (s)
                    {
                        case '1':
                            sandwich_base = "Butter";
                            break;

                        case '2':
                            sandwich_base = "Cream Cheese";
                            break;

                        case '3':
                            sandwich_base = "Nutella";
                            break;

                        default:
                            break;
                    }
                    if (sandwich_base == "")
                        break;

                    Console.Write("\nNew price: ");
                    double price = double.Parse(Console.ReadLine());
                    setPrice("White Bread", sandwich_base, price);
                    break;
                case '4':
                    fillStorage();
                    Console.WriteLine("Sandwich storage filled!");
                    break;
                case '5':
                    Console.WriteLine("Available sandwiches:");
                    for (int i = 0; i < storage.sandwichList.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {storage.sandwichList[i]}");
                    }
                    Console.Write("Which sandwich do u want: ");
                    int k = int.Parse(Console.ReadKey().KeyChar.ToString());

                    removeSandwich(storage.sandwichList[k - 1]);
                    Console.WriteLine("\nSandwich removed from the list!");

                    break;
                case 'q':
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }

            Console.WriteLine("\n\n");
        }

        public void addSandwich(string breadBase, string addon = null)
        {
            storage.addSandwich(SandwichFactory.MakeSandwich(breadBase, addon));
        }

        public void fillStorage()
        {
            addSandwich("Nutella");
            addSandwich("Butter");
            addSandwich("Cream Cheese");
            addSandwich("Cream Cheese", "Ham");
        }

        public void notifyObserver(Sandwich sandwich, double price)
        {
            List<Sandwich> sandwiches = storage.sandwichList.FindAll((s) => s.Base == sandwich.Base && s.Bread == sandwich.Bread && s.Cost == sandwich.Cost); ;
            foreach (Sandwich sw in sandwiches)
            {
                sw.update(price);
            }
        }

        public void removeSandwich(Sandwich sandwich)
        {
            storage.removeSandwich(sandwich);
        }

        public void setPrice(string Bread, string bread_Base, double price)
        {
            Sandwich sw = storage.sandwichList.Find((s) => s.Bread == Bread && s.Base == bread_Base);
            notifyObserver(sw, price);
        }

        public int getSandwichCount()
        {
            return storage.sandwichList.Count;
        }

        public Sandwich getSandwichByIndex(int index)
        {
            return storage.sandwichList[index];
        }

    }
}
