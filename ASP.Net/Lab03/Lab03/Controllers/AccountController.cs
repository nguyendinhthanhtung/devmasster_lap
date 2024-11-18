using Lab03.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab03.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
        {
            new Account()
            {
             Id=1,Name="Hoàng Anh",
            Email="anh@gmail.com",
            Phone="0326001258",
            Address="hà nội",
            Avatar=Url.Content("~/Avatar/1.jpg"),
            Gender=1,Bio="My name is Small",
            Birthday=new DateTime(1998,7,15)
              },


            new Account(){
            Id=1,Name="Trường Giang ",
            Email="anh@gmail.com",
            Phone="0326001258",
            Address="hà nội",
            Avatar=Url.Content("~/Avatar/1.jpg"),
            Gender=1,Bio="My name is Small",
            Birthday=new DateTime(1998,7,15)
            },
            
            new Account()
            { 
            Id= 1, Name="Hoàng Thuỳ",
            Email="anh@gmail.com",
            Phone="0326001258",
            Address="hà nội",
            Avatar=Url.Content("~/Avatar/1.jpg"),
            Gender=1,Bio="My name is Small",
            Birthday=new DateTime(1998,7,5)
            },

        };
            return View();
       }
        public IActionResult Profile()
        {
            Account account = new Account()
            {
                Id = 1,
                Name = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0326001258",
                Address = "hà nội ",
                Avatar = Url.Content("~/Avatar/1.jpg"),
                Gender = 1,
                Bio = "my name small",
                Birthday = new DateTime(1998, 7, 15)
            };
            ViewBag.Account = account;
            return View();
            }
    }
}
