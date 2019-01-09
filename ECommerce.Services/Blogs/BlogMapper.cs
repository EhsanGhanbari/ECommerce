using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Blogs;
using ECommerce.Services.Blogs.ViewModels;

namespace ECommerce.Services.Blogs
{
    public static class BlogMapper
    {


        /// <summary>
        /// Convert to BlogView
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static BlogViewModel ConvertToPostViewModel(this Blog post)
        {
            Mapper.CreateMap<Blog, BlogViewModel>()
                .ForMember(blo => blo.PostId, bl => bl.MapFrom(b => b.Id));
            return Mapper.Map<Blog, BlogViewModel>(post);
        }


        /// <summary>
        ///Convert to PostModel 
        /// </summary>
        /// <param name="postViewModel"></param>
        /// <returns></returns>
        public static Blog ConvertToPostModel(this BlogViewModel postViewModel)
        {
            return Mapper.Map<BlogViewModel, Blog>(postViewModel);
        }


        /// <summary>
        /// Convert to BlogPostViewList
        /// </summary>
        /// <param name="posts"></param>
        /// <returns></returns>
        public static IEnumerable<BlogViewModel> ConvertToPostListViewModel(this IEnumerable<Blog> posts)
        {
            Mapper.CreateMap<Blog, BlogViewModel>()
                .ForMember(blo => blo.PostId, bl => bl.MapFrom(b => b.Id));
            return Mapper.Map<IEnumerable<Blog>, IEnumerable<BlogViewModel>>(posts);
        }



        /// <summary>
        /// Conertti blog category view model list
        /// </summary>
        /// <param name="blogCategory"></param>
        /// <returns></returns>
        public static IEnumerable<BlogCategoryViewModel> ConvertToBlogCategoryViewModelList(this IEnumerable<BlogCategory> blogCategory)
        {
            Mapper.CreateMap<BlogCategoryViewModel, BlogCategory>()
            .ForMember(blo => blo.Name, bl => bl.MapFrom(b => b.BlogCategoryName));
            return Mapper.Map<IEnumerable<BlogCategory>, IEnumerable<BlogCategoryViewModel>>(blogCategory);
        }

        /// <summary>
        ///  Convert to blog tag view model list
        /// </summary>
        /// <param name="blogTag"></param>
        /// <returns></returns>
        public static IEnumerable<BlogTagViewModel> ConvertToBlogTagViewModelList(this IEnumerable<BlogTag> blogTag)
        {
            return Mapper.Map<IEnumerable<BlogTag>, IEnumerable<BlogTagViewModel>>(blogTag);
        }

        /// <summary>
        /// Convert to blog comment view model
        /// </summary>
        /// <param name="blogComment"></param>
        /// <returns></returns>
        public static BlogViewModel ConvertToBlogCommentViewModel(this BlogComment blogComment)
        {
            return Mapper.Map<BlogComment, BlogViewModel>(blogComment);
        }


        /// <summary>
        /// Convert blog view model to blog Comment model
        /// </summary>
        /// <param name="blogViewModel"></param>
        /// <returns></returns>
        public static BlogComment ConvertToBlogCommentModel(this BlogViewModel blogViewModel)
        {
            return Mapper.Map<BlogViewModel, BlogComment>(blogViewModel);
        }


        /// <summary>
        /// Convert to blog comment view model list
        /// </summary>
        /// <param name="blogComment"></param>
        /// <returns></returns>
        public static IEnumerable<BlogViewModel> ConvertToBlogCommentViewModelList(
            this IEnumerable<BlogComment> blogComment)
        {
            return Mapper.Map<IEnumerable<BlogComment>, IEnumerable<BlogViewModel>>(blogComment);
        }

    }
}
