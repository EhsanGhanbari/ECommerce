using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Groups;

namespace ECommerce.Services.Groups
{
    public static class GroupMapper
    {
        /// <summary>
        /// Convert to group View Model
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static GroupViewModel ConvertToGroupViewModel(this Group group)
        {
            return Mapper.Map<Group, GroupViewModel>(group);
        }


        /// <summary>
        /// Convert to Group Model
        /// </summary>
        /// <param name="groupViewModel"></param>
        /// <returns></returns>
        public static Group ConvertToGroupModel(this GroupViewModel groupViewModel)
        {
            return Mapper.Map<GroupViewModel, Group>(groupViewModel);
        }


        /// <summary>
        /// Convert to Groupd View Model list 
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static IEnumerable<GroupViewModel> ConvertToGroupViewModelList(this IEnumerable<Group> group)
        {
            return Mapper.Map<IEnumerable<Group>, IEnumerable<GroupViewModel>>(group);
        }
    }
}
