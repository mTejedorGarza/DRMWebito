﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Spartan_Bitacora_SQL
{
    public interface ISpartan_Bitacora_SQLApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQLPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData Spartan_Bitacora_SQLInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL entity, Spartane.Core.Domain.User.GlobalData Spartan_Bitacora_SQLInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL entity, Spartane.Core.Domain.User.GlobalData Spartan_Bitacora_SQLInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQLPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.Spartan_Bitacora_SQL.Spartan_Bitacora_SQL>> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}

