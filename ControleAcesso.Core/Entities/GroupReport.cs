﻿namespace ControleAcessso.API.Entities
{
    public class GroupReport
    {
        public GroupReport(int idGroup, int idRelatorio)
        {
            IdGroup = idGroup;
            IdRelatorio = idRelatorio;
        }

        public int Id { get; set; }
        public int IdGroup { get; set; }
        public Group Group { get; set; }
        public int IdRelatorio { get; set; }
        public Report Relatorio { get; set; }
    }
}
