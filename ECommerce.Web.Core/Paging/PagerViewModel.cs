namespace ECommerce.Web.Core.Paging
{
    public class PagerViewModel
    {
        public int CurrentPage { get; set; }
        public int CurrentPageByButton
        {
            set
            {
                CurrentPage = value;
            }
            get { return CurrentPage; }
        }
        public int TotalItems { get; set; }
        public PagerHelperOptions PagerHelperOptions { get; set; }

        public PagerViewModel()
        {
            PagerHelperOptions = new PagerHelperOptions();
            CurrentPage = 1;
        }

        public int Take
        {
            get { return PagerHelperOptions.PageSize; }
        }

        public int Skip
        {
            get
            {
                int skip = (CurrentPage - 1) * PagerHelperOptions.PageSize;

                if (TotalItems == skip)
                {
                    skip = (CurrentPage - 2) * PagerHelperOptions.PageSize;

                    if (skip < 0)
                    {
                        skip = 0;
                    }
                }
                return skip;
            }
        }
    }
}