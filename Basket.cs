using System;
using System.Collections.Generic;
namespace SolutionItems {
    public class Basket
    {

        private int totalItemCount; //includes duplicates
        private static int basketCount;
        private Dictionary<Item, int> items;

        public Basket()
        {
            this.totalItemCount = 0;
            this.basketCount++;
            this.items = new Dictionary<Item, int>();

        }
        public String getBasketNumber()
        {
            return this.basketCount;


        }
        public Boolean add(Item item)
        {
            try
            {

                if (items.ContainsKey(item))
                {
                    items[item] = items[item] + 1;

                }
                else
                {
                    items.Add(item, 1);

                }
                totalItemCount++;
                return true;
            }
            catch
            {
                Console.Write("Went wrong adding to dict");
                return false;
            }

        }
        public int getBasketCount()
        { // number of basket 

            return this.getBasketCount;
        }
        public int getTotalItemCount()
        { // returns all items
            return totalItemCount;

        }
        public int getItemCount()
        { //returns number of key value pairs

            return items.Count;
        }
        public Boolean remove(Item item)
        {
            try
            {
                if (!items.ContainsKey(item))
                {
                    return;

                }

                if (items[item] > 1)
                {
                    items[item] = items[item] - 1;

                }
                else
                {
                    items.Remove(item);

                }
                totalItemCount--;
                return true;
            }
            catch
            {
                Console.Write("went wrong removing item from dict");
                return false;

            }


        }
        public Dictionary<String, int> getTable()
        {

            return this.items;
        }
        public int basketValue()
        {
            List<Item> keys = items.Keys;
            int totalCost = 0;
            try
            {
                foreach (Item item in keys)
                {
                    totalCost += (item.getValue() * items[item]); //item cost times the number of that item in the basket

                }
                return totalCost;

            }
            catch {

                Console.Write("problem getting total basket cost");

            }
           
        }
        public void clear()
        {

            items = new Dictionary<string, int>();
            totalItemCount = 0;

        }

    }


}

