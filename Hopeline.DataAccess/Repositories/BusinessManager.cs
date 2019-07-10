using Hopeline.DataAccess.DatabaseContext;
using Hopeline.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Hopeline.DataAccess.Repositories
{
    public class BusinessManager : IBusinessManager
    {
        private readonly AppDbContext _dbContext;

        public BusinessManager(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void setResourceCategoryEnableFlg(int id, int flg)
        {
            SqlParameter id_ = new SqlParameter("@id", id);
            SqlParameter flg_ = new SqlParameter("@flg", flg);
            //SqlParameter plist[] = new SqlParameter { id_, flg_ };
            _dbContext.Database.ExecuteSqlCommand("SetResourceCategoryEnableFlg @id, @flg", id_, flg_);
        }

        public void setResourceActive(int id, int flg)
        {
            SqlParameter id_ = new SqlParameter("@id", id);
            SqlParameter flg_ = new SqlParameter("@flg", flg);
            _dbContext.Database.ExecuteSqlCommand("setResourceActive @id, @flg", id_, flg_);
        }
    }
}
