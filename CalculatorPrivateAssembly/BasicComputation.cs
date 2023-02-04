using System;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public float Addition (float num1, float num2)
        {
            float answer = num1 + num2;
            return answer;
        }
        public float Subtraction(float num1, float num2)
        {
            float answer = num1 - num2;
            return answer;
        }
        public float Multiplication(float num1, float num2)
        {
            float answer = num1 * num2;
            return answer;
        }
        public float Division(float num1, float num2)
        {
            float answer = num1 / num2;
            return answer;
        }

    }
}
