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
        public ButtonElement(ISearchContext context, By selector) : base(context, selector) { }
        
        /// <summary>
        /// Click the Button Element.
        /// </summary>
        public new void Click() => base.Click();
        
    }
}
