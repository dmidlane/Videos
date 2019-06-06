using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using Videos.Dtos;
using Videos.Models;
using System.Data.Entity;

namespace Videos.Controllers.Api
{

    
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpPost]
        public IHttpActionResult CreateNewRental(RentalsDto newRental)
        {
            if (newRental.MovieIds.Count() == 0)
                return BadRequest("No movieIds were provided.");

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid.");

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count() != newRental.MovieIds.Count())
                return BadRequest("One or more movieIds were invalid.");

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    RentalDate = DateTime.Now

                };

                _context.Rentals.Add(rental);


            }

            _context.SaveChanges();

            return Ok();
            
        }
    }
}
