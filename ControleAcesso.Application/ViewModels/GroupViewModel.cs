using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Application.ViewModels
{
    public class GroupViewModel
    {
        public GroupViewModel(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
