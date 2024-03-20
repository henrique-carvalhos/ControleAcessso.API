using ControleAcessso.API.Enums;

namespace ControleAcessso.API.Entities
{
    public class Report
    {
        public Report(string codRelatorio, string descricao)
        {
            CodRelatorio = codRelatorio;
            Descricao = descricao;

            Status = StatusEnum.Ativo;
        }

        public int Id { get; set; }
        public string CodRelatorio { get; set; }
        public string Descricao { get; set; }
        public StatusEnum Status { get; set; }

        public void Update(string codRelatorio, string descricao)
        {
            CodRelatorio = codRelatorio;
            Descricao = descricao;
        }

        public void Delete()
        {
            if (Status == StatusEnum.Ativo)
            {
                Status = StatusEnum.Inativo;
            }
        }
    }
}
