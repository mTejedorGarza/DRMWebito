﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Classes.Spartan_User;
using Spartane.Core.Classes.Spartane_File;
using Spartane.Core.Classes.Tipo_de_comida_platillos;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spartane.Core.Classes.Platillos
{
    /// <summary>
    /// Platillos table
    /// </summary>
    public class Platillos: BaseEntity
    {
        public int Folio { get; set; }
        public DateTime? Fecha_de_Registro { get; set; }
        public string Hora_de_Registro { get; set; }
        public int? Usuario_que_Registra { get; set; }
        public string Nombre_de_Platillo { get; set; }
        public int? Imagen { get; set; }
        //public string Imagen_URL { get; set; }
        public int? Tipo_de_comida { get; set; }
        public string Calificacion { get; set; }
        public string Modo_de_Preparacion { get; set; }

        [ForeignKey("Usuario_que_Registra")]
        public virtual Spartane.Core.Classes.Spartan_User.Spartan_User Usuario_que_Registra_Spartan_User { get; set; }
        [ForeignKey("Imagen")]
        public virtual Spartane.Core.Classes.Spartane_File.Spartane_File Imagen_Spartane_File { get; set; }
        [ForeignKey("Tipo_de_comida")]
        public virtual Spartane.Core.Classes.Tipo_de_comida_platillos.Tipo_de_comida_platillos Tipo_de_comida_Tipo_de_comida_platillos { get; set; }

    }
}

