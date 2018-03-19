﻿using System;
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
        /// <summary>
        /// Finds the element or list of elements from the context, using the passed in selector.  It waits upto 30 seconds to find the control before exiting.
        /// </summary>
        /// <param name="context">The base element to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="listElement">If the search element is a list or a single control.</param>
        protected internal HtmlElement(ISearchContext context, By selector, bool listElement = false)
        {
            var wait = new DefaultWait<ISearchContext>(context) { Timeout = TimeSpan.FromSeconds(30) };
            if (listElement) {
                wait.Until(c => c.FindElements(selector).Count > 0);
                Elements = context.FindElements(selector);
            }
            else {
                wait.Until(c => c.FindElement(selector));
                Element = context.FindElement(selector);
            }
        }

        private IWebElement Element { get; }
        internal IWebElement GetElement() => Element;
        private IReadOnlyCollection<IWebElement> Elements { get; }
        internal IReadOnlyCollection<IWebElement> GetElements() => Elements;
        internal IWebElement FindElement(By selector) => Element.FindElement(selector);
        internal IReadOnlyCollection<IWebElement> FindElements(By selector) => Element.FindElements(selector);
        internal void Clear() => Element.Clear();
        internal void SendKeys(string text) => Element.SendKeys(text);
        internal void Submit() => Element.Submit();
        internal void Click() => Element.Click();
        internal string Text => Element.Text;
        internal bool Selected => Element.Selected;

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
    }
}