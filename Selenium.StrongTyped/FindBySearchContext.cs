using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Extension Methods for FindElement using ISearchContext as the base to search from on types inherited from HtmlElement and return Element type.
    /// </summary>
    public static class FindBySearchContext
    {
        /// <summary>
        /// Finds an element within the search context of the original control and returns the type of element supplied.
        /// </summary>
        /// <typeparam name="T">The type of Element to be passed back.</typeparam>
        /// <param name="context">The ISearchContext to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="seconds">The number of seconds to wait</param>
        /// <returns></returns>
        public static T FindElement<T>(this ISearchContext context, By selector, int seconds = 30) where T : HtmlElement
        {
            T el;
            if (typeof(T) == typeof(ButtonElement))
                el = (T)(object)new ButtonElement(context, selector, seconds);
            else if (typeof(T) == typeof(CheckboxElement))
                el = (T)(object)new CheckboxElement(context, selector, seconds);
            else if (typeof(T) == typeof(LabelElement))
                el = (T)(object)new LabelElement(context, selector, seconds);
            else if (typeof(T) == typeof(RadioElement))
                el = (T)(object)new RadioElement(context, selector, seconds);
            else if (typeof(T) == typeof(TextElement))
                el = (T)(object)new TextElement(context, selector, seconds);
            else if (typeof(T) == typeof(TableElement))
                el = (T)(object)new TableElement(context, selector, seconds);
            else if (typeof(T) == typeof(TableRowElement))
                el = (T)(object)new TableRowElement(context, selector, seconds);
            else if (typeof(T) == typeof(TableCellElement))
                el = (T)(object)new TableCellElement(context, selector, seconds);
            else
                el = (T)(object)new CustomElement(context, selector, seconds);
            return el;
        }

        /// <summary>
        /// Finds an element within the search context of the original control and returns the type of element supplied.
        /// </summary>
        /// <typeparam name="T">The type of Element to be passed back.</typeparam>
        /// <param name="context">The ISearchContext to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="timespan">The timespan for how long to wait.</param>
        /// <returns></returns>
        public static T FindElement<T>(this ISearchContext context, By selector, TimeSpan timespan) where T : HtmlElement
        {
            T el;
            if (typeof(T) == typeof(ButtonElement))
                el = (T)(object)new ButtonElement(context, selector, timespan);
            else if (typeof(T) == typeof(CheckboxElement))
                el = (T)(object)new CheckboxElement(context, selector, timespan);
            else if (typeof(T) == typeof(LabelElement))
                el = (T)(object)new LabelElement(context, selector, timespan);
            else if (typeof(T) == typeof(RadioElement))
                el = (T)(object)new RadioElement(context, selector, timespan);
            else if (typeof(T) == typeof(TextElement))
                el = (T)(object)new TextElement(context, selector, timespan);
            else if (typeof(T) == typeof(TableElement))
                el = (T)(object)new TableElement(context, selector, timespan);
            else if (typeof(T) == typeof(TableRowElement))
                el = (T)(object)new TableRowElement(context, selector, timespan);
            else if (typeof(T) == typeof(TableCellElement))
                el = (T)(object)new TableCellElement(context, selector, timespan);
            else
                el = (T)(object)new CustomElement(context, selector, timespan);
            return el;
        }

        /// <summary>
        /// Finds list of elements within the search context of the original control and returns list of the elements supplied.
        /// </summary>
        /// <typeparam name="T">The type of Element to be passed back.</typeparam>
        /// <param name="context">The ISearchContext to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="seconds">The number of seconds to wait</param>
        /// <returns>List of the elements all of the same type that was passed in.</returns>
        public static IList<T> FindElements<T>(this ISearchContext context, By selector, int seconds = 30) where T : HtmlElement
        {
            IList<T> el = new List<T>();
            switch (typeof(T).Name)
            {
                case "ButtonElement":
                    var buttons = (T)(object)new ButtonElement(context, selector, seconds, true);
                    foreach (var buttonsElement in buttons.Elements)
                    {
                        el.Add((T)(object)new ButtonElement(buttonsElement));
                    }
                    break;
                case "CheckboxElement":
                    var checkbox = (T)(object)new CheckboxElement(context, selector, seconds, true);
                    foreach (var webElement in checkbox.Elements)
                    {
                        el.Add((T)(object)new CheckboxElement(webElement));
                    }
                    break;
                case "LabelElement":
                    var label = (T)(object)new LabelElement(context, selector, seconds, true);
                    foreach (var webElement in label.Elements)
                    {
                        el.Add((T)(object)new LabelElement(webElement));
                    }
                    break;
                case "RadioElement":
                    var radio = (T)(object)new RadioElement(context, selector, seconds, true);
                    foreach (var webElement in radio.Elements)
                    {
                        el.Add((T)(object)new RadioElement(webElement));
                    }
                    break;
                case "TextElement":
                    var text = (T)(object)new TextElement(context, selector, seconds, true);
                    foreach (var webElement in text.Elements)
                    {
                        el.Add((T)(object)new TextElement(webElement));
                    }
                    break;
                case "TableElement":
                    var table = (T)(object)new TableElement(context, selector, seconds, true);
                    foreach (var webElement in table.Elements)
                    {
                        el.Add((T)(object)new TableElement(webElement));
                    }
                    break;
                case "TableRowElement":
                    var tableRow = (T)(object)new TableRowElement(context, selector, seconds, true);
                    foreach (var webElement in tableRow.Elements)
                    {
                        el.Add((T)(object)new TableRowElement(webElement));
                    }
                    break;
                case "TableCellElement":
                    var tableCell = (T)(object)new TableCellElement(context, selector, seconds, true);
                    foreach (var webElement in tableCell.Elements)
                    {
                        el.Add((T)(object)new TableCellElement(webElement));
                    }
                    break;
                default:
                    var custom = (T)(object)new CustomElement(context, selector, seconds, true);
                    foreach (var webElement in custom.Elements)
                    {
                        el.Add((T)(object)new CustomElement(webElement));
                    }
                    break;
            }
            return el;
        }

        /// <summary>
        /// Finds list of elements within the search context of the original control and returns list of the elements supplied.
        /// </summary>
        /// <typeparam name="T">The type of Element to be passed back.</typeparam>
        /// <param name="context">The ISearchContext to search from.</param>
        /// <param name="selector">The by selector to be search for.</param>
        /// <param name="timespan">The timespan for how long to wait.</param>
        /// <returns>List of the elements all of the same type that was passed in.</returns>
        public static IList<T> FindElements<T>(this ISearchContext context, By selector, TimeSpan timespan) where T : HtmlElement
        {
            IList<T> el = new List<T>();
            switch (typeof(T).Name)
            {
                case "ButtonElement":
                    var buttons = (T)(object)new ButtonElement(context, selector, timespan, true);
                    foreach (var buttonsElement in buttons.Elements)
                    {
                        el.Add((T)(object)new ButtonElement(buttonsElement));
                    }
                    break;
                case "CheckboxElement":
                    var checkbox = (T)(object)new CheckboxElement(context, selector, timespan, true);
                    foreach (var webElement in checkbox.Elements)
                    {
                        el.Add((T)(object)new CheckboxElement(webElement));
                    }
                    break;
                case "LabelElement":
                    var label = (T)(object)new LabelElement(context, selector, timespan, true);
                    foreach (var webElement in label.Elements)
                    {
                        el.Add((T)(object)new LabelElement(webElement));
                    }
                    break;
                case "RadioElement":
                    var radio = (T)(object)new RadioElement(context, selector, timespan, true);
                    foreach (var webElement in radio.Elements)
                    {
                        el.Add((T)(object)new RadioElement(webElement));
                    }
                    break;
                case "TextElement":
                    var text = (T)(object)new TextElement(context, selector, timespan, true);
                    foreach (var webElement in text.Elements)
                    {
                        el.Add((T)(object)new TextElement(webElement));
                    }
                    break;
                case "TableElement":
                    var table = (T)(object)new TableElement(context, selector, timespan, true);
                    foreach (var webElement in table.Elements)
                    {
                        el.Add((T)(object)new TableElement(webElement));
                    }
                    break;
                case "TableRowElement":
                    var tableRow = (T)(object)new TableRowElement(context, selector, timespan, true);
                    foreach (var webElement in tableRow.Elements)
                    {
                        el.Add((T)(object)new TableRowElement(webElement));
                    }
                    break;
                case "TableCellElement":
                    var tableCell = (T)(object)new TableCellElement(context, selector, timespan, true);
                    foreach (var webElement in tableCell.Elements)
                    {
                        el.Add((T)(object)new TableCellElement(webElement));
                    }
                    break;
                default:
                    var custom = (T)(object)new CustomElement(context, selector, timespan, true);
                    foreach (var webElement in custom.Elements)
                    {
                        el.Add((T)(object)new CustomElement(webElement));
                    }
                    break;
            }
            return el;
        }

    }
}
