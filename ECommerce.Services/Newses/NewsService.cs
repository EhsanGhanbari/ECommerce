using System;
using ECommerce.CrossCutting.Logging;
using ECommerce.Infrastructure.Helpers;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Newses;
using ECommerce.Services.Newses.Messaging;

namespace ECommerce.Services.Newses
{
    public class NewsService : INewsService
    {

        #region Constructor

        private readonly INewsRepository _newsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;


        public NewsService(
            INewsRepository newsRepository,
            IUnitOfWork unitOfWork,
            ILogger logger)
        {
            _newsRepository = newsRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        #endregion

        #region News Post

        /// <summary>
        /// Create News by Admin and also Operator
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CreateNewsResponse CreateNews(CreateNewsRequest request)
        {
            var response = new CreateNewsResponse();

            try
            {
                var newsTag = new NewsTag(request.NewsTags);
                var newsCategory = new NewsCategory(request.NewsCategories);

                var news = new News(
                    newsTag.NewsTags,
                    newsCategory.NewsCategories,
                    request.NewsViewModel.Title,
                    request.NewsViewModel.Body,
                    request.NewsViewModel.PostSlug.GenerateSlug());

                _newsRepository.Add(news);
                _unitOfWork.Commit();
                response.Success = true;
                response.MessageType = MessageType.Success;
                response.Message = ServiceMessages.GeneralServiceSuccessMessageOnCreation;
                _logger.Log(string.Format(response.Message));
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnCreation;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);

            }
            return response;
        }


        /// <summary>
        /// Get the News Post by it's Identity 
        /// request by both Admin and any users of the system
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetNewsResponse GetNews(GetNewsRequest request)
        {
            var response = new GetNewsResponse();
            try
            {
                var newsPost = _newsRepository.GetById(request.NewsViewModel.NewsId);
                response.NewsViewModel = newsPost.ConvertToNewsPostViewModel();

                if (newsPost != null)
                {
                    response.NewsViewModel = newsPost.ConvertToNewsPostViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.UnSuccess;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }

        /// <summary>
        /// returns All News Post Created ever
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllNewsResponse GetAllNews(GetAllNewsRequest request)
        {
            var response = new GetAllNewsResponse();
            try
            {
                var newsPosts = _newsRepository.GetAll();

                if (newsPosts != null)
                {
                    response.NewsViewModels = newsPosts.ConvertToNewsPostViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
                else
                {
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Log(exception.Message);
            }
            return response;
        }

        /// <summary>
        /// Update News Post
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateNewsResponse UpdateNews(UpdateNewsRequest request)
        {
            var response = new UpdateNewsResponse();
            try
            {
                var requestedPost = _newsRepository.GetById(request.NewsViewModel.NewsId);
                if (requestedPost != null)
                {
                    var blogPost = request.NewsViewModel.ConvertToNewsPostModel();
                    _newsRepository.SaveOrUpdate(blogPost);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Warning;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnEdition;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// Removes the News Post request by it's Identity 
        /// request makes by admin and operator
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveNewsResponse RemoveNews(RemoveNewsRequest request)
        {
            var response = new RemoveNewsResponse();
            var post = request.NewsViewModel.ConvertToNewsPostModel();
            try
            {
                var requestedPost = _newsRepository.GetById(request.NewsViewModel.NewsId);
                if (requestedPost != null)
                {
                    _newsRepository.Remove(post);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// returns the news post by it's date
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetNewsResponse GetNewsByDate(GetNewsRequest request)
        {

            var response = new GetNewsResponse();
            try
            {
                var newsPosts = _newsRepository.GetNewsByDateQuery(request.Year, request.Month, request.Day, request.NewsSlug);

                if (newsPosts != null)
                {
                    response.NewsViewModel = newsPosts.ConvertToNewsPostViewModel();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
                else
                {
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Log(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// returns news archive
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllNewsResponse GetAllArchivedNewsByDate(GetAllNewsRequest request)
        {
            var response = new GetAllNewsResponse();

            try
            {
                var newsPosts = _newsRepository.GetAllArchivedNewsByDateQuery(request.Year, request.Month);
                if (newsPosts != null)
                {
                    response.NewsViewModels = newsPosts.ConvertToNewsPostViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
                else
                {
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                _logger.Log(string.Format(response.Message));
                _logger.Log(exception.Message);
            }
            return response;
        }

        public GetAllNewsPostsByCategoryResponse GetAllNewsPostByCategory(GetAllNewsPostsByCategoryRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAllNewsPostsByTagResponse GetAllNewsPostsByTag(GetAllNewsPostsByTagRequest request)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region News Tag

        /// <summary>
        /// Get All news tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllNewsTagResponse GetAllNewsTags(GetAllNewsTagRequest request)
        {
            var response = new GetAllNewsTagResponse();
            try
            {
                var newsTags = _newsRepository.GetAllNewsTagsQuery(request.NewsViewModel.NewsTagName);
                if (newsTags != null)
                {
                    response.NewsTagViewModels = newsTags.ConvertToNewsTagViewModelList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(response.Message);
                _logger.Error(exception.Message);
            }
            return response;
        }


        /// <summary>
        /// remove news tag
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveNewsTagResponse RemoveNewsTag(RemoveNewsTagRequest request)
        {
            var response = new RemoveNewsTagResponse();

            try
            {
                var requestedPost = "";
                if (requestedPost != null)
                {

                    // blog.RemoveBlogTag(requestedPost);
                    //_blogRepository.Remove(blog);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }
            return response;

        }

        #endregion

        #region News Category

        /// <summary>
        /// Remove news category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public RemoveNewsCategoryResponse RemoveNewsCategory(RemoveNewsCategoryRequest request)
        {
            var response = new RemoveNewsCategoryResponse();

            try
            {
                var requestedPost = "";
                if (requestedPost != null)
                {

                    // blog.RemoveBlogTag(requestedPost);
                    //_blogRepository.Remove(blog);
                    _unitOfWork.Commit();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnDeletion;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(string.Format(response.Message));
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnDeletion;
                _logger.Log(string.Format(response.Message));
                _logger.Error(exception.Message);
            }

            return response;
        }



        /// <summary>
        /// Get all news category
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public GetAllNewsCategoriesResponse GetAllNewsCategories(GetAllNewsCategoriesRequest request)
        {
            var response = new GetAllNewsCategoriesResponse();
            try
            {
                var newsCategories = _newsRepository.GetAllNewsCategoriesQuery(request.NewsCategoryViewModel.NewsCategoryName);
                if (newsCategories != null)
                {
                    response.NewsCategoryViewModels = newsCategories.ConvertToNewsCategoryViewModelsList();
                    response.Success = true;
                    response.MessageType = MessageType.Success;
                    response.Message = ServiceMessages.GeneralServiceSuccessMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
                else
                {
                    response.Success = false;
                    response.MessageType = MessageType.Info;
                    response.Message = ServiceMessages.GeneralServiceAlarmMessageOnRetrieveInformation;
                    _logger.Log(response.Message);
                }
            }
            catch (Exception exception)
            {
                response.Success = false;
                response.MessageType = MessageType.Error;
                response.Message = ServiceMessages.GeneralServiceErrorMessageOnRetrieveInformation;
                _logger.Log(response.Message);
                _logger.Error(exception.Message);
            }
            return response;
        }

        #endregion
    }
}
