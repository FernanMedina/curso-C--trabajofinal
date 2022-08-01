using System;

namespace TPFinal_Medina
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa 
            //un cero. 
            //A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.
            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y 
            //que devuelva true o false según corresponda.

            //Declaro las variables a utilizar y las inicializo
            int numero;
            int banderaPar = 0, maximoPar = 0, cantImpares = 0;
            int minimoPrimo = 0, banderaPrimo = 0;

            //Ingresamos un numero
            Console.WriteLine("Ingrese un numero distinto de cero para empezar: ");
            numero = int.Parse(Console.ReadLine());
            
            while (numero != 0)
            {
                //punto a
                if(numero % 2 == 0)
                {
                    if(banderaPar == 0){
                        maximoPar = numero;
                        banderaPar = 1;
                    }
                    else{
                        if(numero > maximoPar){
                            maximoPar = numero;
                        }
                    }
                }
                else
                {
                    cantImpares++; //punto b
                }

                //Punto C
                if(primo(numero)){
                    if (banderaPrimo == 0)
                    {
                        minimoPrimo = numero;
                        banderaPrimo = 1;
                    }
                    else
                    {
                        if (numero < minimoPrimo)
                        {
                            minimoPrimo = numero;
                        }
                    }
                }
                    

                //Pido un numero
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("La cantidad de numeros impares es: " + cantImpares);
            Console.WriteLine("El maximo de los pares es: " + maximoPar);
            Console.WriteLine("El menor de los numeros primos es: " + minimoPrimo);
        }

        //Funcion bool primo
         static bool primo(int numero)
        {
            int contador = 0;
            for (int x = 1; x <= numero; x++)
            {
                if(numero % x == 0){
                    contador++;
                }
            }

            if(contador == 2){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
