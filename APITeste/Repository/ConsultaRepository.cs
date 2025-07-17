using APITeste.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace APITeste.Repository
{
    public class ConsultaRepository
    {
        private readonly IConfiguration _configuration;

        public ConsultaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<ConsultaProdutoModel> ListarProdutos()
        {
            var lista = new List<ConsultaProdutoModel>();

            using (var con = new SqlConnection(_configuration.GetConnectionString("TESTESDb")))
            {
                var cmd = new SqlCommand();
                SqlDataReader dr;

                var SQL = @"
                        SELECT * 
                        FROM TBLProdutos";
                cmd = new SqlCommand(SQL, con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new ConsultaProdutoModel
                    {
                        IDProduto = Convert.ToInt32(dr["IDProduto"]),
                        Nome = dr["Nome"].ToString(),
                        Preco = Convert.ToDecimal(dr["Preco"]),
                    });
                }
            }

            return lista;
        }
    }
}
