namespace BUFFET.RequestModels
{
    public class CadastroAcessoRequestModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}