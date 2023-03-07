using System;


static class Program
{

    public static void Main(string[] args)
    {
        
        var anketa = GetUserDataFromConsole();
        WriteUserDataToConsole(anketa);

    }

    static (string firstname, string lastname, int age, string[] namePets, string[] favColors) GetUserDataFromConsole()
    {

        Console.Write("Введите имя: ");
        string firstname = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        string lastname = Console.ReadLine();
        Console.Write("Введите возрас цифрами:");
        int age = Convert.ToInt32(Console.ReadLine());
        while (!IsNaturaleNumber(age))
        {
            Console.WriteLine("Вы ввели некоректный возраст повторите ввод");
            age = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Есть ли у вас питомец? (да/нет)");
        string hasPet = Console.ReadLine();
        string[] namePets = new string[0];
        if (hasPet == "да")
        {
            Console.WriteLine("Сколько у вас питомцев? (укажите цифрами)");
            int petCount = Convert.ToInt32(Console.ReadLine());
            while (!IsNaturaleNumber(petCount))
            {
                Console.WriteLine("Вы ввели некоректное количество пиомцев повторите ввод");
                petCount = Convert.ToInt32(Console.ReadLine());
            }
            namePets = GetPetsNameFromConsole(petCount);
        }
        string[] favColors = new string[0];

        Console.WriteLine("Сколько у вас любимых цветов? (укажите цифрами)");
        int colorCount = Convert.ToInt32(Console.ReadLine());
        
            while (!IsNaturaleNumber(colorCount))
            {
                Console.WriteLine("Вы ввели некоректное количество цветов повторите ввод");
                colorCount = Convert.ToInt32(Console.ReadLine());
            }
            favColors = GetFavColorFromConsole(colorCount);
        

        return(firstname, lastname, age, namePets, favColors); 
    }
    static bool IsNaturaleNumber(int namber)
    {
         return namber > 0;
    }
   static string[] GetPetsNameFromConsole(int petCount) 
    {
        string[] namePets = new string[petCount];
        for (int i = 0; i < petCount; i++)
        {
            Console.WriteLine($"Введите имя питомца номер {i+1}");
            namePets[i] = Console.ReadLine();
        }
        return namePets;   
    }
    static string[] GetFavColorFromConsole(int colorCount)
    { 
        string[] favColors= new string[colorCount];
        for (int i=0 ; i < colorCount; i++) 
        {
            Console.WriteLine($"Введите любимый цвет номер {i+1}");
            favColors[i] = Console.ReadLine();
        }
        return favColors;
    }

    static void WriteUserDataToConsole((string firstname, string lastname, int age, string[] namePets, string[] favColors) anketa)
    {

        Console.WriteLine($"Имя пользователя {anketa.firstname}");
        Console.WriteLine($"Фамилия пользователя {anketa.lastname}");
        Console.WriteLine($"Возраст пользователя {anketa.age}");
        if (anketa.namePets.Length > 0)
        {
            Console.WriteLine("Имена питомцев:");
            for (int i = 0; i < anketa.namePets.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {anketa.namePets[i]}");
            }
        }
        Console.WriteLine("Любимые цвета");
        for (int i = 0; i < anketa.favColors.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {anketa.favColors[i]}");
        }
    }
}