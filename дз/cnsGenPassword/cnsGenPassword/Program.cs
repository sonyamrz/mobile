using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество паролей: ");
            int numberOfPasswords = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину пароля: ");
            int passwordLength = Convert.ToInt32(Console.ReadLine());

            Console.Write("Использовать цифры в пароле? (да/нет): ");
            bool useNumbers = Console.ReadLine().ToLower() == "да";

            Console.Write("Использовать буквы маленькие в пароле? (да/нет): ");
            bool useLowercaseLetters = Console.ReadLine().ToLower() == "да";

            Console.Write("Использовать буквы большие в пароле? (да/нет): ");
            bool useUppercaseLetters = Console.ReadLine().ToLower() == "да";

            Console.Write("Использовать спец символы в пароле? (да/нет): ");
            bool useSpecialCharacters = Console.ReadLine().ToLower() == "да";

            Console.Write("Введите дополнительные символы для пароля (если нет, оставьте пустую строку): ");
            string additionalCharacters = Console.ReadLine();

            // Генерация паролей с заданными параметрами
            List<string> passwords = GeneratePasswords(numberOfPasswords, passwordLength, useNumbers, useLowercaseLetters, useUppercaseLetters,
                useSpecialCharacters, additionalCharacters);

            // Вывод сгенерированных паролей
            Console.WriteLine("\nСгенерированные пароли:");
            foreach (string password in passwords)
            {
                Console.WriteLine(password);
            }
        }

        static List<string> GeneratePasswords(int numberOfPasswords, int passwordLength, bool useNumbers, bool useLowercaseLetters, bool useUppercaseLetters,
            bool useSpecialCharacters, string additionalCharacters)
        {
            // Проверка входящих параметров
            if (numberOfPasswords <= 0 || passwordLength <= 0)
            {
                Console.WriteLine("Количество паролей и длина пароля должны быть больше нуля.");
                return null;
            }

            // Генерация списка паролей
            List<string> passwords = new List<string>();
            string charSet = additionalCharacters;
            if (useNumbers)
                charSet += "0123456789";
            if (useLowercaseLetters)
                charSet += "abcdefghijklmnopqrstuvwxyz";
            if (useUppercaseLetters)
                charSet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (useSpecialCharacters)
                charSet += "!@#$%^&*()_+~`|}{[]:;?><,./-=";

            Random random = new Random();
            for (int i = 0; i < numberOfPasswords; i++)
            {
                StringBuilder password = new StringBuilder();
                for (int j = 0; j < passwordLength; j++)
                {
                    int index = random.Next(0, charSet.Length);
                    password.Append(charSet[index]);
                }
                passwords.Add(password.ToString());
            }

            return passwords;
        }
    }
}