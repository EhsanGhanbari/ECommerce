using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Media
{

    /// <summary>
    /// Represents a download
    /// </summary>
    public class Download : EntityBase<Guid>
    {

        /// <summary>
        /// Gets a sets a value indicating whether DownloadUrl property should be used
        /// </summary>
        public virtual bool UseDownloadUrl { get; set; }

        /// <summary>
        /// Gets a sets a download URL
        /// </summary>
        public virtual string DownloadUrl { get; set; }

        /// <summary>
        /// Gets or sets the download binary
        /// </summary>
        public virtual byte[] DownloadBinary { get; set; }

        /// <summary>
        /// The mime-type of the download
        /// </summary>
        public virtual string ContentType { get; set; }

        /// <summary>
        /// The filename of the download
        /// </summary>
        public virtual string Filename { get; set; }

        /// <summary>
        /// Gets or sets the extension
        /// </summary>
        public virtual string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the download is new
        /// </summary>
        public virtual bool IsNew { get; set; }




        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

}
