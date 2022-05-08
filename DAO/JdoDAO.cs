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

        public void Remover(string tabela, int id)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            string query = string.Format("DELETE FROM {0} WHERE id = {1}", tabela, id);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
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
            Remover("skin", id);
        }
        public void RemoverTabuleiro(int id)
        {
            Remover("tabuleiro", id);
        }
        public void RemoverSeason(int id)
        {
            Remover("season", id);
        }
        public void RemoverVenda(int id)
        {
            Remover("venda", id);
        }

        public int ConsultarAutoIncrement(string tabela)
        {
            int autoIncrement;
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = string.Format("SELECT auto_increment FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'testedb' AND TABLE_NAME = {0}", "'" + tabela + "'");

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

        public int ConsultarAutoIncrementSkin()
        {
            return ConsultarAutoIncrement("skin");
        }
        public int ConsultarAutoIncrementTabuleiro()
        {
            return ConsultarAutoIncrement("tabuleiro");
        }
        public int ConsultarAutoIncrementSeason()
        {
            return ConsultarAutoIncrement("season");
        }
        public int ConsultarAutoIncrementVenda()
        {
            return ConsultarAutoIncrement("venda");
        }

        public Skin ConsultarSkin(int id)
        {
            Skin skin = new Skin();
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = string.Format("select * from skin where id = {0}", "'" + id + "'");

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

                foreach (DataRow row in dataTable.Rows)
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

        public void InserirSkin(Skin skin)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            jdoDataSet set = new jdoDataSet();

            string query = "insert into skin(nomeSkin, imagemSkin, ehPermanente, tipoPeca, corTematica) VALUES";
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

        public void AtualizarSkin(Skin skin)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            string query = "update skin SET nomeSkin = ?nomeSkin, imagemSkin = ?imagemSkin, ehPermanente = ?ehPermanente, tipoPeca = ?tipoPeca, corTematica = ?corTematica";
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

        public Tabuleiro ConsultarTabuleiro(int id)
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();

            string query = string.Format("select * from tabuleiro where id = {0}", "'" + id + "'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                tabuleiro.Id = int.Parse(row["id"].ToString());
                tabuleiro.NomeTabuleiro = row["nomeTabuleiro"].ToString();
                tabuleiro.ImagemTabuleiro = row["imagemTabuleiro"].ToString();
                tabuleiro.DtCriacao = DateTime.Parse(row["dtCriacao"].ToString());
                tabuleiro.CorTematica = row["corTematica"].ToString();
            }
            return tabuleiro;
        }

        public void InserirTabuleiro(Tabuleiro tabuleiro)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            jdoDataSet set = new jdoDataSet();

            string query = "insert into tabuleiro(nomeTabuleiro, imagemTabuleiro, dtCriacao, corTematica) VALUES";
            query += "(?nomeTabuleiro, ?imagemTabuleiro, now(), ?corTematica)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeTabuleiro", tabuleiro.NomeTabuleiro);
                cmd.Parameters.AddWithValue("?imagemTabuleiro", tabuleiro.ImagemTabuleiro);
                cmd.Parameters.AddWithValue("?corTematica", tabuleiro.CorTematica);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
        public void AtualizarTabuleiro(Tabuleiro tabuleiro)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.getConnectionString();
            string query = "update tabuleiro SET nomeTabuleiro = ?nomeTabuleiro, imagemTabuleiro = ?imagemTabuleiro, corTematica = ?corTematica";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", tabuleiro.Id);
                cmd.Parameters.AddWithValue("?nomeTabuleiro", tabuleiro.NomeTabuleiro);
                cmd.Parameters.AddWithValue("?imagemTabuleiro", tabuleiro.ImagemTabuleiro);
                cmd.Parameters.AddWithValue("?corTematica", tabuleiro.CorTematica);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
