namespace ControleAcessso.API.Entities
{
    public class Report
    {
        public Report(int id, string codRelatorio, string descricao)
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
