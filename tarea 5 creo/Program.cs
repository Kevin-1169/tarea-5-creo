using System;

namespace dibuja
{
    class Program
    {


        static void Main(string[] args)

        {

            dibuja(32); // aca podes cambiar el valor para ejecutar el programa de diferentes formas
        }

        public static void dibuja(int Cantidad) // se crea una clase publica de forma estatica
        {
            int FF = 70;
            int CF = 20;
            int FI = 3;       //se le da valor a la variables y se indica que son de tipo entero
            int CI = 3;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)  //inicia el for principal que contiene dos for ejecutando diferentes ciclos de relleno
            {
                for (F = CI; F <= CF; F++)
                {
                    Console.SetCursorPosition(F, FF); Console.Write("?");
                    Console.SetCursorPosition(F, FI); Console.Write("?");  // este for crea el marco de la figura al momento de ejecutar y le indica al cursor
                                                                           //en que posiciones tiene que escribir 
                }
                for (C = FI; C <= FF; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("X"); //este for crea el interior del marco y le indica al cursor en que posiciones tiene que escribir
                    Console.SetCursorPosition(CF, C); Console.Write("X");
                }
                FI = FI + 1;
                FF = FF - 1; // indican las posiciones del signo ? y el signo + si va a ir sumando o restando depende de la posicion y el valor
                CI = CI + 1;
                CF = CF - 1;
            }//for principal
            Console.WriteLine(); //fin del programa
        }
    }
}