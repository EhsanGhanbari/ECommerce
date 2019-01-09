using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Management
{
    /// <summary>
    /// Report class is for Reported account by other users
    /// Reported 
    /// </summary>
    public class Report : EntityBase<Guid>, IAggregateRoot
    {

        /// <summary>
        /// who has been reported?
        /// Email Address of the reported Member
        /// </summary>
        public virtual string ReportedAccount { get; set; }

        /// <summary>
        /// Who is reporting?
        ///  Email Address of the reporter Member
        /// </summary>
        public virtual string ReporterAccount { get; set; }


        /// <summary>
        /// every report contains a description
        /// </summary>
        public virtual string Description { get; set; }


        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
