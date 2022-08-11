using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yiershanren.WebApi.Util
{
    public interface IUserInfoRepository
    {
        /// <summary>
        /// 根据用户id获取用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        UserInfo GetUserInfoById(int id);
    }
}
