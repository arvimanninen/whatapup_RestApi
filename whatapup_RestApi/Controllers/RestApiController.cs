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
        private readonly WhatapupDbContext _db;

        public RestApiController(WhatapupDbContext db)
        {
            _db = db;
        }
        public IActionResult GetAllItems()
        {
            var rawItemDtos = from item in _db.Items
                          select new ItemDTO
                          {
                              CategoryName = item.Category.Name,
                              ItemName = item.Name,
                          };
            var itemDtos = rawItemDtos.ToList();
            if(itemDtos.Count >= 1)
            {
                return Ok(itemDtos);
            }
            return NotFound();
        }
    }
}