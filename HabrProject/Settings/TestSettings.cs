using System;
using System.Collections.Generic;
using System.Text;

namespace HabrProject.Data
{
    public class TestSettings
    {
        public static string _loginOfMailRu = "testinghabr@mail.ru";
          
        public static string _passwordOfMailRu= "1OfPyoUAud3%";

        public static string _loginHabr = "testinghabr1";

        public static string _passwordHabr = "1OfPyoUAud3%";

        public static string UrlHabr = "https://habr.com/ru/top/";

        public static string _realName = "IamARobot";
        public static string _specialization = "SitesTester";

        public static int WaitTime = 4;

        public static DateTime now = DateTime.Now;

        public static string currentDate = now.ToString("dd.MM.yyyy");

        public static string plusThreeDaysDate = now.AddDays(3.0).ToString("dd.MM.yyyy");
        public static string GenerateRandomString(int size, bool lowerCase = true)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                stringBuilder.Append(ch);
            }
            if (lowerCase) { return stringBuilder.ToString().ToLower(); }

            return stringBuilder.ToString();
        }
        public static string GenerateRandomEmail(string nameDomain, int size = 10)
        {
            string randomEmail = GenerateRandomString(size) + nameDomain;

            return randomEmail;
        }
        public static string GenerateRandomData(int size)
        {
            int[] array = new int[size];
            Random random = new Random();
            string data = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                data += (char)array[i];
            }

            return data;
        }
        public static string GenerateRandomPassword(int size)
        {
            string randomPassword = GenerateRandomData(size);

            return randomPassword;
        }

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static string GenerateRandomPhoneNumber()
        {
            var random = new Random();
            int[] array = new int[10];

            string phoneNumber = "";

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(33, 125);
                phoneNumber += array[i];
            }
            phoneNumber = "+7" + phoneNumber;
            return phoneNumber;
        }
    }
}
