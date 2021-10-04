using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// get and set methods
// try catch
// sql code
// tab / click events
// documentation

namespace GUI_Prototype02
{
    public partial class ProductForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbProductsDataSet.tableProductsCurrent' table. You can move, or remove it, as needed.
            this.tableProductsCurrentTableAdapter.Fill(this.dbProductsDataSet.tableProductsCurrent);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\GUI_Prototype02_Anja\GUI_Prototype02\dbProducts.mdf;Integrated Security=True";

            connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter adapterDataTable = new SqlDataAdapter("SELECT * FROM tableProductsCurrent", connection);
            DataTable dataTable = new DataTable();
            adapterDataTable.Fill(dataTable);
            dataGridSearchAndDelete.DataSource = dataTable;
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void txtBUnitWeightPerUnit_TextChanged(object sender, EventArgs e)
        {
            double weightPerUnit = 0, pricePerKg = 0, pricePerUnit = 0;
            string weightPerUnitString = txtBWeightPerUnit.Text, 
                pricePerKgString = txtBPricePerKg.Text, 
                pricePerUnitString;

            // Testing if the value in the textboxes for the "weight per unit" and "price per kg" is "".
            // This will lead to string values of "0".

            if (weightPerUnitString == "")
                weightPerUnitString = "0";

            if (pricePerKgString == "")
                pricePerKgString = "0";

            // Testing if the value in the textboxes for the "weight per unit" and "price per kg" contains a ".".
            // If true, then this "." will be replaced by a "," to smoothen the input into the system.

            if (weightPerUnitString.Contains("."))
            {
                int indexOfFullStop;
                string indexOfFullStopString;
                
                indexOfFullStop = weightPerUnitString.IndexOf(".");
                weightPerUnitString = weightPerUnitString.Substring(0, weightPerUnitString.Length - weightPerUnitString.Substring(indexOfFullStop + 1).Length - 1) + "," + weightPerUnitString.Substring(indexOfFullStop + 1);
                txtBWeightPerUnit.Text = weightPerUnitString;

                txtBWeightPerUnit.SelectionStart = txtBWeightPerUnit.Text.Length;
                txtBWeightPerUnit.SelectionLength = 0;
            }

            if (pricePerKgString.Contains("."))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = pricePerKgString.IndexOf(".");
                pricePerKgString = pricePerKgString.Substring(0, pricePerKgString.Length - pricePerKgString.Substring(indexOfFullStop + 1).Length - 1) + "," + pricePerKgString.Substring(indexOfFullStop + 1);
                txtBPricePerKg.Text = pricePerKgString;

                txtBPricePerKg.SelectionStart = txtBPricePerKg.Text.Length;
                txtBPricePerKg.SelectionLength = 0;
            }

            // Testing if the values of the "weight per unit" and "price per kg" textboxes are numerical or not.
            // If not, then a message will be displayed, the textboxes will be reset as well as the focus of the UI.

