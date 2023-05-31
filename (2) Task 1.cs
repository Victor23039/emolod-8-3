internal class Program
{
    private static void Main(string[] args)
    {
        {
            double r = 0;
            string opt1 = @"Console.WriteLine(""Enter first number: "");
            double first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(""Enter second number: "");
            double second = Convert.ToInt32(Console.ReadLine())"
            string opt2 = @"Console.WriteLine(""Enter first number: "");
            double first = Convert.ToInt32(Console.ReadLine());"
            Console.WriteLine("Choose operation(+,-,*,/,pow,sqrt,%,): ");
            string opt = "Console.ReadLine()"
            switch (opt);
                case "+":
                Console.WriteLine(opt1);
                    r = first + second;
                    break;
                case "-":
                Console.WriteLine(opt1);
                    r = first - second;
                    break;
                case "*":
                Console.WriteLine(opt1);
                    r = first * second;
                    break;
                case "/":
                Console.WriteLine(opt1);
                if (first = 0)
                    Console.WriteLine("Неможлива дія");
                else if (second = 0)
                    Console.WriteLine("Неможлива дія");
                else
                    r = first / second;
                    break;
                case "pow":
                Console.WriteLine(opt2);
                    r = Math.Pow(first);
                    break;
                case "sqrt":
                Console.WriteLine(opt2);
                r = Math.Sqrt(first);
                    break;
                case "%":
                Console.WriteLine(opt1);
                r = first / 100 * second;
                    break;
                }
            }}
}