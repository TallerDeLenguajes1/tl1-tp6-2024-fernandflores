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
