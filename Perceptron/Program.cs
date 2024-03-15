namespace Perceptron
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] initialWeightValues = { 0.75, -1.25};
            const double initialBiasValue = 0.5;
            double[][] inputValues = { new[]{0.0, 0.0}, new[]{0.3, -0.7}, new[]{ 1.0, 1.0 }, new[]{ -1.0, -1.0}, new[]{ -0.5, 0.5 } };

            Perceptron perceptron = new Perceptron(initialWeightValues, initialBiasValue);

            double[] output = perceptron.Compute(inputValues);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"{output[i]} \n");
            }
        }
    }
}