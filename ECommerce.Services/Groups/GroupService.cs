using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Groups;
using ECommerce.Services.Contract.Groups;
using ECommerce.Services.Groups.Messaging;

namespace ECommerce.Services.Groups
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public GroupService(IGroupRepository groupRepository, IUnitOfWork unitOfWork, ILogger logger)
        {
            _groupRepository = groupRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }


        /// <summary>
        /// Create Group Servive
        /// members could create a group , manage the members of the group and etc!
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var response = new CreateGroupResponse();
            var group = request.GroupViewModel.ConvertToGroupModel();
            _groupRepository.Add(group);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// retruns all groups created in the system
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllGroupsRespone GetAllGroups(GetAllGroupsRequest request)
        {
            var respone = new GetAllGroupsRespone();
            var groups = _groupRepository.GetAll();
            respone.GroupViewModels = groups.ConvertToGroupViewModelList();
            return respone;
        }

        /// <summary>
        /// GetAll Members of a group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllMembersOfGroupResponse GetAllMembersOfGroup(GetAllMembersOfGroupRequest request)
        {
            var response = new GetAllMembersOfGroupResponse();
            var members=_groupRepository.GetAllMembersOfGroupQuery(request.GroupViewModel.GroupId);
            response.GroupViewModels = members.ConvertToGroupViewModelList();
            return response;
        }

        /// <summary>
        /// get a group details by Id 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetGroupResponse GetGroup(GetGroupRequest request)
        {
            var response = new GetGroupResponse();
            var group = _groupRepository.GetById(request.GroupViewModel.GroupId);
            response.GroupViewModel = group.ConvertToGroupViewModel();
            return response;
        }


        /// <summary>
        /// Remove Group 
        /// this is done by Admin and group creater
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveGroupResponse RemoveGroup(RemoveGroupRequest request)
        {
            var response = new RemoveGroupResponse();
            var group = request.GroupViewModel.ConvertToGroupModel();
            _groupRepository.Remove(group);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// Removes a member from group
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveMemberFromGroupResponse RemoveMemberFromGroup(RemoveMemberFromGroupRequest request)
        {
            var response = new RemoveMemberFromGroupResponse();


            return response;
        }

        /// <summary>
        /// Update Group Content 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var response = new UpdateGroupResponse();
            var group = request.GroupViewModel.ConvertToGroupModel();
            _groupRepository.SaveOrUpdate(group);
            _unitOfWork.Commit();
            return response;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllGroupsByProductBrandResponse GetAllGroupsByProductBrand(GetAllGroupsByProductBrandRequest request)
        {
            var response = new GetAllGroupsByProductBrandResponse();
            var groups = _groupRepository.GetAllGroupsByProductBrandQuery(request.GroupViewModel.ProductBrand);
            response.GroupViewModels = groups.ConvertToGroupViewModelList();
            return response;
        }


        /// <summary>
        /// Returns all groups by product category 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllGroupsByCategoryResponse GetAllGroupsByCategory(GetAllGroupsByCategoryRequest request)
        {
            var response = new GetAllGroupsByCategoryResponse();
            var groups = _groupRepository.GetAllGroupsByProductCategoryQuery(request.GroupViewModel.CategoryId);
            response.GroupViewModels = groups.ConvertToGroupViewModelList();
            return response;

        }
    }
}
