using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hopeline.Service.Interfaces;
using Hopeline.Service.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hopeline.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/adminrescomm")]
    [ApiController]
    public class AdminResCommController : ControllerBase
    {
        private readonly ICommonResourceService _commRes;
        public AdminResCommController(ICommonResourceService commRes)
        {
            _commRes = commRes;
        }
        [HttpPost("addtopic")]
        public IActionResult addTopic(TopicModel obj)
        {
            try
            {
                _commRes.addTopic(obj);
                _commRes.saveTopc();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("addrescates")]
        public IActionResult addResCates(ResourceCategoryModel obj)
        {
            try
            {
                _commRes.addResourceCategory(obj);
                _commRes.saveResourceCates();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("addres")]
        public IActionResult addRes(ResourceModel obj)
        {
            try
            {
                _commRes.addResource(obj);
                _commRes.saveResourec();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("addcomms")]
        public IActionResult addComms(CommunityModel obj)
        {
            try
            {
                _commRes.addCommunity(obj);
                _commRes.saveCommunity();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("editrescates")]
        public IActionResult editResCates(ResourceCategoryModel obj)
        {
            try
            {
                _commRes.editResourceCategory(obj);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("deleterescates")]
        public IActionResult deleteResCates(ResourceCategoryModel obj)
        {
            try
            {
                _commRes.deleteResourceCategory(obj);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost("deleteres")]
        public IActionResult deleteRes(ResourceModel obj)
        {
            try
            {
                _commRes.deleteResource(obj);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("setrescateenable")]
        public IActionResult setResCateFlg(ResourceCategoryModel obj)
        {
            try
            {
                _commRes.setResourceCategoryEnableFlg(obj.Id, obj.enable_flg);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPut("setresenable")]
        public IActionResult setResourceActive(ResourceModel obj)
        {
            try
            {
                _commRes.setResourceActive(obj.Id, obj.enabled_flg);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}