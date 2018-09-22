using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using whatapup_RestApi.Models;

namespace whatapup_RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestApiController : ControllerBase
    {
        private readonly WhatapupDbContext _context;

        public RestApiController(WhatapupDbContext context)
        {
            _context = context;
        }
        // public async Task<IActionResult> GetCategory([FromRoute] int id)
        public async Task<IActionResult> GetCategoryData()
        {
            var rawCategor
        }



    }
}