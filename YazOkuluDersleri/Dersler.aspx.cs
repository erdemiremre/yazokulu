using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace YazOkuluDersleri
{
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDers> EntDers = BLLDers.BllListele();
            DropDownList1.DataSource= BLLDers.BllListele();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Seçiniz", "0"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            ent.BASOGRID = int.Parse(TextBox1.Text);
            BLLDers.BllTalepEkle(ent);
        }
    }
}