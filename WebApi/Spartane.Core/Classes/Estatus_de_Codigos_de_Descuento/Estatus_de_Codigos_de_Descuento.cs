﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spartane.Core.Classes.Estatus_de_Codigos_de_Descuento
{
    /// <summary>
    /// Estatus_de_Codigos_de_Descuento table
    /// </summary>
    public class Estatus_de_Codigos_de_Descuento: BaseEntity
    {
        public int Folio { get; set; }
        public string Nombre { get; set; }


    }
}

