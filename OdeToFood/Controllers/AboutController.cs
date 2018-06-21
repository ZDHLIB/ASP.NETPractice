using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{

    //[Route("controller")]
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("action")]
        public string Phone() {
            return "111122223333";
        }

        //[Route("action")]
        public string Address() {
            return "Address";
        }
    }
}
