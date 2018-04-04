using System.Collections.Generic;
using System.Linq;

namespace Selenium.StrongTyped.Controls
{
    /// <summary>
    /// Extension Methods for use on the List of HtmlElements. 
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Return the first element that has the Text required.
        /// </summary>
        /// <typeparam name="T">Control Type that will be returned.</typeparam>
        /// <param name="elements">List of all the Elements of the particular type.</param>
        /// <param name="searchText">The text to search for.</param>
        /// <returns>Returns the first element that has the Text that is passed in.</returns>
        public static T GetItemWithText<T>(this IList<T> elements, string searchText) where T : HtmlElement
        {
            return elements.First(x => x.Text.Equals(searchText));
        }

        /// <summary>
        /// Return the first element that has the containing Text required.
        /// </summary>
        /// <typeparam name="T">Control Type that will be returned.</typeparam>
        /// <param name="elements">List of all the Elements of the particular type.</param>
        /// <param name="searchText">The text to search for.</param>
        /// <returns>Returns the first element that has contains the Text that is passed in.</returns>
        public static T GetItemContainsText<T>(this IList<T> elements, string searchText) where T : HtmlElement
        {
            return elements.First(x => x.Text.Contains(searchText));
        }

        /// <summary>
        /// Return the first element that has the value required.
        /// </summary>
        /// <typeparam name="T">Control Type that will be returned.</typeparam>
        /// <param name="elements">List of all the Elements of the particular type.</param>
        /// <param name="searchValue">The searchValue to search for.</param>
        /// <returns>Returns the first element that has the value passed in.</returns>
        public static T GetItemWithValue<T>(this IList<T> elements, string searchValue) where T : HtmlElement
        {
            return elements.First(x => x.GetAttribute("value").Equals(searchValue));
        }

        /// <summary>
        /// Return the first element that has the containing value required.
        /// </summary>
        /// <typeparam name="T">Control Type that will be returned.</typeparam>
        /// <param name="elements">List of all the Elements of the particular type.</param>
        /// <param name="searchValue">The searchText to search for.</param>
        /// <returns>Returns the first element that has contains the value passed in.</returns>
        public static T GetItemContainsValue<T>(this IList<T> elements, string searchValue) where T : HtmlElement
        {
            return elements.First(x => x.GetAttribute("value").Contains(searchValue));
        }

    }
}
