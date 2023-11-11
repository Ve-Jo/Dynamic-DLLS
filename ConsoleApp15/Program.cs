using ClassLibrary1;
using ClassLibrary2;
using ClassLibrary3;
using ClassLibrary4;
internal class Program
{
    private static void Main(string[] args)
    {
        double squareSide = 5;
        double squareArea = Geometry.SquareArea(squareSide);
        Console.WriteLine("Площадь квадрата составляет: {0}", squareArea);

        double rectangleWidth = 10;
        double rectangleHeight = 20;
        double rectangleArea = Geometry.RectangleArea(rectangleWidth, rectangleHeight);
        Console.WriteLine("Площадь прямоугольника составляет: {0}", rectangleArea);

        double triangleBase = 15;
        double triangleHeight = 8;
        double triangleArea = Geometry.TriangleArea(triangleBase, triangleHeight);
        Console.WriteLine("Площадь треугольника составляет: {0}", triangleArea);

        string text = "А роза упала на лапу Азора";
        bool isPalindrome = Text.IsPalindrome(text);

        if (isPalindrome)
        {
            Console.WriteLine("Текст \"" + text + "\" является палиндромом.");
        }
        else
        {
            Console.WriteLine("Текст \"" + text + "\" не является палиндромом.");
        }

        text = "Привет мир. Как дела?";
        int countSentences = Text.CountSentences(text);

        Console.WriteLine("Количество предложений в тексте \"" + text + "\" равно: " + countSentences);

        text = "Привет, мир!";
        string reversedText = Text.Reverse(text);

        Console.WriteLine("Реверс текста \"" + text + "\" равен: " + reversedText);

        string name = "Иван";
        string age = "25";
        string phone = "099-123-4567";
        string email = "ivanov@example.com";
        bool isValidName = ContactData.IsNameValid(name);

        if (isValidName)
        {
            Console.WriteLine("Имя \"" + name + "\" является валидным.");
        }
        else
        {
            Console.WriteLine("Имя \"" + name + "\" не является валидным.");
        }

        bool isValidAge = ContactData.IsAgeValid(age);

        if (isValidAge)
        {
            Console.WriteLine("Возраст \"" + age + "\" является валидным.");
        }
        else
        {
            Console.WriteLine("Возраст \"" + age + "\" не является валидным.");
        }

        bool isValidPhone = ContactData.IsPhoneValid(phone);

        if (isValidPhone)
        {
            Console.WriteLine("Телефон \"" + phone + "\" является валидным.");
        }
        else
        {
            Console.WriteLine("Телефон \"" + phone + "\" не является валидным.");
        }

        bool isValidEmail = ContactData.IsEmailValid(email);

        if (isValidEmail)
        {
            Console.WriteLine("Электронная почта \"" + email + "\" является валидной.");
        }
        else
        {
            Console.WriteLine("Электронная почта \"" + email + "\" не является валидной.");
        }

        string sourcePath = "test_file.txt";
        string destinationPath = "test_folder\\new_file.txt";
        FileSystem.CopyFile(sourcePath, destinationPath);
        Console.WriteLine("Файл \"" + sourcePath + "\" скопирован в \"" + destinationPath + "\".");

        string fileName = "test_folder\\new_file.txt";
        string word = "привет";
        string reportFileName = "test_folder\\report.txt";
        FileSystem.FindWordInFile(fileName, word, reportFileName);
        Console.WriteLine("Результаты поиска слова \"" + word + "\" в файле \"" + fileName + "\" записаны в файл \"" + reportFileName + "\".");

        sourcePath = "test_folder\\new_file.txt";
        FileSystem.DeleteFile(sourcePath);
        Console.WriteLine("Файл \"" + sourcePath + "\" удален.");
    }
}