            if (double.TryParse(weightPerUnitString, out weightPerUnit))
            {
                if (double.TryParse(pricePerKgString, out pricePerKg))
                {
                    pricePerUnit = weightPerUnit * pricePerKg;
                    pricePerUnitString = Convert.ToString(pricePerUnit);
                    txtBPricePerUnit.Text = pricePerUnitString;
                }
                else
                {
                    MessageBox.Show("Input Error", "Invalid input entered.\n\n\nPlease enter numbers into the Unit Information spaces provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBWeightPerUnit.Text = "0";
                    txtBPricePerKg.Text = "0";
                    txtBPricePerUnit.Text = "0";
                    txtBWeightPerUnit.SelectAll();
                    txtBWeightPerUnit.Focus();
                }
            }
            else
            {
                MessageBox.Show("Input Error","Invalid input entered.\n\n\nPlease enter numbers into the Unit Information spaces provided.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBWeightPerUnit.Text = "0";
                txtBPricePerKg.Text = "0";
                txtBPricePerUnit.Text = "0";
                txtBWeightPerUnit.SelectAll();
                txtBWeightPerUnit.Focus();
            }
        }

        private void txtBPricePerKg_TextChanged(object sender, EventArgs e)
        {
            double weightPerUnit = 0, pricePerKg = 0, pricePerUnit = 0;
            string weightPerUnitString = txtBWeightPerUnit.Text,
                pricePerKgString = txtBPricePerKg.Text,
                pricePerUnitString;

            // Testing if the value in the textboxes for the "weight per unit" and "price per kg" is "".
            // This will lead to string values of "0".

            if (weightPerUnitString == "")
                weightPerUnitString = "0";

            if (pricePerKgString == "")
                pricePerKgString = "0";

            // Testing if the value in the textboxes for the "weight per unit" and "price per kg" contains a ".".
            // If true, then this "." will be replaced by a "," to smoothen the input into the system.

            if (weightPerUnitString.Contains("."))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = weightPerUnitString.IndexOf(".");
                weightPerUnitString = weightPerUnitString.Substring(0, weightPerUnitString.Length - weightPerUnitString.Substring(indexOfFullStop + 1).Length - 1) + "," + weightPerUnitString.Substring(indexOfFullStop + 1);
                txtBWeightPerUnit.Text = weightPerUnitString;

                txtBWeightPerUnit.SelectionStart = txtBWeightPerUnit.Text.Length;
                txtBWeightPerUnit.SelectionLength = 0;
            }

            if (pricePerKgString.Contains("."))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = pricePerKgString.IndexOf(".");
                pricePerKgString = pricePerKgString.Substring(0, pricePerKgString.Length - pricePerKgString.Substring(indexOfFullStop + 1).Length - 1) + "," + pricePerKgString.Substring(indexOfFullStop + 1);
                txtBPricePerKg.Text = pricePerKgString;

                txtBPricePerKg.SelectionStart = txtBPricePerKg.Text.Length;
                txtBPricePerKg.SelectionLength = 0;
            }

            // Testing if the values of the "weight per unit" and "price per kg" textboxes are numerical or not.
            // If not, then a message will be displayed, the textboxes will be reset as well as the focus of the UI.

            if (double.TryParse(weightPerUnitString, out weightPerUnit))
            {
                if (double.TryParse(pricePerKgString, out pricePerKg))
                {
                    pricePerUnit = weightPerUnit * pricePerKg;
                    pricePerUnitString = Convert.ToString(pricePerUnit);
                    txtBPricePerUnit.Text = pricePerUnitString;
                }
                else
                {
                    MessageBox.Show("Input Error", "Invalid input entered.\n\n\nPlease enter numbers into the Unit Information spaces provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBPricePerKg.Text = "0";
                    txtBPricePerUnit.Text = "0";
                    txtBWeightPerUnit.Text = "0";
                    txtBWeightPerUnit.SelectAll();
                    txtBWeightPerUnit.Focus();
                }
            }
            else
            {
                MessageBox.Show("Input Error", "Invalid input entered.\n\n\nPlease enter numbers into the Unit Information spaces provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBPricePerKg.Text = "0";
                txtBPricePerUnit.Text = "0";
                txtBWeightPerUnit.Text = "0";
                txtBWeightPerUnit.SelectAll();
                txtBWeightPerUnit.Focus();
            }
        }

        /*
        SqlConnection connection;
        SqlCommand command;
        DataSet dataSet;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        */

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string productKey = maskedTxtBProductKey.Text, 
                productType = txtBProductType.Text, 
                productDescription = txtBProductDescription.Text;

            string weightPerUnitString = txtBWeightPerUnit.Text,
                pricePerKgString = txtBPricePerKg.Text,
                pricePerUnitString = txtBPricePerUnit.Text,
                inStock = txtBStock.Text; ;

            if (weightPerUnitString.Contains(","))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = weightPerUnitString.IndexOf(",");
                weightPerUnitString = weightPerUnitString.Substring(0, weightPerUnitString.Length - weightPerUnitString.Substring(indexOfFullStop + 1).Length - 1) + "." + weightPerUnitString.Substring(indexOfFullStop + 1);
            }

