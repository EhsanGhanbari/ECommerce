using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Forums
{
    /// <summary>
    /// Represents a forum
    /// </summary>
    public class Forum : EntityBase<Guid> , IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the forum group identifier
        /// </summary>
        public Guid ForumGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public virtual string Name { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public virtual  string Description { get; set; }

        /// <summary>
        /// Gets or sets the number of topics
        /// </summary>
        public virtual  int NumTopics { get; set; }

        /// <summary>
        /// Gets or sets the number of posts
        /// </summary>
        public virtual int NumPosts { get; set; }

        /// <summary>
        /// Gets or sets the last topic identifier
        /// </summary>
        public virtual Guid LastTopicId { get; set; }

        /// <summary>
        /// Gets or sets the last post identifier
        /// </summary>
        public virtual  Guid LastPostId { get; set; }

        /// <summary>
        /// Gets or sets the last post date and time
        /// </summary>
        public virtual  DateTime? LastPostTime { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public virtual  int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public virtual DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public virtual DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// Gets the ForumGroup
        /// </summary>
        public virtual ForumGroup ForumGroup { get; set; }



        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
