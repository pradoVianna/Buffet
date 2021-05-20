using BUFFET.Models.Buffet.Access;
using BUFFET.Models.Buffet.Evento;

namespace BUFFET.RequestModels
{
    public class EditarUserRequestModel

    {
    public string Username { get; set; }
    public string Senha { get; set; }
    public string ConfirmSenha { get; set; }
    public string AtualSenha { get; set; }


    public EditarUserRequestModel()
    {
    }
    
   
    }
}