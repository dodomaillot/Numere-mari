using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Operatii_cu_numere_mari
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = new BigInteger();
            BigInteger second = new BigInteger();
            BigInteger result = new BigInteger();
            string op;

            Console.WriteLine("Scrieti operatia pe care doriti sa o executati:");
            Console.WriteLine("+(adunare), -(scadere), /(impartire), *(inmultire), ²√(radacina patrata), ¹||²||³(ridicare la putere)");
            Console.Write("Operatia dorita(scrieti sau semnul sau cuvantul. Scrieti direct cuvantul pt radacina si ridicare): "); op = Console.ReadLine();

            switch (op)
            {
                case "+":
                case "adunare":
                    Console.Write("primul nr: "); first = BigInteger.Parse(Console.ReadLine());
                    Console.Write("al doilea nr: "); second = BigInteger.Parse(Console.ReadLine());
                    result = first + second;
                    break;

                case "-":
                case "scadere":
                    Console.Write("primul nr: "); first = BigInteger.Parse(Console.ReadLine());
                    Console.Write("al doilea nr: "); second = BigInteger.Parse(Console.ReadLine());
                    result = first - second;
                    break;

                case "/":
                case "impartire":
                    Console.Write("primul nr: "); first = BigInteger.Parse(Console.ReadLine());
                    Console.Write("al doilea nr: "); second = BigInteger.Parse(Console.ReadLine());
                    result = first / second;
                    break;

                case "*":
                case "inmultire":
                    Console.Write("primul nr: "); first = BigInteger.Parse(Console.ReadLine());
                    Console.Write("al doilea nr: "); second = BigInteger.Parse(Console.ReadLine());
                    result = first * second;
                    break;

                case "radacina":
                    Console.Write("primul nr: "); first = BigInteger.Parse(Console.ReadLine());
                    Console.Write("al doilea nr: "); second = BigInteger.Parse(Console.ReadLine());
                    result = first - second;
                    break;

                case "ridicare":
                    int rid;
                    Console.Write("Ridicare la(scrieti numarul=>) "); rid = int.Parse(Console.ReadLine());
                    Console.Write("nr: "); first = BigInteger.Parse(Console.ReadLine());
                    result = first;
                    rid--;
                    while(rid != 0)
                    {
                        result *= first;
                        rid--;
                    }
                    break;
            }
            Console.Write("Rezultatul este: " + result);
        }
    }
}
