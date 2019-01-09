namespace ECommerce.Web.Core.Paging
{
    public class PagerHelperOptions
    {
        public bool ShowNext { get; set; }
        public bool ShowLast { get; set; }
        public bool ShowPrevious { get; set; }
        public bool ShowFirst { get; set; }
        public string NextText { get; set; }
        public string LastText { get; set; }
        public string PreviousText { get; set; }
        public string FirstText { get; set; }
        public bool DisablePreviousIfNoMorePages { get; set; }
        public bool DisableNextIfNoMorePages { get; set; }
        public bool DisableFirstIfNoMorePages { get; set; }
        public bool DisableLastIfNoMorePages { get; set; }
        public bool ShowDisplayingItemsAlways { get; set; }
        public bool ShowDisplayingItemsLeyend { get; set; }
        public string DisplayingItemsText { get; set; }
        public int PageSize { get; set; }
        public int PagesInPager { get; set; }

        public PagerHelperOptions()
        {
            ShowNext = true;
            ShowLast = true;
            ShowPrevious = true;
            ShowFirst = true;
            NextText = ">";
            LastText = ">>";
            PreviousText = "<";
            FirstText = "<<";
            DisableFirstIfNoMorePages = true;
            DisableLastIfNoMorePages = true;
            DisableNextIfNoMorePages = true;
            DisablePreviousIfNoMorePages = true;
            ShowDisplayingItemsLeyend = true;
            DisplayingItemsText = "Displaying items {0} - {1} of {2}";
            PageSize = 5;
            PagesInPager = 5;
            ShowDisplayingItemsAlways = true;
        }
    }
}