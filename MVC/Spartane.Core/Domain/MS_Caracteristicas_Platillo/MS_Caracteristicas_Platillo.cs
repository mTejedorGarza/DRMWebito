﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Platillos;
using Spartane.Core.Domain.Caracteristicas_platillo;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Spartane.Core.Domain.MS_Caracteristicas_Platillo
{
    /// <summary>
    /// MS_Caracteristicas_Platillo table
    /// </summary>
    public class MS_Caracteristicas_Platillo: BaseEntity
    {
        public int Folio { get; set; }
        public int? Folio_Platillos { get; set; }
        public int? Caracteristicas { get; set; }

        [ForeignKey("Folio_Platillos")]
        public virtual Spartane.Core.Domain.Platillos.Platillos Folio_Platillos_Platillos { get; set; }
        [ForeignKey("Caracteristicas")]
        public virtual Spartane.Core.Domain.Caracteristicas_platillo.Caracteristicas_platillo Caracteristicas_Caracteristicas_platillo { get; set; }

    }
	
	public class MS_Caracteristicas_Platillo_Datos_Generales
    {
                public int Folio { get; set; }
        public int? Folio_Platillos { get; set; }
        public int? Caracteristicas { get; set; }

		        [ForeignKey("Folio_Platillos")]
        public virtual Spartane.Core.Domain.Platillos.Platillos Folio_Platillos_Platillos { get; set; }
        [ForeignKey("Caracteristicas")]
        public virtual Spartane.Core.Domain.Caracteristicas_platillo.Caracteristicas_platillo Caracteristicas_Caracteristicas_platillo { get; set; }

    }


}

