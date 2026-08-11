using System;

namespace Lab_Tutorial_3
{
    class Line
    {
        private double length;   // Length of a line

        // Constructor
        public Line()
        {
            Console.WriteLine("Object is being created, length = 10");
            length = 10;
        }

        // Set length
        public void setLength(double len)
        {
            length = len;
        }

        // Get length
        public double getLength()
        {
            return length;
        }
    }

    class TestLine
    {
        static void Main(string[] args)
        {
            // Create object
            Line line = new Line();

            // Set line length to 10
            line.setLength(10);
            Console.WriteLine("Length of line : {0}", line.getLength());

            // Set line length to 6
            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}