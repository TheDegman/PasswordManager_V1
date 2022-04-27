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
        public Form1()
        {
            InitializeComponent();
            using (BazaPodatakaEntities1 context = new BazaPodatakaEntities1())
            {
                var query = context.Korisniks
                    .Select(user => new
                    {
                        Username=user.Username,
                        Password=user.Password,
                        
                    });
                listBox1.DataSource = query;

            }

            
        }
    }
}
