# Selenium.StrongTyped

This project is a wrapper on top the initial IWebElement so that the methods or properties for each element type
are related to the type of control.  I.E ButtonElement has Click method but not a Clear method.

## How to use Selenium.StrongTyped.
Project will be available as a nuget package at <a href="https://www.nuget.org/packages/Selenium.StrongTyped">Nuget Page</a>.

## How to create the StrongTyped controls.
Within POM or test method.

```sh
- public TextElement textBox = new TextElement(Driver, By.Id("id"));                               		
    'Default wait timeout 30 seconds'
- public TextElement textBox = new TextElement(Driver, By.Id("id"), 20);                              	
    'Changed wait timeout 20 seconds'
- public TextElement textBox = new TextElement(Driver, By.Id("id"), TimeSpan.FromMilliseconds(500));  	
    'Wait timeout using TimeSpan object'
```

or using an Expression body I.E:

```sh
- private TextElement TextBox => new TextElement(Driver, By.CssSelector(".button"), TimeSpan.FromMilliseconds(500));
```

NOTE - The finding of the element uses a WebDriver wait to search for the control and currently times out after 30 seconds 
if the element can not be found.  If you don't want a timeout set the value to '0'.


## FindElement(s) - as of `Version 0.0.4` 

Able to call FindElement<T> of type of control, so don't have to create an instance of the Element.
Example:

```sh
- var driver = new ChromeDriver();
.....
- var button = driver.FindElement<ButtonElement>(By.Id("id"), 20);										
    'FindElement and return as a ButtonElement from the ISearchContext(WebDriver) wait timeout 20 seconds'
- var textBox = driver.FindElement<TextElement>(By.Id("id"), TimeSpan.FromMilliseconds(500));			
    'FindElement and return as a TextElement from the ISearchContext(WebDriver) wait timeout using TimeSpan object'
- var subElement = button.FindElement<LabelElement>(By.Id("id");										
    'FindElement and return as a LabelElement from within the found ButtonElement default wait timeout 30 seconds'
```

Able to call FindElements<T> of type of control.

```sh
- var driver = new ChromeDriver();
.....
- IList<ButtonElement> buttons = driver.FindElements<ButtonElement>(By.Id("id"), 20);					
    'FindElements and return a List of ButtonElements from the ISearchContext(WebDriver) wait timeout 20 seconds'
```


## Element Methods
Current Controls available are (Actions):

- ButtonElement  	{ Click() }
- CheckboxElement  	{ Click(), Selected }
- LabelElement  	{ Value }
- RadioElement      { Click(), Selected }
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


## List Methods
- GetItemWithText																					'Returns a single element in which the element in the list has the Text supplied.'
- GetItemContainsText																				'Returns a single element in which the element in the list has the Contains the Text supplied.'
- GetItemWithValue																					'Returns a single element in which the element in the list has the Value supplied.'
- GetItemContainsValue																				'Returns a single element in which the element in the list has the Contains the Value supplied.'