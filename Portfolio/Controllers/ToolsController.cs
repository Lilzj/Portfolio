 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    [Route("api/[action]")]
    public class ToolsController : Controller
    {

        private ApplicationDbContext _context;
        private IHttpContextAccessor _accessor;

        public ToolsController(ApplicationDbContext context, IHttpContextAccessor accessor)
        {
            this._context = context;
            this._accessor = accessor;
        }

    }
}
