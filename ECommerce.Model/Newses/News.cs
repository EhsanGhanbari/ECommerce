using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Newses
{
    public class News : EntityBase<Guid>, IAggregateRoot
    {

        #region Domain Fields

        private readonly IList<NewsTag> _newsTags = new List<NewsTag>();
        private readonly IList<NewsCategory> _newsCategories = new List<NewsCategory>();
        private readonly NewsComment _newsComments;
        private readonly string _title;
        private readonly string _body;
        private readonly string _postSlug;


        #endregion

        #region Constructor

        public News()
        {
        }

        public News(NewsComment newsComment)
        {
            _newsComments = newsComment;
        }

        public News(IEnumerable<NewsTag> newsTags,
            IEnumerable<NewsCategory> newsCategories,
            string title, string body, string postSlug)
        {
            _newsTags = new List<NewsTag>(newsTags);
            _newsCategories = new List<NewsCategory>(newsCategories);
            _title = title;
            _body = body;
            _postSlug = postSlug;
        }

        #endregion

        #region Domain Properties

        /// <summary>
        /// News Title
        /// </summary>
        public virtual string Title
        {
            get { return _title; }
        }

        /// <summary>
        /// News Body
        /// </summary>
        public virtual string Body
        {
            get { return _body; }
        }


        /// <summary>
        /// PostSlug
        /// </summary>
        public virtual string PostSlug
        {
            get { return _postSlug; }
        }

        /// <summary>
        /// News Summary 
        /// </summary>
        public virtual string Summary { get; set; }

        /// <summary>
        /// Creation Time
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// News Slug 
        /// </summary>
        public virtual string NewsSlug { get; set; }

        /// <summary>
        /// Visitor could make any comment or Not!
        /// </summary>
        public virtual bool AllowComments { get; set; }


        /// <summary>
        /// List of news categories
        /// </summary>
        public virtual IList<NewsCategory> NewsCategories
        {
            get { return _newsCategories; }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual IList<NewsTag> NewsTags
        {
            get { return _newsTags; }
        }

        /// <summary>
        /// List of news comments
        /// </summary>
        public virtual NewsComment NewsComments
        {
            get;
            set;
        }

        #endregion


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
