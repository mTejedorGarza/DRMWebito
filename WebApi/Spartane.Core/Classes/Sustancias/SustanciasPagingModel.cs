﻿using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartane.Core.Classes.Sustancias
{
    public class SustanciasPagingModel
    {
        public List<Spartane.Core.Classes.Sustancias.Sustancias> Sustanciass { set; get; }
        public int RowCount { set; get; }
    }
}
