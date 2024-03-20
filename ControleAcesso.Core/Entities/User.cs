using ControleAcessso.API.Enums;

namespace ControleAcessso.API.Entities
{
    public class User
    {
        //public User(int id, string nome, string login, string senha, int idGroup, StatusEnum status)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Login = login;
        //    Senha = senha;
        //    IdGroup = idGroup;

        //    Status = status;
        //}

        public User(string nome, string login, string senha, int idGroup)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            IdGroup = idGroup;

            Status = StatusEnum.Ativo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdGroup { get; set; }
        public Group Group { get; set; }
        public StatusEnum Status { get; set; }

        public void Update(string nome, string login, string senha, int idGroup)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
            IdGroup = idGroup;
        }

        public void Delete()
        {
            if(Status == StatusEnum.Ativo)
            {
                Status = StatusEnum.Inativo;
            }
        }
    }
}
