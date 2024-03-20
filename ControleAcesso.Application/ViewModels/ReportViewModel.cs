namespace ControleAcesso.Application.ViewModels
{
    public class ReportViewModel
    {
        public ReportViewModel(int id, string codRelatorio, string descricao)
        {
            Id = id;
            CodRelatorio = codRelatorio;
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string CodRelatorio { get; set; }
        public string Descricao { get; set; }
    }
}