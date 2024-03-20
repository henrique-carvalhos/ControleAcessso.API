namespace ControleAcessso.API.InputModels
{
    public class UpdateUserInputModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdGroup { get; set; }
    }
}
