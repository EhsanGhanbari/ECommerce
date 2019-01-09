using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Forums;

namespace ECommerce.Services.Forums
{
    public static class ForumMapper
    {
        /// <summary>
        /// Convert to Forum ViewModel
        /// </summary>
        /// <param name="forum"></param>
        /// <returns></returns>
        public static ForumViewModel ConvertToForumViewModel(this Forum forum)
        {
            return Mapper.Map<Forum, ForumViewModel>(forum);
        }


        /// <summary>
        /// Convert to Forum Model
        /// </summary>
        /// <param name="forumViewModel"></param>
        /// <returns></returns>
        public static Forum ConvertToForumModel(this ForumViewModel forumViewModel)
        {
            return Mapper.Map<ForumViewModel, Forum>(forumViewModel);
        }

        /// <summary>
        /// Convert to Forum View Model list
        /// </summary>
        /// <param name="forum"></param>
        /// <returns></returns>
        public static IEnumerable<ForumViewModel> ConvertToForumViewModelList(this IEnumerable<Forum> forum)
        {
            return Mapper.Map<IEnumerable<Forum>, IEnumerable<ForumViewModel>>(forum);
        }

    }
}
