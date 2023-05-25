﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wepr0.core.DTO;
using wepr0.core.Model;

namespace wepr0.core.Interface.Service
{
    public interface IMoedaService
    {
        List<MoedaDTO> GetAllRegisters();
        MoedaDTO GetMoedaBySimbolo(string SimboloMoeda);
        MoedaDTO GetMoedaById(int IdMoeda);
        MoedaDTO Create(MoedaDTO moeda);
    }
}
