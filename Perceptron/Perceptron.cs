using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class Perceptron
    {
        double[] weights;
        double bias;
        public Perceptron(double[] initialWeightValues, double initialBiasValue)
        { /*initializes the weights array and bias*/

            weights = initialWeightValues;
            bias = initialBiasValue;
        }

        public Perceptron(int amountOfInputs)
        { /*Initializes the weights array given the amount of inputs*/

            weights = new double[amountOfInputs];
            
        }

        public void Randomize(Random random, double min, double max)
        { /*Randomly generates values for every weight including the bias*/

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = random.Next((int)min, (int)max);
            }

        }

        public double Compute(double[] inputs)
        { /*computes the output with given input*/

            double output = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                output += inputs[i] * weights[i];
            }


            return output + bias;
        }

        //public double[] Compute(double[][] inputs)
        //{ /*computes the output for each row of inputs*/

        //    double[] output = new double[inputs.Length / 2];

        //    for (int i = 0; i < inputs.Length; i++)
        //    {
        //        for (int k = 0; k < inputs.Length; k++)
        //        {
        //            output += inputs[i][k] * weights[i];
        //        }
                
        //    }


        //    return output + bias;

        //}
    }
}
