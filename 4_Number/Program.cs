//Задание 3
//Пользователь вводит с клавиатуры четыре цифры. 
//Необходимо создать число, содержащее эти цифры. На-
//пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
//сформировать число 1578.
int k;
do
{
    int res = 0;
    int mult = 1000;
    for (int i = 0; i < 4; i++)
    {

        Console.WriteLine("Input "+ (i+1) + " number");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Input only positive numbers and 0" );
            break;
        }
        else
        {
            num *= mult;
            res += num;
            mult /= 10;
        }

    }
    Console.WriteLine("Result is " + res);
    Console.WriteLine("Int key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;
