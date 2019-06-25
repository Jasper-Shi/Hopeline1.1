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
    [Route("api/populate")]
    [ApiController]
    public class PopulateController : ControllerBase
    {
        private readonly ICommonResourceService _commconService;
        public PopulateController(ICommonResourceService commonService)
        {
            _commconService = commonService;
        }
        [HttpPost("addtopics")]
        public IActionResult addTopics()
        {
            int i = 0;
            var topics = new List<TopicModel>
            {
                new TopicModel
                {
                    
                    user_code = "Drep001",
                    enabled_flg = 1,
                    topic_name = "Depression",
                    desc = "Despression is a mental disease"
                },
                new TopicModel
                {
                    
                    user_code = "Bullying001",
                    enabled_flg = 1,
                    topic_name = "Bullying",
                    desc = "Bullying is bad"
                }
            };
            foreach(var item in topics)
            {
                _commconService.addTopic(item);
                i++;
            }
            var tmp = _commconService.saveTopc();
            return Ok(tmp);
        }

        [HttpPost("addrescates")]
        public IActionResult addResCates()
        {
            var resCates = new List<ResourceCategoryModel>
            {
                new ResourceCategoryModel
                {
                    
                    user_code = "depre001",
                    category_name = "depression",
                    category_decription = "depression description"
                },
                new ResourceCategoryModel
                {
                    
                    user_code = "bully001",
                    category_name = "bullying",
                    category_decription = "bullying description"
                },
                new ResourceCategoryModel
                {
                    
                    user_code = "school001",
                    category_name = "school-related",
                    category_decription = "school-related description"
                }

            };
            foreach(var item in resCates)
            {
                _commconService.addResourceCategory(item);
            }
            var tmp = _commconService.saveResourceCates();
            return Ok(tmp);
        }

        [HttpPost("addres")]
        public IActionResult addResources()
        {
            var counter = 0;
            var resources = new List<ResourceModel>
            {
                new ResourceModel
                {

                    user_code = "res001",
                    enabled_flg = 1,
                    url = "www.google.ca",
                    title = "Some resources",
                    desc = "Descrpition for the resource",
                    resourceCategoryId = 1
                },
                new ResourceModel
                {

                    user_code = "res002",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Some title for res2",
                    desc = "Description for the res2",
                    resourceCategoryId = 2
                },
                new ResourceModel
                {

                    user_code = "res003",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Some title for res3",
                    desc = "Description for the res3",
                    resourceCategoryId = 3
                }
            };
            foreach(var item in resources)
            {
                _commconService.addResource(item);
                counter++;
            }
            var tmp = _commconService.saveResourec();
            return Ok(tmp);
        }
        [HttpPost("addcomms")]
        public IActionResult addComms()
        {
            var comms = new List<CommunityModel>
            {
                new CommunityModel
                {

                    user_code = "comm001",
                    enabled_flg = 1,
                    url = "www.google.ca",
                    title = "Community 1",
                    desc = "Descrption for community 1"
                },
                new CommunityModel
                {

                    user_code = "comm002",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Community 2",
                    desc = "Descrption for community 2"
                }
            };
            foreach(var item in comms)
            {
                _commconService.addCommunity(item);
            }
            var tmp = _commconService.saveCommunity();
            return Ok(tmp);
        }
    }
}