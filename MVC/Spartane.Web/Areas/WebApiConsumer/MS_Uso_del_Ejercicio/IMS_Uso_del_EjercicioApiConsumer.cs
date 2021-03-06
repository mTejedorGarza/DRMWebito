﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Data;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.MS_Uso_del_Ejercicio
{
    public interface IMS_Uso_del_EjercicioApiConsumer
    {
        void SetAuthHeader(string token);
        Int32 SelCount();
        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> SelAll(Boolean ConRelaciones);
        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> SelAllComplete(Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio> GetByKey(int Key, Boolean ConRelaciones);
        ApiResponse<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_EjercicioPagingModel> GetByKeyComplete(int Key);
        ApiResponse<bool> Delete(int Key, Spartane.Core.Domain.User.GlobalData MS_Uso_del_EjercicioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Insert(Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio entity, Spartane.Core.Domain.User.GlobalData MS_Uso_del_EjercicioInformation, DataLayerFieldsBitacora DataReference);
        ApiResponse<Int32> Update(Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio entity, Spartane.Core.Domain.User.GlobalData MS_Uso_del_EjercicioInformation, DataLayerFieldsBitacora DataReference);

        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> SelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        ApiResponse<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_EjercicioPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        ApiResponse<IList<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio>> ListaSelAll(Boolean ConRelaciones, string Where);
		ApiResponse<int> GenerateID();
		ApiResponse<int> Update_Datos_Generales(Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio_Datos_Generales entity);
		ApiResponse<Spartane.Core.Domain.MS_Uso_del_Ejercicio.MS_Uso_del_Ejercicio_Datos_Generales> Get_Datos_Generales(string Key);


    }
}

