using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Reservation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /* private void FillPage()
     {
         int[] person = Enumerable.Range(1, 20).ToArray();
         ddlPerson.DataSource = person;
         ddlPerson.AppendDataBoundItems = true;
         ddlPerson.DataBind();
     }*/

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // ReservationModel model = new ReservationModel();
        // Reservation res = createReservation();

        // lblResult.Text = model.InsertReservation(res);

        ReservationModel model = new ReservationModel();
        Reservation res = createReserv();

        lblResult.Text = model.InsertReservation(res);
    }
    private Reservation createReserv()
    {
        Reservation p = new Reservation();
       
        p.datareservation = Calendar1.SelectedDate;
        p.FIO = txtFIO.Text;
        p.person = Convert.ToInt32(ddlPerson.Text);
        p.number= Convert.ToInt32(ddlTable.Text);
        p.comment = txtDescription.Text;
        p.time = txtTime.Text;
        p.telefon = txtTime.Text;
       
        return p;
    }
}