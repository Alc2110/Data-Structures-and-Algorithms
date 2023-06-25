using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SymbolTables
{
    public class BinarySearchSymbolTable<TKey, TValue> where TKey : IComparable<TKey>
    {
        /*
        private TKey[] _keys;
        private TValue[] _values;
        */
        private List<TKey> _keys;
        private List<TValue> _values;
        private int _n = 0; // number of key-value pairs

        /// <summary>
        /// </summary>
        /// <param name="size">Capacity of the table.</param>
        //public BinarySearchSymbolTable(int size)
        public BinarySearchSymbolTable()
        {
            /*
            this._keys = new TKey[size];
            this._values = new TValue[size];
            */
            this._keys = new List<TKey>();
            this._values = new List<TValue>();
        }//ctor

        /// <summary>
        /// Number of key-value pairs in the table.
        /// </summary>
        /// <returns></returns>
        public int Size() => this._n;

        /// <summary>
        /// Returns the value corresponding to this key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TValue this[TKey key]
        {
            get
            {
                if (this.Size() == 0)
                    return default(TValue);

                if (object.Equals(key, default(TKey)))
                    throw new ArgumentNullException("Key is null");

                int i = this.Rank(key);
                if (i < this._n && this._keys[i].CompareTo(key) == 0)
                {
                    return this._values[i];
                }
                else
                {
                    return default(TValue);
                }
            }
        }

        /// <summary>
        /// Number of keys smaller than the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Rank(TKey key)
        {
            if (object.Equals(key, default(TKey)))
                throw new ArgumentNullException("Key is null");

            int low = 0;
            int high = this._n - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                int comp = key.CompareTo(this._keys[mid]);
                if (comp < 0)
                {
                    high = mid - 1;
                }
                else if (comp > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return low;
        }//Rank

        public void Insert(TKey key, TValue value)
        {
            if (object.Equals(key, default(TKey)))
                throw new ArgumentNullException("Key is null");

            int i = this.Rank(key);
            // update value if found
            if (i < this._n && this._keys[i].CompareTo(key) == 0)
            {
                this._values[i] = value;

                return;
            }
            // otherwise, add new key-value pair to table
            for (int j = this._n; j > i; j--)
            {
                this._keys[j] = this._keys[j - 1];
                this._values[j] = this._values[j - 1];
            }
            this._keys[i] = key;
            this._values[i] = value;

            this._n++;
        }//Insert

        /// <summary>
        /// Removes the given key and its associated value from the table.
        /// </summary>
        /// <param name="key"></param>
        public void Delete(TKey key)
        {
            if (object.Equals(key, default(TKey)))
                throw new ArgumentNullException("Key is null");

            int i = this.Rank(key);

            if (i == this._n || this._keys[i].CompareTo(key) != 0)
            {
                // key not found in table
                return;
            }

            // shift remaining keys and values by one
            for (int j = i; i < this._n-1; j++)
            {
                this._keys[j] = this._keys[j + 1];
                this._values[j] = this._values[j + 1];
            }

            this._n--;
            this._keys[this._n] = default(TKey);
            this._values[this._n] = default(TValue);
        }//Delete
    }//class
}