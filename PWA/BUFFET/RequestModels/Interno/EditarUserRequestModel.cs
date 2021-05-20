using BUFFET.Models.Buffet.Access;

namespace BUFFET.RequestModels
{
    public class EditarUserRequestModel : IDadosBasicosUser
    {
        public string Username { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
        public string AtualSenha { get; set; }
    }
}