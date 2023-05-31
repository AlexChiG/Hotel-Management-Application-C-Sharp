using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAOO
{
    public partial class tab_rezervare : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\GC353\SOURCE\REPOS\PROIECTPAOO\DATABASE1.MDF;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter adapter;
        public tab_rezervare(string username)
        {
            InitializeComponent();
            LoadData();
            if (username != "admin")
                isNotAdmin();
        }

        void isNotAdmin()
        {
            cod.Enabled = false;
            data.Enabled = false;
            nr.Enabled = false;
            codc.Enabled = false;
            coda.Enabled = false;

            add.Enabled = false;
            sterg.Enabled = false;
            modif.Enabled = false;
            imp.Enabled = false;

            cod.BackColor = Color.Gray;
            data.BackColor = Color.Gray;
            nr.BackColor = Color.Gray;
            codc.BackColor = Color.Gray;
            coda.BackColor = Color.Gray;

            add.BackColor = Color.Gray;
            sterg.BackColor = Color.Gray;
            modif.BackColor = Color.Gray;
            imp.BackColor = Color.Gray;
        }

        void LoadData()
        {
            connection.Open();
            string query = "SELECT * FROM rezervare";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        void adaugare()
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO rezervare (cod_rezervare, data, nr_zile, cod_client, cod_angajat) VALUES (@value1, @value2, @value3, @value4, @value5)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@value1", cod.Text);
                cmd.Parameters.AddWithValue("@value2", data.Text);
                cmd.Parameters.AddWithValue("@value3", nr.Text);
                cmd.Parameters.AddWithValue("@value4", codc.Text);
                cmd.Parameters.AddWithValue("@value5", coda.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Succes");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:\n" + ex);
            }
        }

        void modificare()
        {
            try
            {
                connection.Open();
                string query = "UPDATE rezervare SET data=@value2, nr_zile=@value3, cod_client=@value4, cod_angajat=@value5 WHERE cod_rezervare=@value1";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@value1", cod.Text);
                cmd.Parameters.AddWithValue("@value2", data.Text);
                cmd.Parameters.AddWithValue("@value3", nr.Text);
                cmd.Parameters.AddWithValue("@value4", codc.Text);
                cmd.Parameters.AddWithValue("@value5", coda.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Succes");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:\n" + ex);
            }
        }

        void stergere()
        {
            try
            {
                SqlCommand cmd;
                string query = "Delete FROM rezervare WHERE cod_rezervare=@value1";
                connection.Open();
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@value1", cod.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Succes");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:\n" + ex);
            }
        }

        void clear()
        {
            cod.Text = "";
            data.Text = "";
            nr.Text = "";
            codc.Text = "";
            coda.Text = "";
        }

        void filtrare()
        {
            try
            {
                string query = "Select * from rezervare WHERE cod_rezervare LIKE @searchTerm";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + filtru.Text + "%");
                adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:\n" + ex);
            }
        }

        void cautare()
        {
            try
            {
                string query = "Select * from rezervare WHERE cod_rezervare LIKE @searchTerm";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + textcaut.Text + "%");
                adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();
                MessageBox.Show("Succes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:\n" + ex);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            adaugare();
            clear();
        }

        private void modif_Click(object sender, EventArgs e)
        {
            modificare();
            clear();
        }

        private void sterg_Click(object sender, EventArgs e)
        {
            stergere();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowindex = dataGridView1.SelectedRows[0].Index;
                cod.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                data.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                nr.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                codc.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                coda.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            }
        }

        private void clr_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void caut_Click(object sender, EventArgs e)
        {
            cautare();
            textcaut.Text = "";
        }

        private void filtru_TextChanged(object sender, EventArgs e)
        {
            filtrare();
        }

        private void imp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV Files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // The path of the .csv file
                string filePath = ofd.FileName;

                // Create a new DataTable
                DataTable dt = new DataTable();

                // Read the contents of the .csv file into the DataTable
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }
                }

                // Assign the DataTable as the DataSource for the DataGridView
                dataGridView1.DataSource = dt;
            }

        }

        private void exp_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            // If the user chooses a printer, print the table
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set the row height and column width
            int rowHeight = dataGridView1.RowTemplate.Height;
            int columnWidth = 80;

            // Set the starting x and y coordinates
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;

            // Draw the column headers
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(x, y, columnWidth, rowHeight));
                x += columnWidth;

                // Draw a line after each column except for the last column
                if (i != dataGridView1.Columns.Count - 1)
                {
                    e.Graphics.DrawLine(Pens.Black, x, y, x, y + rowHeight);
                }
            }

            // Draw a line below the column headers
            y += rowHeight;
            x = e.MarginBounds.Left;
            e.Graphics.DrawLine(Pens.Black, x, y, x + (dataGridView1.Columns.Count * columnWidth), y);

            // Draw the data
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                x = e.MarginBounds.Left;
                y += rowHeight;

                // Draw the row data
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 12), Brushes.Black, new RectangleF(x, y, columnWidth, rowHeight));
                    x += columnWidth;

                    // Draw a line after each column except for the last column
                    if (j != dataGridView1.Columns.Count - 1)
                    {
                        e.Graphics.DrawLine(Pens.Black, x, y, x, y + rowHeight);
                    }
                }

                // Draw a line below the row
                e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Left + (dataGridView1.Columns.Count * columnWidth), y);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
