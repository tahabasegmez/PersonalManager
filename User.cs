using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJE
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public string Photo { get; set; }
        public int UserType { get; set; }
        public bool RememberMe { get; set; }

        public User(string username, string password, string name, string surname, string phoneNumber, string address, string email,string salary, string photo, int userType, bool rememberMe)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            Salary = salary;
            Photo = photo;
            UserType = userType;
            RememberMe = rememberMe;
        }
        public User() { }
        
    }
}
