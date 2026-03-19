namespace TDD_Calculator.Services
{
    public class CalculatorService
    {
        public int Add(int x, int y)
        {
            checked
            {
                return x + y;
            }
        }

        public int Subtract(int x, int y)
        {
            checked
            {
                return x - y;
            }
        }

        public int Multiply(int x, int y)
        {
            checked
            {
                return x * y;
            }
        }

        public int Divide(int x, int y)
        {
            checked
            {
                return x / y;
            }
        }
    }
}
