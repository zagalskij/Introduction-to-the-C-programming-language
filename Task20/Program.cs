Random rand = new Random();

int x1 = rand.Next(-100, 101), y1 = rand.Next(-100, 101);
int x2 = rand.Next(-100, 101), y2 = rand.Next(-100, 101);

Console.WriteLine($"Point A  ({x1}, {y1})");
Console.WriteLine($"Point B  ({x2}, {y2})");

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(Math.Round(length,2));