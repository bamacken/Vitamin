﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Hashtable
    {
        private Item[] hashtable;
        private int capacity;
        private int size = 100;

        /// <summary>
        /// Hashtable constructor
        /// </summary>
        /// <param name="capacity"></param>
        public Hashtable(int capacity)
        {
            // set hashtable capacity and create the hashtable object
            this.capacity = capacity;
            hashtable = new Item[capacity];

            // init hashtable to default/generic values 
            for (int i = 0; i < hashtable.Length; i++)
            {
                hashtable[i] = new Item("open", null);
            }

            object obj = GetHash("open");
        }

        // get hash code
        int Hash(string value)
        {
            return Math.Abs(value.GetHashCode() % this.capacity);
        }

        // Get Hash
        public object GetHash(string key)
        {
            int hash = Hash(key);

            // check for collision
            while (hashtable[hash].getKey() != "open" && hashtable[hash].getKey() != key)
            {
                hash = (hash + 1) % capacity;
            }

            return hashtable[hash].getValue();
        }

        // insert
        public void Insert(string key, object value)
        {
            if (key != null)
            {
                int hash = Hash(key);
                // check for collision
                while (hashtable[hash].getKey() != "open" && hashtable[hash].getKey() != key)
                {
                    hash = (hash + 1) % capacity;
                }
                hashtable[hash] = new Item(key, value);
            }
        }

        // search


        public class Item
        {
            private string key;
            private object value;

            public Item(string key, object value)
            {
                this.key = key;
                this.value = value;
            }

            public string getKey()
            {
                return this.key;
            }

            public object getValue()
            {
                return this.value;
            }
        }
    }
}
