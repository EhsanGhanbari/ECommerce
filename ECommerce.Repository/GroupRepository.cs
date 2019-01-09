using System;
using System.Collections.Generic;
using ECommerce.Infrastructure.UnitOfWork;
using ECommerce.Model.Groups;
using ECommerce.Model.Products;

namespace ECommerce.Repository
{
    public class GroupRepository : Repository<Group, Guid>, IGroupRepository
    {
        public GroupRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }


        /// <summary>
        /// Returns all Groups by a brand name 
        /// </summary>
        /// <param name="productBrand"></param>
        /// <returns></returns>
        public IEnumerable<Group> GetAllGroupsByProductBrandQuery(ProductBrand productBrand)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Returns all Groups by categoryId
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public IEnumerable<Group> GetAllGroupsByProductCategoryQuery(Guid categoryId)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// returns all members of a group
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public IEnumerable<Group> GetAllMembersOfGroupQuery(Guid groupId)
        {
            throw new NotImplementedException();
        }
    }
}
