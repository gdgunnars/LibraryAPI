using System.Collections.Generic;
using LibraryAPI.Models.DTOModels;

namespace LibraryAPI.Services
{
    public interface IReviewsService
    {
        IEnumerable<BookReviewsDTO> GetAllBookReviews();
    }
}