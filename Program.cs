// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);
int num;
Console.WriteLine("ingrese numero");
string buff=Console.ReadLine();
if (int.TryParse(buff, out num))
{
    if(num>0)
    {
        int aux=num;
        do
        {
            int mostrar=aux%10;
            Console.Write(mostrar);
            aux=aux/10;
        } while (aux>0);

    }else{
        Console.WriteLine("no es un numero positivo");
    }
}*/

using System.Reflection.Emit;
/*
  //EJERCICIO 2 Y 3
int control=1;
  int bandera=1;
  int opc=0;
do
{
    Console.WriteLine("-------------------MENU------------------");
    Console.WriteLine("1: sumar");
    Console.WriteLine("2: restar");
    Console.WriteLine("3: multiplicar");
    Console.WriteLine("4: dividir");
    Console.WriteLine("5: valor absoluto");
    Console.WriteLine("6: cuadrado de un numero");
    Console.WriteLine("7: raiz cuadrada de un numero");
    Console.WriteLine("8: seno de un numero");
    Console.WriteLine("9: coseno de un numero");
    Console.WriteLine("10: parte entera de un numero con decimal (ingrese decimal con ',' ej: 2,6) ");
    Console.WriteLine("11: el mayor entre dos numeros");
    Console.WriteLine("12: el menor entre dos numeros");
    string opcion=Console.ReadLine();
    if(int.TryParse(opcion, out opc))
    {
        ejecucionCalculadora(opc); 
        do{ //control para que ingrese si o si un tipo entero y no un caracter
            Console.WriteLine("desea realizar otra operacion? presione 1 para continuar o cualquier otra tecla para salir");
            string buff3=Console.ReadLine();
            if(!(int.TryParse(buff3, out bandera)))
            { 
                Console.WriteLine("ingrese una opcion valida");
                control=0;
            }
            else{
                    control=1;
                }
            }while(control==0);
    }else
    {
        Console.WriteLine("ingreso un caracter invalido");
    }
}while(bandera==1);
Console.WriteLine("~~**~~ gracias por usar calculaneitor ~~**~~");

void ejecucionCalculadora (int opc)
{
    int num1, num2;
    double radianes;
    float num3;
    string buff1, buff2, buff3;
    if (opc>=1 && opc<=4)
    {   
        Console.WriteLine("ingrese numero 1 y numero 2");
        buff1= Console.ReadLine();
        buff2= Console.ReadLine();
        if (int.TryParse(buff1, out num1) && int.TryParse(buff2, out num2)){
            switch(opc)
                {
                    case 1: 
                            Console.WriteLine("la suma es: "+ (num1+num2));
                            break;
                    case 2: 
                            Console.WriteLine("la resta num 1 - num 2 es: "+ (num1-num2));
                            break;
                    case 3: 
                            Console.WriteLine("la multiplicacion es: "+ (num1*num2));
                            break;
                    case 4: 
                            Console.WriteLine("la division es: "+ (num1/num2));
                            break;   

                }
        }
        else
        {
            Console.WriteLine("ingreso un caracter (no es numero) invalido");
        }
    }else if(opc>=5 && opc<=9) 
    {
        Console.WriteLine("ingrese numero");  
        buff1= Console.ReadLine();   
        if (int.TryParse(buff1, out num1))
        {
            switch (opc)
            {
                case 5:
                    Console.WriteLine("el valor absoluto del numero "+num1+" es: "+Math.Abs(num1));
                    break;
                case 6: 
                    Console.WriteLine("el cuadrado de "+num1+" es: "+ Math.Pow(num1,2));
                    break;
                case 7:
                    Console.WriteLine("la raiz cuadra de "+num1+" es:"+Math.Sqrt(num1));
                    break;
                case 8:
                    radianes= num1*(Math.PI/180);
                    Console.WriteLine("el seno de "+num1+" es: "+Math.Round(Math.Sin(radianes),2));
                    break;
                case 9:
                    radianes= num1*(Math.PI/180);
                    Console.WriteLine("el coseno de "+ num1+" es: "+Math.Round(Math.Cos(radianes),2));
                    break;
            }
        } else
        {
            Console.WriteLine("ingreso un caracter (no es numero) invalido");
        } 
    }
    else if(opc==10)
    {
        Console.WriteLine("ingrese numero");
        buff3=Console.ReadLine();
        if (float.TryParse(buff3, out num3))
        {
            Console.WriteLine("la parte entera del float: "+num3+" es: "+Math.Truncate(num3));
        } else
        {
            Console.WriteLine("ingreso un caracter (no es numero) invalido");
        }
    }
    else if(opc==11 || opc==12)
    {
        Console.WriteLine("ingrese numero 1 y numero 2");
        buff1=Console.ReadLine();
        buff2=Console.ReadLine();
        if (int.TryParse(buff1, out num1) && int.TryParse(buff2, out num2))
        {   
            if (opc==11)
            {
                Console.WriteLine("el maximo entre "+num1+" y "+num2+" es: "+Math.Max(num1,num2));
            }
            else
            {
                Console.WriteLine("el minimo entre "+num1+" y "+num2+" es: "+Math.Min(num1,num2));
            }
        } else
        {
            Console.WriteLine("ingreso un caracter (no es numero) invalido");
        }
    }
    else
    {
        Console.WriteLine("ingreso una opcion incorrecta");
    }

}
*/ 
//EJECICIO 4
string cadena, cadena2, subcadena, buscada;
int cant, num4=5, num5=20, resultado, encontrado;

