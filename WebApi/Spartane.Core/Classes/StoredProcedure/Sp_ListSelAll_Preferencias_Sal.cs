﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Classes.StoredProcedure
{
   public class SpListSelAllPreferencias_Sal : BaseEntity
    {
        public Int64 RowNumber { get; set; }
        public int Preferencias_Sal_Clave { get; set; }
        public string Preferencias_Sal_Descripcion { get; set; }

    }
}
