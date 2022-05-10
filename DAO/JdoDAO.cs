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
            con.ConnectionString = db.GetConnectionString();
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
            con.ConnectionString = db.GetConnectionString();

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
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from skin where id = {0}", "'" + id + "'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                skin.Id = int.Parse(row["id"].ToString());
                skin.NomeSkin = row["nomeSkin"].ToString();
                skin.ImagemSkin = row["imagemSkin"].ToString();
                skin.TipoPeca = int.Parse(row["tipoPeca"].ToString());
                skin.CorTematica = row["corTematica"].ToString();


            }
            return skin;
        }

        public List<Skin> ConsultarSkins()
        {
            List<Skin> skins = new List<Skin>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

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
            con.ConnectionString = db.GetConnectionString();
            jdoDataSet set = new jdoDataSet();

            string query = "insert into skin(nomeSkin, imagemSkin,  tipoPeca, corTematica) VALUES";
            query += "(?nomeSkin, ?imagemSkin, ?tipoPeca, ?corTematica)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeSkin", skin.NomeSkin);
                cmd.Parameters.AddWithValue("?imagemSkin", skin.ImagemSkin);
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
            con.ConnectionString = db.GetConnectionString();
            string query = "update skin SET nomeSkin = ?nomeSkin, imagemSkin = ?imagemSkin, tipoPeca = ?tipoPeca, corTematica = ?corTematica";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", skin.Id);
                cmd.Parameters.AddWithValue("?nomeSkin", skin.NomeSkin);
                cmd.Parameters.AddWithValue("?imagemSkin", skin.ImagemSkin);
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
            con.ConnectionString = db.GetConnectionString();

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

        public List<Tabuleiro> ConsultarTabuleiros()
        {
            List<Tabuleiro> tabuleiros = new List<Tabuleiro>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = "select * from tabuleiro";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Tabuleiro tabuleiro = new Tabuleiro(); 
                    tabuleiro.Id = int.Parse(row["id"].ToString());
                    tabuleiro.NomeTabuleiro = row["nomeTabuleiro"].ToString();
                    tabuleiro.ImagemTabuleiro = row["imagemTabuleiro"].ToString();
                    tabuleiro.DtCriacao = DateTime.Parse(row["dtCriacao"].ToString());
                    tabuleiro.CorTematica = row["corTematica"].ToString();
                    tabuleiros.Add(tabuleiro);
                }

            }
            return tabuleiros;
        }

        public void InserirTabuleiro(Tabuleiro tabuleiro)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();
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
            con.ConnectionString = db.GetConnectionString();
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

        public bool IsRemovivelSkin(int id)
        {
            List<Venda> vendas = new List<Venda>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from venda where idSkin = {0}", id);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();

                    venda.Id = int.Parse(row["id"].ToString());
                    venda.IdSeason = int.Parse(row["idSeason"].ToString());
                    venda.IdSkin = int.Parse((row["idSkin"].ToString()));

                    vendas.Add(venda);
                }

            }
            return vendas.Count == 0;
        }

        public bool IsRemovivelTabuleiro(int id)
        {
            List<Season> seasons = new List<Season>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from season where idTabuleiro = {0}", id);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Season season = new Season();
                    season.Id = int.Parse(row["id"].ToString());
                    season.NomeSeason = row["nomeSeason"].ToString();
                    season.InicioVigencia = DateTime.Parse(row["inicioVigencia"].ToString());
                    season.FimVigencia = DateTime.Parse(row["fimVigencia"].ToString());
                    season.IdTabuleiro = int.Parse(row["idTabuleiro"].ToString());
                    season.Prioridade = int.Parse(row["prioridade"].ToString());

                    seasons.Add(season);
                }

            }
            return seasons.Count == 0;
        }

        public bool IsRemovivelSeason(int id)
        {
            List<Venda> vendas = new List<Venda>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from venda where idSeason = {0}", id);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();

                    venda.Id = int.Parse(row["id"].ToString());
                    venda.IdSeason = int.Parse(row["idSeason"].ToString());
                    venda.IdSkin = int.Parse((row["idSkin"].ToString()));

                    vendas.Add(venda);
                }

            }
            return vendas.Count == 0;
        }

        public Season ConsultarSeason(int id)
        {
            Season season = new Season();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from season where id = {0}", "'" + id + "'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                season.Id = int.Parse(row["id"].ToString());
                season.NomeSeason = row["nomeSeason"].ToString();
                season.InicioVigencia = DateTime.Parse(row["inicioVigencia"].ToString());
                season.FimVigencia = DateTime.Parse(row["fimVigencia"].ToString());
                season.IdTabuleiro = int.Parse(row["idTabuleiro"].ToString());
                season.Prioridade = int.Parse(row["prioridade"].ToString());
            }
            return season;
        }

        public List<Season> ConsultarSeasons()
        {
            List<Season> seasons = new List<Season>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = "select * from season";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Season season = new Season();
                    season.Id = int.Parse(row["id"].ToString());
                    season.NomeSeason = row["nomeSeason"].ToString();
                    season.InicioVigencia = DateTime.Parse(row["inicioVigencia"].ToString());
                    season.FimVigencia = DateTime.Parse(row["fimVigencia"].ToString());
                    season.IdTabuleiro = int.Parse(row["idTabuleiro"].ToString());
                    season.Prioridade = int.Parse(row["prioridade"].ToString());

                    seasons.Add(season);
                }

            }
            return seasons;
        }

        public void InserirSeason(Season season)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();
            jdoDataSet set = new jdoDataSet();

            string query = "insert into season(nomeSeason, inicioVigencia, fimVigencia, idTabuleiro, prioridade) VALUES";
            query += "(?nomeSeason, ?inicioVigencia, ?fimVigencia, ?idTabuleiro, ?prioridade)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?nomeSeason", season.NomeSeason);
                cmd.Parameters.AddWithValue("?inicioVigencia", season.InicioVigencia);
                cmd.Parameters.AddWithValue("?fimVigencia", season.FimVigencia);
                cmd.Parameters.AddWithValue("?idTabuleiro", season.IdTabuleiro);
                cmd.Parameters.AddWithValue("?prioridade", season.Prioridade);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizarSeason(Season season)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();
            string query = 
                "update season SET nomeSeason = ?nomeSeason, inicioVigencia = ?inicioVigencia, fimVigencia = ?fimVigencia, idTabuleiro = ?idTabuleiro, prioridade = ?prioridade";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", season.Id);
                cmd.Parameters.AddWithValue("?nomeSeason", season.NomeSeason);
                cmd.Parameters.AddWithValue("?inicioVigencia", season.InicioVigencia);
                cmd.Parameters.AddWithValue("?fimVigencia", season.FimVigencia);
                cmd.Parameters.AddWithValue("?idTabuleiro", season.IdTabuleiro);
                cmd.Parameters.AddWithValue("?prioridade", season.Prioridade);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public bool IsPeriodoDisponivelSeason(int prioridade, DateTime inicioVigencia, DateTime fimVigencia)
        {
            List<Season> seasons = new List<Season>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from season where ({0} between inicioVigencia and fimVigencia or {1} between inicioVigencia and fimVigencia) and prioridade = {2}",
                inicioVigencia.ToString("yyyy/MM/dd"),
                fimVigencia.ToString("yyyy/MM/dd"),
                prioridade);

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Season season = new Season();
                    season.Id = int.Parse(row["id"].ToString());
                    season.NomeSeason = row["nomeSeason"].ToString();
                    season.InicioVigencia = DateTime.Parse(row["inicioVigencia"].ToString());
                    season.FimVigencia = DateTime.Parse(row["fimVigencia"].ToString());
                    season.IdTabuleiro = int.Parse(row["idTabuleiro"].ToString());
                    season.Prioridade = int.Parse(row["prioridade"].ToString());

                    seasons.Add(season);
                }

            }
            return seasons.Count == 0;
        }        

        public void InserirVenda(Venda venda)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();
            jdoDataSet set = new jdoDataSet();

            string query = "insert into venda(valor, idSeason, idSkin) VALUES";
            query += "(?valor, ?idSeason, ?idSkin)";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?valor", venda.Valor);
                cmd.Parameters.AddWithValue("?idSeason", venda.IdSeason);
                cmd.Parameters.AddWithValue("?idSkin", venda.IdSkin);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizarVenda(Venda venda)
        {
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();
            string query = "update venda SET valor = ?valor, idSeason = ?idSeason, idSkin = ?idSkin";
            query += " WHERE id = ?id";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", venda.Id); 
                cmd.Parameters.AddWithValue("?valor", venda.Valor);
                cmd.Parameters.AddWithValue("?idSeason", venda.IdSeason);
                cmd.Parameters.AddWithValue("?idSkin", venda.IdSkin);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                con.Close();
            }
        }

        public Venda ConsultarVenda(int id)
        {
            Venda venda = new Venda();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = string.Format("select * from venda where id = {0}", "'" + id + "'");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                venda.Id = int.Parse(row["id"].ToString());
                venda.IdSeason = int.Parse(row["idSeason"].ToString());
                venda.IdSkin = int.Parse((row["idSkin"].ToString()));
            }
            return venda;
        }

        public List<Venda> ConsultarVendas()
        {
            List<Venda> vendas = new List<Venda>();
            con = new MySqlConnection();
            con.ConnectionString = db.GetConnectionString();

            string query = "select * from venda";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
            {

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Venda venda = new Venda();

                    venda.Id = int.Parse(row["id"].ToString());
                    venda.IdSeason = int.Parse(row["idSeason"].ToString());
                    venda.IdSkin = int.Parse((row["idSkin"].ToString()));

                    vendas.Add(venda);
                }

            }
            return vendas;
        }
    }
}
