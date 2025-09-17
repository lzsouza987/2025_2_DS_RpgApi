using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
//using Microsoft.EntityFrameworkCore;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensController : ControllerBase
    {        
        private readonly DataContext _context;

        public PersonagensController(DataContext context)
        {
            _context = context;
        }






    }
}