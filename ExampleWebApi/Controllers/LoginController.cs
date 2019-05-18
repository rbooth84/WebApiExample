using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharedClientObjects;

namespace ExampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<UserPermissions> Post([FromBody]Login login)
        {
            var permissions = new UserPermissions();

            if (login.Username == "TestUser" && login.Password == "pwdwrdOne")
            {
                permissions.Successful = true;
                permissions.AllowedToDoSomething = true;
                permissions.AllowedToDoSomethingElse = false;
            }

            return new ActionResult<UserPermissions>(permissions);
        }
    }
}
