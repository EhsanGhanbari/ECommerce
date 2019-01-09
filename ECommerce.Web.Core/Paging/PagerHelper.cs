using System.Text;
using System.Web.Mvc;

namespace ECommerce.Web.Core.Paging
{
    public static class PagerHelper
    {
        public static MvcHtmlString Pager(this HtmlHelper html, PagerViewModel pagerViewModel)
        {
            int totalPages = MathHelper.CalcTotalPages(pagerViewModel.TotalItems, pagerViewModel.PagerHelperOptions.PageSize);
            int previousPage = MathHelper.CalcPreviousPage(pagerViewModel.CurrentPage);
            int nextPage = MathHelper.CalcNextPage(pagerViewModel.CurrentPage, totalPages);
            int lowerBound = MathHelper.CalcLowerBound(pagerViewModel.CurrentPage, pagerViewModel.PagerHelperOptions.PagesInPager, totalPages);
            int upperBound = MathHelper.CalcUpperBound(pagerViewModel.CurrentPage, pagerViewModel.PagerHelperOptions.PagesInPager, totalPages);

            var result = new StringBuilder();

            if (pagerViewModel.TotalItems != 0)
            {
                CreateCurrentPageHidden(result, pagerViewModel.CurrentPage);

                if (pagerViewModel.PagerHelperOptions.ShowFirst)
                {
                    CreateButton(result, pagerViewModel.PagerHelperOptions.FirstText, 1,
                        (pagerViewModel.PagerHelperOptions.DisableFirstIfNoMorePages &&
                        pagerViewModel.CurrentPage == 1));
                }

                if (pagerViewModel.PagerHelperOptions.ShowPrevious)
                {
                    CreateButton(result, pagerViewModel.PagerHelperOptions.PreviousText, previousPage,
                        (pagerViewModel.PagerHelperOptions.DisablePreviousIfNoMorePages &&
                        pagerViewModel.CurrentPage == 1));
                }

                for (int i = lowerBound; i <= upperBound; i++)
                {
                    CreateButton(result, i.ToString(), i);
                }

                if (pagerViewModel.PagerHelperOptions.ShowNext)
                {
                    CreateButton(result, pagerViewModel.PagerHelperOptions.NextText, nextPage,
                        (pagerViewModel.PagerHelperOptions.DisableNextIfNoMorePages &&
                        pagerViewModel.CurrentPage == totalPages));
                }

                if (pagerViewModel.PagerHelperOptions.ShowLast)
                {
                    CreateButton(result, pagerViewModel.PagerHelperOptions.LastText, totalPages,
                        (pagerViewModel.PagerHelperOptions.DisableLastIfNoMorePages &&
                        pagerViewModel.CurrentPage == totalPages));
                }
            }

            if (pagerViewModel.PagerHelperOptions.ShowDisplayingItemsLeyend &&
                (pagerViewModel.PagerHelperOptions.ShowDisplayingItemsAlways || pagerViewModel.TotalItems != 0))
            {
                int firstItem = MathHelper.CalcFirstItem(pagerViewModel.CurrentPage,
                    pagerViewModel.PagerHelperOptions.PageSize,
                    pagerViewModel.TotalItems);
                int lastItem = MathHelper.CalcLastItem(pagerViewModel.CurrentPage,
                    pagerViewModel.PagerHelperOptions.PageSize,
                    pagerViewModel.TotalItems);
                result.Append(string.Format(pagerViewModel.PagerHelperOptions.DisplayingItemsText, firstItem,
                                            lastItem, pagerViewModel.TotalItems));
            }

            return MvcHtmlString.Create(result.ToString());
        }

        private static void CreateCurrentPageHidden(StringBuilder result, int currentPage)
        {
            //TagBuilder tagBuilder = new TagBuilder("input");
            //tagBuilder.MergeAttribute("type", "hidden");
            //tagBuilder.MergeAttribute("name", "PagerViewModel.CurrentPage");
            //tagBuilder.MergeAttribute("value", currentPage.ToString());
            //result.Append(tagBuilder.ToString());
        }

        private static void CreateButton(StringBuilder result, string text, int gotoPage, bool disabled = false)
        {
            //TagBuilder tagBuilder = new TagBuilder("button");
            //tagBuilder.InnerHtml = text;
            //tagBuilder.MergeAttribute("type", "submit");
            //tagBuilder.MergeAttribute("name", "PagerViewModel.CurrentPageByButton");
            //tagBuilder.MergeAttribute("value", gotoPage.ToString());
            //tagBuilder.MergeAttribute("class", "pagerbutton");
            //if (disabled)
            //{
            //    tagBuilder.MergeAttribute("disabled", "disabled");
            //}
            //result.Append(tagBuilder.ToString());
        }
    }
}