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
using System.IO;

namespace ProiectPAOO
{
    public partial class tab_angajat : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\GC353\SOURCE\REPOS\PROIECTPAOO\DATABASE1.MDF;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionString);
        SqlDataAdapter adapter;
        public tab_angajat(string username)
        {
            InitializeComponent();
            LoadData();
            if(username != "admin")
                isNotAdmin();
        }
        
        void isNotAdmin()
        {
            cod_angajat.Enabled = false;
            cnp.Enabled = false;
            nume.Enabled = false;
            prenume.Enabled = false;
            adresa.Enabled = false;
            telefon.Enabled = false;
            salariu.Enabled = false;
            data_angajare.Enabled = false;
            cod_departament.Enabled = false;
            add.Enabled = false;
            sterg.Enabled = false;
            modif.Enabled = false;
            imp.Enabled = false;

            cod_angajat.BackColor = Color.Gray;
            cnp.BackColor = Color.Gray;
            nume.BackColor = Color.Gray;
            prenume.BackColor = Color.Gray;
            adresa.BackColor = Color.Gray;
            telefon.BackColor = Color.Gray;
            salariu.BackColor = Color.Gray;
            data_angajare.BackColor = Color.Gray;
            cod_departament.BackColor = Color.Gray;
            add.BackColor = Color.Gray;
            sterg.BackColor = Color.Gray;
            modif.BackColor = Color.Gray;
            imp.BackColor = Color.Gray;
        }

        void LoadData()
        {
            connection.Open();
            string query = "SELECT * FROM Angajat";
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
            string query = "INSERT INTO angajat (cod_angajat, cnp, nume, prenume, adresa, telefon, salariu, data_angajare, cod_departament) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8, @value9)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value1", cod_angajat.Text);
            cmd.Parameters.AddWithValue("@value2", cnp.Text);
            cmd.Parameters.AddWithValue("@value3", nume.Text);
            cmd.Parameters.AddWithValue("@value4", prenume.Text);
            cmd.Parameters.AddWithValue("@value5", adresa.Text);
            cmd.Parameters.AddWithValue("@value6", telefon.Text);
            cmd.Parameters.AddWithValue("@value7", salariu.Text);
            cmd.Parameters.AddWithValue("@value8", data_angajare.Text);
            cmd.Parameters.AddWithValue("@value9", cod_departament.Text);
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
            try {
            connection.Open();
            string query = "UPDATE angajat SET cnp=@value2, nume=@value3, prenume=@value4, adresa=@value5, telefon=@value6, salariu=@value7, data_angajare=@value8, cod_departament=@value9 WHERE cod_angajat=@value1";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value1", cod_angajat.Text);
            cmd.Parameters.AddWithValue("@value2", cnp.Text);
            cmd.Parameters.AddWithValue("@value3", nume.Text);
            cmd.Parameters.AddWithValue("@value4", prenume.Text);
            cmd.Parameters.AddWithValue("@value5", adresa.Text);
            cmd.Parameters.AddWithValue("@value6", telefon.Text);
            cmd.Parameters.AddWithValue("@value7", salariu.Text);
            cmd.Parameters.AddWithValue("@value8", data_angajare.Text);
            cmd.Parameters.AddWithValue("@value9", cod_departament.Text);
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
            try {
            SqlCommand cmd;
            string query = "Delete FROM angajat WHERE cod_angajat=@value1";
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@value1", cod_angajat.Text);
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
            cod_angajat.Text = "";
            cnp.Text = "";
            nume.Text = "";
            prenume.Text = "";
            adresa.Text = "";
            telefon.Text = "";
            salariu.Text = "";
            data_angajare.Text = "";
            cod_departament.Text = "";
        }

        void filtrare()
        {
            try {
            string query = "Select * from angajat WHERE cod_angajat LIKE @searchTerm";
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
            try {
            string query = "Select * from angajat WHERE cod_angajat LIKE @searchTerm";
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
                cod_angajat.Text = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                cnp.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                nume.Text = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                prenume.Text = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                adresa.Text = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
                telefon.Text = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
                salariu.Text = dataGridView1.Rows[rowindex].Cells[6].Value.ToString();
                data_angajare.Text = dataGridView1.Rows[rowindex].Cells[7].Value.ToString();
                cod_departament.Text = dataGridView1.Rows[rowindex].Cells[8].Value.ToString();
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
