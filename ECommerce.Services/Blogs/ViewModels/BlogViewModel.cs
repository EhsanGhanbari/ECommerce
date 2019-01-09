using System;
using FluentValidation.Attributes;

namespace ECommerce.Services.Blogs.ViewModels
{
    [Validator(typeof(BlogValidation))]
    public class BlogViewModel
    {

        /// <summary>
        /// Post Id
        /// </summary>
        public Guid PostId { get; set; }

        /// <summary>
        /// Blog post title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Blog post body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Blog post summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Creation Time of the post
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// Post url slug
        /// </summary>
        public string PostSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool AllowComment { get; set; }

        /// <summary>
        /// Name of the BlogTag
        /// </summary>
        public string TageName { get; set; }


        /// <summary>
        /// Name of the category
        /// </summary>
        public string CategoryName { get; set; }
    }
}
