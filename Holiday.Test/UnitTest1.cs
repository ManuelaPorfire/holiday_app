using System;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Collections.Generic;

namespace Holiday.Test
{


    [TestClass]
    public class UnitTest1
    {
        [Test]
        public void TC001_OpenHolidaySite_Smoke_Testing()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.Manage().Window.Maximize();

            driver.Quit();
        }

        [Test]

        public void TC002_BehaviourOfLinkAllHolidayIfTheUserIsNotLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li/a")).Click();

            Assert.AreEqual("Log in - Holidays App", driver.Title);

            driver.Quit();
        }

        [Test]

        public void TC003_BehaviourOfLinkMyHolidayIfTheUserIsNotLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.ClassName("navbar-brand")).Click();

            Assert.AreEqual("Log in - Holidays App", driver.Title);

            driver.Quit();
        }

        [Test]

        public void TC004_ForgotPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.Id("forgot-password")).Click();
            driver.FindElement(By.Name("Input.Email")).SendKeys("anamaria1@bt.com");
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement paragraph = driver.FindElement(By.TagName("p"));

            Assert.IsTrue(paragraph.Text.Contains("Please check your email to reset your password."));

            Console.WriteLine("The Page contains the text 'Please check your email to reset your password.' ");

            driver.Quit();
        }

        [Test]

        public void TC005_EmptyEmailFieldForgotPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.Id("forgot-password")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.Id("Input_Email-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The Email field is required."));

            ITakesScreenshot screenShotDriver2 = driver.FindElement(By.ClassName("pb-3")) as ITakesScreenshot;
            Screenshot screenShot1 = screenShotDriver2.GetScreenshot();
            screenShot1.SaveAsFile(fileName: @"C:\Users\manue\Desktop\ForgotPassword.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }

        [Test]

        public void TC006_IncorrectEmailOnForgotPasswordField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.Id("forgot-password")).Click();
            driver.FindElement(By.Name("Input.Email")).SendKeys("111");
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.Id("Input_Email-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The Email field is not a valid e-mail address."));

            ITakesScreenshot screenShotDriver2 = driver.FindElement(By.ClassName("pb-3")) as ITakesScreenshot;
            Screenshot screenShot1 = screenShotDriver2.GetScreenshot();
            screenShot1.SaveAsFile(fileName: @"C:\Users\manue\Desktop\ForgotPasswordIncorrectEmailField.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }

        [Test]

        public void TC007_RegisterNewUser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.XPath("//*[@id='account']/div[6]/p[2]/a")).Click();
            IWebElement fullName = driver.FindElement(By.Name("Input.FullName"));
            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            IWebElement confirmPassword = driver.FindElement(By.Name("Input.ConfirmPassword"));

            Random rnd = new Random();
            string nume = String.Format($"AnaMaria{rnd.Next(1, 1000)}");
            string email = String.Format($"ana{rnd.Next(10000)}maria{rnd.Next(10000)}@gmail.com");
            string pass = String.Format($"AnaMaria?{rnd.Next(DateTime.Now.Millisecond)}");
            string confirm = pass;

            fullName.SendKeys(nume);
            emailField.SendKeys(email);
            password.SendKeys(pass);
            confirmPassword.SendKeys(confirm);

            driver.FindElement(By.ClassName("btn-primary")).Click();

            Assert.AreEqual("My Holidays - Holidays App", driver.Title);

            ITakesScreenshot screenShotDriver2 = driver.FindElement(By.ClassName("pb-3")) as ITakesScreenshot;
            Screenshot screenShot1 = screenShotDriver2.GetScreenshot();
            screenShot1.SaveAsFile(fileName: @"C:\Users\manue\Desktop\RegisterUser.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }

        [Test]

        public void TC008__CreateAccountIncorrectEmailFormat()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/Identity/Account/Login?ReturnUrl=%2F";
            driver.FindElement(By.XPath("//*[@id='account']/div[6]/p[2]/a")).Click();

            IWebElement fullName = driver.FindElement(By.Name("Input.FullName"));
            fullName.Click();
            fullName.SendKeys("AnaMaria Bob");

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anabt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            IWebElement confirmPassword = driver.FindElement(By.Name("Input.ConfirmPassword"));

            Random rnd = new Random();
            string pass = String.Format($"AnaMaria?{rnd.Next(DateTime.Now.Millisecond)}");
            string confirm = pass;

            password.SendKeys(pass);
            confirmPassword.SendKeys(confirm);

            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.Id("Input_Email-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The Email field is not a valid e-mail address."));

            driver.Quit();
        }

        [Test]

        public void TC009_CreateHolidaywithInvalidYearOnStartDate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-plus-circle")).Click();

            IWebElement startDate = driver.FindElement(By.Id("StartDate"));
            startDate.Click();
            startDate.SendKeys("06/03/20202");

            IWebElement endDate = driver.FindElement(By.Id("EndDate"));
            endDate.Click();
            endDate.SendKeys("06/01/2020");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByValue("2");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("field-validation-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The value '20202-06-03' is not valid for Start Date."));

            driver.Quit();
        }

        [Test]

        public void TC010_CreateHolidayWithInvalidYearOnEndDate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-plus-circle")).Click();

            IWebElement startDate = driver.FindElement(By.Id("StartDate"));
            startDate.Click();
            startDate.SendKeys("06/01/2020");

            IWebElement endDate = driver.FindElement(By.Id("EndDate"));
            endDate.Click();
            endDate.SendKeys("06/03/20202");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("Medical");

            driver.FindElement(By.XPath("/html/body/div/main/div[2]/div/form/div[4]/input")).Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("field-validation-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The value '20202-06-03' is not valid for End Date."));

            driver.Quit();
        }

        [Test]

        public void TC011_CreateHolidayWithEmptyField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-plus-circle")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("field-validation-error"));

            Assert.IsTrue(errorMessage.Text.Contains("The value '' is invalid."));

            IWebElement error = driver.FindElement(By.ClassName("field-validation-error"));

            Point className = error.Location;
            int xCordi = className.X;
            int yCordi = className.Y;

            Console.WriteLine("Element's Position from left side" + xCordi + " pixels.");
            Console.WriteLine("Element's Position from left side" + yCordi + " pixels.");

            driver.Quit();
        }
        [Test]

        public void TC012_TheBehaviourOfBackToListButtonOnCreatePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-plus-circle")).Click();
            driver.FindElement(By.ClassName("fa-arrow-circle-left")).Click();

            Assert.AreEqual("My Holidays - Holidays App", driver.Title);

            driver.Quit();
        }

        [Test]

        public void TC013_EditHolidayRequest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-edit")).Click();

            IWebElement editStartDate = driver.FindElement(By.Id("StartDate"));
            editStartDate.Click();
            editStartDate.SendKeys("04/06/2020");

            IWebElement editEndDate = driver.FindElement(By.Id("EndDate"));
            editEndDate.Click();
            editEndDate.SendKeys("04/10/2020");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("Paid");

            driver.FindElement(By.CssSelector("body > div > main > div:nth-child(5) > div > form > div:nth-child(7) > input")).Click();

            Assert.AreEqual("My Holidays - Holidays App", driver.Title);

            IWebElement startDateEdit = driver.FindElement(By.Id("holidaysTable"));

            Assert.IsTrue(startDateEdit.Text.Contains("4/6/2020"));

            driver.Quit();
        }

        [Test]

        public void TC014_TheBehaviourOfModifiedOnColumnAfterEditAHolidayRequest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-edit")).Click();

            IWebElement startDate = driver.FindElement(By.Name("StartDate"));
            startDate.Click();
            startDate.SendKeys("02/10/2020");

            IWebElement endDate = driver.FindElement(By.Name("EndDate"));
            endDate.Click();
            endDate.SendKeys("02/10/2020");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("Medical");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            var modified = driver.FindElement(By.XPath("//*[@id='holidaysTablebody']/tr[1]/td[6]")).Text;

            Console.WriteLine("The date of ModifiedOn field is" + " " + modified);

            driver.Quit();
        }

        [Test]

        public void TC015_EndDateLessThatStartDate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-plus-circle")).Click();

            IWebElement startDate = driver.FindElement(By.Id("StartDate"));
            startDate.Click();
            startDate.SendKeys("06/01/2020");

            IWebElement endDate = driver.FindElement(By.Id("EndDate"));
            endDate.Click();
            endDate.SendKeys("05/20/2020");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("Legal");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("validation-summary-errors"));

            Assert.IsTrue(errorMessage.Text.Contains("End Date must be greater than Start Date"));

            IWebElement error = driver.FindElement(By.ClassName("validation-summary-errors"));

            Point className = error.Location;
            int xCordi = className.X;
            int yCordi = className.Y;

            Console.WriteLine("Element's Position from left side" + xCordi + " pixels.");
            Console.WriteLine("Element's Position from left side" + yCordi + " pixels.");

            driver.Quit();
        }

        [Test]

        public void TC016_TheBehaviourOfCreateHolidayPageIfYouEnterADateThatAlreadyExist()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.ClassName("fa-edit")).Click();

            IWebElement startDate = driver.FindElement(By.Name("StartDate"));
            startDate.Click();
            startDate.SendKeys("02/06/2020");

            IWebElement endDate = driver.FindElement(By.Name("EndDate"));
            endDate.Click();
            endDate.SendKeys("02/06/2020");

            var type = driver.FindElement(By.Id("Type"));
            var selectElement = new SelectElement(type);
            selectElement.SelectByText("Medical");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement errorMessage = driver.FindElement(By.ClassName("validation-summary-errors"));

            Assert.AreEqual("There are holidays between 02/06/2020 and 02/06/2020. Please re-enter", errorMessage.Text);

            driver.Quit();
        }

        [Test]

        public void TC017_DeleteHolidayRequestInPendingStatus()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();

            List<IWebElement> tableRows = driver.FindElement(By.Id("holidaysTablebody")).FindElements(By.TagName("tr")).ToList();

            driver.FindElement(By.ClassName("fa-trash-alt")).Click();

            Assert.AreEqual("Delete Holiday - Holidays App", driver.Title);

            driver.FindElement(By.ClassName("btn-danger")).Click();

            var newTableNumber = driver.FindElement(By.Id("holidaysTablebody")).FindElements(By.TagName("tr")).ToList();

            Assert.AreNotEqual(tableRows, newTableNumber);

            driver.Quit();
        }


        [Test]

        public void TC018_GoBackFromDeletePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();

            driver.FindElement(By.ClassName("fa-trash-alt")).Click();
            driver.FindElement(By.ClassName("fa-arrow-circle-left")).Click();

            Assert.AreEqual("My Holidays - Holidays App", driver.Title);

            driver.Quit();
        }

        [Test]

        public void TC019_TotalNumberOfDays()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();

            IWebElement currentYearHoliday = driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[2]/b"));

            Console.WriteLine("The number of Current Year Holiday is by default:  " + currentYearHoliday.Text);

            driver.Quit();
        }

        [Test]

        public void TC020_NumberOfDaysLeft()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";
            driver.FindElement(By.CssSelector("#account>div:nth-child(8)>p:nth-child(2)>a")).Click();

            IWebElement fullName = driver.FindElement(By.Id("Input_FullName"));
            fullName.Click();
            fullName.SendKeys("Roxana Bob");

            IWebElement email = driver.FindElement(By.Id("Input_Email"));
            email.Click();
            email.SendKeys("roxanabob@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("RoxanaBob1111?");

            IWebElement confirmPassword = driver.FindElement(By.Id("Input_ConfirmPassword"));
            confirmPassword.Click();
            confirmPassword.SendKeys("RoxanaBob1111?");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement holidaysLeft = driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[3]/b"));

            Console.WriteLine("The number of Holidays Left if you don't have " +
                              "registered Holidays Request for Current Year is:   " + holidaysLeft.Text);

            driver.Quit();

        }

        [Test]

        public void TC021_ManageProfileFullName()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.CssSelector("body>header>nav>div>div>ul>li:nth-child(1)>a")).Click();

            IWebElement fullName = driver.FindElement(By.Id("Input_FullName"));
            fullName.Click();
            fullName.Clear();
            Random rnd = new Random();
            string name = String.Format($"Ana{rnd.Next(1, 1000)}");
            fullName.SendKeys(name);

            driver.FindElement(By.Id("update-profile-button")).Click();
            driver.FindElement(By.Id("holidays")).Click();

            IWebElement newName = driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[1]/b"));
            Console.WriteLine("The name of user was changed in  " + newName.Text);

            driver.Quit();
        }

        [Test]

        public void TC022_ManagePassword_CurrentPasswordCorrect()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            driver.FindElement(By.CssSelector("#account>div:nth-child(8)>p:nth-child(2)>a")).Click();

            IWebElement fullName = driver.FindElement(By.Id("Input_FullName"));
            fullName.Click();
            fullName.SendKeys("Robert Pop");

            Random rnd = new Random();
            string currentP = String.Format($"Robert{rnd.Next(1, 1000)}Pop?");
            string remember = currentP;

            string newP = String.Format($"RobertPop?11{rnd.Next(1, 1000)}");
            string remembernew = newP;
            string emailRegister = String.Format($"robertpop{rnd.Next(1, 1000)}@bt.com");

            IWebElement email = driver.FindElement(By.Id("Input_Email"));
            email.Click();
            email.SendKeys(emailRegister);

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys(remember);

            IWebElement confirmPasswordRegister = driver.FindElement(By.Id("Input_ConfirmPassword"));
            confirmPasswordRegister.Click();
            confirmPasswordRegister.SendKeys(remember);

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a")).Click();
            driver.FindElement(By.Id("change-password")).Click();

            IWebElement currentPassword = driver.FindElement(By.Id("Input_OldPassword"));
            currentPassword.Click();
            currentPassword.SendKeys(remember);

            IWebElement newPassword = driver.FindElement(By.Name("Input.NewPassword"));
            newPassword.Click();
            newPassword.SendKeys(newP);

            IWebElement confirmPassword = driver.FindElement(By.Id("Input_ConfirmPassword"));
            confirmPassword.Click();
            confirmPassword.SendKeys(newP);

            driver.FindElement(By.ClassName("btn-primary")).Click();

            IWebElement confirmChangePassword = driver.FindElement(By.ClassName("alert-success"));
            Assert.IsTrue(confirmChangePassword.Text.Contains("Your password has been changed."));

            driver.Quit();
        }

        [Test]

        public void TC023_ManagePersonalDataLinkDownload()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.CssSelector("body>header>nav>div>div>ul>li:nth-child(1)>a")).Click();
            driver.FindElement(By.Id("personal-data")).Click();
            driver.FindElement(By.XPath("//*[@id='download-data']/button")).Click();

            driver.Quit();
        }

        [Test]

        public void TC024_ManagePersonalDataDeleteAccount()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";
            driver.FindElement(By.CssSelector("#account>div:nth-child(8)>p:nth-child(2)>a")).Click();


            string name = String.Format($"Alexandru" + DateTime.Now.Millisecond + "Pop?");
            string email = String.Format($"alexandru" + DateTime.Now.Millisecond + "@bt.com");
            string password = String.Format($"Alex?12" + DateTime.Now.Millisecond);

            IWebElement fullName = driver.FindElement(By.Id("Input_FullName"));
            fullName.Click();
            fullName.SendKeys(name);

            IWebElement emailField = driver.FindElement(By.Id("Input_Email"));
            emailField.Click();
            emailField.SendKeys(email);

            IWebElement passwordField = driver.FindElement(By.Name("Input.Password"));
            passwordField.Click();
            passwordField.SendKeys(password);

            IWebElement confirmPassword = driver.FindElement(By.Id("Input_ConfirmPassword"));
            confirmPassword.Click();
            confirmPassword.SendKeys(password);

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a")).Click();
            driver.FindElement(By.Id("personal-data")).Click();
            driver.FindElement(By.Id("delete")).Click();

            driver.Quit();
        }

        [Test]

        public void TC025_SmartSearchField_MyHolidayPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("anamaria@bt.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("AnaMaria1234?");

            driver.FindElement(By.ClassName("btn-primary")).Click();

            IWebElement smartSearch = driver.FindElement(By.Id("input"));
            smartSearch.Click();
            smartSearch.SendKeys("Training");

            IWebElement training = driver.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[2]/td[5]"));
            Assert.IsTrue(training.Text.Contains("Training"));

            driver.Quit();
        }

        [Test]

        public void TC026_SmartSearchFieldAllHolidays()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("allHolidays")).Click();

            IWebElement smartSearch = driver.FindElement(By.Id("input"));
            smartSearch.Click();
            smartSearch.SendKeys("Paid");

            IWebElement paidtext = driver.FindElement(By.XPath("/html/body/div/main/table/tbody/tr[1]/td[5]"));
            Assert.IsTrue(paidtext.Text.Contains("Paid"));

            var tableRows = driver.FindElement(By.Id("allholidaysTableBody")).FindElements(By.TagName("tr")).ToList();
            foreach (var row in tableRows)
            {
                if (!"none".Equals(row.GetCssValue("display")))
                {
                    var employeesInfo = row.FindElements(By.TagName("td")).ToList();
                    Console.WriteLine(employeesInfo[6].Text);
                }
            }

            driver.Quit();

        }

        [Test]

        public void TC027_EditButtonOnAllHolidayPage_statusPending()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("allHolidays")).Click();
            driver.FindElement(By.XPath("//*[@id='allholidaysTableBody']/tr[4]/td[8]/a/i")).Click();
            driver.FindElement(By.XPath("//*[@id='Status']/option[1]")).Click();
            driver.FindElement(By.ClassName("btn-primary")).Click();
            IWebElement status = driver.FindElement(By.XPath("//*[@id='allholidaysTableBody']/tr[4]/td[4]"));
            Assert.IsTrue(status.Text.Contains("Accepted"));
            Console.WriteLine("After edit, the status of Holiday Request for user Ana is: " + status.Text);

            driver.Quit();

        }

        [Test]

        public void TC028_TheBehaviourOfBackToListButton_EditPageAdmin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("allHolidays")).Click();
            driver.FindElement(By.XPath("//*[@id='allholidaysTableBody']/tr[2]/td[8]/a/i")).Click();
            driver.FindElement(By.ClassName("fa-arrow-circle-left")).Click();

            Assert.AreEqual("All Holidays - Holidays App", driver.Title);

            driver.Quit();
        }

        [Test]

        public void TC029_EditButtonOnAllHolidayPage_StatusDeclined()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://localhost:44382/";

            IWebElement emailField = driver.FindElement(By.Name("Input.Email"));
            emailField.Click();
            emailField.SendKeys("manuelaporfire@gmail.com");

            IWebElement password = driver.FindElement(By.Name("Input.Password"));
            password.Click();
            password.SendKeys("VY!N3vt9usCSAF5");

            driver.FindElement(By.ClassName("btn-primary")).Click();
            driver.FindElement(By.Id("allHolidays")).Click();
            driver.FindElement(By.XPath("//*[@id='allholidaysTableBody']/tr[2]/td[8]/a/i")).Click();

            var status = driver.FindElement(By.Id("Status"));
            var selectElement = new SelectElement(status);
            selectElement.SelectByValue("2");

            driver.FindElement(By.ClassName("btn-primary")).Click();

            IWebElement statusdecliend = driver.FindElement(By.XPath("//*[@id='allholidaysTableBody']/tr[2]/td[4]"));
            Assert.IsTrue(statusdecliend.Text.Contains("Declined"));
            Console.WriteLine("The status of request is: " + statusdecliend.Text);

            driver.Quit();
        }
    }

}
