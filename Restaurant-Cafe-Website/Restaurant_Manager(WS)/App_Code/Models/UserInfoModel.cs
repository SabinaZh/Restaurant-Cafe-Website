using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/// <summary>
/// Сводное описание для UserInfoModel
/// </summary>
namespace Models
{
    public class UserInfoModel
    {
        public UserInformation GetUserInformation(string guId)
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            UserInformation info = (from x in db.UserInformations
                                    where x.GUID==guId
                                    select x).FirstOrDefault();

            return info;
        }

        public void InsertUserInformation(UserInformation info)
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            db.UserInformations.Add(info);
            db.SaveChanges();
        }

    }
}