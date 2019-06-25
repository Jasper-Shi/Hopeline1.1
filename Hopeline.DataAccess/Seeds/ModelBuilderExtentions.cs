using Hopeline.DataAccess.DatabaseContext;
using Hopeline.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.DataAccess.Seeds
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(
                new Resource
                {
                    Id = 1,
                    user_code = "res001",
                    enabled_flg = 1,
                    url = "www.google.ca",
                    title = "Some resources",
                    desc = "Descrpition for the resource",
                    resource_categoryId = 1
                },
                new Resource
                {
                    Id = 2,
                    user_code = "res002",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Some title for res2",
                    desc = "Description for the res2",
                    resource_categoryId = 2
                },
                new Resource
                {
                    Id = 3,
                    user_code = "res003",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Some title for res3",
                    desc = "Description for the res3",
                    resource_categoryId = 3
                }
           );
            modelBuilder.Entity<Resource_Category>().HasData(
                new Resource_Category
                {
                    Id = 1,
                    user_code = "depre001",
                    category_name = "depression",
                    category_decription = "depression description"
                },
                new Resource_Category
                {
                    Id = 2,
                    user_code = "bully001",
                    category_name = "bullying",
                    category_decription = "bullying description"
                },
                new Resource_Category
                {
                    Id = 3,
                    user_code = "school001",
                    category_name = "school-related",
                    category_decription = "school-related description"
                }
            );
            modelBuilder.Entity<Community>().HasData(
                new Community
                {
                    Id = 1,
                    user_code = "comm001",
                    enabled_flg = 1,
                    url = "www.google.ca",
                    title = "Community 1",
                    desc = "Descrption for community 1"
                },
                new Community
                {
                    Id = 2,
                    user_code = "comm002",
                    enabled_flg = 0,
                    url = "www.google.ca",
                    title = "Community 2",
                    desc = "Descrption for community 2"
                }
            );
            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    Id = 1,
                    user_code = "Drep001",
                    enabled_flg = 1,
                    topic_name = "Depression",
                    desc = "Despression is a mental disease"
                },
                new Topic
                {
                    Id = 2,
                    user_code = "Bullying001",
                    enabled_flg = 1,
                    topic_name = "Bullying",
                    desc = "Bullying is bad"
                }
            );
        }
    }
}
