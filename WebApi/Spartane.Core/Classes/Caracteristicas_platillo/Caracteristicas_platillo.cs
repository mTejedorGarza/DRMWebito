﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spartane.Core.Classes.Caracteristicas_platillo
{
    /// <summary>
    /// Caracteristicas_platillo table
    /// </summary>
    public class Caracteristicas_platillo: BaseEntity
    {
        public int Folio { get; set; }
        public string Caracteristicas { get; set; }


    }
}

