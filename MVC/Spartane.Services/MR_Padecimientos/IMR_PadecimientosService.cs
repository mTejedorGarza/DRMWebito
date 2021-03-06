﻿using System;
using Spartane.Core.Domain.MR_Padecimientos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.MR_Padecimientos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMR_PadecimientosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.MR_Padecimientos.MR_PadecimientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.MR_Padecimientos.MR_Padecimientos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
