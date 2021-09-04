using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {

        static void Great(string name)
        {
            Console.WriteLine("Good Morning" + name);

        }

        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            return(a + b)/2;
           
        }
        static void Main(string[] args)
        {
            /*
             fvrnabgrtsn granb;lnnkcnklnvklfnkl nlkdnlkjk, nklfhklcnkl   
            davrberbh3qw  fedgwr geafv db  ghetftfnaeh fdegvgsw 
             */



            //This is important for debuggin. do not remove
            //  int prateek = 55;
            //   Console.WriteLine("Hello World");
            //   Console.Write("Hello Prateek");
            //   Console.WriteLine("I Love c# and the number" + prateek);
            //   Console.ReadLine(); 

            //int a = 5;
            //float b = 34.4F;
            //double c = 2545;
            //Boolean isGreat = true;
            //char d = 'p';


            //Console.WriteLine(d);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.ReadLine();

            // 1.implicit

            //char to int to long to float to double//
            //char= 2byts,2,4,2,4


            //


            // 2.explicit

            //int a = (int) 3.5;

            //int x = 3;
            //double y = x;

            //char  z = 'y';
            //
            // double g = 3.2f;


            //Console.WriteLine(x);
            // Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(g);

            //Console.WriteLine("Enter your name");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hey hello"  + name);

            //
            // Console.WriteLine("How many candies do you want?");

            // string can = Console.ReadLine();
            // Console.WriteLine("you will get"  + 
            //  (Convert.ToInt32(can) + 4));

            //int a = Math.Max(55, 96);
            //Console.WriteLine(a);

            //int b = Math.Min(55, 96);
            //Console.WriteLine(b);



            //double p = Math.Sqrt(66);
            //Console.WriteLine(p);


            //double q = Math.Abs(-66);
            // Console.WriteLine(q);


            //string hello = "hello world this is prateek";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello+ "you are nice");
            //Console.WriteLine(string.Concat (hello+ "you are nice"));

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is  {name}. you will get {candies} candies");

               string hello = "hello world this is prateek";
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("prateek"));
            //Console.WriteLine(hello.Substring(11));
            //Console.WriteLine(hello);

            // Console.WriteLine("Enter your age");
            // string ageStr = Console.ReadLine();
            // int age = Convert.ToInt32(ageStr);

            // if (age <2)
            // {
            //     Console.WriteLine("you are just born");


            // }

            //else  if (age <10)
            // {
            //     Console.WriteLine("please finish your high school");


            // }
            // else if (age <18)
            // {
            //     Console.WriteLine("you are below 18");


            // }
            // else if (age <75)
            // {
            //     Console.WriteLine("you can drive");


            // }
            //else
            // {

            //     Console.WriteLine("you can drive");


            // }


            //int i = 0;
            //while(i<50)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;

            //}



            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;

            //} while (i <5);


            //for (int i=0; i<5; i++)
            //{

            //    if (i==0)
            //    {

            //        continue;
            //    }

            //    Console.WriteLine(i + 1);
            //break;
            //}



            //Great("prateek");
            //Great("raju");
            //Console.WriteLine(Average(5, 9, 8));
            //float temp = Average(9, 7, 0);
            //Console.WriteLine(temp);
            //Console.WriteLine(Average(3,3,3));
            //Console.WriteLine(Average(3, 3));

            Console.ReadLine();




        }
    }
}
