using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LiteralControl chaineHtml = new LiteralControl();
            chaineHtml.Text = "<table border=\"1px solid black\">";
            chaineHtml.Text += "<tr><th>Nom d'utilisateur</td><th>Pourcentage</th></tr>";
            for (int i = 0; i < 50; i++)
            {
                chaineHtml.Text += "<tr>";
                chaineHtml.Text += "<td>" + i + "</td>";
                chaineHtml.Text += "<td>" + i*i + "</td>";
                chaineHtml.Text += "</tr>";
            }
            chaineHtml.Text += "</table";
            suggestionList.Controls.Add(chaineHtml);
        }
    }
}