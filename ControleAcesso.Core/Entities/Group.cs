namespace ControleAcessso.API.Entities
{
    public class Group
    {
        public Group(int id, string descricao)
        {
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
