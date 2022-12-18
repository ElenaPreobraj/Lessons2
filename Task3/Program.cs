Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
/*int num = -n;
while (num<=n)
{
    Console.WriteLine(num);
    Console.Write(", ");
    num++;
}*/

for (int i = -n; i <=n; i++)
{
    Console.Write(i);
    Console.Write(", ");
}