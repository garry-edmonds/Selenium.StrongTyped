# Selenium.StrongTyped

This project is a wrapper on top the initial IWebElement so that the methods or properties for each element type
are related to the type of control.  I.E ButtonElement has Click method but not a Clear method.

## How to use Selenium.StrongTyped.
Project will be available as a nuget package at <a href="https://www.nuget.org/packages/Selenium.StrongTyped">Nuget Page</a>.

## How to create the StrongTyped controls.
Within POM or test method.
- public TextElement textBox = new TextElement(new ChromeDriver(), By.Id("id"));

or using an Expression body:

- private TextElement TextBox => new TextElement(Driver, By.CssSelector(".button"));

NOTE - The finding of the element uses a WebDriver wait to search for the control and currently times out after 30 seconds 
if the element can not be found.

## Element Methods
Current Controls available are (Actions):

- ButtonElement  	{ Click() }
- CheckboxElement  	{ Click(), Selected }
- LabelElement  	{ Value }
- ListElement  		{ GetItemByValue(), SelectItemByValue(), Count, Elements }
- TextElement  		{ SendKeys(), Text, Clear() }

All elements also have.

- Enabled
- Location
- Size
- GetAttribute
- GetProperty
- GetCssValue
- TagName
- Displayed

## Wish to add functionality
This is the initial version and more functionality will be added and more elements as required.
If you have an idea or enhancement please raise an issue on the page or contact me.