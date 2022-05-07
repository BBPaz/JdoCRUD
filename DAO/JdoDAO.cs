using System;
using MySql.Data.MySqlClient;
using JdoCRUD.Model;
using System.Data;
using System.Collections.Generic;

namespace JdoCRUD.DAO
{
    class JdoDAO
    {
        private helper db = helper.Instancia;
        private MySqlConnection con;

        public JdoDAO()
        {

        }

        public void InserirSkin(Skin skin)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            jdoDataSet set = new jdoDataSet();
            
            String query = "insert into skin(nomeSkin, imagemSkin, ehPermanente, tipoPeca, corTematica) VALUES";
            query += "(?nomeSkin, ?imagemSkin, ?ehPermanente, ?tipoPeca, ?corTematica)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeSkin", skin.NomeSkin);
                cmd.Parameters.AddWithValue("?imagemSkin", skin.ImagemSkin);
                cmd.Parameters.AddWithValue("?ehPermanente", skin.EhPermanente);
                cmd.Parameters.AddWithValue("?tipoPeca", skin.TipoPeca);
                cmd.Parameters.AddWithValue("?corTematica", skin.CorTematica);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public Skin ConsultarSkin(int id)
        {
            Skin skin = new Skin();
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = String.Format("select * from skin where id = {0}", "'" + id + "'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                skin.Id = int.Parse(row["id"].ToString());
                skin.NomeSkin = row["nomeSkin"].ToString();
                skin.ImagemSkin = row["imagemSkin"].ToString();
                skin.EhPermanente = bool.Parse(row["ehPermanente"].ToString());
                skin.TipoPeca = int.Parse(row["tipoPeca"].ToString());
                skin.CorTematica = row["corTematica"].ToString();


            }
            return skin;
        }

        public List<Skin> ConsultarSkins()
        {
            List<Skin> skins = new List<Skin>();
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = "select * from skin";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach(DataRow row in dataTable.Rows)
                {
                    Skin skin = new Skin();
                    skin.Id = int.Parse(row["id"].ToString());
                    skin.NomeSkin = row["nomeSkin"].ToString();
                    skin.ImagemSkin = row["imagemSkin"].ToString();
                    skin.EhPermanente = bool.Parse(row["ehPermanente"].ToString());
                    skin.TipoPeca = int.Parse(row["tipoPeca"].ToString());
                    skin.CorTematica = row["corTematica"].ToString();
                    skins.Add(skin);
                }

            }
            return skins;
        }

        public void AtualizarSkin(Skin skin)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            String query = "update skin SET nomeSkin = ?nomeSkin, imagemSkin = ?imagemSkin, ehPermanente = ?ehPermanente, tipoPeca = ?tipoPeca, corTematica = ?corTematica";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", skin.Id);
                cmd.Parameters.AddWithValue("?nomeSkin", skin.NomeSkin);
                cmd.Parameters.AddWithValue("?imagemSkin", skin.ImagemSkin);
                cmd.Parameters.AddWithValue("?ehPermanente", skin.EhPermanente);
                cmd.Parameters.AddWithValue("?tipoPeca", skin.TipoPeca);
                cmd.Parameters.AddWithValue("?corTematica", skin.CorTematica);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void RemoverSkin(int id)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            String query = "DELETE FROM skin ";
            query += "WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public int ConsultarAutoIncrementSkin()
        {
            int autoIncrement;
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = String.Format("SELECT auto_increment FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'testedb' AND TABLE_NAME = 'skin'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {
                MySqlCommand cmd = new MySqlCommand("SET @@SESSION.information_schema_stats_expiry = 0;", con);
                con.Open();
                cmd.ExecuteNonQuery();//Comando para remover o cache antes de pedir o autoincrement. Se não executado, a query pode retornar um id antigo.

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                autoIncrement = int.Parse(row["auto_increment"].ToString());
            }
            return autoIncrement;
        }

    }
}
