using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.Entity;
using PasswordManager_V1.Model;




namespace PasswordManager_V1
{
    public partial class Form1 : Form
    {
        List<Korisnik> korisnikList = new List<Korisnik>();
        public Form1()
        {
            InitializeComponent();

            using(BazaPodatakaEntities2 context = new BazaPodatakaEntities2())
            {
                var query = context.Korisniks
                    .Select(k => new
                    {
                        ime=k.Username,
                        sifra=k.Password,                       

                    });
                foreach (var kInfo in query)
                {
                    

                }
                
                
                
                



            }
            
            

            
        }
    }
}
