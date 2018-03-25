using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Button Element, with all functionality required from a button control.
    /// </summary>
    public sealed class ButtonElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the Button Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Button Element within.</param>
        /// <param name="selector">The Selector to use to find the Button Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Button Element to be available.</param>
        public ButtonElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Button Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Button Element within.</param>
        /// <param name="selector">The Selector to use to find the Button Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Button Element to be available.</param>
        public ButtonElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        /// <summary>
        /// Click the Button Element.
        /// </summary>
        public new void Click() => base.Click();
        
    }
}
