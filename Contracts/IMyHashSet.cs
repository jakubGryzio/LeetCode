using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Contracts
{
    internal interface IMyHashSet
    {
        void Add(int key);

        void Remove(int key);

        bool Contains(int key); 
    }
}
