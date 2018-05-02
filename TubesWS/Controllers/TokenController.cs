﻿using System;
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
    public class TokenController : Controller
    {
        private IConfiguration Configuration;
        public TokenController(IConfiguration config)
        {
            Configuration = config;
        }
        // GET : token/CreateToken
        public IActionResult CreateToken()
        {
            var jwttoken = JwtTokenBuilder();

            IActionResult respon = Ok(new { acces_token = jwttoken });
            
            return respon;
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