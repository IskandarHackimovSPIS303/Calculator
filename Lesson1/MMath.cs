using System;
using System.Collections.Generic;
using System.Text;

namespace Subjects
{
    public class MMath:Math
    {
        void test1()
        {
            sum(1, 2);
        }
        protected int count(int[] elementArray)
        {
            return elementArray.Length;
        }
    }
}
