using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Contracts
{
    internal interface IMyHashMap
    {
        void Put(int key, int value);

        int Get(int key);

        void Remove(int key);
    }
}
