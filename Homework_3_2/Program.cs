// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number");
int A = int.Parse(Console.ReadLine());
int B;
int Sum = 0;
do
{
    B = A % 10;
    A /= 10;
    Sum += B;
}
while (A > 0);
Console.WriteLine("Sum = " + Sum);
Console.ReadLine();
