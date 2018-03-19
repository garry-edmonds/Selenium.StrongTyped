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
        /// <param name="context">Base element to search from to find the Checkbox Element within.</param>
        /// <param name="selector">The Selector to use to find the Checkbox Element.</param>
        public TextElement(ISearchContext context, By selector) : base(context, selector) { }

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