﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using whatapup_RestApi.Models;

namespace whatapup_RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestApiController : ControllerBase
    {
        private readonly WhatapupDbContext _db;

        public RestApiController(WhatapupDbContext db)
        {
            _db = db;
        }

        [EnableCors("RestApiPolicy")]
        [HttpGet]
        public ActionResult Get()
        {
            var rawItemDtos = from item in _db.Items
                              orderby item.Category.Name ascending
                          select new ItemDTO
                          {
                              CategoryName = item.Category.Name,
                              ItemName = item.Name,
                          };
            var itemDtos = rawItemDtos.ToList();
            if(itemDtos.Count == 0)
            {
                ItemDTO errorItemDto = new ItemDTO
                {
                    CategoryName = "Error! No categories found!",
                    ItemName = "Error! No items found!"
                };
                itemDtos.Add(errorItemDto);
            }
            return Ok(itemDtos);
        }
    }
}