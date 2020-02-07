namespace IntermediateRefresher
{
    public class Calculator
    {

        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public static void Run()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(1, 2, 3, 4, 5);
            System.Console.WriteLine(sum);
        }
    }
}
