using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRental.DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private FilmService _service;

        public FilmController()
        {
            _service = new FilmService();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        [Route("Actor")]

        public IActionResult GetByActor(string actor)
        {
            return Ok(_service.GetByActor(actor));
        }

        [HttpGet]
        [Route("Category")]

        public IActionResult GetByCategory(string category)
        {
            return Ok(_service.GetByCategory(category));
        }

        [HttpGet]
        [Route("Title")]

        public IActionResult GetByTitle(string title)
        {
            return Ok(_service.GetByTitle(title));
        }

        [HttpGet]
        [Route("Language")]

        public IActionResult GetByLanguage(string language)
        {
            return Ok(_service.GetByLanguage(language));
        }

        [HttpGet]
        [Route("KeyWord")]

        public IActionResult GetByKeyWord(string KeyWord)
        {
            return Ok(_service.GetByKeyword(KeyWord));
        }

    }
}
