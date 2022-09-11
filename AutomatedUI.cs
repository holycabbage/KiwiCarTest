using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KiwiCarsTest
{   [TestClass]
    public class AutomatedUI
    {
        private readonly IWebDriver _driver;

        public AutomatedUI()
        {
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void LaunchBrowser()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Cars");

            Assert.AreEqual("Index - KiwiCars", _driver.Title);
        }
        [TestMethod]
        public void ShouldEnterRegisterDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Register");

            //Enter FirstName
            IWebElement FirstName = _driver.FindElement(By.Name("Input.FirstName"));
            FirstName.SendKeys("Haosong");
            DelayForDemo();

            //Enter LastName
            IWebElement LastName = _driver.FindElement(By.Name("Input.LastName"));
            LastName.SendKeys("Zhang");
            DelayForDemo();

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            //Enter ConfirmPassword
            IWebElement ConfirmPassword = _driver.FindElement(By.Name("Input.ConfirmPassword"));
            ConfirmPassword.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();
        }


        [TestMethod]
        public void ShouldEnterLoginDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();


            _driver.FindElement(By.ClassName("btn-block")).Click();
        }


        //Cars
        [TestMethod]
        public void ShouldEnterCarDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();


            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars/Create");

            //Enter Make
            IWebElement Make = _driver.FindElement(By.Name("Make"));
            Make.SendKeys("Toyota");
            DelayForDemo();

            //Enter Model
            IWebElement Model = _driver.FindElement(By.Name("Model"));
            Model.SendKeys("MarkX");
            DelayForDemo();

            //Enter Year
            IWebElement Year = _driver.FindElement(By.Name("Year"));
            Year.SendKeys("2010");
            DelayForDemo();

            //Enter Price
            IWebElement Price = _driver.FindElement(By.Name("Price"));
            Price.SendKeys("11000");
            DelayForDemo();

            //Enter Description
            IWebElement Description = _driver.FindElement(By.Name("Description"));
            Description.SendKeys("No issues");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [TestMethod]
        public void ShouldEditCarDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars/Edit/103");

            //Edit Make
            IWebElement Make = _driver.FindElement(By.Name("Make"));
            Make.Clear();
            Make.SendKeys("New Lexus");
            DelayForDemo();

            //Edit Model
            IWebElement Model = _driver.FindElement(By.Name("Model"));
            Model.Clear();
            Model.SendKeys("is350");
            DelayForDemo();

            //Edit Year
            IWebElement Year = _driver.FindElement(By.Name("Year"));
            Year.Clear();
            Year.SendKeys("2015");
            DelayForDemo();

            //Edit Price
            IWebElement Price = _driver.FindElement(By.Name("Price"));
            Price.Clear();
            Price.SendKeys("25000");
            DelayForDemo();

            //Edit Description
            IWebElement Description = _driver.FindElement(By.Name("Description"));
            Description.Clear();
            Description.SendKeys("very good");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [TestMethod]
        public void ShouldDeleteCar()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars/Delete/105");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-danger")).Click();
        }

        [TestMethod]
        public void ShouldSearchCars()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars");
            DelayForDemo();

            IWebElement Search = _driver.FindElement(By.Name("SearchString"));
            Search.SendKeys("Mazda");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-default")).Click();
        }

        [TestMethod]
        public void ShouldSortCars()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars?sortOrder=make_desc");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/Cars");
            DelayForDemo();

        }



        //Users
        [TestMethod]
        public void ShouldEditUserDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/AspNetUsers/Edit/b050bf33-5b8b-4248-aa72-43843315f20a");

            //Edit FirstName
            IWebElement FirstName = _driver.FindElement(By.Name("FirstName"));
            FirstName.Clear();
            FirstName.SendKeys("Stu");
            DelayForDemo();

            //Edit PhoneNumber
            IWebElement PhoneNumber = _driver.FindElement(By.Name("PhoneNumber"));
            PhoneNumber.Clear();
            PhoneNumber.SendKeys("021 123 1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [TestMethod]
        public void ShouldSearchUsers()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/AspNetUsers");
            DelayForDemo();

            IWebElement Search = _driver.FindElement(By.Name("SearchString"));
            Search.SendKeys("Haosong");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-default")).Click();
        }

        [TestMethod]
        public void ShouldSortUsers()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/AspNetUsers");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/AspNetUsers?sortOrder=name_desc");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/AspNetUsers");
            DelayForDemo();

        }


        //Adverts
        [TestMethod]
        public void ShouldEnterAdvertDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();


            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts/Create");

            //Enter UserId
            IWebElement UserId = _driver.FindElement(By.Name("UserId"));
            UserId.SendKeys("9df5a243-87fe-4be4-ab59-bb92c98fba02");
            DelayForDemo();

            //Enter CarId
            IWebElement CarId = _driver.FindElement(By.Name("CarId"));
            CarId.SendKeys("No issues");
            DelayForDemo();

            //Enter AdvertDate
            IWebElement AdvertDate = _driver.FindElement(By.Name("AdvertDate"));
            AdvertDate.SendKeys("18/10/2021");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [TestMethod]
        public void ShouldEditAdvertDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();


            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts/Edit/7");    

            //Edit AdvertDate
            IWebElement AdvertDate = _driver.FindElement(By.Name("AdvertDate"));
            AdvertDate.Clear();
            AdvertDate.SendKeys("21/10/2021");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-primary")).Click();
        }

        [TestMethod]
        public void ShouldDeleteAdvertDetails()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();


            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts/Delete/8");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-danger")).Click();

        }

        [TestMethod]
        public void ShouldSearchAdverts()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts");
            DelayForDemo();

            IWebElement Search = _driver.FindElement(By.Name("SearchString"));
            Search.SendKeys("18/10/2021");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-default")).Click();
        }

        [TestMethod]
        public void ShouldSortAdverts()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts?sortOrder=Date");
            DelayForDemo();

            _driver.Navigate().GoToUrl("https://localhost:44384/Adverts");
            DelayForDemo();

        }

        [TestMethod]
        public void ShouldLogout()
        {
            _driver.Navigate().GoToUrl("https://localhost:44384/Identity/Account/Login");

            //Enter Email
            IWebElement Email = _driver.FindElement(By.Name("Input.Email"));
            Email.SendKeys("zhanghaosong111@gmail.com");
            DelayForDemo();

            //Enter Password
            IWebElement Password = _driver.FindElement(By.Name("Input.Password"));
            Password.SendKeys("English.1234");
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-block")).Click();
            DelayForDemo();

            _driver.FindElement(By.ClassName("btn-link")).Click();
        }

        

        private static void DelayForDemo()
        {
            Thread.Sleep(1000);
        }
    }
}
