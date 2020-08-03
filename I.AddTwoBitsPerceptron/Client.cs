using System;

namespace I.AddTwoBitsPerceptron
{
    public class Client
    {
        static void Main()
        {
            int byte1 = 0;
            int byte2 = 0;

            Perceptron NAND1 = new Perceptron(-3, -3, 4);
            Perceptron NAND2 = new Perceptron(-3, -3, 4);
            Perceptron NAND3 = new Perceptron(-3, -3, 4);
            Perceptron NAND4 = new Perceptron(-3, -3, 4);
            Perceptron NAND5 = new Perceptron(-3, -3, 4);

            NAND1.Byte1 = byte1;
            NAND1.Byte2 = byte2;

            NAND2.Byte1 = byte1;
            NAND2.Link2 = NAND1;

            NAND3.Link1 = NAND1;
            NAND3.Byte2 = byte2;

            NAND4.Link1 = NAND2;
            NAND4.Link2 = NAND3;

            NAND5.Link1 = NAND1;
            NAND5.Link2 = NAND1;

            int zeroBit = NAND4.Result();
            int firstBit = NAND5.Result();

            Console.WriteLine($"{firstBit}{zeroBit}");
        }
    }
}
