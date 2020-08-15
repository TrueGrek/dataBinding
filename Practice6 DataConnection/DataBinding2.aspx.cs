using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice6_DataConnection
{
    public partial class DataBinding2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] values = { "item1", "item2", "item3", "item4" };
            DropDownList1.DataSource = values;
            DropDownList1.DataBind();
        }
    }
}