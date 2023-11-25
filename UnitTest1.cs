using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;
namespace Laba5Podderzhka
{
    [TestFixture]
    public class SearchFilterTests
    {


        private IWebDriver driver;
        private SearchFilterPagecs searchFilterPage;

        [SetUp]
        public void Setup()
        {
            // Инициализация драйвера Selenium
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Переход на страницу поиска и фильтрации
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/SearchFilter/");

            // Инициализация объекта страницы поиска и фильтрации
            searchFilterPage = new SearchFilterPagecs(driver);
        }

        [TearDown]
        public void Teardown()
        {
            // Закрытие браузера и освобождение ресурсов
            driver.Quit();

        }



        [Test]
        public void SearchByAccountTest()
        {
            // Выбор значения "All Accounts" в поле поиска по аккаунту. по каждому cash bank
            searchFilterPage.SelectAccountSearchOption("Cash");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит аккаунт "cash"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("Cash", result.Account);
            }
        }
        [Test]
        public void SearchByAccountTestBank()
        {
            // Выбор значения "All Accounts" в поле поиска по аккаунту. по каждому cash bank
            searchFilterPage.SelectAccountSearchOption("Bank Savings");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит аккаунт "Bank Savings"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("Bank Savings", result.Account);
            }
        }

        [Test]
        public void SearchByTypeTest()
        {
            // Выбор значения "EXPENDITURE" в поле поиска по типу
            searchFilterPage.SelectTypeSearchOption("EXPENDITURE");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат имеет тип "EXPENDITURE"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("EXPENDITURE", result.Type);
            }
        }
        [Test]
        public void SearchByTypeTestINCOME()
        {
            // Выбор значения "EXPENDITURE" в поле поиска по типу
            searchFilterPage.SelectTypeSearchOption("INCOME");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат имеет тип "EXPENDITURE"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("INCOME", result.Type);
            }
        }
        [Test]
        public void SearchByPayeeTest()
        {
            // Создание экземпляра класса страницы поиска
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // Ввод значения "Payee" в поле поиска по получателю
            searchFilterPage.EnterPayeeSearchText("HouseRent");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит значение "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("HouseRent"));
            }
        }
        [Test]
        public void SearchByPayeeTest1()
        {
            

            // Ввод значения "Payee" в поле поиска по получателю
            searchFilterPage.EnterPayeeSearchText("InternetBill");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит значение "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("InternetBill"));
            }
        }
        [Test]
        public void SearchByPayeeTest2()
        {
            // Создание экземпляра класса страницы поиска
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // Ввод значения "Payee" в поле поиска по получателю
            searchFilterPage.EnterPayeeSearchText("Salary");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит значение "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("Salary"));
            }
        }
        [Test]
        public void SearchByPayeeTest3()
        {
            // Создание экземпляра класса страницы поиска
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // Ввод значения "Payee" в поле поиска по получателю
            searchFilterPage.EnterPayeeSearchText("PowerBill");

            // Проверка результатов поиска
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // Получение результатов поиска
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // Проверка, что каждый результат содержит значение "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("PowerBill"));
            }
        }
    }
}


