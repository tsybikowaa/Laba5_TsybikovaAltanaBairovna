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
            // ������������� �������� Selenium
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // ������� �� �������� ������ � ����������
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/SearchFilter/");

            // ������������� ������� �������� ������ � ����������
            searchFilterPage = new SearchFilterPagecs(driver);
        }

        [TearDown]
        public void Teardown()
        {
            // �������� �������� � ������������ ��������
            driver.Quit();

        }



        [Test]
        public void SearchByAccountTest()
        {
            // ����� �������� "All Accounts" � ���� ������ �� ��������. �� ������� cash bank
            searchFilterPage.SelectAccountSearchOption("Cash");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� ������� "cash"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("Cash", result.Account);
            }
        }
        [Test]
        public void SearchByAccountTestBank()
        {
            // ����� �������� "All Accounts" � ���� ������ �� ��������. �� ������� cash bank
            searchFilterPage.SelectAccountSearchOption("Bank Savings");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� ������� "Bank Savings"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("Bank Savings", result.Account);
            }
        }

        [Test]
        public void SearchByTypeTest()
        {
            // ����� �������� "EXPENDITURE" � ���� ������ �� ����
            searchFilterPage.SelectTypeSearchOption("EXPENDITURE");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� ����� ��� "EXPENDITURE"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("EXPENDITURE", result.Type);
            }
        }
        [Test]
        public void SearchByTypeTestINCOME()
        {
            // ����� �������� "EXPENDITURE" � ���� ������ �� ����
            searchFilterPage.SelectTypeSearchOption("INCOME");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� ����� ��� "EXPENDITURE"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.AreEqual("INCOME", result.Type);
            }
        }
        [Test]
        public void SearchByPayeeTest()
        {
            // �������� ���������� ������ �������� ������
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // ���� �������� "Payee" � ���� ������ �� ����������
            searchFilterPage.EnterPayeeSearchText("HouseRent");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� �������� "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("HouseRent"));
            }
        }
        [Test]
        public void SearchByPayeeTest1()
        {
            

            // ���� �������� "Payee" � ���� ������ �� ����������
            searchFilterPage.EnterPayeeSearchText("InternetBill");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� �������� "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("InternetBill"));
            }
        }
        [Test]
        public void SearchByPayeeTest2()
        {
            // �������� ���������� ������ �������� ������
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // ���� �������� "Payee" � ���� ������ �� ����������
            searchFilterPage.EnterPayeeSearchText("Salary");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� �������� "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("Salary"));
            }
        }
        [Test]
        public void SearchByPayeeTest3()
        {
            // �������� ���������� ������ �������� ������
            SearchFilterPagecs searchFilterPage = new SearchFilterPagecs(driver);

            // ���� �������� "Payee" � ���� ������ �� ����������
            searchFilterPage.EnterPayeeSearchText("PowerBill");

            // �������� ����������� ������
            NUnit.Framework.Assert.IsTrue(searchFilterPage.AreSearchResultsDisplayed());

            // ��������� ����������� ������
            List<SearchResult> searchResults = searchFilterPage.GetSearchResults();

            // ��������, ��� ������ ��������� �������� �������� "Payee"
            foreach (SearchResult result in searchResults)
            {
                NUnit.Framework.Assert.IsTrue(result.Payee.ToLower().Contains("PowerBill"));
            }
        }
    }
}


