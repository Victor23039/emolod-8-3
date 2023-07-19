namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected class User:sames
        {
            private string[] names = { "Ivan", "Oleksandr", "Volodymyr", "Oleksiy", "Nikita" };
            protected string comments = "";
            public User(Random random, string comments) : base (random)
            {
                this.comments = comments;
                this.initsames(names);
            }
        }

        protected class Administrator:sames
        {
            private string[] names = { "Ivan", "Oleksandr", "Volodymyr", "Oleksiy", "Nikita" };
            protected string bans = "";
            public Administrator(Random random, string bans) : base (random)
            {
                this.bans = bans;
                this.initsames(names);
            }
        }

        protected class Moderator:sames
        {
            private string[] names = { "Ivan", "Oleksandr", "Volodymyr", "Oleksiy", "Nikita" };
            protected string articles = "";
            public Moderator(Random random, string articles) : base (random)
            {
                this.articles = articles;
                this.initsames(names);
            }
        }


        public class sames
        {
            protected string name = "";
            protected string email = "";
            protected string password = "";
            protected double phoneNumber = 0;
            protected double age = 0;
            Random random = null;
            protected void initsames(string[] names)
            {
                this.name = names[random.Next(0, names.Length)];
                this.age = random.Next(6, 101);
            }
            public string getName()
            {
                return this.name;
            }
            public string getEmail()
            { 
                return this.email;
            }
            public string getPassword()
            {
                return this.password;
            }
            public double getPassword()
            {
                return this.password;
            }
            public double getAge()
            {
                return this.age;
            }
            public void showName()
            {
                Console.WriteLine($"-={this.name}=-");
            }
            public sames(Random random)
            {
                this.random = random;
            }
            public sames(Random random, string name, string password, string email, double phoneNumber, double age)
            {
                this.random = random;
                this.name = name;
                this.email = email;
                this.phoneNumber = phoneNumber;
                this.age = age;
                this.password = password;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Адміністратор_Click_1(object sender, EventArgs e)
        {

        }

        private void Користувач_Click(object sender, EventArgs e)
        {

        }
    }
}