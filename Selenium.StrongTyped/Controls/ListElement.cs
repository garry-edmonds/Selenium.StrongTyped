using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// List Element, with all functionality required from a List control.
    /// </summary>
    public sealed class ListElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the List Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the List Element within.</param>
        /// <param name="selector">The Selector to use to find the List Element.</param>
        /// <param name="seconds">The number of seconds to wait for the List Element to be available.</param>
        public ListElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, true) { }

        /// <summary>
        /// Constructor for the Checkbox Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the List Element within.</param>
        /// <param name="selector">The Selector to use to find the List Element.</param>
        /// <param name="timeSpan">The timespan to wait until the List Element to be available.</param>
        public ListElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        /// <summary>
        /// Returns an Element based on the value passed in.
        /// </summary>
        /// <param name="value">The value from the list to find an element.</param>
        /// <returns>IWebElement of the found element.</returns>
        public IWebElement GetItemByValue(string value) => GetElements().First(x => x.Text.Equals(value));

        /// <summary>
        /// Select the element based on the value passed in.
        /// </summary>
        /// <param name="value">The value from the list to find an element and then click it.</param>
        public void SelectItemByValue(string value) => GetItemByValue(value).Click();

        /// <summary>
        /// Return the number of items in the list.
        /// </summary>
        public int Count => GetElements().Count;

        /// <summary>
        /// Returns list of IWebElements.
        /// </summary>
        public IReadOnlyCollection<IWebElement> Elements => GetElements();
        
    }
}