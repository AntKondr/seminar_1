Console.Clear();
Console.WriteLine("Seminar_1, task_4\n");

Console.Write("input number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("input number c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b & a > c) {
    Console.Write($"max -> {a}");
}
else if (b > c & b > a) {
    Console.Write($"max -> {b}");
}
else if (c > a & c > b) {
    Console.Write($"max -> {c}");
}
else {
    Console.Write("numbers are equal");
}