using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System;

namespace SocialNetwork
{
    
    public class User
    {
        
        public string Username { get; set; }       // Имя пользователя
        public string Email { get; set; }          // Электронная почта
        public string Password { get; private set; } // Пароль (только для чтения вне класса)
        public int Age { get; set; }                // Возраст
        public string ProfilePictureUrl { get; set; } // URL к изображению профиля

        // Конструктор класса
        public User(string username, string email, string password, int age, string profilePictureUrl)
        {
            Username = username;
            Email = email;
            Password = password;
            Age = age;
            ProfilePictureUrl = profilePictureUrl;
        }

        // Метод для отображения информации о пользователе
        public string DisplayUserInfo()
        {
            return $"Username: {Username}, Email: {Email}, Age: {Age}";
        }

        
        public bool IsAdult()
        {
            return Age >= 18;
        }

        
        private string EncryptPassword(string password)
        {
            // Здесь можно добавить реальную логику шифрования
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
        public void SetPassword(string newPassword)
        {
            Password = EncryptPassword(newPassword);
        }
    }

    // Главный класс программы
    class Program
    {
        static void Main(string[] args)
        {
       
            User user = new User("Viktoria", "ahn@example.com", "password123", 17, "http://example.com/profile.jpg");

            Console.WriteLine(user.DisplayUserInfo());
           
            Console.WriteLine($"Is adult: {user.IsAdult()}");
      
            user.SetPassword("newpassword456");
            Console.WriteLine($"Encrypted Password: {user.Password}");
        }
    }
}
