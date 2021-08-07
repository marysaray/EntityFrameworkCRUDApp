using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkCRUDApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a new product
            Product p = new Product()
            {
                Title = "Gadget",
                Price = 9.99
            };

            // instance of DbContext class
            ProductContext dbContext = new ProductContext();

            // add to database: generate an insert statement that is parameterized
            dbContext.Products.Add(p);

            // execute against the database: send query to the database
            dbContext.SaveChanges();

            MessageBox.Show("Added");
        }
    }
}
