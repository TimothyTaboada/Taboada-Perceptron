using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputPerceptron
{
    public class Perceptron
    {
        // Define the input and output arrays
        private double[,] inputs = { { 0, 0, 0, 0 }, { 0, 0, 0, 1 }, { 0, 0, 1, 0 }, { 0, 0, 1, 1 }, { 0, 1, 0, 0 }, { 0, 1, 0, 1 }, { 0, 1, 1, 0 }, { 0, 1, 1, 1 }, { 1, 0, 0, 0 }, { 1, 0, 0, 1 }, { 1, 0, 1, 0 }, { 1, 0, 1, 1 }, { 1, 1, 0, 0 }, { 1, 1, 0, 1 }, { 1, 1, 1, 0 }, { 1, 1, 1, 1 } };
        private double[] outputs = { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1 };

        // Define the weights and bias
        private Random ran = new Random();
        private double[] weights = { 0, 0, 0, 0 };
        private double bias = 0;

        // Define the learning rate, weighted sum, output and error
        private double learningRate = 0.1;
        private double weightedSum = 0;
        private double output = 0;
        private double error = 0;

        // Initialize weights and bias in constructor
        public Perceptron()
        {
            for (int x = 0; x > 4; x++)
            {
                weights[x] = ran.NextDouble();
            }
            bias = ran.NextDouble();

            Train();
        }

        // Train the perceptron
        private void Train()
        {
            for (int i = 0; i < 10000; i++)
            {
                for (int j = 0; j < inputs.GetLength(0); j++)
                {
                    weightedSum = inputs[j, 0] * weights[0] + inputs[j, 1] * weights[1] + inputs[j, 2] * weights[2] + inputs[j, 3] * weights[3] + bias;
                    output = weightedSum > 0 ? 1 : 0;
                    error = outputs[j] - output;

                    weights[0] += error * inputs[j, 0] * learningRate;
                    weights[1] += error * inputs[j, 1] * learningRate;
                    weights[2] += error * inputs[j, 2] * learningRate;
                    weights[3] += error * inputs[j, 3] * learningRate;
                    bias += error * learningRate;
                }
            }
        }

        // Return the predicted value as double
        public double Predict(double[] inputs)
        {
            weightedSum = inputs[0] * weights[0] + inputs[1] * weights[1] + inputs[2] * weights[2] + inputs[3] * weights[3] + bias;
            return output = weightedSum > 0 ? 1 : 0;
        }
    }
}
