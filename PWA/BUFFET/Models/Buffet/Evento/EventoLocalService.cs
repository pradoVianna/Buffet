using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BUFFET.Data;
using Microsoft.EntityFrameworkCore;

namespace BUFFET.Models.Buffet.Evento
{
    public class EventoLocalService
    {
        private readonly DataBaseContext _dataBaseContext;

        public EventoLocalService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ICollection<EventoLocal> ListaTodos()
        {
            return _dataBaseContext.EventoLocal
                .ToList();
            
        }
    }
}