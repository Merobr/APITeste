namespace APITeste.Model
{

    public class ConsultaResponseModel
    {
        public string? Message { get; set; }
        public List<ConsultaProdutoModel>? Produtos { get; set; }
    }

    public class ConsultaRequestModel
    {
        public int IDProduto { get; set; }
    }

    public class ConsultaProdutoModel
    {
        public int IDProduto { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
