﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Classes.StoredProcedure
{
    public class Sp_SelallTipos_de_Vendedor_Complete : BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }
        public int? Clave_Rol { get; set; }

    }
}
