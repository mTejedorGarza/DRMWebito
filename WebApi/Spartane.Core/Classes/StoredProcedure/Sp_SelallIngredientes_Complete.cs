﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Classes.StoredProcedure
{
    public class Sp_SelallIngredientes_Complete : BaseEntity
    {
        public int Clave { get; set; }
        public bool? Es_un_ingrediente_de_SMAE { get; set; }
        public int? Clasificacion { get; set; }
        public string Clasificacion_Descripcion { get; set; }
        public int? Subgrupo { get; set; }
        public string Subgrupo_Nombre { get; set; }
        public string Nombre_Ingrediente { get; set; }
        public string Ingrediente { get; set; }
        public int? Imagen { get; set; }
        public string Cantidad_sugerida { get; set; }
        public decimal? Cantidad_Sugerida_Decimal { get; set; }
        public int? Unidad { get; set; }
        public string Unidad_Unidad { get; set; }
        public decimal? Peso_bruto_redondeado_g { get; set; }
        public decimal? Peso_neto_g { get; set; }
        public int? Estatus { get; set; }
        public string Estatus_Descripcion { get; set; }

    }
}
