using ECommerce.Services.Forums.Messaging;

namespace ECommerce.Services.Forums
{
    public interface IForumService
    {
        
        /// <summary>
        /// Create forum 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateForumResponse CreateForum(CreateForumRequest request);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveForumResponse RemoveForum(RemoveForumRequest request);

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateForumResponse UpdateForum(UpdateForumRequest request);



        //GetForum GetAllForum  DeleteForum GetTopic CreateTopic  UpdateTipc DeletePost CreatePost GetAllPost getPOst 

        //Topic
        //Group
        //Post
        //PrivateMessage
        //
    }
}
