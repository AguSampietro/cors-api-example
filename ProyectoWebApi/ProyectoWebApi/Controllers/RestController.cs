﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoWebApi.Controllers
{
    public class RestController : ApiController
    {
        // GET: api/Rest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Rest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rest
        public string Post([FromBody]Models.Pelicula peli)
        {
            return peli.Titulo + " fue agregado";
        }

        // PUT: api/Rest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rest/5
        public void Delete(int id)
        {
        }
    }
}
