Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Carpet Cleaning Service\n");

int LargeCarpetCost = 35;
int SmallCarpetCost = 25;
double serviceRate = 0.06 ;
Console.Write("Enter number of large carpet: ");
int largecount = int.Parse(Console.ReadLine());

Console.Write("Enter number of small carpet: ");
int smallcount = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("35 for Large One \n" + "25 for Small One \n");

int total_BS = (largecount * LargeCarpetCost) + (smallcount * SmallCarpetCost);
double service6 = total_BS * 0.06;
double total_FS = total_BS + service6;
Console.WriteLine($"total: {total_BS}");
Console.WriteLine($"Service (6%): {serviceRate}");
Console.WriteLine($"Summary: {total_FS}\n");
Console.WriteLine("Estimates Are Valid For 30 Days\n ");




