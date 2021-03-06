﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Notificaciones_PacienteModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Funcionalidad { get; set; }
        public string FuncionalidadFuncionalidad { get; set; }

    }
	
	public class Detalle_Notificaciones_Paciente_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Funcionalidad { get; set; }
        public string FuncionalidadFuncionalidad { get; set; }

    }


}

