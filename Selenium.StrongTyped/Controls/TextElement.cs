using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Text Element, with all functionality required from a Text control.
    /// </summary>
    public sealed class TextElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the Text Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Text Element within.</param>
        /// <param name="selector">The Selector to use to find the Text Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Text Element to be available.</param>
        public TextElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds) { }

        /// <summary>
        /// Constructor for the Checkbox Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Text Element within.</param>
        /// <param name="selector">The Selector to use to find the Text Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Text Element to be available.</param>
        public TextElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan) { }

        /// <summary>
        /// Enter the string into the Text box.
        /// </summary>
        /// <param name="textEntered">Text to be entered.</param>
        public new void SendKeys(string textEntered) => base.SendKeys(textEntered);

        /// <summary>
        /// The text in the text box.
        /// </summary>
        /// <returns>Passed back the text in the text box.</returns>
        public new string Text => base.Text;

        /// <summary>
        /// Clear the value in the text box.
        /// </summary>
        public new void Clear() => base.Clear();
        
    }
}