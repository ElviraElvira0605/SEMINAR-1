// Напишите программу, которая на вход принимает число 
// (N), а на выходе показывает все чётные числа
//  от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите N:  ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);

  {
        int num = Convert.ToInt32(Console.ReadLine());
        int res = 1;
       
        if (res == 1)

        {
         res += 1;
        }

        while (res <= num)

        {
            Console.WriteLine(res);
            res += 2;
        }

    }
