using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice6_DataConnection
{
    public partial class DataBinding : System.Web.UI.Page
    {
        public string FirstName
        {
            get { return "Jhon"; }
        }

        protected string LastName
        {
            get { return "Doe"; }
        }

        protected int size = 24;

        protected void Page_Load(object sender, EventArgs e)
        {

                // Если не вызвать данный метод, выражения привязки не прочтут значения из свойств страницы.
                DataBind();
        }
    }
}