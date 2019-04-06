using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        string wejscie;
        string[] wyjscie;

        void zmianaZnaku()
        {
            string[] temp;
            bool poprzedniWyrazJednoznakowy = false;
            for (int i = 0; i < wyjscie.Count(); i++)
            {
                if (wyjscie[i] != "")
                {
                    string ponownieZlaczonyWyraz = "";
                    temp = new string[wyjscie[i].Length];
                    for (int j = 0; j < wyjscie[i].Length; j++)
                    {
                        temp[j] = wyjscie[i].Substring(j, 1);
                    }
                    if ((i - 1) >= 0 && wyjscie[i - 1].Length == 1)
                        poprzedniWyrazJednoznakowy = true;
                    else
                        poprzedniWyrazJednoznakowy = false;

                    if (!poprzedniWyrazJednoznakowy)
                    {
                        temp[0] = temp[0].ToUpper();
                        for (int k = 1; k < temp.Length; k++)
                        {
                            temp[k] = temp[k].ToLower();
                        }
                        poprzedniWyrazJednoznakowy = false;
                    }

                    for (int k = 0; k < temp.Length; k++)
                    {
                        ponownieZlaczonyWyraz += temp[k];
                    }
                    wyjscie[i] = ponownieZlaczonyWyraz;
                }           
            }
        }

        static void Main(string[] args)
        {
            
            Program program = new Program();
            Console.WriteLine("Wpisz dowolny tekst i nacisnij enter");
            program.wejscie = Console.ReadLine();

            program.wyjscie = program.wejscie.Split(' ');

            program.zmianaZnaku();

            for (int i = 0; i < program.wyjscie.Length; i++)
            {
                Console.Write(program.wyjscie[i]);
            }

            Console.ReadKey();
        }
    }
}
