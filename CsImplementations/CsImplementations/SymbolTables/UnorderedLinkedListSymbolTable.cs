using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures.SymbolTables
{
    /// <summary>
    /// Stores keys and values in an unordered linked list.
    /// </summary>
    public class UnorderedLinkedListSymbolTable<TKey, TValue>
    {
        private Node _first;
        private int _n = 0; // number of key-value pairs in the table

        private class Node 
        {
            public TKey key;
            public TValue val;
            public Node next;

            public Node(TKey key, TValue value, Node next)
            {
                this.key = key;
                this.val = value;
                this.next = next;
            }
        }//class

        /// <summary>
        /// Finds the value associated with the key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Value associated with the key. Null if the key is not in the table.</returns>
        public TValue Get(TKey key)
        {
            for (Node n = this._first; n != null; n = n.next)
            {
                if (key.Equals(n.key))
                {
                    return n.val;
                }
            }

            return default(TValue);
        }//Get

        /// <summary>
        /// Adds a new key-value pair.
        /// If the key already exists, updates the value.
        /// If the key does not exist, adds the new key-value pair.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Insert(TKey key, TValue value)
        {
            // first check if key already exists
            // update its value if it does exist
            for (Node n = this._first; n != null; n = n.next)
            {
                if (key.Equals(n.key))
                {
                    n.val = value;
                    return;
                }
            }

            // key not found
            // add key-value pair to table
            this._first = new Node(key, value, this._first);
            this._n++;
        }//Insert

        /// <summary>
        /// Removes the key and its associated value.
        /// Sets the value corresponding to the key to null.
        /// TODO: completely remove the key from the table.
        /// </summary>
        /// <param name="key"></param>
        public void Delete(TKey key)
        {
            if (!this.Contains(key))
                return;

            for (Node n = this._first; n != null; n = n.next)
            {
                if (key.Equals(n.key))
                {
                    n.val = default(TValue);
                    this._n--;
                }
            }
        }//Delete

        /// <summary>
        /// Finds whether there is a value associated with the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(TKey key)
        {
            for (Node n = this._first; n != null; n = n.next)
            {
                if (key.Equals(n.key))
                    return true;
            }

            return false;
        }//Contains

        /// <summary>
        /// Gets whether there are no key-value pairs in the table.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => (this._n == 0);

        /// <summary>
        /// Number of key-value pairs in the table.
        /// </summary>
        /// <returns></returns>
        public int Size() => this._n;

        /// <summary>
        /// All keys in the table.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TKey> Keys()
        {
            List<TKey> keys = new List<TKey>();
            for (Node n = this._first; n != null; n = n.next)
            {
                keys.Add(n.key);
            }
            keys.Sort();

            return keys;
        }//Keys
    }//class
}
