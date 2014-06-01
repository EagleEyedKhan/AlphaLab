using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TimeSpan ts1 = TimeSpan.FromMinutes(15);
        TimeSpan ts2 = TimeSpan.FromMinutes(16);
        TimeSpan ts3 = TimeSpan.FromMinutes(17);
        ltMsg.Text += "(ts1 > ts2): " + (ts1 > ts2).ToString() + "<br/>";
        ltMsg.Text += "(ts2 > ts3): " + (ts2 > ts3).ToString() + "<br/>";
        ltMsg.Text += "(ts3 > ts1): " + (ts3 > ts1).ToString() + "<br/>";
    }
}
