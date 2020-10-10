using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet(template:"getall")]
        public IActionResult GetList()
        {
            try
            {
                return Ok( _articleService.GetList());
            }
            catch (Exception)
            {
                return BadRequest("Listelenemedi");
            }
        }

        [HttpGet(template: "getbyarticle")]
        public IActionResult GetListByArticleId(int articleId)
        {
            try
            {
                return Ok(_articleService.GetListByArticleId(articleId));
            }
            catch (Exception)
            {
                return BadRequest("Listelenemedi");
            }
        }

        [HttpGet(template: "getbyid")]
        public IActionResult GetByArticleId(int articleId)
        {
            try
            {
                return Ok(_articleService.GetById(articleId));
            }
            catch (Exception)
            {
                return BadRequest("Nesne getirilemedi");
            }
        }

        [HttpPost(template: "add")]
        public IActionResult Add(Article article)
        {
            try
            {
                return Ok(_articleService.Add(article));
            }
            catch (Exception)
            {
                return BadRequest("Makale eklenemedi");
            }
        }

        [HttpPost(template: "delete")]
        public IActionResult Delete(Article article)
        {
            try
            {
                return Ok(_articleService.Delete(article));
            }
            catch (Exception)
            {
                return BadRequest("Makale silinemedi");
            }
        }

        [HttpPost(template: "update")]
        public IActionResult Update(Article article)
        {
            try
            {
                return Ok(_articleService.Update(article));
            }
            catch (Exception)
            {
                return BadRequest("Makale güncellenemedi");
            }
        }
    }
}