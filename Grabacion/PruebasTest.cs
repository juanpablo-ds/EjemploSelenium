using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.IO;

[TestFixture]
public class PruebasTest
{
    private WebDriver driver;
    [SetUp]
    public void SetUp()
    {
        string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        driver = new ChromeDriver(path + @"\drivers1\");
        
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void pruebas()
    {
        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.Manage().Window.Size = new System.Drawing.Size(1247, 648);
        driver.FindElement(By.Name("q")).Click();
        driver.FindElement(By.Name("q")).SendKeys("pruebas unitarias");
    }
}