using System;

namespace Lab_Tutorial_3
{
    class Product
    {
        string pcode;
        string pname;
        string mname;

        public Product(string pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        public void Display()
        {
            Console.WriteLine("Product Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }

    class TestProduct
    {
        public static void _5Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
            }
            else
            {
                string pcd = args[0];
                string pnm = args[1];
                string mnm = args[2];

                Product p = new Product(pcd, pnm, mnm);

                p.Display();

                Console.Read();
            }
        }
    }
}