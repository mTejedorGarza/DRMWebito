﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Estado_Civil;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Estado_Civil
{
    public class Estado_CivilApiConsumer : BaseApiConsumer,IEstado_CivilApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Estado_CivilApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Estado_Civil";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estado_Civil.Estado_Civil>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Estado_Civil.Estado_Civil>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Estado_Civil.Estado_Civil> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estado_Civil.Estado_Civil>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estado_Civil.Estado_Civil>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estado_Civil.Estado_Civil>(false, null);
            }
        }

        public ApiResponse<Estado_CivilPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estado_Civil.Estado_CivilPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Estado_Civil.Clave='" + Key.ToString() + "'"
                        + "&Order=Estado_Civil.Clave ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estado_Civil.Estado_CivilPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estado_Civil.Estado_CivilPagingModel>(false, new Estado_CivilPagingModel() { Estado_Civils = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Estado_CivilInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<bool>(baseApi, ApiControllerUrl + "/Delete?Id=" + Key,
                      Method.DELETE, ApiHeader);

                return new ApiResponse<bool>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<bool>(false, false);
            }
        }

        public ApiResponse<int> Insert(Core.Domain.Estado_Civil.Estado_Civil entity, Core.Domain.User.GlobalData Estado_CivilInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Post",
                      Method.POST, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<int> Update(Core.Domain.Estado_Civil.Estado_Civil entity, Core.Domain.User.GlobalData Estado_CivilInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Clave,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Estado_CivilPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estado_Civil.Estado_CivilPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estado_Civil.Estado_CivilPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estado_Civil.Estado_CivilPagingModel>(false, new Estado_CivilPagingModel() { Estado_Civils = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Estado_Civil.Estado_Civil>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Estado_CivilGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Estado_Civil_Datos_Generales entity)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put_Datos_Generales",
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<Estado_Civil_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Estado_Civil.Estado_Civil_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Estado_Civil.Estado_Civil_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Estado_Civil.Estado_Civil_Datos_Generales>(false, null);
            }
        }


    }
}

