using Hopeline.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.Service.Interfaces
{
    public interface ICommonResourceService
    {
        IEnumerable<ResourceModel> getAllResources();
        IEnumerable<TopicModel> getAllTopics();
        IEnumerable<CommunityModel> getAllCommunities();
        IEnumerable<ResourceCategoryModel> getAllResourceCategories();
        ResourceModel getResource(int id);
        TopicModel getTopic(int id);
        CommunityModel GetCommunity(int id);
        ResourceCategoryModel getResourceCategory(int id);
        bool addResource(ResourceModel obj);
        bool addResourceCategory(ResourceCategoryModel obj);
        bool addTopic(TopicModel obj);
        bool addCommunity(CommunityModel obj);
        bool editResource(ResourceModel obj);
        bool editResourceCategory(ResourceCategoryModel obj);
        bool editTopic(TopicModel obj);
        bool editCommunity(CommunityModel obj);
        bool deleteResource(ResourceModel obj);
        bool deleteResourceCategory(ResourceCategoryModel obj);
        bool deleteTopic(TopicModel obj);
        bool deleteCommunity(CommunityModel obj);
        bool saveTopc();
        string saveResourec();
        bool saveResourceCates();
        bool saveCommunity();
    }
}
