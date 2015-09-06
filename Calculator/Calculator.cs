using System;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private int input;
        private int result;
        private int lastResult;

        private bool reset = true;

        private Func<int, int, int> operation;

        public Calculator()
        {
            Reset();
        }

        public void Enter(int number)
        {
            input = number;
        }

        public void Plus()
        {
            operation = (x, y) => x + y;
            lastResult = operation(input, lastResult);
        }

        public void Multiply()
        {
            operation = (x, y) => x * y;

            if (reset)
                lastResult = 1;

            lastResult = operation(input, lastResult);
        }

        public void Substruction()
        {
            operation = (x, y) => x - y;
            lastResult = operation(input, lastResult);
        }

        public void PressEqual()
        {
            result = operation(lastResult, input);
            lastResult = result;
        }

        public int Result
        {
            get { return result; }
        }

        private void Reset()
        {
            result = 0;
            lastResult = 0;
            operation = (x, y) => 0;
            reset = true;
        }
    }
}
