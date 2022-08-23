Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int init = 1;

while(number >= init)
{
    if(number % 2 == 0)
        {
            Console.Write(number);
            Console.Write(" ");
        }
    number = number - 1;
} 
