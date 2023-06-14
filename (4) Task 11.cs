using ConsoleApp3;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    public class Car
    {
        private List<Unit> units;
        Engire engire = null;
        private List<Engire> goods;
        public void addEngire (Engire engire)
        {
            if (engire != null)
            {
                if (this.engire == null)
                {
                    this.engire = engire;
                }
                else
                {
                    goods.Add (engire);
                    this.engire = engire;
                }
            }
        }
    }
        class Sedan : Car
        {
        public double brand = null
        public double model = null
        public int graduationYear = 0
        public Sedan (double brand, double model, int GraduationYear)
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = GraduationYear;
        }
        }
        class Van : Car
        {
        {
        public double brand = null
        public double model = null
        public int graduationYear = 0
        public Van(double brand, double model, int GraduationYear)
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = GraduationYear;
        }
        }
}
        class Pickup : Car
        {
        public double brand = null
        public double model = null
        public int graduationYear = 0
        public Pickup(double brand, double model, int GraduationYear)
        {
        this.brand = brand;
        this.model = model;
        this.graduationYear = GraduationYear;
        }
        }
class Engire
{
    private int power = 0;
    private int volume = 0;
}
public Engire(int power, int volume)
{
    this.power = power;
    this.volume = volume;
}   

    internal class Program
    {
        static void Main(string[] args)
    {
        Car car = new car();
        List<Sedan> list = new List<Sedan>();
        Sedan roach = new Sedan(Toyota, bZ3, 2017)
            list.Add(roach);
        List<Van> list = new List<Van>();
        Van roach = new Van(Ford, Transit, 2016)
            list.Add(roach);
        List<Pickup> list = new List<Pickup>();
        Pickup roach = new Pickup(Nissan, Navara, 2022)
            list.Add(roach);
        Random rand = new Random ();
        List<Engire> list = new List<Engire> ();
        for (int i = 0; i<10; i++)
        {
            Engire roach = new Engire(rand.Next(12, 45), rand.Next(1, 13));
            list.Add(roach);
        }
    }
            
    }
}