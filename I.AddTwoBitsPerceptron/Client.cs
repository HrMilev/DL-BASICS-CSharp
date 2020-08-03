using System;
using System.Collections.Generic;

namespace I.AddTwoBitsPerceptron
{
    public class Client
    {
        static void Main()
        {
            var v1 = new InputValue(1);
            var v2 = new InputValue(0);
            
            Perceptron NAND1 = new Perceptron(4, new List<(IPerceptron<int> neuron, int weigth)>
            {
                (v1, -3),
                (v2, -3)
            });
            Perceptron NAND2 = new Perceptron(4, new List<(IPerceptron<int> neuron, int weigth)>
            {
                (v1, -3),
                (NAND1, -3)
            });
            Perceptron NAND3 = new Perceptron(4, new List<(IPerceptron<int> neuron, int weigth)>
            {
                (NAND1, -3),
                (v2, -3)
            });
            Perceptron NAND4 = new Perceptron(4, new List<(IPerceptron<int> neuron, int weigth)>
            {
                (NAND2, -3),
                (NAND3, -3)
            });
            Perceptron NAND5 = new Perceptron(4, new List<(IPerceptron<int> neuron, int weigth)>
            {
                (NAND1, -3),
                (NAND1, -3)
            });

            int zeroBit = NAND4.Result();
            int firstBit = NAND5.Result();

            Console.WriteLine($"{firstBit}{zeroBit}");
        }
    }
}
