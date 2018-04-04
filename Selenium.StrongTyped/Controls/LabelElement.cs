using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Label Element, with all functionality required from a Label control.
    /// </summary>
    public sealed class LabelElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Label Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Label Element within.</param>
        /// <param name="selector">The Selector to use to find the Label Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Label Element to be available.</param>
        public LabelElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Label Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Label Element within.</param>
        /// <param name="selector">The Selector to use to find the Label Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Label Element to be available.</param>
        public LabelElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        #endregion

        #region Used for FindElements

        internal LabelElement(IWebElement element) 
            : base(element) { }

        internal LabelElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal LabelElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Label Methods

        /// <summary>
        /// The value in the label.
        /// </summary>
        /// <returns>Passed back the value in the label element.</returns>
        public string Value => base.GetAttribute("value");

        #endregion
    }
}
