using ControleAcessso.API.Entities;

namespace ControleAcesso.Application.ViewModels
{
    public class GroupReportViewModel
    {
        public GroupReportViewModel(int id, int idGroup, int idRelatorio)
        {
            Id = id;
            IdGroup = idGroup;
            IdRelatorio = idRelatorio;
        }

        public GroupReportViewModel() { }

        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdRelatorio { get; set; }
    }
}
