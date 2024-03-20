using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Application.InputModels
{
    public class UpdateReportInputModel
    {
        public int Id { get; set; }
        public string CodRelatorio { get; set; }
        public string Descricao { get; set; }
    }
}
