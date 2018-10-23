using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class Pages_Product : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RestaurantDB;Data Source=LOCALHOST\\SQLEXPRESS");
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string clientId = Context.User.Identity.GetUserId();

            if (clientId != null)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                int amount = Convert.ToInt32(ddlAmount.SelectedValue);

                Cart cart = new Cart
                {
                    Amount = amount,
                    ClientID = clientId,
                    DatePurchased = DateTime.Now,
                    IsInCart = true,
                    ProductID = id
                };

                CartModel model = new CartModel();
                lblResult.Text = model.InsertCart(cart);
            }
            else
            {
                lblResult.Text = "Пожалуйста, войдите в систему";
            }
        }
    }

    private void FillPage()
{
    if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
    {
        int id = Convert.ToInt32(Request.QueryString["id"]);
        ProductModel productModel = new ProductModel();
        Product product = productModel.GetProduct(id);

        lblPrice.Text = "Price per unit: <br/>" + product.Price + " ₽";
        lblTitle.Text = product.Name;
        lblDescription.Text = product.Description;
        lblItemNr.Text = id.ToString();
        imgProduct.ImageUrl = "~/Images/Food/" + product.Image;

        int[] amount = Enumerable.Range(1, 20).ToArray();
        ddlAmount.DataSource = amount;
        ddlAmount.AppendDataBoundItems = true;
        ddlAmount.DataBind();
    }
}

  

}