namespace ControleAcessso.API.Entities
{
    public class Relatorio
    {
        public Relatorio(int id, string codRelatorio, string descricao)
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
