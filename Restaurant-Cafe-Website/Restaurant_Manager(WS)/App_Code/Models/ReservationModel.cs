using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для ReservationModel
/// </summary>
public class ReservationModel
{
    public string InsertReservation(Reservation reserv)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            db.Reservations.Add(reserv);
            db.SaveChanges();

            return " Столик успешно забронирован";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }

    }
}