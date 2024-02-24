// Put in the conversion rate
// Put in the amount of chaos
// divide
// division leftover is the chaos change

Console.Write("Exchange rate for 1 divine orb = ");
int rate = Convert.ToInt32(Console.ReadLine());
Console.Write("Amount of chaos for conversion: ");
int chaos_to_convert = Convert.ToInt32(Console.ReadLine());

int divine = chaos_to_convert / rate;
double divine_calc = (double)chaos_to_convert / rate;
double converted_divines = Math.Round(divine_calc, 1);
int change_c_conv = chaos_to_convert % (divine * rate);

Console.WriteLine($"Divines: {converted_divines}");
Console.WriteLine("Divines with change");
Console.WriteLine($"Divine orbs: {divine}");
Console.WriteLine($"Chaos orbs: {change_c_conv}");

//Separate process, interface and butto logic needed
Console.Write("Amount of divines for conversion: ");
double divines_to_convert = Convert.ToDouble(Console.ReadLine());

double converted_chaos = Math.Round(divines_to_convert * rate);

Console.WriteLine($"Chaos: {converted_chaos}");