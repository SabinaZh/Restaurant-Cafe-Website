using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userId = User.Identity.GetUserId();
        GetPurchasesInCart(userId);


    }

    private void GetPurchasesInCart(string userId)
    {
        CartModel model = new CartModel();
        double subTotal = 0;

        List<Cart> purchaseList = model.GetOrdersInCart(userId);
        CreateShopTable(purchaseList, out subTotal);

        double totalAmount = subTotal + 0;

        litTotal.Text = subTotal + " ₽";
        litTotalAmount.Text = totalAmount + " ₽";

    }

    private void CreateShopTable(List<Cart> purchaseList, out double subTotal)
    {
        subTotal = new Double();
        ProductModel model = new ProductModel();

        foreach(Cart cart in purchaseList)
        {
            Product product = model.GetProduct(cart.ProductID);

            //create image buttom
            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/Food/{0}", product.Image),
                PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.Id)
            };

            //create delete-link
            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.ID),
                Text = "Удалить элемент",
                ID = "del" + cart.ID
            };

            //add OnClick Event
            lnkDelete.Click += Delete_Item;

            //create 'Quantity' dropdownList
            //generate list with numbers from 1 to 25
            int[] amount = Enumerable.Range(1, 25).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amount,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = cart.ID.ToString()
            };

            ddlAmount.DataBind();
            ddlAmount.SelectedValue = cart.Amount.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

            //create HTML table with 2 rows
            Table table = new Table { CssClass = "cartTable" };
            TableRow a = new TableRow();
            TableRow b = new TableRow();

            //create 6 cells for row a
            TableCell a1 = new TableCell { RowSpan=2, Width=50 };
            TableCell a2 = new TableCell { Text=string.Format("<h4>{0}</h4><br/>{1}<br/>В наличии",
               product.Name, "Product No:"+product.Id),
            HorizontalAlign=HorizontalAlign.Left, Width=350};

           

            TableCell a3 =new TableCell { Text="Цена за ед.<hr/>" };
            TableCell a4 = new TableCell { Text="Количество<hr/>"};
            TableCell a5 = new TableCell { Text = "Сумма<hr/>" };
            TableCell a6 = new TableCell { };

            //create 6 cells for row b
            TableCell b1 = new TableCell { };
            TableCell b2 = new TableCell { Text= product.Price+ " ₽"};
            TableCell b3 = new TableCell { };
            TableCell b4 = new TableCell {  Text= Math.Round((double)(cart.Amount* product.Price), 2)+" ₽"};
            TableCell b5 = new TableCell { };
            TableCell b6 = new TableCell { };

            //set special controls
            a1.Controls.Add(btnImage);
            a6.Controls.Add(lnkDelete);
            b3.Controls.Add(ddlAmount);

            //add cells to rows
            a.Cells.Add(a1);
            a.Cells.Add(a2);
            a.Cells.Add(a3);
            a.Cells.Add(a4);
            a.Cells.Add(a5);
            a.Cells.Add(a6);

            b.Cells.Add(b1);
            b.Cells.Add(b2);
            b.Cells.Add(b3);
            b.Cells.Add(b4);
            b.Cells.Add(b5);
            b.Cells.Add(b6);

            //add rows to table
            table.Rows.Add(a);
            table.Rows.Add(b);

            //add table to pnlShoppingCart
            pnlShoppingCart.Controls.Add(table);

            //add total amount of item in cart to subtotal
            subTotal += (double)(cart.Amount * product.Price);

        }
        //add current user`s shopping cart to user specific session value
        Session[User.Identity.GetUserId()] = purchaseList;
    }

    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList selectedList = (DropDownList)sender;
        int quantity = Convert.ToInt32(selectedList.SelectedValue);
        int cartId = Convert.ToInt32(selectedList.ID);

        CartModel model = new CartModel();
        model.UpdateQuantity(cartId, quantity);

        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

    private void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int cartId = Convert.ToInt32(link);

        CartModel model = new CartModel();
        model.DeleteCart(cartId);


        Response.Redirect("~/Pages/ShoppingCart.aspx");
    }

   

    


   

    private Order CreateOrder()
    {
        Order p = new Order();

        string userId = User.Identity.GetUserId();
        GetPurchasesInCart(userId);

        using (RestaurantDBEntities1 db = new RestaurantDBEntities1())
        {
            int userID = (from y in db.UserInformations
                          where y.GUID == userId
                          select y).ToList()[0].ID;


            p.customerId = userID;
            p.dataorder = Convert.ToDateTime(TextBox1.Text);
            // p.productId =
            //p.amount =
            //p.price =
            p.telefon = txtTelefon.Text;
            p.timeorder = txtTime.Text;
            p.adress = txtAdress.Text;
        }

        return p;
        
    }




    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        OrderModel model = new OrderModel();
        Order order = CreateOrder();

        lblResult.Text = model.InsertOrder(order);
    }
}