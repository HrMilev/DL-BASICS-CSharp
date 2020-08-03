using System.Collections.Generic;
using System.Linq;

namespace I.AddTwoBitsPerceptron
{
    public class Perceptron : IPerceptron<int>
    {
        private readonly int bias;
        private readonly IList<(IPerceptron<int> neuron, int weigth)> links;

        public Perceptron(int bias, IList<(IPerceptron<int> neuron, int weigth)> links)
        {
            this.bias = bias;
            this.links = links;
        }

        public int Result()
        {
            return (links.Select( x => x.neuron.Result() * x.weigth ).Sum() + bias) > 0 ? 1 : 0;
        }
    }
}
