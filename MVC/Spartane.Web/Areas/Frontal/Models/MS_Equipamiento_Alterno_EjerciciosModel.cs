﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class MS_Equipamiento_Alterno_EjerciciosModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Equipamiento_Alterno { get; set; }
        public string Equipamiento_AlternoDescripcion { get; set; }

    }
	
	public class MS_Equipamiento_Alterno_Ejercicios_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Equipamiento_Alterno { get; set; }
        public string Equipamiento_AlternoDescripcion { get; set; }

    }


}

