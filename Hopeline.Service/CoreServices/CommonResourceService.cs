using Hopeline.DataAccess.Entities;
using Hopeline.DataAccess.Interfaces;
using Hopeline.Service.Interfaces;
using Hopeline.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hopeline.Service.CoreServices
{
    public class CommonResourceService : ICommonResourceService
    {
        private readonly IRepository<Resource> _resourceRepo;
        private readonly IRepository<Community> _communityRepo;
        private readonly IRepository<Topic> _topicRepo;
        private readonly IRepository<Resource_Category> _resourceCategoryRepo;
        public CommonResourceService(IRepository<Resource> resourceRepo, IRepository<Community> communityRepo, IRepository<Topic> topicRepo, IRepository<Resource_Category> resourceCategoryRepo)
        {
            _resourceRepo = resourceRepo;
            _communityRepo = communityRepo;
            _topicRepo = topicRepo;
            _resourceCategoryRepo = resourceCategoryRepo;

        }
        public bool addCommunity(CommunityModel obj)
        {
            try
            {
                var o = new Community
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    image = obj.image,
                    title = obj.title,
                    desc = obj.desc,
                    url = obj.url,
                    enabled_flg = obj.enabled_flg
                };
                _communityRepo.insert(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool addResource(ResourceModel obj)
        {
            try
            {
                var o = new Resource
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    image = obj.image,
                    title = obj.title,
                    desc = obj.desc,
                    url = obj.url,
                    enabled_flg = obj.enabled_flg,
                    resource_categoryId = obj.resourceCategoryId
                };
                _resourceRepo.insert(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool addResourceCategory(ResourceCategoryModel obj)
        {
            try
            {
                var o = new Resource_Category
                {
                    user_code = obj.user_code,
                    category_name = obj.category_name,
                    category_decription = obj.category_decription
                };
                _resourceCategoryRepo.insert(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool addTopic(TopicModel obj)
        {
            try
            {
                var o = new Topic
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    enabled_flg = obj.enabled_flg,
                    topic_name = obj.topic_name,
                    desc = obj.desc
                };
                _topicRepo.insert(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool deleteCommunity(CommunityModel obj)
        {
            try
            {
                var o = new Community
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    image = obj.image,
                    title = obj.title,
                    desc = obj.desc,
                    url = obj.url,
                    enabled_flg = obj.enabled_flg
                };
                _communityRepo.delete(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool deleteResource(ResourceModel obj)
        {
            try
            {
                var o = new Resource
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    image = obj.image,
                    title = obj.title,
                    desc = obj.desc,
                    url = obj.url,
                    enabled_flg = obj.enabled_flg,
                    resource_categoryId = obj.resourceCategoryId
                };
                _resourceRepo.delete(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool deleteResourceCategory(ResourceCategoryModel obj)
        {
            try
            {
                var o = new Resource_Category
                {
                    user_code = obj.user_code,
                    category_name = obj.category_name,
                    category_decription = obj.category_decription
                };
                _resourceCategoryRepo.delete(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool deleteTopic(TopicModel obj)
        {
            try
            {
                var o = new Topic
                {
                    Id = obj.Id, // modify this later to adding new id in sql server
                    user_code = obj.user_code,
                    enabled_flg = obj.enabled_flg,
                    topic_name = obj.topic_name,
                    desc = obj.desc
                };
                _topicRepo.delete(o);
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool editCommunity(CommunityModel obj)
        {
            try
            {
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool editResource(ResourceModel obj)
        {
            try
            {
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public bool editResourceCategory(ResourceCategoryModel obj)
        {
            throw new NotImplementedException();
        }

        public bool editTopic(TopicModel obj)
        {
            try
            {
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public IEnumerable<CommunityModel> getAllCommunities()
        {
            try
            {
                return _communityRepo.GetAll().Select(c => new CommunityModel
                {
                    Id = c.Id,
                    user_code = c.user_code,
                    image = c.image,
                    enabled_flg = c.enabled_flg,
                    title = c.title,
                    desc = c.desc,
                    url = c.url
                });
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public IEnumerable<ResourceCategoryModel> getAllResourceCategories()
        {
            try
            {
                return _resourceCategoryRepo.GetAll().Select(c => new ResourceCategoryModel
                {
                    Id = c.Id,
                    dateAdded = c.dateAdded,
                    user_code = c.user_code,
                    category_name = c.category_name,
                    category_decription = c.category_decription
                });
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<ResourceModel> getAllResources()
        {
            try
            {
                return _resourceRepo.GetAll().Select(c => new ResourceModel
                {
                    Id = c.Id,
                    user_code = c.user_code,
                    image = c.image,
                    enabled_flg = c.enabled_flg,
                    title = c.title,
                    desc = c.desc,
                    url = c.url
                });
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public IEnumerable<TopicModel> getAllTopics()
        {
            try
            {
                return _topicRepo.GetAll().Select(c => new TopicModel
                {
                    Id = c.Id,
                    user_code = c.user_code,
                    enabled_flg = c.enabled_flg,
                    topic_name = c.topic_name,
                    desc = c.desc
                });
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public CommunityModel GetCommunity(int id)
        {
            try
            {
                var o = _communityRepo.GetById(id);
                var res = new CommunityModel
                {
                    Id = o.Id,
                    dateAdded = o.dateAdded,
                    title = o.title,
                    image = o.image,
                    desc = o.desc,
                    enabled_flg = o.enabled_flg,
                    url = o.url,
                    user_code = o.user_code
                };
                return res;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public ResourceModel getResource(int id)
        {
            try
            {
                var o = _resourceRepo.GetById(id);
                var res = new ResourceModel
                {
                    Id = o.Id,
                    dateAdded = o.dateAdded,
                    title = o.title,
                    image = o.image,
                    desc = o.desc,
                    enabled_flg = o.enabled_flg,
                    url = o.url,
                    user_code = o.user_code,
                    resourceCategoryId=o.resource_categoryId
                };
                return res;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public ResourceCategoryModel getResourceCategory(int id)
        {
            try
            {
                var o = _resourceCategoryRepo.GetById(id);
                var res = new ResourceCategoryModel
                {
                    Id = o.Id,
                    dateAdded = o.dateAdded,
                    user_code = o.user_code,
                    category_name = o.category_name,
                    category_decription = o.category_decription
                };
                return res;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public TopicModel getTopic(int id)
        {
            try
            {
                var o = _topicRepo.GetById(id);
                var res = new TopicModel
                {
                    Id = o.Id,
                    dateAdded = o.dateAdded,
                    user_code = o.user_code,
                    topic_name = o.topic_name,
                    desc = o.desc,
                    enabled_flg = o.enabled_flg
                };
                return res;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public bool saveCommunity()
        {
            try
            {
                _communityRepo.save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool saveResourceCates()
        {
            try
            {
                _resourceCategoryRepo.save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string saveResourec()
        {
            string tmp = "";
            try
            {
                
                tmp = _resourceRepo.save();
                return tmp;
            }
            catch
            {
                return tmp;
            }
        }

        public bool saveTopc()
        {
            
            try
            {
                _topicRepo.save();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
