﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewByReviewer(int reviewerId);
        bool ReviewerExists(int id);
        bool CreateReviewer (Reviewer reviewer);
       
        bool UpdateReviewer(Reviewer reviewer);
        bool DeleteReview(Reviewer reviewer);

        bool Save();
        
    }
}
