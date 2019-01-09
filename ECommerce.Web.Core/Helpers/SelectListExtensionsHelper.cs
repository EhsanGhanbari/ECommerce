using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ECommerce.Web.Core.Helpers
{
    /// <summary>
    /// SelectList Extention
    /// </summary>
    public static class SelectListExtensionsHelper
    {
        public static IEnumerable<SelectListItem> ToSelectList<T>(this IEnumerable<T> source)
        {
            return ToSelectList(source, null);
        }

        public static IEnumerable<SelectListItem> ToSelectList<T>(this IEnumerable<T> source, string defaultOption)
        {
            return ToSelectList(source, value => value, value => value.ToString(), null);
        }

        public static IEnumerable<SelectListItem> ToSelectList<T, TDataValue>(
            this IEnumerable<T> source,
            Func<T, TDataValue> dataValueSelector,
            Func<T, string> dataTextSelector)
        {
            return ToSelectList(source, (value, index) => dataValueSelector(value), dataTextSelector, null);
        }

        public static IEnumerable<SelectListItem> ToSelectList<T, TDataValue>(
            this IEnumerable<T> source,
            Func<T, int, TDataValue> dataValueSelector,
            Func<T, string> dataTextSelector)
        {
            return ToSelectList(source, dataValueSelector, dataTextSelector, null);
        }

        public static IEnumerable<SelectListItem> ToSelectList<T, TDataValue>(
            this IEnumerable<T> source,
            Func<T, TDataValue> dataValueSelector,
            Func<T, string> dataTextSelector,
            string defaultOption)
        {
            return ToSelectList(source, (value, index) => dataValueSelector(value), dataTextSelector, defaultOption);
        }

        public static IEnumerable<SelectListItem> ToSelectList<T, TDataValue>(
            this IEnumerable<T> source,
            Func<T, int, TDataValue> dataValueSelector,
            Func<T, string> dataTextSelector,
            string defaultOption)
        {
            var list = source.Select((item, index) => new SelectListItem
            {
                Value = dataValueSelector(item, index).ToString(),
                Text = dataTextSelector(item),
            }).ToList();

            if (defaultOption == null) return list;

            list.Insert(0, new SelectListItem { Text = defaultOption, Value = "-1" });

            return list;
        }
    }
}