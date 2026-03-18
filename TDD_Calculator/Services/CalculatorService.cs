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
    }
}
