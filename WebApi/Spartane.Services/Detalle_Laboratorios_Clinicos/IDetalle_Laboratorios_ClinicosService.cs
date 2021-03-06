﻿using System;
using Spartane.Core.Classes.Detalle_Laboratorios_Clinicos;
using System.Collections.Generic;


namespace Spartane.Services.Detalle_Laboratorios_Clinicos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Laboratorios_ClinicosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key);
        Int32 Insert(Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos entity);
        Int32 Update(Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos entity);
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_ClinicosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos> ListaSelAll(Boolean ConRelaciones, string Where);
              int Update_Datos_Generales(Spartane.Core.Classes.Detalle_Laboratorios_Clinicos.Detalle_Laboratorios_Clinicos entity);

    }
}
