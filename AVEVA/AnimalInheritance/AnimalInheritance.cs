namespace Polymorphism
{
    public abstract class Animal
    {
        protected string name { set; get; }
        protected List<string> breed { set; get; }
        protected int age { set; get; }

        protected Animal(string name, List<string> breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public abstract void sound();

        public virtual void eat()
        {
            Console.WriteLine("Nom Nom");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, List<string> breed, int age) : base(name, breed, age) { }

        public override void sound()
        {
            Console.WriteLine("Woof Woof!");
        }

        public override void eat()
        {
            Console.WriteLine("Gnom Gnom");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, List<string> breed, int age) : base(name, breed, age) { }

        public override void sound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Alpha", new List<string> { "German Shepherd", "Husky" }, 4);
            Dog dog2 = new Dog("Nimbus", new List<string> { "King German Shepherd", "Husky", "Slow" }, 3);
            Cat cat1 = new Cat("Garfield", new List<string> { "Orange" }, 4);

            List<Animal> Animals = new List<Animal> { dog1, dog2, cat1 };

            foreach (Animal a in Animals)
            {
                a.sound();
                a.eat();
            }
        }
    }
}
