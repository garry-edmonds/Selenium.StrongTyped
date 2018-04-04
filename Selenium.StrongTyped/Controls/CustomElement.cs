using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    public sealed class CustomElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Custom Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Custom Element within.</param>
        /// <param name="selector">The Selector to use to find the Custom Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Custom Element to be available.</param>
        public CustomElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, false) { }

        /// <summary>
        /// Constructor for the Custom Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Custom Element within.</param>
        /// <param name="selector">The Selector to use to find the Custom Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Custom Element to be available.</param>
        public CustomElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan, false) { }

        #endregion

        #region Used for FindElements

        internal CustomElement(IWebElement element) 
            : base(element) { }

        internal CustomElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal CustomElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Custom Methods

        /// <summary>
        /// Click the Custom Element.
        /// </summary>
        public new void Click() => base.Click();

        /// <summary>
        /// Clear the content of the Custom Element.
        /// </summary>
        public new void Clear() => base.Clear();

        /// <summary>
        /// Gets the state of the Custom Element.
        /// </summary>
        /// <returns>bool if the Custom Element is checked or not.</returns>
        public new bool Selected => base.Selected;
        
        /// <summary>
        /// Enters the passed in text into the Custom Element.
        /// </summary>
        /// <param name="text">Value to enter into Custom Element.</param>
        public new void SendKeys(string text) => base.SendKeys(text);

        /// <summary>
        /// Submits the Custom Element to the Web Server.
        /// </summary>
        public new void Submit() => base.Submit();

        /// <summary>
        /// Gets the innertext of the Custom Element.
        /// </summary>
        public new string Text => base.Text;
        
        #endregion
    }
}
