using CloudCustormers.Api.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTesting.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>

            new()
            {
                new User
                {
                    Id = 1,
                    Name = "Abdulrahman",
                    Address = new Address()
                    {
                        Street = "Al-Mansour Street",
                        City = "Tripoli",
                        ZipCode = "23410"
                    },
                    Email = "Bakkash2003@gmail.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Fatima",
                    Address = new Address()
                    {
                        Street = "Al-Sharif Street",
                        City = "Tripoli",
                        ZipCode = "23412"
                    },
                    Email = "fatima.alhussein@example.com"
                },
                new User
                {
                    Id = 3,
                    Name = "Omar",
                    Address = new Address()
                    {
                        Street = "Al-Mahdi Street",
                        City = "Benghazi",
                        ZipCode = "21500"
                    },
                    Email = "omar.khan@example.com"
                },
                new User
                {
                    Id = 4,
                    Name = "Aisha",
                    Address = new Address()
                    {
                        Street = "Al-Nasr Street",
                        City = "Misrata",
                        ZipCode = "33000"
                    },
                    Email = "aisha.mohammed@example.com"
                },
                new User
                {
                    Id = 5,
                    Name = "Youssef",
                    Address = new Address()
                    {
                        Street = "Al-Muqara Street",
                        City = "Sebha",
                        ZipCode = "00000"
                    },
                    Email = "youssef.said@example.com"
                },
                new User
                {
                    Id = 6,
                    Name = "Layla",
                    Address = new Address()
                    {
                        Street = "Al-Salam Street",
                        City = "Zliten",
                        ZipCode = "12000"
                    },
                    Email = "layla.alnasser@example.com"
                },
                new User
                {
                    Id = 7,
                    Name = "Hassan",
                    Address = new Address()
                    {
                        Street = "Al-Hawari Street",
                        City = "Tobruk",
                        ZipCode = "88000"
                    },
                    Email = "hassan.ali@example.com"
                },
                new User
                {
                    Id = 8,
                    Name = "Samira",
                    Address = new Address()
                    {
                        Street = "Al-Jazeera Street",
                        City = "Derna",
                        ZipCode = "12001"
                    },
                    Email = "samira.fadl@example.com"
                }
            };
    }
}