            if (pricePerKgString.Contains(","))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = pricePerKgString.IndexOf(",");
                pricePerKgString = pricePerKgString.Substring(0, pricePerKgString.Length - pricePerKgString.Substring(indexOfFullStop + 1).Length - 1) + "." + pricePerKgString.Substring(indexOfFullStop + 1);
            }

            if (pricePerUnitString.Contains(","))
            {
                int indexOfFullStop;
                string indexOfFullStopString;

                indexOfFullStop = pricePerUnitString.IndexOf(",");
                pricePerUnitString = pricePerUnitString.Substring(0, pricePerUnitString.Length - pricePerUnitString.Substring(indexOfFullStop + 1).Length - 1) + "." + pricePerUnitString.Substring(indexOfFullStop + 1);
            }

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\GUI_Prototype02_Anja\GUI_Prototype02\dbProducts.mdf;Integrated Security=True";

            connection = new SqlConnection(connectionString);

            connection.Open();

            adapter = new SqlDataAdapter();

            string commandString = "INSERT INTO tableProductsCurrent (Id,Product_Key,Product_Type,Product_Description,Weight_per_Unit,Price_per_Kg,Price_per_Unit,In_Stock) VALUES (6,'" + productKey + "','" + productType + "','" + productDescription + "'," + weightPerUnitString + "," + pricePerKgString + "," + pricePerUnitString + "," + inStock + ")";
            MessageBox.Show("Add Product with Product Key '" + productKey + "'?", "Insert Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            adapter.InsertCommand = new SqlCommand(commandString, connection);
            adapter.InsertCommand.ExecuteNonQuery();

            /*SqlDataAdapter adapterDataTable = new SqlDataAdapter("SELECT * FROM tableProductsCurrent", connection);
            DataTable dataTable = new DataTable();
            adapterDataTable.Fill(dataTable);
            dataGridInsert.DataSource = dataTable;*/

            connection.Close();

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\GUI_Prototype02_Anja\GUI_Prototype02\dbProducts.mdf;Integrated Security=True";

            connection = new SqlConnection(connectionString);

            connection.Open();

            SqlDataAdapter adapterDataTable = new SqlDataAdapter("SELECT * FROM tableProductsCurrent", connection);
            DataTable dataTable = new DataTable();
            adapterDataTable.Fill(dataTable);
            dataGridSearchAndDelete.DataSource = dataTable;
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void maskedTxtBProductKey_Click(object sender, EventArgs e)
        {
            maskedTxtBProductKey.SelectAll();
        }

        private void txtBProductType_Click(object sender, EventArgs e)
        {
            txtBProductType.SelectAll();
        }

        private void txtBProductDescription_Click(object sender, EventArgs e)
        {
            txtBProductDescription.SelectAll();
        }

        private void txtBWeightPerUnit_Click(object sender, EventArgs e)
        {
            txtBWeightPerUnit.SelectAll();
        }

        private void txtBPricePerKg_Click(object sender, EventArgs e)
        {
            txtBPricePerKg.SelectAll();
        }

        private void txtBPricePerUnit_Click(object sender, EventArgs e)
        {
            txtBPricePerUnit.SelectAll();
        }

        private void txtBStock_Click(object sender, EventArgs e)
        {
            txtBStock.SelectAll();
        }

        private void btnViewUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add ordered stock with Product Key '" + comboBox1.SelectedItem.ToString() + "'?", "Procurement Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deduct sold stock with Product Key '" + comboBox12.SelectedItem.ToString() + "'?", "Sales Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}
