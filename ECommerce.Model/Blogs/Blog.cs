using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Blogs
{
    public sealed class Blog : EntityBase<Guid>, IAggregateRoot
    {

        #region Domain Fields

        private IList<BlogTag> _blogTags;
        private IList<BlogCategory> _blogCategories;
        private IList<BlogComment> _blogComments;

        #endregion

        #region Constructor

        public Blog()
        {
        }

        public Blog(IEnumerable<BlogComment> blogComment)
        {
            _blogComments = new List<BlogComment>(blogComment);
        }

        public Blog(string title, string body, string summary, string postSlug, bool allowComment,
            IEnumerable<BlogTag> blogTag, IEnumerable<BlogCategory> blogCategory)
        {
            Title = title;
            Body = body;
            Summary = summary;
            PostSlug = postSlug;
            AllowComments = allowComment;
            _blogTags = new List<BlogTag>(blogTag);
            _blogCategories = new List<BlogCategory>(blogCategory);
        }

        #endregion



        #region Domain Properties

        /// <summary>
        /// Titlte of the Blog Post
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Body of the Blog Post
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// CreationTime
        /// </summary>
        public DateTime CreationTime
        {
            get;
            set;
        }

        /// <summary>
        /// Summary of the Blog post
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Post Url Slug for CEO stuff
        /// </summary>
        public string PostSlug { get; set; }

        /// <summary>
        /// blog post could has comment or not ?
        /// </summary>
        public bool AllowComments { get; set; }

        /// <summary>
        /// mumber of comments
        /// </summary>
        public int CommentCount { get; set; }


        /// <summary>
        /// Blog Tag
        /// </summary>
        public IEnumerable<BlogTag> BlogTag
        {
            get { return _blogTags; }
        }


        /// <summary>
        /// List of Blog comments
        /// </summary>s
        public IEnumerable<BlogComment> BlogComment
        {
            get { return _blogComments; }
        }


        /// <summary>
        /// List of Blog Categories
        /// </summary>
        public IEnumerable<BlogCategory> BlogCategory
        {
            get { return _blogCategories; }
        }

        #endregion


        #region Domain Methods

        /// <summary>
        /// Removes blog Tag
        /// </summary>
        /// <param name="blogTag"></param>
        public void RemoveBlogTag(BlogTag blogTag)
        {
            _blogTags.Remove(blogTag);
        }

        /// <summary>
        /// Remove Blog category
        /// </summary>
        /// <param name="blogCategory"></param>
        public void RemoveBlogCategory(BlogCategory blogCategory)
        {
            _blogCategories.Remove(blogCategory);
        }

        /// <summary>
        /// Validate the Business Rule
        /// </summary>
        protected override void Validate()
        {
            if (Title == null)
                AddBrokenRule(BlogBusinessRule.TitleRequired);
            if (Body == null)
                AddBrokenRule(BlogBusinessRule.BodyRequired);
        }

        #endregion
    }
}
