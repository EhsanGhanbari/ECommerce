namespace ECommerce.Model.Forums
{
    public class ForumSettings 
    {
        /// <summary>
        /// Gets or sets a value indicating whether forums are enabled
        /// </summary>
        public virtual bool ForumsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether relative date and time formatting is enabled (e.g. 2 hours ago, a month ago)
        /// </summary>
        public virtual bool RelativeDateTimeFormattingEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to edit posts that they created
        /// </summary>
        public virtual bool AllowCustomersToEditPosts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to manage their subscriptions
        /// </summary>
        public virtual bool AllowCustomersToManageSubscriptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether guests are allowed to create posts
        /// </summary>
        public virtual bool AllowGuestsToCreatePosts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether guests are allowed to create topics
        /// </summary>
        public virtual bool AllowGuestsToCreateTopics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to delete posts that they created
        /// </summary>
        public virtual bool AllowCustomersToDeletePosts { get; set; }

        /// <summary>
        /// Gets or sets maximum length of topic subject
        /// </summary>
        public virtual int TopicSubjectMaxLength { get; set; }

        /// <summary>
        /// Gets or sets the maximum length for stripped forum topic names
        /// </summary>
        public virtual int StrippedTopicMaxLength { get; set; }

        /// <summary>
        /// Gets or sets maximum length of post
        /// </summary>
        public virtual int PostMaxLength { get; set; }

        /// <summary>
        /// Gets or sets the page size for topics in forums
        /// </summary>
        public virtual int TopicsPageSize { get; set; }

        /// <summary>
        /// Gets or sets the page size for posts in topics
        /// </summary>
        public virtual int PostsPageSize { get; set; }

        /// <summary>
        /// Gets or sets the number of links to display for pagination of posts in topics
        /// </summary>
        public virtual int TopicPostsPageLinkDisplayCount { get; set; }

        /// <summary>
        /// Gets or sets the page size for search result
        /// </summary>
        public virtual int SearchResultsPageSize { get; set; }

        /// <summary>
        /// Gets or sets the page size for latest customer posts
        /// </summary>
        public virtual int LatestCustomerPostsPageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show customers forum post count
        /// </summary>
        public virtual bool ShowCustomersPostCount { get; set; }

        /// <summary>
        /// Gets or sets a forum editor type
        /// </summary>
        public virtual EditorType ForumEditor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether customers are allowed to specify a signature
        /// </summary>
        public virtual bool SignaturesEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether private messages are allowed
        /// </summary>
        public virtual bool AllowPrivateMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether an alert should be shown for new private messages
        /// </summary>
        public virtual bool ShowAlertForPM { get; set; }

        /// <summary>
        /// Gets or sets the page size for private messages
        /// </summary>
        public virtual int PrivateMessagesPageSize { get; set; }

        /// <summary>
        /// Gets or sets the page size for (My Account) Forum Subscriptions
        /// </summary>
        public virtual int ForumSubscriptionsPageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a customer should be notified about new private messages
        /// </summary>
        public virtual bool NotifyAboutPrivateMessages { get; set; }

        /// <summary>
        /// Gets or sets maximum length of pm subject
        /// </summary>
        public virtual int PMSubjectMaxLength { get; set; }

        /// <summary>
        /// Gets or sets maximum length of pm message
        /// </summary>
        public virtual int PMTextMaxLength { get; set; }

        /// <summary>
        /// Gets or sets the number of items to display for Active Discussions on forums home page
        /// </summary>
        public virtual int HomePageActiveDiscussionsTopicCount { get; set; }

        /// <summary>
        /// Gets or sets the number of items to display for Active Discussions page
        /// </summary>
        public virtual int ActiveDiscussionsPageTopicCount { get; set; }

        /// <summary>
        /// Gets or sets the number of items to display for Active Discussions RSS Feed
        /// </summary>
        public virtual int ActiveDiscussionsFeedCount { get; set; }

        /// <summary>
        /// Gets or sets the whether the Active Discussions RSS Feed is enabled
        /// </summary>
        public virtual bool ActiveDiscussionsFeedEnabled { get; set; }

        /// <summary>
        /// Gets or sets the whether Forums have an RSS Feed enabled
        /// </summary>
        public virtual bool ForumFeedsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the number of items to display for Forum RSS Feed
        /// </summary>
        public virtual int ForumFeedCount { get; set; }

        /// <summary>
        /// Gets or sets the minimum length for search term
        /// </summary>
        public virtual int ForumSearchTermMinimumLength { get; set; }
    }
}
