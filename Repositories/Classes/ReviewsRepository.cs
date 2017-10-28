using System;
using System.Linq;
using System.Collections.Generic;
using LibraryAPI.Models.DTOModels;
using LibraryAPI.Exceptions;
using LibraryAPI.Models.ViewModels;
using LibraryAPI.Models.EntityModels;

namespace LibraryAPI.Repositories
{
    public class ReviewsRepository : IReviewsRepository
    {
        private readonly AppDataContext _db;

        public ReviewsRepository(AppDataContext db) {
            _db = db;
        }

        public IEnumerable<ReviewDTO> GetAllBookReviews() {
            var reviews = (from r in _db.Reviews
                            join b in _db.Books on r.BookId equals b.Id
                            select new ReviewDTO {
                                UserId = r.UserId,
                                BookTitle = b.Title,
                                BookId = r.BookId,
                                ReviewText = r.ReviewText,
                                Stars = r.Stars
                            }).ToList();

            return reviews;
        }

        public IEnumerable<ReviewDTO> GetAllReviewsForBook(int bookId) {
            // 
            var book = (from b in _db.Books
                        where b.Id == bookId
                        && b.Deleted == false
                        select b).SingleOrDefault();

            if (book == null) {
                throw new NotFoundException("Book with id: " + bookId + " not found.");
            }

            var reviews = (from r in _db.Reviews
                            join b in _db.Books on r.BookId equals b.Id
                            where b.Id == bookId
                            select new ReviewDTO {
                                UserId = r.UserId,
                                BookTitle = b.Title,
                                BookId = r.BookId,
                                ReviewText = r.ReviewText,
                                Stars = r.Stars
                            } ).ToList();
            
            return reviews;
        }

        public ReviewDTO AddReviewToBook(int userId, int bookId, ReviewView review) {
            // Checking if user exists.
            var user = (from u in _db.Users
                        where u.Id == userId && u.Deleted == false
                        select u).SingleOrDefault();
            if(user == null) {
                throw new NotFoundException("User with id: " + userId + " not found.");
            }

            // Check if book exists
            var book = (from b in _db.Books
                        where b.Id == bookId
                        && b.Deleted == false
                        select b).SingleOrDefault();
            if (book == null) {
                throw new NotFoundException("Book with id: " + bookId + " not found.");
            }

            _db.Reviews.Add(new Review {
                            UserId = userId,
                            BookId = bookId,
                            ReviewText = review.ReviewText,
                            Stars = review.Stars.Value
                            });
            try {
                _db.SaveChanges();
                return new ReviewDTO {
                    UserId = userId,
                    BookTitle = book.Title,
                    BookId = bookId,
                    ReviewText = review.ReviewText,
                    Stars = review.Stars.Value
                };
            } catch(System.Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}