Console.WriteLine("\n -------- MOSTRAR LONGITUD DE CADENA ----------\n");
Console.WriteLine("ingrese frase");
cadena=Console.ReadLine();
cant= cadena.Length;   //devuelve la longitud de la cadena
Console.WriteLine("longitud de la cadena: "+ cant);

Console.WriteLine("\n -------- CONCATENANDO CADENAS -------- \n");
Console.WriteLine("ingrese segunda cadena");
cadena2= Console.ReadLine();
string cadenaConcatenada= string.Concat(cadena, " ", cadena2); //concatena cadena +" "  + cadena2
Console.WriteLine("cadena concatenada: "+cadenaConcatenada);

Console.WriteLine("\n -------- EXTRAYENDO SUBCADENA -------- \n");
if(cadena.Length>=6)
{
    subcadena= cadena.Substring(2,6); //extrae la sub cadena desde la letra 2 hasta la letra 6
    Console.WriteLine("la subcadena de: "+cadena+" es: "+subcadena);
}
else
{
    Console.WriteLine("la cadena es muy pequeña");
}

Console.WriteLine("\n --------- PASANDO DE ENTERO A STRING ---------\n");
resultado=num4+num5;
Console.WriteLine("la suma de "+num4.ToString()+" y "+num5.ToString()+" es: "+resultado.ToString()); //transforma el int a string

Console.WriteLine("\n --------- ESCRIBIENDO ELEMENTO A ELEMENTO -----------");
foreach (char elemento in cadena) // para cada letra (elemento) de cadena (arreglo) hacer:
{
    Console.WriteLine(elemento);
}

Console.WriteLine("\n --------- BUSCANDO PALABRA EN CADENA --------- \n");
Console.WriteLine("ingrese palabra a buscar en la cadena");
buscada=Console.ReadLine();
encontrado= cadena.IndexOf(buscada); // busca la palabra ingresada (buscada) en la cadena, si se encuentra es != -1, sino es -1
if (encontrado!=-1)
{
    Console.WriteLine("la palabra se encuentra en el indice: "+encontrado);
}else
{
    Console.WriteLine("no se encontro la palabra en la cadena");
}

Console.WriteLine("\n --------- PASANDO CADENA A MINUSCULA Y MAYUSCULA --------- \n");
string mayuscula= cadena.ToUpper();
string minuscula= cadena.ToLower();
Console.WriteLine("la cadena en mayuscula es: '"+mayuscula+"'");
Console.WriteLine("la cadena en minuscula es: '"+minuscula+"'");

Console.WriteLine("\n ----- SEPARANDO CADENA SEGUN CARACTER ESPECIFICO (EN ESTE CASO EN CADA ESPACIO) (CREANDO UN ARRAY NUEVO) ----\n");
string[] nuevaCadena= cadena.Split(" "); // va a crear un array, cada vez que vea un espacio, hace un nuevo elemento para el array
foreach (string aux in nuevaCadena)
{
    Console.WriteLine(aux);
}

Console.WriteLine("\n -----------RESOLVIENDO ECUACION DE STRING COMO INT ---------\n");
int  total=0, numero, j=0; 
string[] terminos; //voy a aguardar los terminos: 123+53-2= terminos[]: {"123", "53", "2"}
Console.WriteLine("ingrese ecuacion");
string ecuacionString= Console.ReadLine(); //guarda toda la ecuacion ecuacionString:{"123+53-2"}
terminos= ecuacionString.Split('+','-'); // va a crear un arreglo separando cada elemento en cada '+' o '-' 123+53-2 terminos[]:{"153","53","2"}
if(int.TryParse(terminos[0], out numero)) //revisa si el primer termino es entero, si es entero devuelve int numero
{
    total=numero; // le asignamos el primer termino para que ya lo tenga en cuenta y pueda resolver la ecuacion
    for (int i = 0; i < ecuacionString.Length; i++)
    {   
        char operador=ecuacionString[i]; 
        if(operador=='+' || operador=='-' ) // si encuentra un  operador, va a utilizar un termino 
        {
            j++; //si encuentra un operador, se posiciona en el siguiente termino
            if (int.TryParse(terminos[j], out numero)) // revisa si en el termino hay solo numeros enteros (no dejaria pasar un: 2j2), y transofmra lo que contenga terminos[j] a entero (numero)
            {
                switch (operador)
                {
                    case '+':
                        total+=numero;
                        break;
                    case '-':
                        total-=numero;
                        break;
                }
            }else
            {
                Console.WriteLine("no ingreso un numero");
            }
        }
    }
    Console.WriteLine("el resultado de la ecuacion: "+ecuacionString+" es: "+ecuacionString+"= "+total);
}//todo dentro del if del primer termino ya que si no fuera numero no tiene sentido continuar con la operacion
else
{
    Console.WriteLine("no ingreso un termino valido, el primer termino no es numero");
}