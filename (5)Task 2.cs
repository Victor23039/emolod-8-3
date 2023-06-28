using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

abstract class Item
{
    private int id = 0;
    protected string name = "";
    protected double price = 0;
    protected double weight = 0;
    Random random = null;
    static private int autoincrement = 1;
    private void generateId()
    {

        this.id = autoincrement;
        autoincrement++;
    }
    protected void initItem(string[] names)
    {


        this.name = names[random.Next(0, names.Length)];
        this.price = random.Next(35000, 50000);
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

    public Item(Random random)
    {
        this.random = random;
    }

    public Item(Random random, string name, double price)
    {
        this.generateId();
        this.random = random;

        this.name = name;
        this.price = price;
    }
}
class Laptop : Item
{
    private string[] names = { "Gamer's", "Universal", "Office" };
    private string description = "";

    public Laptop(Random random, string description) : base(random)
    {
        this.description = description;
        this.initItem(names);
    }
}
class Player
{
    private Laptop laptop = null;

    private double coinsCount = 0;

    public Player()
    {
        this.coinsCount = 60000;
    }

    public bool checkBuy(double coins)
    {
        if (coins > coinsCount)
        {
            return false;
        }

        return true;
    }

    public void minusCoins(double coins)
    {
        coinsCount -= coins;
    }


    public void setLaptop(Laptop laptop)
    {
        this.laptop = laptop;
    }
}


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Random random = new Random();
            Player player = new Player();
            Item laptop = new Laptop(random, "Laptop ASUS TUF Gaming F15 FX506HM-HN017 (90NR0753-M01170) Eclipse Gray " +
                "/ Intel Core i5-11400H / RAM 16 GB / SSD 512 ГБ / nVidia GeForce RTX 3060" +
                "The TUF Gaming F15 is smaller and lighter than previous models in the series, but has a larger 90Wh battery." +
                " This ensures long battery life. The light weight and long battery life make this laptop a truly mobile device.");
        }
    }
}