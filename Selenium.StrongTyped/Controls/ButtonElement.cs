using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Button Element, with all functionality required from a Button control.
    /// </summary>
    public sealed class ButtonElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Button Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Button Element within.</param>
        /// <param name="selector">The Selector to use to find the Button Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Button Element to be available.</param>
        public ButtonElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, false) { }

        /// <summary>
        /// Constructor for the Button Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Button Element within.</param>
        /// <param name="selector">The Selector to use to find the Button Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Button Element to be available.</param>
        public ButtonElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan, false) { }

        #endregion

        #region Used for FindElements

        internal ButtonElement(IWebElement element) 
            : base(element) { }

        internal ButtonElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal ButtonElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Button Methods

        /// <summary>
        /// Click the Button Element.
        /// </summary>
        public new void Click() => base.Click();

        #endregion
    }
}
