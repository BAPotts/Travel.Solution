using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelContext _db;

    public ReviewsController(TravelContext db)
    {
      _db = db;
    }

[HttpGet]
public IActionResult GetPages([FromQuery] Test test )
{
  var tests = __db.Reviews.AsQueryable();

  return tests.ToList();
}




    //get api/reviews
    public ActionResult<IEnumerable<Review>> Get([FromQuery] UrlQuery urlQuery, string destination, string country, int? rating)
    {
      var query = _db.Reviews.AsQueryable();

      if( destination != null )
      {
        query = query.Where(entry => entry.Destination == destination);
      }
      if( country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if(rating != null)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if(urlQuery.PageNumber.HasValue)
      {
        // query += @" Order BY Contact.ContackPK
        //     OFFSET @PageSize *(@PageNumber -1) ROWS
        //     FETCH NEXT @PageSize ROWS ONLY";

      }
      return query.ToList();
    }
    
    //POST api/reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }

    //Get api/reviews/id#
    [HttpGet("{id}")]
    public ActionResult<Review> GetAction(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }
    

    //PUT api/reviews/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //DELETE api/reviews/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }

  }
}