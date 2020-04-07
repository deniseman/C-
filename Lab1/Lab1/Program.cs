using System;

namespace Lab1
{
    class Program
    {
        static float Ftoc(float f)
        {
            return (f - 32) * 5 / 9;
        }

        static float Ctof(float c)
        {
            return c*9/5+32;
        }

        static void Main(string[] args)
        {
            //ex1
            int[] fib = new int[100];
            fib[0] = 0; fib[1] = 1;
            int a = int.Parse(Console.ReadLine());
            Console.Write("{0} {1} ", fib[0], fib[1]);
            for (int i=2; i < a; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.Write("{0} ", fib[i]);
            }
            
            Console.ReadLine(); 

            /* //ex2
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            Calcule calcule = new Calcule(x, y);
            calcule.afisare();
            Console.Read(); */

            /*
            //ex3
            float celsius=float.Parse(Console.ReadLine());
            float fahrenheit= float.Parse(Console.ReadLine());

            Console.WriteLine("celsius->fahrenheit:{0}\nfahrenheit->celsius:{1}", Ctof(celsius), Ftoc(fahrenheit));
            Console.Read(); */

            //ex4
            /*
            int inaltime = int.Parse(Console.ReadLine());
            int varsta = int.Parse(Console.ReadLine());
            Greutate greutate = new Greutate(inaltime,varsta);
            greutate.afisare();
            Console.Read(); */

            //ex5 
            /*
            string sir = Console.ReadLine();
            string[] newsir = sir.Split(' ');
            int[] rez = new int[newsir.Length];
            int i = 0;
            while (i < newsir.Length)
            {
                rez[i] = int.Parse(newsir[i]);
                i++;
            }

            double sum = 0,mg=1; 
            foreach(int nr in rez)
            {
                sum += nr;
                mg = mg*nr;
            }
            Console.WriteLine("Media aritmetica: {0}\nMedia geometrca: {1}",sum/rez.Length,Math.Pow(mg,1.0/rez.Length));
            Console.Read(); */
        }
    }

    class Greutate
    {
        private int inaltimea;
        private int varsta;

        public Greutate(int inaltime, int varsta)
        {
            this.inaltimea = inaltime;
            this.varsta = varsta;
        }

        public double Greutate_barbati()
        {
            return (inaltimea - 100 - (inaltimea - 150) / 4) + (varsta - 20) / 4;
        }

        public double Greutate_femei()
        {
            return (inaltimea - 100 - (inaltimea - 150) / 2.5) + (varsta - 20) / 6;
        }

        public void afisare()
        {
            Console.WriteLine("Greutate ideala barbati: {0}\nGreutate ideala femei: {1}", Greutate_barbati(), Greutate_femei());
        }
    }

    class Calcule
    {
        private float a, b;
        public Calcule(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        float adunare()
        {
            return this.a + this.b;
        }

        float scadere()
        {
            return this.a - this.b;
        }

        float impartire()
        {
            return this.a / this.b;
        }

        float inmultire()
        {
            return this.a * this.b;
        }

        public void afisare()
        {
            Console.WriteLine("adunare: {0}\nscadere: {1}\ninmultire: {2}\nimpartire: {3}", adunare(),scadere(),inmultire(),impartire());
        }
    }
}
