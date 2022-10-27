// Напишите программу, которая на вход принимает число
//  и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
//Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

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

