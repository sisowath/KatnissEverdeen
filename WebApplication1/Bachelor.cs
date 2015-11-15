using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Bachelor
    {
            // attribut(s)
        private int id;
        private String username;
        private String password;
        private String email;
        private int numberOfLikes;
        //private String nom;
        //private String prenom;
        //private int age;
        /* Il y a sûrement beaucoup plus d'aatributs, mais je vais rester sur l'essentiel - Samnang */
            // methode(s)
        // constructeur(s)
        public Bachelor(int id, String username, String password, String email, int numberOfLikes)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.numberOfLikes = numberOfLikes;
        }
        public Bachelor() : this (1, "no username", "no password", "no email", 0) {}
        // proprietes en lecture et en ecriture
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public int NumberOfLikes
        {
            get { return numberOfLikes; }
            set { numberOfLikes = value; }
        }
        // autre(s)
        public override string ToString()
        {
            return id + " :: " + username + " :: " + email + " :: " + numberOfLikes; 
        }
    }
}