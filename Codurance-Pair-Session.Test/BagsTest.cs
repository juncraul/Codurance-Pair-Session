using NUnit.Framework;
using Codurance_Pair_Session.Library;
using System.Collections.Generic;
using System.Linq;

namespace Codurance_Pair_Session.Test
{
    public class Tests
    {
        Inventory inventory;

        [SetUp]
        public void Setup()
        {
            inventory = new Inventory();
        }

        [Test]
        public void AddOneItem_WillHaveABackpackOfOneItem()
        {
            string[] expectedBackpack = new string[1];
            expectedBackpack[0] = "Leather";
            inventory.AddItem("Leather");
            var actualBackpack = inventory.Backpack;
            Assert.AreEqual(expectedBackpack, actualBackpack);
        }

        [Test]
        public void AddTwoItems_WillHaveABackpackOfTwoItems()
        {
            List<string> expectedBackpack = new List<string>();
            expectedBackpack.Add("Leather");
            expectedBackpack.Add("Iron");
            inventory.AddItem("Leather");
            inventory.AddItem("Iron");
            var actualBackpack = inventory.Backpack;
            Assert.AreEqual(expectedBackpack, actualBackpack);
        }

        [Test]
        public void AddNineItems_WillHaveAFullBackpackWithEightItems()
        {
            List<string> expectedBackpack
                = (new string[] { "Leather", "Iron", "Copper", "Marigold", "Wool", "Gold", "Silk", "Copper" }).ToList();

            inventory.AddItem("Leather");
            inventory.AddItem("Iron");
            inventory.AddItem("Copper");
            inventory.AddItem("Marigold");
            inventory.AddItem("Wool");
            inventory.AddItem("Gold");
            inventory.AddItem("Silk");
            inventory.AddItem("Copper");
            inventory.AddItem("Cherry Blossom");
            var actualBackpack = inventory.Backpack;
            Assert.AreEqual(expectedBackpack, actualBackpack);
        }

        [Test]
        public void SortingItems_WillHaveTheBackpackTheItemsSortedAlphabetically()
        {
            List<string> expectedBackpack
                = (new string[] { "Copper", "Iron", "Leather", "Marigold" }).ToList();

            inventory.AddItem("Marigold");
            inventory.AddItem("Leather");
            inventory.AddItem("Iron");
            inventory.AddItem("Copper");
            inventory.SortBackpack();
            var actualBackpack = inventory.Backpack;
            Assert.AreEqual(expectedBackpack, actualBackpack);
        }

        [Test]
        public void AddNineItems_WillHaveAFullBackpackWithEightItemsAndOneBagWithOneItem()
        {
            List<string> expectedBackpack
                = (new string[] { "Leather", "Iron", "Copper", "Marigold", "Wool", "Gold", "Silk", "Copper" }).ToList();
            List<string> expectedBag
                = (new string[] { "Cherry Blossom" }).ToList();

            inventory.AddItem("Leather");
            inventory.AddItem("Iron");
            inventory.AddItem("Copper");
            inventory.AddItem("Marigold");
            inventory.AddItem("Wool");
            inventory.AddItem("Gold");
            inventory.AddItem("Silk");
            inventory.AddItem("Copper");
            inventory.AddItem("Cherry Blossom");
            var actualBackpack = inventory.Backpack;
            var actualBag = inventory.Bag;
            Assert.AreEqual(expectedBackpack, actualBackpack);
            Assert.AreEqual(expectedBag, actualBag);
        }

        [Test]
        public void SortingItems_WillMoveMetalItemsIntoFirstBag()
        {
            List<string> expectedBackpack
                = (new string[] {  }).ToList();
            List<string> expectedBag
                = (new string[] { "Copper" }).ToList();

            inventory.AssignBagType("Metal");
            inventory.AddItem("Copper");
            inventory.SortBackpack();
            var actualBackpack = inventory.Backpack;
            var actualBag = inventory.Bag;
            Assert.AreEqual(expectedBackpack, actualBackpack);
            Assert.AreEqual(expectedBag, actualBag);
        }
    }
}