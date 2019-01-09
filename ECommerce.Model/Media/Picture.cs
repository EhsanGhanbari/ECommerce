using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Products;

namespace ECommerce.Model.Media
{
    /// <summary>
    /// Represents a picture of the system
    /// </summary>
    public class Picture : EntityBase<Guid>
    {

        /// <summary>
        /// Picture name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the picture binary
        /// </summary>
        public byte[] PictureBinary { get; set; }

        /// <summary>
        /// Gets or sets the picture mime type
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the SEO friednly filename of the picture
        /// </summary>
        public string SeoFilename { get; set; }




        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}