namespace I.AddTwoBitsPerceptron
{
    public class Perceptron
    {
        private readonly int weigth1;
        private readonly int weigth2;
        private readonly int bias;

        public Perceptron(int weigth1, int weigth2, int bias)
        {
            this.weigth1 = weigth1;
            this.weigth2 = weigth2;
            this.bias = bias;
        }

        public Perceptron Link1 { get; set; }
        public Perceptron Link2 { get; set; }
        public int Byte1 { get; set; }
        public int Byte2 { get; set; }

        public int Result()
        {
            return ((Link1 == null ? Byte1 : Link1.Result()) * weigth1
                + (Link2 == null ? Byte2 : Link2.Result()) * weigth2
                + bias) > 0 ? 1 : 0;
        }
    }
}
