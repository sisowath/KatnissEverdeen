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
    public partial class WebForm4 : System.Web.UI.Page
    {
        private List<Interest> uneListeDeChampInterets = new List<Interest>();
        private Bachelor unBachelor;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isConnected"] == null) Response.Redirect("login.aspx");

            if (Session["profile"] != null)
            {
                unBachelor = (Bachelor)Session["profile"];
                txtId.Text = unBachelor.Id.ToString();
                txtUsername.Text = unBachelor.Username;
                txtPassword.Text = unBachelor.Password;
                txtEmail.Text = unBachelor.Email;
                txtNumberOfLikes.Text = unBachelor.NumberOfLikes.ToString();
                pbxImage.ImageUrl = unBachelor.Image;
                pbxImage.Height=300;
                pbxImage.Width = 530;                
            }
            MySqlConnection cnx = new MySqlConnection("server=localhost;user=root;password=root;database=katnisseverdeen");
            cnx.Open();
            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
// bookgenres
            cmd.CommandText = "SELECT * FROM bookgenres ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"booksGenres\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                {
                    //if(uneListeDeChampInterets[i].Id.Equals(unBachelor.);
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                }
                chaineHtml.Text += "</select>";
                bookGenres.Controls.Add(chaineHtml);
            }
// brands
            uneListeDeChampInterets = new List<Interest>();
            cmd.CommandText = "SELECT * FROM brands ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"brands\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                chaineHtml.Text += "</select>";
                brands.Controls.Add(chaineHtml);
            }
// hobbies
            uneListeDeChampInterets = new List<Interest>();
            cmd.CommandText = "SELECT * FROM hobbies ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"hobbies\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                chaineHtml.Text += "</select>";
                hobbies.Controls.Add(chaineHtml);
            }
// musicGenres
            uneListeDeChampInterets = new List<Interest>();
            cmd.CommandText = "SELECT * FROM musicgenres ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"musicGenres\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                chaineHtml.Text += "</select>";
                musicGenres.Controls.Add(chaineHtml);
            }
// sports
            uneListeDeChampInterets = new List<Interest>();
            cmd.CommandText = "SELECT * FROM sports ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"sports\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                chaineHtml.Text += "</select>";
                sports.Controls.Add(chaineHtml);
            }
// moveiGenres
            uneListeDeChampInterets = new List<Interest>();
            cmd.CommandText = "SELECT * FROM moviegenres ORDER BY id";
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                while (dbrdr.Read())
                {
                    int id;
                    int.TryParse(dbrdr["id"].ToString(), out id);
                    String nom = dbrdr["nom"].ToString();

                    uneListeDeChampInterets.Add(new Interest(id, nom));
                }
                LiteralControl chaineHtml = new LiteralControl();
                chaineHtml.Text = "<select id=\"movieGenres\" width=\"100%\">";
                for (int i = 0; i < uneListeDeChampInterets.Count; i++)
                    chaineHtml.Text += "<option value=\"" + uneListeDeChampInterets[i].Nom + "\">" + uneListeDeChampInterets[i].Nom + "</option>";
                chaineHtml.Text += "</select>";
                movieGenres.Controls.Add(chaineHtml);
            }
            cnx.Close();            
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("server=localhost;user=root;password=root;database=katnisseverdeen");
            cnx.Open();
            MySqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT numberOfLikes FROM bachelor WHERE id = @id";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@id", unBachelor.Id);
            int x = 0;
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                if(dbrdr.Read())
                {
                    int.TryParse(dbrdr["numberOfLikes"].ToString(), out x);   
                }                
            }
            cmd.CommandText = "UPDATE bachelor SET numberOfLikes = @numberOfLikes WHERE id = @id";
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@numberOfLikes", (x++));
            using (DbDataReader dbrdr = cmd.ExecuteReader())
            {
                if (dbrdr.Read())
                {                   
                }
                unBachelor.NumberOfLikes = x++;
                txtNumberOfLikes.Text = unBachelor.NumberOfLikes.ToString();
                Session["profile"] = unBachelor;
                lblMessage.Text = "<h3 style=\"color:blue\">Likes Updated !!</h3>";                
            }
            cnx.Close();
        }
    }
}