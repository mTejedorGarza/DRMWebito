﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spartane.Core.Classes.Tipo_de_Recordatorio_Notificacion
{
    /// <summary>
    /// Tipo_de_Recordatorio_Notificacion table
    /// </summary>
    public class Tipo_de_Recordatorio_Notificacion: BaseEntity
    {
        public int Clave { get; set; }
        public string Descripcion { get; set; }


    }
}

