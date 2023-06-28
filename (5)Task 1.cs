using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
abstract class Weapon
{
    private int id = 0;
    protected string name = "";
    protected double price = 0;
    static private int autoincrement = 1;
    Random random = new Random();
    private void generateId()
    {

        this.id = autoincrement;
        autoincrement++;
    }
    protected void initItem(string[] names)
    {


        this.name = names[random.Next(0, names.Length)];
        this.price = random.Next(100, 900);
    }

    public int getId()
    {
        return this.id;
    }

    public double getPrice()
    {
        return this.price;
    }

    public string getName()
    {
        return this.name;
    }

    public void showName()
    {
        Console.WriteLine($"-={this.name}=-");
    }

    public Weapon(Random random)
    {
        this.random = random;
    }

    public Weapon(Random random, string name, double price)
    {
        this.generateId();
        this.random = random;

        this.name = name;
        this.price = price;
    }
}
class Gun : Weapon
{
    private string[] names = { "Glock", "Deagle", "CCW 101" };
    private double magazinCapacity = 0;
    public Gun(Random random, double magazinCapacity) : base(random)
    {
        this.magazinCapacity = magazinCapacity;
        this.initItem(names);
    }
}
class Sword : Weapon
{
    private string[] names = { "Shortsword", "Model 1832", "Machete" };
    private double length = 0;
    public Sword(Random random, double length) : base(random)
    {
        this.length = length;
        this.initItem(names);
    }
}
class Rifle : Weapon
{
    private string[] names = { "Blaser R8", "CZ 455", "ArmaLite AR-7" };
    private double magazinCapacity = 0;
    public Rifle(Random random, double magazinCapacity) : base(random)
    {
        this.magazinCapacity = magazinCapacity;
        this.initItem(names);
    }
}
    class Spear : Weapon
    {
        private string[] names = { "Bill Hook", "Glaive", "Lance" };
        private double length = 0;
        public Spear(Random random, double length) : base(random)
        {
            this.length = length;
            this.initItem(names);
        }
    }
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}