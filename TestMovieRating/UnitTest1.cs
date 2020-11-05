using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieRating.Repository;
using System;
using System.Collections.Generic;

namespace TestMovieRating
{
    [TestClass]
    public class UnitTest1 
    {
        [TestMethod]
        public void TestGetNumberOfReviewsFromReviewer()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualResult = _rtngRepo.GetNumberOfReviewsFromReviewer(1);
            Assert.AreEqual(234,actualResult);
        }

        [TestMethod]
        public void TestGetAverageRateFromReviewer()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualResult = _rtngRepo.GetAverageRateFromReviewer(1);
            Assert.AreEqual(5.5, actualResult);
        }

        [TestMethod]
        public void TestGetNumberOfRatesByReviewer()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualresult = _rtngRepo.GetNumberOfRatesByReviewer(2,7);
            Assert.AreEqual(1, actualresult);
        }

        [TestMethod]
        public void TestGetNumberOfReviews()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualresult = _rtngRepo.GetNumberOfReviews(1997);
            Assert.AreEqual(1, actualresult);
        }

        [TestMethod]
        public void TestGetAverageRateOfMovie()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualresult = _rtngRepo.GetAverageRateOfMovie(1998);
            Assert.AreEqual(9, actualresult);
        }

        [TestMethod]
        public void TestGetNumberOfRates()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            double actualresult = _rtngRepo.GetNumberOfRates(1994, 7);
            Assert.AreEqual(1, actualresult);
        }

        [TestMethod]
        public void TestGetMoviesWithHighestNumberOfTopRates()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            List<int> actualresult = _rtngRepo.GetMoviesWithHighestNumberOfTopRates();
            List<int> expectedresult = new List<int>();
            expectedresult.Add(1997);
            expectedresult.Add(1994);
            expectedresult.Add(1998);
            CollectionAssert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void TestGetMostProductiveReviewers()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            List<int> actualresult = _rtngRepo.GetMostProductiveReviewers();
            List<int> expectedresult = new List<int>();
            expectedresult.Add(1);
            expectedresult.Add(2);
            CollectionAssert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void TestGetTopRatedMovies()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            List<int> actualresult = _rtngRepo.GetTopRatedMovies(2);
            List<int> expectedresult = new List<int>();
            expectedresult.Add(1998);
            expectedresult.Add(1994);
            expectedresult.Add(1997);
            CollectionAssert.AreEqual(expectedresult, actualresult);
        }
            [TestMethod]
        public void TestGetTopMoviesByReviewer()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            List<int> actualresult = _rtngRepo.GetTopMoviesByReviewer(1);
            List<int> expectedresult = new List<int>();
            expectedresult.Add(1998);
            expectedresult.Add(1997);
            CollectionAssert.AreEqual(expectedresult, actualresult);

        }
        [TestMethod]
        public void TestGetReviewersByMovie()
        {
            IRatingRepository _rtngRepo = new RatingRepository(true);
            List<int> actualresult= _rtngRepo.GetReviewersByMovie(1994);
            List<int> reviewersList = new List<int>();
            reviewersList.Add(2);
            CollectionAssert.AreEqual(reviewersList, actualresult);
        }
    }
}
