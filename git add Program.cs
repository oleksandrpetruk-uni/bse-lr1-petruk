Console.WriteLine("Hello, World!"); 
Console.WriteLine("Sth!"); 

Console.WriteLine("Ok"); 

// Функція, яка приймає масив цілих чисел і повертає їх суму
int Sum(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}  
int[] myNumbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Сума масиву: " + Sum(myNumbers));



