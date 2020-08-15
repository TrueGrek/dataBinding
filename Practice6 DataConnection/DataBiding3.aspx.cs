using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice6_DataConnection
{
    public partial class DataBiding3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return; // не подгружать данные если сайт уже был загружен
            }

            List<ListBrowser> items = new List<ListBrowser>();
            items.Add(new ListBrowser() { BrowserId = 1, BrowserName = "Mozila"});
            items.Add(new ListBrowser() { BrowserId = 2, BrowserName = "Google" });
            items.Add(new ListBrowser() { BrowserId = 3, BrowserName = "Safari" });
            items.Add(new ListBrowser() { BrowserId = 4, BrowserName = "Opera" });
            items.Add(new ListBrowser() { BrowserId = 5, BrowserName = "IE" });

            DropDownList1.DataSource = items;
            DropDownList1.DataTextField = "BrowserName";
            DropDownList1.DataValueField = "BrowserId";
            DropDownList1.DataBind();

        }

        class ListBrowser
        {
            public int BrowserId { get; set; }
            public string BrowserName { get; set; }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = "Text: " + DropDownList1.SelectedItem.Text + "<br/>";
            text += "Value: " + DropDownList1.SelectedItem.Value + "<br/>";
            Label1.Text = text;
        }
    }
}