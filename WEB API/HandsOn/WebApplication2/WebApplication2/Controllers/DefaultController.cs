﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet,Route("GetAll")]
        public IHttpActionResult Get()
        {
            return Ok("Hello");
        }
    }
}