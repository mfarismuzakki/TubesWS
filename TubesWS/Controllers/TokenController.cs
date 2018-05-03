using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace TubesWS.Controllers
{
    [Produces("application/json")]
 
    public class TokenController : Controller
    {
        private IConfiguration Configuration;   
        public TokenController(IConfiguration config)
        {
            Configuration = config;
        }

        // POST : token/CreateToken/
        [HttpPost]
        public IActionResult CreateToken([FromBody]Object.User pengguna)
        {
            try
            {
                Repository.RepositoryUser user = new Repository.RepositoryUser();
                Object.User temp = user.GetByNamaUser(pengguna.Username);

                if (temp.Username == pengguna.Username && temp.Password == pengguna.Password)
                {
                    var jwttoken = JwtTokenBuilder();

                    IActionResult respon = Ok(new { acces_token = jwttoken });

                    return respon;
                }
                return BadRequest("Username atau Password Salah");
            }
            catch (Exception)
            {
                return BadRequest("Username atau Password Salah");
            }
        }

        private string JwtTokenBuilder()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("somesupersecretkey"));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                issuer: "http://localhost:50062/",
                audience: "http://localhost:50062/",
                signingCredentials:credentials,
                expires:DateTime.Now.AddHours(12)
                );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}