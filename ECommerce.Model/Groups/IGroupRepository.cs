using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Groups
{
    public interface IGroupRepository : IRepository<Group, Guid>
    {

        /// <summary>
        /// returns all group of a product brand 
        /// </summary>
        /// <param name="productBrand"></param>
        /// <returns></returns>
        IEnumerable<Group> GetAllGroupsByProductBrandQuery(ProductBrand productBrand);


        /// <summary>
        /// Returns all Groups by CategoryId 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        IEnumerable<Group> GetAllGroupsByProductCategoryQuery(Guid categoryId);


        /// <summary>
        /// Returns all members of a group
        /// </summary>
        /// <returns></returns>
        IEnumerable<Group> GetAllMembersOfGroupQuery(Guid groupId);
    }
}
