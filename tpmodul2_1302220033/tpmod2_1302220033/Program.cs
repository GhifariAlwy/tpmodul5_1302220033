// See https://aka.ms/new-console-template for more information
Console.WriteLine("Masukan satu huruf");
string letter = Console.ReadLine();
int[] angka = {0,2,4,6,8,10};
if (letter == "A" || letter == "I" || letter == "U" || letter == "E" || letter == "O")
{
    Console.WriteLine("Huruf vokal");
}
else
{
    Console.WriteLine("Huruf konsonan");
}

for (int i = 0; i < angka.Length; i++)
{
    Console.Write("Angka genap" + i + ":" + angka[i]);
}
