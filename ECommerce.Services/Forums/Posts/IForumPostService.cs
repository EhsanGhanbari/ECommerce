using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Services.Forums.Posts.Messaging;

namespace ECommerce.Services.Forums.Posts
{
    public interface IForumPostService
    {
        CreateForumPostResponse CreateForumPost(CreateForumPostRequest request);

        GetForumPostResponse GetForumPost(GetForumPostRequest request);

        RemoveForumPostResponse RemoveForumPost(RemoveForumPostRequest request);

        UpdateForumPostResponse UpdateForumPost(UpdateForumPostRequest request);
    }
}
