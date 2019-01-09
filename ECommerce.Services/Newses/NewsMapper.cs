using System.Collections.Generic;
using AutoMapper;
using ECommerce.Model.Newses;
using ECommerce.Services.Newses.ViewModels;

namespace ECommerce.Services.Newses
{
    public static class NewsMapper
    {
        /// <summary>
        /// Convert to NewsViewModel
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static NewsViewModel ConvertToNewsPostViewModel(this News post)
        {
            return Mapper.Map<News, NewsViewModel>(post);
        }

        /// <summary>
        /// Convert To NewsModel
        /// </summary>
        /// <param name="postView"></param>
        /// <returns></returns>
        public static News ConvertToNewsPostModel(this NewsViewModel postView)
        {
            return Mapper.Map<NewsViewModel, News>(postView);
        }


        /// <summary>
        /// Convert To 
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static IEnumerable<NewsViewModel> ConvertToNewsPostViewModelList(this IEnumerable<News> post)
        {
            return Mapper.Map<IEnumerable<News>, IEnumerable<NewsViewModel>>(post);
        }


        /// <summary>
        /// Convert news tag view model to news tag
        /// </summary>
        /// <param name="newsTagViewModel"></param>
        /// <returns></returns>
        public static NewsTag ConvertNewsTagViewModelToNewsTag(this NewsTagViewModel newsTagViewModel)
        {
            return Mapper.Map<NewsTagViewModel, NewsTag>(newsTagViewModel);
        }


        /// <summary>
        /// Convert to news tag view model
        /// </summary>
        /// <param name="newsTags"></param>
        /// <returns></returns>
        public static IEnumerable<NewsTagViewModel> ConvertToNewsTagViewModelList(this IEnumerable<NewsTag> newsTags)
        {
            return Mapper.Map<IEnumerable<NewsTag>, IEnumerable<NewsTagViewModel>>(newsTags);
        }


        /// <summary>
        /// convert to news category view model 
        /// </summary>
        /// <param name="newsCategories"></param>
        /// <returns></returns>
        public static IEnumerable<NewsCategoryViewModel> ConvertToNewsCategoryViewModelsList(
            this IEnumerable<NewsCategory> newsCategories)
        {
            return Mapper.Map<IEnumerable<NewsCategory>, IEnumerable<NewsCategoryViewModel>>(newsCategories);
        }




    }
}