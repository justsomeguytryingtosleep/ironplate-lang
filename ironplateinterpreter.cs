using System;
class p { static void Main() { int a = 0; int s(int b) => b == -1 || b == 256 ? 0 : b; while (true) { Console.Write(">>"); var c = Console.ReadLine(); 
            for (int i = 0; i < c.Length; i++) 
            { switch (c[i]) 
                { case '+': case 'x': a = s(a + 1); break;
                    case '-': a = s(a - 1); break; case 's': 
                    case 'k': a = s(a * a); break; case 'o': case 
                    'c': Console.WriteLine(a); break; } } } } }
