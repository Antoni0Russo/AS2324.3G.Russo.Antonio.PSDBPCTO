using System.Data.SQLite;
using System.Data;

namespace AS2324._3G.Russo.Antonio.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Users\Utente\Desktop\flow\AS2324.3G.Russo.Antonio.PSDBPCTO\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT \r\n\t* \r\nFROM \r\n\tPiloti WHERE nazionalita='ITA'\r\nORDER BY \r\n\tnome, cognome;";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnGare_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";

            // https://www.connectionstrings.com/

            // imposta la connessione

            // sqlite Data Source=c:\mydb.db;Version=3;
            strConnessione = "Data Source=" + @"C:\Users\Utente\Desktop\flow\AS2324.3G.Russo.Antonio.PSDBPCTO\MotoGP.db" + ";Version=3;";

            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();

            // query per l'estrazione dei dati dal database
            query = "SELECT * FROM Gare WHERE Punteggio >= 1 AND Punteggio <= 3 ORDER BY IdCircuiti,Punteggio;";

            //connessione e query
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

            try
            {
                // riempie il DataTable
                da.Fill(dtDati);

                // binda la DataGridView
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnSeleziona_Click(object sender, EventArgs e)
        {
            // contenitore per i dati estratti
            DataTable dtDati = new DataTable();
            switch (cmbSeleziona.SelectedItem.ToString())
            {

                case "Elenco squadre non italiane ordinate per nome":
                    string query = "";
                    string strConnessione = "";

                    // https://www.connectionstrings.com/

                    // imposta la connessione

                    // sqlite Data Source=c:\mydb.db;Version=3;
                    strConnessione = "Data Source=" + @"C:\Users\Utente\Desktop\flow\AS2324.3G.Russo.Antonio.PSDBPCTO\MotoGP.db" + ";Version=3;";

                    

                    // query per l'estrazione dei dati dal database
                    query = "SELECT * FROM Squadre WHERE nazionalita <> 'ITA' ORDER BY nome;";

                    //connessione e query
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);

                    try
                    {
                        // riempie il DataTable
                        da.Fill(dtDati);

                        // binda la DataGridView
                        dgvDati.DataSource = dtDati;
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                    break;
                case "Elenco piloti Ducati ordinati per cognome e nome":
                   

                    // https://www.connectionstrings.com/

                    // imposta la connessione

                    // sqlite Data Source=c:\mydb.db;Version=3;
                    strConnessione = "Data Source=" + @"C:\Users\Utente\Desktop\flow\AS2324.3G.Russo.Antonio.PSDBPCTO\MotoGP.db" + ";Version=3;";

                   

                    // query per l'estrazione dei dati dal database
                    query = "SELECT * FROM Piloti WHERE IdSquadre='Ducati' ORDER BY nome,cognome;";

                    //connessione e query
                    SQLiteDataAdapter dai = new SQLiteDataAdapter(query, strConnessione);

                    try
                    {
                        // riempie il DataTable
                        dai.Fill(dtDati);

                        // binda la DataGridView
                        dgvDati.DataSource = dtDati;
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                    break;
                case "Elenco circuiti ordinati per nome":
                    // https://www.connectionstrings.com/

                    // imposta la connessione

                    // sqlite Data Source=c:\mydb.db;Version=3;
                    strConnessione = "Data Source=" + @"C:\Users\Utente\Desktop\flow\AS2324.3G.Russo.Antonio.PSDBPCTO\MotoGP.db" + ";Version=3;";



                    // query per l'estrazione dei dati dal database
                    query = "SELECT * FROM Circuiti  ORDER BY nome;";

                    //connessione e query
                    SQLiteDataAdapter dain = new SQLiteDataAdapter(query, strConnessione);

                    try
                    {
                        // riempie il DataTable
                        dain.Fill(dtDati);

                        // binda la DataGridView
                        dgvDati.DataSource = dtDati;
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.Message);
                    }
                    break;
            }
        }
    }
}