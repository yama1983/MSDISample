using System;
using Sample.Domain;

namespace Sample.App
{
    public class SampleService : ISampleService
    {
        private IInteger Integer { get; }

        public SampleService(IInteger integer)
            => Integer = integer;

        public void AddNumber()
            => Integer.Increment();

        public int GetResult()
            => Integer.GetNum();
    }
}
