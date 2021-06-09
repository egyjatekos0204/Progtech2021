using storageManager.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storageManager
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageController st = new StorageController();

            st.fillStorage();

            do
            {
                st.handleUser();
            } while (true);


            
        }
    }
}
