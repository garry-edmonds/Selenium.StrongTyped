using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Table Row Element, with all functionality required from a Table Row control.
    /// </summary>
    public sealed class TableRowElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Table Row Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Row Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Row Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Table Row Element to be available.</param>
        public TableRowElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, true) { }

        /// <summary>
        /// Constructor for the Table Row Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Row Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Row Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Table Row Element to be available.</param>
        public TableRowElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan, true) { }

        #endregion

        #region Used for FindElements

        internal TableRowElement(IWebElement element) 
            : base(element) { }

        internal TableRowElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal TableRowElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Table Row Methods

        /// <summary>
        /// List containing all the Data Cells in the selected row of the table.
        /// </summary>
        public IList<TableRowElement> Cells => this.FindElements<TableRowElement>(By.CssSelector("td"));
        
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
