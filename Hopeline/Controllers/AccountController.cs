using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hopeline.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hopeline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(UserManager<HopelineUser> userManager, SignInManager<HopelineUser> signInManager)
        {

        }
    }
}