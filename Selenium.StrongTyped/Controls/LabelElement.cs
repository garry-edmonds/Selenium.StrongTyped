using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    public sealed class LabelElement : HtmlElement
    {
        /// <summary>
        /// Constructor for the Label Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Checkbox Element within.</param>
        /// <param name="selector">The Selector to use to find the Checkbox Element.</param>
        public LabelElement(ISearchContext context, By selector) : base(context, selector) { }

        /// <summary>
        /// The text in the text box.
        /// </summary>
        /// <returns>Passed back the text in the text box.</returns>
        public string Value => base.GetAttribute("value");

    }
}
