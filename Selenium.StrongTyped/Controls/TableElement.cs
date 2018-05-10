using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Table Element, with all functionality required from a Table control.
    /// </summary>
    public sealed class TableElement : HtmlElement
    {
        #region Constructors

        /// <summary>
        /// Constructor for the Table Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Element.</param>
        /// <param name="seconds">The number of seconds to wait for the Table Element to be available.</param>
        public TableElement(ISearchContext context, By selector, int seconds = 30) : base(context, selector, seconds, false) { }

        /// <summary>
        /// Constructor for the Table Element.
        /// </summary>
        /// <param name="context">Base element to search from to find the Table Element within.</param>
        /// <param name="selector">The Selector to use to find the Table Element.</param>
        /// <param name="timeSpan">The timespan to wait until the Table Element to be available.</param>
        public TableElement(ISearchContext context, By selector, TimeSpan timeSpan) : base(context, selector, timeSpan, false) { }

        #endregion

        #region Used for FindElements

        internal TableElement(IWebElement element) 
            : base(element) { }

        internal TableElement(ISearchContext context, By selector, int seconds, bool listElements) 
            : base(context, selector, seconds, listElements) { }

        internal TableElement(ISearchContext context, By selector, TimeSpan timeSpan, bool listElements) 
            : base(context, selector, timeSpan, listElements) { }

        #endregion

        #region Table Methods

        /// <summary>
        /// List containing all the Header Rows in the table.
        /// </summary>
        public IList<TableRowElement> HeaderRows => this.FindElements<TableRowElement>(By.CssSelector("thead tr"));
        
        /// <summary>
        /// List containing all the Data Rows in the table.
        /// </summary>
        public IList<TableRowElement> BodyRows => this.FindElements<TableRowElement>(By.CssSelector("tbody tr"));

        #endregion
    }
}
