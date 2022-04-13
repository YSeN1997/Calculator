
Console.WriteLine("Добро пожаловать в недокалькулятор!) ");
Console.ReadLine();


while (true)
{
    
    
    Console.Clear();
    double num1, num2;
    String action;
    
    try
    {
        Console.WriteLine("Введите первое число:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        num2 = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Введено не число!");
        Console.ReadLine();
        continue;
    }
    Console.WriteLine("Выберите знак: '+' '-' '*' '/'");
    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            Console.WriteLine("Ответ: " + (num1+num2));
            break;
        case "-":
            Console.WriteLine("Ответ: " + (num1-num2));
            break;
        case "*":
            Console.WriteLine("Ответ: " + (num1*num2));
            break;
        case "/":
            if (num2 == 0)
                Console.WriteLine("На ноль делить нельзя!");
            else
                Console.WriteLine("Ответ: " + (num1/num2));
            break;
        default:
            Console.WriteLine("Неправильный знак!");
            break;
    }
   
    Console.ReadLine(); 
}