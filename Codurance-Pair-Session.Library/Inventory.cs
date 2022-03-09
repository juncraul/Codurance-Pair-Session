using System.Collections.Generic;

namespace Codurance_Pair_Session.Library
{
    public class Inventory
    {
        private const int MAX_ITEMS_IN_BACKPACK = 8;

        public List<string> Backpack;
        public List<string> Bag;

        public Inventory()
        {
            Backpack = new List<string>();
            Bag = new List<string>();
        }

        public void AddItem(string item)
        {
            if (!IsBackpackFull())
            {
                Backpack.Add(item);
            }
            else
            {
                Bag.Add(item);
            }
        }

        private bool IsBackpackFull()
        {
            return Backpack.Count >= MAX_ITEMS_IN_BACKPACK;
        }

        public void SortBackpack()
        {
            Backpack.Sort();
        }

        public void AssignBagType(string v)
        {
            return;
        }

        enum Categories
        {

        }
    }
}