using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using storageManager.controller;

namespace storageManagerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FillingUpTheStorage()
        {
            StorageController controller = new StorageController();

            int default_count = controller.getSandwichCount();

            controller.fillStorage();

            int after_fill_count = controller.getSandwichCount();

            Assert.AreNotEqual(default_count, after_fill_count,"Something is wrong with the filling.");
        }

        [TestMethod]
        public void RemovingARandomSandwich()
        {
            StorageController controller = new StorageController();

            controller.fillStorage();

            int default_count = controller.getSandwichCount();

            int r = new Random().Next(default_count);

            controller.removeSandwich(controller.getSandwichByIndex(r));

            int after_delete_count = controller.getSandwichCount();

            Assert.AreNotEqual(default_count, after_delete_count, "Something is wrong with deleting sandwich!");
        }
    }
}
