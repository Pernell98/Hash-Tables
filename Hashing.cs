using System;

using System;
using System.Collections.Generic;
using System.Text;

namespace Hashing_Table
{
    class Hashing
    {
        private Hashtable hashes = new Hashtable(2);
        public Hashing()
        {
            hashes = insert();
            find(2);
        }


        public hashingTable insert()
        {
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("enter something\n");
                hashes.Add(a, Console.ReadLine());
            }
            return hashes;
        }
    
        

        public hashTable remove()
        {
        hashes.Remove(key);
        return hashes;
        }



        public hashTable find()
        {
        if (hashes.ContainsKey(key))
        {
            Console.WriteLine("found " + hashes[key]);
        }
        else
            Console.WriteLine("the key " + key + " is not found in the hash.");
        }

    }
}
