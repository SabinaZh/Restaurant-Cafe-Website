using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            db.Carts.Add(cart);
            db.SaveChanges();

            return  " добавлено в корзину";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }

    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();

            Cart p = db.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;

            db.SaveChanges();
            return cart.DatePurchased + " was succesfully updated";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public List<Cart> GetOrdersInCart(string userId)
    {
        RestaurantDBEntities1 db = new RestaurantDBEntities1();
        List<Cart> orders = (from x in db.Carts
                             where x.ClientID == userId
                             && x.IsInCart
                             orderby x.DatePurchased
                             select x).ToList();

        return orders;
    }

    public int GetAmountOfOrders( string userId)
    {
        try
        {
            RestaurantDBEntities1 db = new RestaurantDBEntities1();
            int amount = (from x in db.Carts
                          where x.ClientID == userId
                          && x.IsInCart
                          select x.Amount).Sum();

            return amount;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateQuantity (int id, int quantity)
    {
        RestaurantDBEntities1 db = new RestaurantDBEntities1();
        Cart cart = db.Carts.Find(id);
        cart.Amount = quantity;

        db.SaveChanges();
    }

    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        RestaurantDBEntities1 db = new RestaurantDBEntities1();

        if (carts !=null)
        {
            foreach(Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.ID);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }


}