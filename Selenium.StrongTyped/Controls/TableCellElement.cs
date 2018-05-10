using System;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Table Cell Element, with all functionality required from a Table Cell control.
    /// </summary>
    public sealed class TableCellElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Table Cell Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Cell Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Cell Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Table Cell Element to be available.</param>
        public TableCellElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, true) { }

        /// <summary>
        /// Constructor for the Table Cell Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Cell Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Cell Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Table Cell Element to be available.</param>
        public TableCellElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan, true) { }

        #endregion

        #region Used for FindElements

        internal TableCellElement(IWebElement element) 
            : base(element) { }

        internal TableCellElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal TableCellElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Table cell Methods

        /// <summary>
        /// Click the Cell Element.
        /// </summary>
        public new void Click() => base.Click();

        /// <summary>
        /// The text in the Cell.
        /// </summary>
        /// <returns>Passed back the text in the table cell.</returns>
        public new string Text => base.Text;

        #endregion
    }
}
