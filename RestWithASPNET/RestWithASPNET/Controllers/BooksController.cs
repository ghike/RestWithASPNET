using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNET.Model;

namespace RestWithASPNET.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {

        //private IPersonBusiness _personBusiness;
        //public PersonsController(IPersonBusiness personBusiness)
        //{
        //    _personBusiness = personBusiness;
        //}

        //// GET api/values
        [HttpGet("v1")]
        public IActionResult Get()
        {
            //return Ok(_bookBusiness.FindAll());
            return Ok();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //var person = _bookBusiness.FindById(id);
            //if (person == null)
            //    return NotFound();
            //return Ok(book);
            return Ok();
        }

        // POST api/values
        [HttpPost("v1")]
        public IActionResult Post([FromBody]Book book)
        {
            //if (book == null)
            //    return BadRequest();
            //return new ObjectResult(_bookBusiness.Create(person));
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("v1")]
        public IActionResult Put(int id, [FromBody]Book book)
        {
            //if (person == null)
            //    return BadRequest();
            //var updatedPerson = _personBusiness.Update(person);
            //if (updatedPerson == null)
            //    NoContent();
            //return new ObjectResult(updatedBook);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //_bookBusiness.Delete(id);
            //return NoContent();
            return Ok();
        }
    }
}
