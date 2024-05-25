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
    float num3;
    string buff1, buff2, buff3;
    if (opc>=1 && opc<=4)
    {   
        Console.WriteLine("ingrese numero 1 y numero 2");
        buff1= Console.ReadLine();
        buff2= Console.ReadLine();
        if (int.TryParse(buff1, out num1) && int.TryParse(buff2, out num2))
        {
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
                    Console.WriteLine("el seno de "+num1+" es: "+Math.Sin(num1));
                    break;
                case 9:
                    Console.WriteLine("el coseno de "+ num1+" es: "+Math.Cos(num1));
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
    else{
        Console.WriteLine("ingreso una opcion incorrecta");
    }

}