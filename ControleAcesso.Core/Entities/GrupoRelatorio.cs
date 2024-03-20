namespace ControleAcessso.API.Entities
{
    public class GrupoRelatorio
    {
        public GrupoRelatorio(int id, int idGroup, int idRelatorio)
        {
            Id = id;
            IdGroup = idGroup;
            IdRelatorio = idRelatorio;
        }

        public int Id { get; set; }
        public int IdGroup { get; set; }
        public int IdRelatorio { get; set; }
    }
}
