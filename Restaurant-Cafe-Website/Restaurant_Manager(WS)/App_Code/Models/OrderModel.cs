using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для OrderModel
/// </summary>
public class OrderModel
{
    public string InsertOrder(Order order)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            db.Orders.Add(order);
            db.SaveChanges();

            return " все окей";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }

    }
}