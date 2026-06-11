using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Lab6_Test
{
    public class Selenium
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Enter_To_List_Of_Countries_Test()
        {
            // Arrange
            var URL = "http://localhost:8080/";

            string countryName = "Venezuela";
            string countryContinent = "America";
            string countryLanguage = "Español";

            // Act
            _driver!.Navigate().GoToUrl(URL);

            // Click en Agregar Pais
            var addCountryButton = _driver.FindElement(
                By.XPath("//button[contains(text(), 'Agregar Pais')]")
            );
            addCountryButton.Click();

            //Asserts

            //verificar que llego al formulario
            var formTitle = _driver.FindElement(
                By.XPath("//h3[contains(text(), 'Formulario de creacion de paises')]")
            );
            Assert.That(formTitle.Displayed, Is.True);

            //Agregar nombre de pais.
            var nameInput = _driver.FindElement(By.Id("name"));
            nameInput.SendKeys(countryName);

            //Seleccionar continente
            var continentSelectElement = _driver.FindElement(By.Id("continente"));
            var continentSelect = new SelectElement(continentSelectElement);
            continentSelect.SelectByText(countryContinent);

            //Agregar idioma
            var languageInput = _driver.FindElement(By.Id("idioma"));
            languageInput.SendKeys(countryLanguage);

            //Guardamos el pais
            var saveButton = _driver.FindElement(
                By.XPath("//button[contains(text(), 'Guardar')]")
            );
            saveButton.Click();

            //Como no tenemos alerta de agregado correctamente, volveremos a la pagina y revisaremos si existe en la lista
            // Assert: verificar que volvio a la lista
            var listTitle = _driver.FindElement(
                By.XPath("//h1[contains(text(), 'Lista de paises')]")
            );

            Assert.That(listTitle.Displayed, Is.True);

            // Assert: verificar que el país aparece en la página
            Assert.That(_driver.PageSource, Does.Contain(countryName));
            Assert.That(_driver.PageSource, Does.Contain(countryContinent));
            Assert.That(_driver.PageSource, Does.Contain(countryLanguage));
        }

        //Cerramos la pagina
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}