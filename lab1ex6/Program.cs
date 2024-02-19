/*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
impar
 In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
 Google :even and odd number*/

Console.WriteLine("Introduceti numarul");
int Numar = Convert.ToInt32(Console.ReadLine());
if (Numar %2==0)
{
    Console.WriteLine("Par");
}
else {Console.WriteLine("Impar");
}