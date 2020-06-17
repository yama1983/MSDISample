using System;
using System.Dynamic;

namespace Sample.Domain
{
    public class Integer : IInteger
    {
        private int Num { get; set; }

        public Integer() : this(0) { }

        public Integer(int i)
            => Num = i;

        public void Increment()
            => Num++;

        public int GetNum()
            => Num;
    }
}
