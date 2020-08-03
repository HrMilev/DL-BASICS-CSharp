using System;
using System.Collections.Generic;
using System.Text;

namespace I.AddTwoBitsPerceptron
{
    public class InputValue : IPerceptron<int>
    {
        private readonly int value;

        public InputValue(int value)
        {
            this.value = value;
        }

        public int Result()
        {
            return value;
        }
    }
}
