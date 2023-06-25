using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues
{
    public class IndexMinPriorityQueue<TKey> where TKey : IComparable<TKey>
    {
        private int _maxN; // maximum number of elements on the queue
        private int _n; // number of elements on the queue
        private int[] _pq; // binary heap using 1-based indexing
        private int[] _qp; // inverse of binary heap: qp[pq[i]] = pq[qp[i]] = i
        private TKey[] _keys; // items with priorities

        public IndexMinPriorityQueue(int maxN)
        {
            this._maxN = maxN;

            this._keys = new TKey[maxN + 1];
            this._pq = new int[maxN + 1];
            this._qp = new int[maxN + 1];

            for (int i = 0; i <= maxN; i++)
            {
                this._qp[i] = -1;
            }
        }//ctor

        public bool IsEmpty() => this._n == 0;

        public bool Contains(int index)
        {
            return this._qp[index] != -1;
        }

        public int Count
        {
            get => this._n;
        }

        public void Insert(int index, TKey key)
        {
            this._n++;
            this._qp[index] = this._n;
            this._pq[this._n] = index;
            this._keys[index] = key;
            Swim(this._n);
        }

        public int MinIndex()
        {
            return this._pq[1];
        }

        public TKey MinKey()
        {
            return this._keys[_pq[1]];
        }

        public int DeleteMin()
        {
            int indexOfMin = this._pq[1];
            Exchange(1, this._n--);
            Sink(1);
            this._keys[this._pq[this._n + 1]] = default(TKey);
            this._qp[this._pq[this._n + 1]] = -1;

            return indexOfMin;
        }

        private bool Less(int i, int j)
        {
            return this._pq[i].CompareTo(this._pq[j]) < 0;
        }

        private bool Greater(int i, int j)
        {
            return this._keys[this._pq[i]].CompareTo(this._keys[this._pq[j]]) > 0;
        }

        private void Exchange(int i, int j)
        {
            int swap = this._pq[i];
            this._pq[i] = this._pq[j];
            this._pq[j] = swap;
            this._qp[this._pq[i]] = i;
            this._qp[this._pq[j]] = j;
        }

        private void Sink(int k)
        {
            while (2*k <= this._n)
            {
                int j = 2 * k;
                if (j < this._n && Greater(j, j + 1))
                {
                    j++;
                }
                if (!Greater(k,j))
                {
                    break;
                }
                Exchange(k, j);
                k = j;
            }
        }

        private void Swim(int k)
        {
            while (k > 1 && Less(k/2, k))
            {
                Exchange(k / 2, k);
                k = k / 2;
            }
        }
    }//class
}
