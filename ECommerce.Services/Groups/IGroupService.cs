using ECommerce.Services.Groups.Messaging;

namespace ECommerce.Services.Contract.Groups
{
    public interface IGroupService
    {
        /// <summary>
        /// Create Group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        ///Get ALl Groups in system 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllGroupsRespone GetAllGroups(GetAllGroupsRequest request);

        /// <summary>
        /// Get All Members of Group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllMembersOfGroupResponse GetAllMembersOfGroup(GetAllMembersOfGroupRequest request);

        /// <summary>
        /// Get Groups 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Remove Group Request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveGroupResponse RemoveGroup(RemoveGroupRequest request);

        /// <summary>
        /// Remove members from a group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        RemoveMemberFromGroupResponse RemoveMemberFromGroup(RemoveMemberFromGroupRequest request);
        
        /// <summary>
        /// Update Group 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Returns groups by brand
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllGroupsByProductBrandResponse GetAllGroupsByProductBrand(GetAllGroupsByProductBrandRequest request);

        /// <summary>
        /// returns groups by product category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        GetAllGroupsByCategoryResponse GetAllGroupsByCategory(GetAllGroupsByCategoryRequest request);

    }
}
