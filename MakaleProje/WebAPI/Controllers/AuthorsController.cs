using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet(template: "getall")]
        public IActionResult GetList()
        {
           
            try
            {
                return Ok(_authorService.GetList());
            }
            catch (Exception)
            {
                return BadRequest("Listelenemedi");
            }
        }

        [HttpGet(template: "getbyauthor")]
        public IActionResult GetListByArticleId(int authorId)
        {
            try
            {
                return Ok(_authorService.GetListByAuthorId(authorId));
            }
            catch (Exception)
            {
                return BadRequest("Listelenemedi");
            }
        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetByAuthorId(int authorId)
        {
            try
            {
                return Ok(_authorService.GetById(authorId));
            }
            catch (Exception)
            {
                return BadRequest("Nesne getirilemedi");
            }
        }


        [HttpPost(template: "add")]
        public IActionResult Add(Author author)
        {
            try
            {
                return Ok(_authorService.Add(author));
            }
            catch (Exception)
            {
                return BadRequest("Yazar eklenemedi");
            }
        }

        [HttpPost(template: "delete")]
        public IActionResult Delete(Author author)
        {
            try
            {
                return Ok(_authorService.Delete(author));
            }
            catch (Exception)
            {
                return BadRequest("Yazar silinemedi");
            }
        }

        [HttpPost(template: "update")]
        public IActionResult Update(Author author)
        {
            try
            {
                return Ok(_authorService.Update(author));
            }
            catch (Exception)
            {
                return BadRequest("Yazar güncellenemedi");
            }
        }
    }
}