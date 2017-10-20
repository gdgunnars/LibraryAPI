using System.Collections.Generic;
using LibraryAPI.Models.DTOModels;
using LibraryAPI.Repositories;

namespace LibraryAPI.Services
{
    public class ReviewsService : IReviewsService
    {
        public readonly IReviewsRepository _repo;

        public ReviewsService(IReviewsRepository repo) {
            _repo = repo;
        }

        public IEnumerable<BookReviewsDTO> GetAllBookReviews() {
            var bookReviews = _repo.GetAllBookReviews();
            return bookReviews;
        }
    }
}