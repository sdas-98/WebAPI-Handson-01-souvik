﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesWebAPI.Controllers
{
    public class MoviesController : ApiController
    {
       public List<string>GetMovies()
        {
            return new List<string> { "Titanic", "Misson Impossible", "Matrix" };
        }
        
        //public string Get()
        //{
        //    return "Hello From Web Api";
        //}
    }
}
