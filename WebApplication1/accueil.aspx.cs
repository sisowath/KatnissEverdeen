using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common; // IMPORTANT pour utiliser DbProviderFactory
using MySql.Data.MySqlClient; // IMPORTANT pour utiliser MySQL avec PhpMyAdmin
using System.Data; // IMPORTANT pour utiliser CommandType

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<Bachelor> uneListeDeBacheliers = new List<Bachelor>();

        protected void Page_Load(object sender, EventArgs e)
        {            
            MySqlConnection cnx = new MySqlConnection("server=localhost;user=root;password=root;database=katnisseverdeen");
            cnx.Open();
            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM bachelor ORDER BY numberOfLikes DESC LIMIT 5";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String username = dbrdr["username"].ToString();
                    String password = dbrdr["password"].ToString();
                    String email = dbrdr["email"].ToString();
                    int numberOfLikes;
                    int.TryParse(dbrdr["numberOfLikes"].ToString(), out numberOfLikes);

                    uneListeDeBacheliers.Add(new Bachelor(id, username, password, email, numberOfLikes));
                    //lblMessage.Text += id + username + password + email + numberOfLikes;
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<table border=\"1px solid black\">";
                for (int i = 0; i < uneListeDeBacheliers.Count; i++)
                {
                    chaineHtml.Text += "<tr>";
                    chaineHtml.Text += "<td>" + uneListeDeBacheliers[i].Id + "</td>";
                    chaineHtml.Text += "<td>" + uneListeDeBacheliers[i].Username + "</td>";
                    chaineHtml.Text += "<td>" + uneListeDeBacheliers[i].NumberOfLikes + "</td>";
                    chaineHtml.Text += "</tr>";
                }
                chaineHtml.Text += "</table>";
                leaderboard.Controls.Add(chaineHtml);
            }
            cnx.Close();
        }
    }
}