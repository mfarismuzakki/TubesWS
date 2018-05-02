using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        [HttpPost("token")]
        public IActionResult Token()
        {
            var claimdata = new[] { new Claim(ClaimTypes.Name, "username") };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asfsfadawfasdsadsaf"));
            var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var tokenString = new JwtSecurityToken(
                    issuer: "perpustakaanpromvis.com",
                    audience: "perpustakaanpromvis.com",
                    expires:DateTime.Now.AddHours(12),
                    claims:claimdata,
                    signingCredentials:signInCred
                );

            return Ok(tokenString);
        }
    }
}