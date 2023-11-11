using System.Text.RegularExpressions;

namespace ClassLibrary3
{
    public class ContactData
    {
        private static readonly Regex nameRegex = new Regex("^[а-яА-Я]+$");
        private static readonly Regex ageRegex = new Regex("^[0-9]+$");
        private static readonly Regex phoneRegex = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
        private static readonly Regex emailRegex = new Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z]{2,6}$");

        public static bool IsNameValid(string name)
        {
            return nameRegex.IsMatch(name);
        }

        public static bool IsAgeValid(string age)
        {
            return ageRegex.IsMatch(age);
        }

        public static bool IsPhoneValid(string phone)
        {
            return phoneRegex.IsMatch(phone);
        }

        public static bool IsEmailValid(string email)
        {
            return emailRegex.IsMatch(email);
        }
    }
}