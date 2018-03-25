using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    public sealed class LabelElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the Label Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Label Element within.</param>
        /// <param name="selector">The Selector to use to find the Label Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Label Element to be available.</param>
        public LabelElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Checkbox Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Label Element within.</param>
        /// <param name="selector">The Selector to use to find the Label Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Label Element to be available.</param>
        public LabelElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        /// <summary>
        /// The text in the text box.
        /// </summary>
        /// <returns>Passed back the text in the text box.</returns>
        public string Value => base.GetAttribute("value");

    }
}
