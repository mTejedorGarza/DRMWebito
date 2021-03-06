﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Spartane.Web.Areas.Frontal.Models
{
    public class Detalle_Actividades_EventoModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Tipo_de_Actividad { get; set; }
        public string Tipo_de_ActividadDescripcion { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadEspecialidad { get; set; }
        public string Nombre_de_la_Actividad { get; set; }
        public string Descripcion { get; set; }
        public int? Quien_imparte { get; set; }
        public string Quien_imparteName { get; set; }
        public string Dia { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_fin { get; set; }
        public bool Tiene_receso { get; set; }
        public string Hora_inicio_receso { get; set; }
        public string Hora_fin_receso { get; set; }
        [Range(0, 9999999999)]
        public int? Duracion_maxima_por_paciente_mins { get; set; }
        public bool Cupo_limitado { get; set; }
        [Range(0, 9999999999)]
        public int? Cupo_maximo { get; set; }
        public int? Ubicacion { get; set; }
        public string UbicacionNombre { get; set; }
        public int? Estatus_de_la_Actividad { get; set; }
        public string Estatus_de_la_ActividadDescripcion { get; set; }

    }
	
	public class Detalle_Actividades_Evento_Datos_GeneralesModel
    {
        [Required]
        public int Folio { get; set; }
        public int? Tipo_de_Actividad { get; set; }
        public string Tipo_de_ActividadDescripcion { get; set; }
        public int? Especialidad { get; set; }
        public string EspecialidadEspecialidad { get; set; }
        public string Nombre_de_la_Actividad { get; set; }
        public string Descripcion { get; set; }
        public int? Quien_imparte { get; set; }
        public string Quien_imparteName { get; set; }
        public string Dia { get; set; }
        public string Hora_inicio { get; set; }
        public string Hora_fin { get; set; }
        public bool? Tiene_receso { get; set; }
        public string Hora_inicio_receso { get; set; }
        public string Hora_fin_receso { get; set; }
        [Range(0, 9999999999)]
        public int? Duracion_maxima_por_paciente_mins { get; set; }
        public bool? Cupo_limitado { get; set; }
        [Range(0, 9999999999)]
        public int? Cupo_maximo { get; set; }
        public int? Ubicacion { get; set; }
        public string UbicacionNombre { get; set; }
        public int? Estatus_de_la_Actividad { get; set; }
        public string Estatus_de_la_ActividadDescripcion { get; set; }

    }


}

