﻿using ControleAcessso.API.Entities;

namespace ControleAcessso.API.Services.Interfaces
{
    public interface IRelatorioService
    {
        List<Report> GetAll();
    }
}
