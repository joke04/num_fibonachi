Console.Write("До какого числа вывести ряд Фибоначчи? ");
int final = Convert.ToInt32(Console.ReadLine());

int first = 1; int second = 1;
Console.Write("{0} ", first, "{1} ", second);
int sum = 0;

while (final >= sum)
{
    sum = first + second;
    Console.Write("{0} ", sum);
    first = second;
    second = sum;
}