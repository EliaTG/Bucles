﻿
using System;
//namespace Estructuras_repetitivas{
class Program{
static void Main(string[] args){
//Crea un programa que escriba en pantalla los números del 1 al 10, "while". 
//Ejercicio #1
/*
int n = 0;
while(n < 10){
n++;
Console.WriteLine(n);
}
*/
//Ejercicio #2
//Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10). 
/*int num1;
int cifras = 1;
Console.WriteLine("Ingrese sus numeros: ");
num1 = int.Parse(Console.ReadLine());
while(num1 >= 10){
num1 /= 10;
cifras++;
}
Console.WriteLine("Tienes {0} cifras ",cifras);
*/
//Ejercicio #3
//Crear un programa que dé al usuario tres oportunidades para adivinar un número del 1 al 23. 
/*

int num1, num2, contador;
		
num2 = 16;
contador = 1;
		
Console.Write("Adivina un número del 1 al 23: ");
num1=Convert.ToInt32(Console.ReadLine());
		
while ((num1 != num2) && (contador < 3)){
	Console.WriteLine("Número incorrecto.");
			
	Console.Write("Prueba de nuevo, Adivina un número del 1 al 23: ");
	num1=Convert.ToInt32(Console.ReadLine());
			
	contador++;			
}
if (num1 == num2)
	Console.WriteLine("Has acertado el número.");
else
	Console.WriteLine("Has agotado tus intentos. No has conseguido acertar.");
*/

//Ejercicio #4
//Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while". 
/*
int n = 0;
do{
n++;
Console.WriteLine(n); 
} while(n < 10);
*/
//Ejercicio #5
/*Crear un programa que pida números positivos al usuario, y vaya calculando la suma de
todos ellos (terminará cuando se teclea un número negativo o cero). */
/*
int num1;
int num2;
int result;
Console.Write("Escriba un numero positivo:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Escriba otro numero positivo:");
num2 = Convert.ToInt32(Console.ReadLine());

do{
Console.Write("Escriba un numero positivo:");
num1 = Console.ReadLine();
 
if (num1 !=  ){ 
Console.WriteLine("No válida!");
}
 while (clave != valida);
 
        Console.WriteLine("Aceptada.");*/
          /*  do
            {
 
                Console.Write("Escriba un numero positivo:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Escriba otro numero positivo:");
                num2 = Convert.ToInt32(Console.ReadLine());
                result = num1 + num2;
                if (num1 == 0 || num2 == 0)
 
                    Console.WriteLine("El resultado es{0}", result);
 
            } while (num1 != 0 || num2 != 0);
            Console.WriteLine("Haga click para salir del programa...");
*/


//Ejercicio #6
//Crea un programa que pida al usuario su cedula y su contraseña (ambos numéricos), 
//y no le permita seguir hasta que introduzca como cedula "00113764530" y como contraseña "1823". 
/*
int clave = 1823, cedula = 00113764530;
do
{
Console.WriteLine("Ingrese la clave: ");
clave = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cedula: ");
cedula = int.Parse(Console.ReadLine());
}while(clave != 1823 || cedula != 00113764530);

Console.WriteLine("clave ({0}) y cedula ({0}) correcta!!",clave,cedula);
*/

//Ejercicio #7
//Crear un programa que muestre los primeros ocho números pare
//(tips: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar el doble del valor que hace de contador). 
/*
 for (int i=0; i<=16; i=i+2){ 
Console.Write("{0} ", i);
}
*/


//Ejercicio #8
//Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo). 
/*
char letra = 'a';
do
{
    Console.WriteLine("{0}\n",letra);
    letra++;
    
} while (letra >= 'z');
*/
//Ejercicio #9
//Crear un programa que escriba en pantalla los números del 1 al 50 que sean múltiplos de 3. 
/*
for (int i = 1; i <= 50; i++)
{
if (i%3==0)
{
Console.WriteLine("{0} Es multiplo de 3",i);
}else{
Console.WriteLine("{0} No es multiplo de 3",i);
}}
*/
//Ejercicio #10
//Crear un programa que pregunte al usuario su edad y su año de nacimiento. Si la edad que introduce
// no es un número válido, mostrará un mensaje de aviso, pero aun así le preguntará su año de nacimiento. 
/*
int  actual = 2020, edad, year,resta;
DateTime date = DateTime.Now;
DateTime your_date;
do
{
Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su año de nacimiento: ");
year = int.Parse(Console.ReadLine());
resta = actual - year ;
if (edad == resta){
Console.WriteLine("Usted tiene o cumplirá {0} años",edad);
Console.WriteLine("Su fecha de nacimiento: {0}",year);}
else{
Console.WriteLine("Error!!");
Console.WriteLine("Su edad no corresponde con el año que ha introducido!!!");
Console.WriteLine("Vuelva a intentar!!!");}
} while(edad != resta);
*/


//Ejercicio #11
 
/*
string nombre;
int actual = 2020, edad, year;
Console.WriteLine("Ingrese su nombre completo: ");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su año de nacimiento: ");
year = int.Parse(Console.ReadLine());
edad = actual - year;   
Console.WriteLine("Su nombre: {0}",nombre);
Console.WriteLine("Usted tiene o cumplirá {0} años",edad);
*/
//}
}
}

