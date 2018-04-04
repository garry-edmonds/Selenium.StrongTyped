using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Radio Element, with all functionality required from a Radio control.
    /// </summary>
    public sealed class RadioElement : HtmlElement
    {
        #region Constructrs

        /// <summary>
        /// Constructor for the Radio Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Radio Element within.</param>
        /// <param name="selector">The Selector to use to find the Radio Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Radio Element to be available.</param>
        public RadioElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Radio Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Radio Element within.</param>
        /// <param name="selector">The Selector to use to find the Radio Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Radio Element to be available.</param>
        public RadioElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        #endregion

        #region Used for FindElements

        internal RadioElement(IWebElement element) 
            : base(element) { }

        internal RadioElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal RadioElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Radio Methods

        /// <summary>
        /// Click the Radio Element.
        /// </summary>
        public void Select() => Click();

        /// <summary>
        /// Checks if the Radio Element is selected and returns true/false.
        /// </summary>
        /// <returns>True / False if Radio item ins selected.</returns>
        public new bool Selected() => base.Selected;
        
        #endregion
    }
}
