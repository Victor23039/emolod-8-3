int SS = 0;
int PS = 0;
int ST = 0;
int SC = 0;
int PC = 0;
int PR = 0;
int SR = 0;
class Figure
{
    class Rectangle : Figure
    {

    }
    class Square : Figure
    {
    
    }
    class Trapezium : Figure
    {
    
    }
    class Circle : Figure
    {
     
    }
}
Console.WriteLine("=========================================================");
Console.WriteLine("Введіть радіус (см): ");
double rnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть висоту (см): ");
double vnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть ширину (см): ");
double snumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть довжину (см): ");
double fnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведіть фігуру - прямокутник, квадрат, трапеція, коло: ");
double figure = Console.ReadLine();
switch (figure);
case 'прямокутник':
    Console.WriteLine("Площа");
    SR = fnumber * snumber;
    Console.WriteLine("Периметр");
    PR = (fnumber + snumber) * 2;
    break;
case 'квадрат':
    Console.WriteLine("Площа");
    SS = fnumber ^ 2;
    Console.WriteLine("Периметр");
    PS = fnumber * 4;
    break;
case 'трапеція':
    Console.WriteLine("Площа");
    ST = (fnumber + snumber) / 2 * vnumber;
    break;
case 'коло':
    Console.WriteLine("Площа");
    SC = 3,14 * rnumber^2;
    Console.WriteLine("Периметр");
    PC = 2 * 3,14 * rnumber;
    break;