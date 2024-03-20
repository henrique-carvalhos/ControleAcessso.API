using ControleAcessso.API.Entities;

namespace ControleAcessso.API.Persistence
{
    public class ControleAcessoDbContext
    {
        public ControleAcessoDbContext()
        {
            Users = new List<User>
            {
                new(1, "Henrique", "henrique.carvalho", "123456", 1, Enums.StatusEnum.Ativo),
                new(2, "Amanda", "henrique.souza", "123456", 1, Enums.StatusEnum.Inativo),
                new(3, "Adriano", "souza.henrique", "123456",1 ,Enums.StatusEnum.Ativo),
                new(4, "Vinicius", "carvalho.henrique", "123456", 1, Enums.StatusEnum.Ativo),
                new(5, "Marcelo", "carvalho.henrique", "123456", 1 ,Enums.StatusEnum.Ativo),
                new(6, "Bruno", "carvalho.henrique", "123456", 1 ,Enums.StatusEnum.Inativo),
                new(7, "Hugo", "carvalho.henrique", "123456", 1, Enums.StatusEnum.Inativo),
                new(8, "Sabrina", "carvalho.henrique", "123456", 1, Enums.StatusEnum.Ativo)
            };

            Groups = new List<Group>
            {
                new(1, "COMERCIAL"),
                new(2, "TI"),
                new(3, "PCP"),
                new(4, "REPRESENTANTE"),
                new(5, "FINANCEIRO"),
                new(6, "PRODUÇÃO"),
                new(7, "ESTOQUE"),
                new(8, "FATURAMENTO")
            };

            Relatorios = new List<Relatorio>
            {
                new(1, "COM001", "COM001-Comparativo de Vendas"),
                new(2, "COM007", "COM007-Preços de Artigos - Analítico"),
                new(3, "EST013", "EST013-Acabado por Item analítico"),
                new(4, "EST019", "EST019-Estoque de Fios Analítico"),
                new(5, "FAT003", "FAT003-Comparativo de Faturamento"),
                new(6, "FAT001", "FAT001-Posição do Romaneio"),
                new(7, "PRO019", "PRO019-Produção de Segunda Qualidade"),
                new(8, "PRO011", "PRO011-OB Fases")
            };

            GruposRelatorios = new List<GrupoRelatorio>
            {
                new(1,2,1),
                new(2,2,3),
                new(3,1,1),
                new(4,1,5),
                new(5,7,3),
                new(6,7,4),
                new(7,6,7),
                new(8,6,8) 
            };
        }


        public List<User> Users { get; set; }
        public List<Group> Groups { get; set; }
        public List<Relatorio> Relatorios { get; set; }
        public List<GrupoRelatorio> GruposRelatorios { get; set; }
        //public List<UserViewModel> UserViewModels { get; set; }
    }
}
