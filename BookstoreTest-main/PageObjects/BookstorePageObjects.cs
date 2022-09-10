using BookStoreAutomationTest.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreAutomationTest.PageObjects
{
    public class BookstorePageObjects
    {
        #region Constructor
        private readonly IWebDriver _driver;

        public BookstorePageObjects(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion

        #region Page Objects
        private readonly By _title = By.Id("page-title");

        #endregion

        #region Gets
        public string PageTitle
        {
            get
            {
                _driver.WaitUntilElementVisible(_title);
                return _driver.FindElement(_title).Text;
            }
        }
        #endregion

        #region Methods

        public void FilterByName()

        {
            // Code here

            IWebDriver element = driver.FindElement(By.Id("searchBar"));
            element.SendKeys("java");
            Console.Read();

        }

        public void FilterByAuthor()
        {
            // Code here
            IWebDriver element = driver.FindElement(By.Id("searchBar"));
            element.SendKeys("greg");
            Console.Read();
        }

        public void FilterByPrice()
        {
            // Code here
            IWebDriver element = driver.FindElement(By.Id("searchBar"));
            element.SendKeys("$9.99");
            Console.Read();

}
        }

        public bool CheckName()
        {
            // Code here

             string userInput;
             Console.WriteLine("Does name java returned book? Answer in True/False");
             userInput= Console.ReadLine();

             bool userInputBoolean = Convert.ToBoolean(userInput);
             Console.WriteLine("Your input was" + userInputBoolean);

             bool isValid = true;
             bool isInValid = false;



        }

        public bool CheckAuthor()
        {
            // Code here

             string userInput;
             Console.WriteLine("Does author greg returned book? Answer in True/False");
             userInput= Console.ReadLine();

             bool userInputBoolean = Convert.ToBoolean(userInput);
             Console.WriteLine("Your input was" + userInputBoolean);

             bool isValid = true;
             bool isInValid = false;


        }

        public bool CheckPrice()
        {
            // Code here
             string userInput;
             Console.WriteLine("Does price $9.99 returned book? Answer in True/False");
             userInput= Console.ReadLine();

             bool userInputBoolean = Convert.ToBoolean(userInput);
             Console.WriteLine("Your input was" + userInputBoolean);

             bool isValid = true;
             bool isInValid = false;


        }
        #endregion
    }
}
