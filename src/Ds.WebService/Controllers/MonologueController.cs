using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Ds.Model;

namespace Ds.WebService.Controllers
{
    public class MonologueController : ApiController
    {
        //
        // GET: /Monologue/

        public Monologue Get()
        {
            return new Monologue() {Body = "test", Id = 1};
        }

    }
}
