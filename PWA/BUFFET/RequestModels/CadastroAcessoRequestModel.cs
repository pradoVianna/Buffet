namespace BUFFET.RequestModels
{
    public class CadastroAcessoRequestModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaConfirm { get; set; }
    }
}