using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_that_uses_hashing
{
    class Set<T>
    {
        private List<T>[] buckets = new List<T>[100];

        public void Insert(T item)
        {
            int bucket = GetBucket(item.GetHashCode());

            if (Contains(item, bucket))
            {
                return;
            }
            if (buckets[bucket] == null)
            {
                buckets[bucket] = new List<T>();
            }

            buckets[bucket].Add(item);
        }


        public bool Contains(T item)
        {
            return Contains(item, GetBucket(item.GetHashCode()));
        }

        public bool Contains(T item, int bucket)
        {
            if (buckets[bucket] != null)
            {
                foreach (T member in buckets[bucket])
                {
                    if (member.Equals(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int GetBucket(int hashCode)
        {
            //A hash code can be negeative . To make sure that you end up with positive
            //value dast the value to unsind int. The uncheckde block mas sur the 
            //you can cast avlue larger then int to an in safely
            unchecked
            {
                return (int)((uint)hashCode % (uint)buckets.Length);
            }

        }
    }
}
