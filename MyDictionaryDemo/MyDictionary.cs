using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    class MyDictionary<K,V>
    {
        K[] key; V[] value;
        K[] tempKey; V[] tempValue;
        
        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K key, V value)
        {
            tempKey = this.key;
            tempValue = this.value;

            this.key = new K[this.key.Length + 1];
            this.value = new V[this.value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++) {
                this.key[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++) {
                this.value[i] = tempValue[i];
            }
            this.key[this.key.Length - 1] = key;
            this.value[this.value.Length - 1] = value;
        }

        public int Length()
        {
            return this.key.Length;
        }
    }
}
