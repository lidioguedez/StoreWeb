﻿using CNTI365.FACTUR.ENTITY.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNTI365.FACTUR.Models
{
    public class modelList
    {
        public List<ResponsePais> listPais { get; set; }
        public List<ResponseMoneda> listMoneda { get; set; }
        
    }
}