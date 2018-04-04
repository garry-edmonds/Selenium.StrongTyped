using System;
using System.Collections.Generic;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Base HtmlElement using the methods from IWebElement to be used by the particular control.
    /// </summary>
    public class HtmlElement 
    {
        #region Constructors

        /// <summary>
        /// Stores the element, so can be used to call the methods on the element.  Used for the FindElements method.
        /// </summary>
        /// <param name="element">The element to store in this class.</param>
        protected internal HtmlElement(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        /// Finds the element or list of elements from the context, using the passed in selector.  It waits upto 30 seconds to find the control before exiting.
        /// </summary>
        /// <param name="context">The base element to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="seconds">The number of seconds to wait.</param>
        /// <param name="listElement">If the search element is a list or a single control.</param>
        protected HtmlElement(ISearchContext context, By selector, int seconds = 30, bool listElement = false)
        {
            var wait = new DefaultWait<ISearchContext>(context) { Timeout = TimeSpan.FromSeconds(seconds) };
            if (listElement)
            {
                wait.Until(c => c.FindElements(selector).Count > 0);
                Elements = context.FindElements(selector);
            }
            else
            {
                wait.Until(c => c.FindElement(selector));
                Element = context.FindElement(selector);
            }
        }

        /// <summary>
        /// Finds the element or list of elements from the context, using the passed in selector.  It waits for as long as you specify.
        /// </summary>
        /// <param name="context">The base element to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="timespan">The timespan for how long to wait.</param>
        /// <param name="listElement">If the search element is a list or a single control.</param>
        protected internal HtmlElement(ISearchContext context, By selector, TimeSpan timespan, bool listElement = false)
        {
            var wait = new DefaultWait<ISearchContext>(context) { Timeout = timespan };
            if (listElement)
            {
                wait.Until(c => c.FindElements(selector).Count > 0);
                Elements = context.FindElements(selector);
            }
            else
            {
                wait.Until(c => c.FindElement(selector));
                Element = context.FindElement(selector);
            }
        }

        #endregion

        internal IWebElement Element { get; }
        
        internal IReadOnlyCollection<IWebElement> Elements { get; }
        internal IReadOnlyCollection<IWebElement> GetElements() => Elements;

        #region Methods that are exposed by the specific control type

        internal void Clear() => Element.Clear();
        internal void SendKeys(string text) => Element.SendKeys(text);
        internal void Submit() => Element.Submit();
        internal void Click() => Element.Click();
        internal string Text => Element.Text;
        internal bool Selected => Element.Selected;

        #endregion

        #region Methods that are available for all control types

        /// <summary>
        /// Gets a value indicating wheather or not this element is enabled.
        /// </summary>
        public bool Enabled => Element.Enabled;
        /// <summary>
        /// Gets a point object of the upper-left corner of this element relative to the upper-left corner of the page.
        /// </summary>
        public Point Location => Element.Location;
        /// <summary>
        /// Get the size of the object containing the height and width of the element.
        /// </summary>
        public Size Size => Element.Size;
        /// <summary>
        /// Gets the value of a specified attribute for this element.
        /// </summary>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public string GetAttribute(string attributeName) => Element.GetAttribute(attributeName);
        /// <summary>
        /// Gets the value of a JavaScript property of this element.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public string GetProperty(string propertyName) => Element.GetProperty(propertyName);
        /// <summary>
        /// Gets the value of a CSS property of this element.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public string GetCssValue(string propertyName) => Element.GetCssValue(propertyName);
        /// <summary>
        /// Gets the tag name of this element.
        /// </summary>
        public string TagName => Element.TagName;   
        /// <summary>
        /// Gets a value indicating wheather or not this element is displayed.
        /// </summary>
        public bool Displayed => Element.Displayed;

        #endregion
    }
}