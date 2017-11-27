using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bullboard.Models
{
    /// <summary>
    /// Ad model
    /// </summary>
    public class Ad
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author identifier.
        /// </summary>
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        public virtual ApplicationUser Author { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the eddition date.
        /// </summary>
        public DateTime EditDate { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the category Id.
        /// </summary>
        public long CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the subcategory Id.
        /// </summary>
        public long SubCategoryId { get; set; }
    }
}