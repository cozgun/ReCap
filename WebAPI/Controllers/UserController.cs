﻿using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserbyid")]
        public IActionResult GetById(int userId)
        {
            var result = _userService.GetById(userId);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getuserbyemail")]
        public IActionResult GetDetailsByEmail(string email)
        {
            var result = _userService.GetDetailsByEmail(email);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getclaims")]
        public IActionResult GetClaims(int userId)
        {
            var result = _userService.GetClaimsNew(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("isadmin")]
        //public IActionResult IsAdmin(int userId)
        //{
        //    var result = _userService.IsAdmin(userId);
        //    if (result = true)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);

        //}


        [HttpGet("GetAllClaims")]
        public IActionResult GetAllClaims()
        {
            var result = _userService.GetAllClaims();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        //[HttpGet("claims")]
        //public IActionResult GetClaims(int id)
        //{
        //    var result = _userService.GetClaims(new User { Id = id });
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

    }
}