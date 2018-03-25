using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Checkbox Element, with all functionality required from a Checkbox control.
    /// </summary>
    public sealed class CheckboxElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the Checkbox Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Checkbox Element within.</param>
        /// <param name="selector">The Selector to use to find the Checkbox Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Checkbox Element to be available.</param>
        public CheckboxElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Checkbox Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Checkbox Element within.</param>
        /// <param name="selector">The Selector to use to find the Checkbox Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Checkbox Element to be available.</param>
        public CheckboxElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        /// <summary>
        /// Click the Checkbox Element.
        /// </summary>
        public new void Click() => base.Click();

        /// <summary>
        /// Gets the state of the Checkbox.
        /// </summary>
        /// <returns>bool if the Checkbox is checked or not.</returns>
        public new bool Selected => base.Selected;
        
    }
}
