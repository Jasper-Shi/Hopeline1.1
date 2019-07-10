using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.DataAccess.Interfaces
{
    public interface IBusinessManager
    {
        void setResourceCategoryEnableFlg(int id, int flg);
        void setResourceActive(int id, int flg);
    }
}
