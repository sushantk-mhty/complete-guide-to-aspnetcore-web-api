﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models.ViewModels;
using my_books.Data.Services;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorsService;
        public AuthorsController(AuthorsService authorsService)
        {
            _authorsService=authorsService;
        }
        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }
        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooksById(int id)
        {
            var response = _authorsService.GetAuthorWithBooks(id);
            return Ok(response);
        }
    }
}
