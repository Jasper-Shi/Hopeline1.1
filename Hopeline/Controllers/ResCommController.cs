using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hopeline.Service.Interfaces;
using Hopeline.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hopeline.Controllers
{
    [Route("api/rescomm")]
    [ApiController]
    public class ResCommController : ControllerBase
    {
        private readonly ICommonResourceService _commRes;
        public ResCommController(ICommonResourceService commRes)
        {
            _commRes = commRes;
        }
        [HttpGet("getalltopics")]
        public IActionResult getAllTopics()
        {
            return Ok(_commRes.getAllTopics());
        }

        [HttpGet("getallrescates")]
        public IActionResult getAllResCates()
        {
            return Ok(_commRes.getAllResourceCategories());
        }
        [HttpGet("getallres")]
        public IActionResult getAllRes()
        {
            return Ok(_commRes.getAllResources());
        }
        [HttpGet("getallcomms")]
        public IActionResult getAll()
        {
            return Ok(_commRes.getAllCommunities());
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
    }
}