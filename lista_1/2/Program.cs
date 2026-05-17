Console.WriteLine("x: "); 
Int32 x = Convert.ToInt16(Console.ReadLine()); 
Console.WriteLine("y: "); 
Int32 y = Convert.ToInt16(Console.ReadLine()); 

Int32 s = x + y; 
Int32 d = x - y; 
Int32 p = x * y; 
double q = 1.0 * x / y; 
q = Math.Round(q, 2);

Console.WriteLine($"soma: {s}, diferença: {d}, produto: {p}, quociente: {q}"); 
