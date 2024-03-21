using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Application.InputModels
{
    public class UpdateGroupReportInputModel
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdRelatorio { get; set; }
    }
}
