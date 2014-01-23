using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.EntityClient;

namespace DocOrganizer
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntityConnection ec = new EntityConnection();
            ec.Open()
        }
    }
}
