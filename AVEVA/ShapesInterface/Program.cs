namespace Shapes
{
    public interface IShape
    {
        void print();
        void draw();
        double area();
    }

    class Square : IShape
    {
        private string Name { get; set; }
        private int Side { get; set; }

        public Square(int side)
        {
            this.Name = "Square";
            this.Side = side;
        }

        public void print() { Console.WriteLine($"{this.Name}"); }

        public void draw()
        {
            for (int i = 0; i < this.Side; i++)
            {
                for (int j = 0; j < this.Side; j++)
                {
                    if (i == 0 || i == this.Side - 1 || j == 0 || j == this.Side - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public double area()
        {
            return this.Side * this.Side;
        }
    }

    class Triangle : IShape
    {
        private string Name { get; set; }
        private int Base { get; set; }
        private int Height { get; set; }

        public Triangle(int Base, int Height)
        {
            this.Name = "Triangle";
            this.Base = Base;
            this.Height = Height;
        }

        public void print() { Console.WriteLine($"{this.Name}"); }

        public void draw()
        {
            int maxStars = 1 + 2 * (Height - 1);

            for (int i = 0; i < Height; i++)
            {
                int stars = 1 + 2 * i;
                int spaces = (maxStars - stars) / 2;

                for (int j = 0; j < spaces; j++)
                    Console.Write(" ");

                for (int j = 0; j < stars; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        public double area()
        {
            return (this.Base * this.Height) / 2;
        }
    }

    class Circle : IShape
    {
        public string Name { get; set; }
        private int Radius { get; set; }

        public Circle(int Radius)
        {
            this.Name = "Circle";
            this.Radius = Radius;
        }

        public void print() { Console.WriteLine($"{this.Name}"); }

        public void draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;

            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x <= Radius; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public double area()
        {
            return 3.14 * this.Radius * this.Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape> { new Square(5), new Triangle(4, 6), new Circle(3) };

            foreach (IShape shape in shapes)
            {
                shape.print();
                shape.draw();
                Console.WriteLine($"Area: {shape.area()}\n");
            }
        }
    }
}
