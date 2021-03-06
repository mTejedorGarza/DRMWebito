﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Classes.Pais;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spartane.Core.Classes.Tiempos_de_Comida
{
    /// <summary>
    /// Tiempos_de_Comida table
    /// </summary>
    public class Tiempos_de_Comida: BaseEntity
    {
        public int Clave { get; set; }
        public string Comida { get; set; }
        public string Hora_min { get; set; }
        public string Hora_max { get; set; }
        public int? Pais { get; set; }

        [ForeignKey("Pais")]
        public virtual Spartane.Core.Classes.Pais.Pais Pais_Pais { get; set; }

    }
}

