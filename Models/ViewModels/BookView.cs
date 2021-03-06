using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models.ViewModels {
    /// <summary>
    /// A view model of a book.
    /// This is the model that is used when a user is creating a new book.
    /// </summary>
    public class BookView {
        /// <summary>
        /// The title of the book.
        /// </summary>
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// The Author of the book.
        /// </summary>
        [Required]
        public string Author { get; set; }
        /// <summary>
        /// The date of release.
        /// </summary>
        [Required]
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// The ISBN number of the book.
        /// </summary>
        [Required]
        public string ISBN { get; set; }
    }
}