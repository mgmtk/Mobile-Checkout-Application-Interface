using System;
using System.Collections.Generic;
using System.Collections;

namespace SolutionItems {

    public class Item
    {
        // set up conncetion to retrieve actual item list from database

        private static Dictionary<String, int> itemValList = new Dictionary<String, int>();
        private List<String> itemList = new List<String>()  { "a0000", "b0001", "c0010", "0011", "e0100",
                                                                    "f0101","g0110", "h0111", "i1000","j1001",
                                                                    "k1010", "l1011", "m1100", "n1101", "o1111" };
        private String id;
        private int itemValue;
        public Item(String id, int value)
        {
            this.id = id;
            //  fillDict();
            //this.itemValue = itemValList[id];
            this.itemValue = value;


        }
        public int getValue()
        {
            return this.itemValue;
        }
        public String getId()
        {
            return this.id;
        }
        private void fillDict()
        {
            try
            {
                for (int i = 0; i < itemList.Count; i++)
                {
                    itemValList.Add(item, i);

                }
            }
            catch
            {

                Console.Write("Went wrong filling item dict");

            }


        }
    }
}

