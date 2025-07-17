using APITeste.Model;
using APITeste.Repository;
using System.Data.SqlClient;

namespace APITeste.BLL
{
    public class ConsultaBLL
    {
        private readonly ConsultaRepository _repo;

        public ConsultaBLL(ConsultaRepository repo)
        {
            _repo = repo;
        }

        //public List<Produto> Listar() => _repo.ListarProdutos();

        public ConsultaResponseModel ListarProdutos()
        {
            var response = new ConsultaResponseModel();

            response.Produtos = _repo.ListarProdutos();

            return response;
        }
    }
}
