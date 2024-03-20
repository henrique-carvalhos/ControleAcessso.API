namespace ControleAcessso.API.InputModels
{
    public class NewUserInputModel
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdGroup { get; set; }
    }
}
