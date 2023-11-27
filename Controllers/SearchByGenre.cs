using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EnterpriseSystem_Project.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class SearchByGenre : ControllerBase
    {
        
        //GET /api/SearchByGenre
        [HttpGet()]
        public IActionResult SearchGenre(string GenreName){
            if(GenreName == ""){
                throw new Exception("Must give genre name");
            }else{
                
            }
            return Ok();
        }
    }
}