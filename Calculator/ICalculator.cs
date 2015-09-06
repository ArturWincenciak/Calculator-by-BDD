namespace Calculator
{
    public interface ICalculator
    {
        void Enter(int number);

        void Plus();

        void Multiply();

        void Substruction();

        void PressEqual();

        int Result { get; }
    }
}