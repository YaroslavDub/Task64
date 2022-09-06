// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
void Natural(int N) {
    if (N == 0) return;
    Console.Write($"{N} ");
    Natural(N - 1);
}
Natural(n);