// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
}
int num1;
int num2;
 int control=1;
  int bandera=1;
  int opc=0;
do{

    Console.WriteLine("-------------------MENU------------------");
    Console.WriteLine("1: sumar");
    Console.WriteLine("2: restar");
    Console.WriteLine("3: multiplicar");
    Console.WriteLine("4: dividir");
    string opcion=Console.ReadLine();
    if(int.TryParse(opcion, out opc)){
    
        Console.WriteLine("ingrese numero 1 y numero 2");
        string buff1= Console.ReadLine();
        string buff2= Console.ReadLine();
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
                default:
                        Console.WriteLine("ingrese una opcion del menu correcta");
                        break;
            }
            
            do{ //control para que ingrese si o si un tipo entero y no un caracter
                Console.WriteLine("desea realizar otra operacion? 1:si / 0: no");
                string buff3=Console.ReadLine();
                if(!(int.TryParse(buff3, out bandera))){ 
                    Console.WriteLine("ingrese una opcion valida");
                    control=0;
                }
                else{
                    control=1;
                }
            }while(control==0);
        }
    }
}while(bandera==1);