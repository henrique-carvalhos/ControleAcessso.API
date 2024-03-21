using ControleAcessso.API.Enums;

namespace ControleAcessso.API.Entities
{
    public class Group
    {
        public Group(string descricao)
        {
            Descricao = descricao;

            Status = StatusEnum.Ativo;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public StatusEnum Status { get; set; }

        public void Update(string descricao)
        {
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
