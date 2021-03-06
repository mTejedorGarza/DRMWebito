﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Spartane.Core.Domain.Data;
using Spartane.Core.Domain.Registro_de_Asistencia_Telefonica;
using Spartane.Core.Domain.User;
using Spartane.Web.Areas.WebApiConsumer;
using Spartane.Web.Areas.WebApiConsumer.ResponseHelpers;

namespace Spartane.Web.Areas.WebApiConsumer.Registro_de_Asistencia_Telefonica
{
    public class Registro_de_Asistencia_TelefonicaApiConsumer : BaseApiConsumer,IRegistro_de_Asistencia_TelefonicaApiConsumer
    {
        public override sealed string ApiControllerUrl { get; set; }
        public string baseApi;

        public Registro_de_Asistencia_TelefonicaApiConsumer()
        {
            baseApi = ApiUrlManager.BaseUrlLocal;
            ApiControllerUrl = "/api/Registro_de_Asistencia_Telefonica";
        }
        public int SelCount()
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> SelAll(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(baseApi, ApiControllerUrl + "/GetAll",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(false, null);
            }

        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> SelAllComplete(bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<IList<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(baseApi, ApiControllerUrl + "/GetAllComplete",
                      Method.GET, ApiHeader);

                return new ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>>(false, null);
            }
        }

        public ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica> GetByKey(int Key, bool ConRelaciones)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>(baseApi, ApiControllerUrl + "/Get?Id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>(false, null);
            }
        }

        public ApiResponse<Registro_de_Asistencia_TelefonicaPagingModel> GetByKeyComplete(int Key)
        {
            try
            {
                    var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=1&maximumRows=1" 
                        + "&Where=Registro_de_Asistencia_Telefonica.Folio='" + Key.ToString() + "'"
                        + "&Order=Registro_de_Asistencia_Telefonica.Folio ASC",
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(true, varRecords);

            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(false, new Registro_de_Asistencia_TelefonicaPagingModel() { Registro_de_Asistencia_Telefonicas = null, RowCount = 0 });
            }
        }

        public ApiResponse<bool> Delete(int Key, Core.Domain.User.GlobalData Registro_de_Asistencia_TelefonicaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Insert(Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica entity, Core.Domain.User.GlobalData Registro_de_Asistencia_TelefonicaInformation, DataLayerFieldsBitacora DataReference)
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

        public ApiResponse<int> Update(Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica entity, Core.Domain.User.GlobalData Registro_de_Asistencia_TelefonicaInformation, DataLayerFieldsBitacora DataReference)
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Put?Id=" + entity.Folio,
                      Method.PUT, ApiHeader, entity);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> SelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<Registro_de_Asistencia_TelefonicaPagingModel> ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(baseApi, ApiControllerUrl + "/ListaSelAll?startRowIndex=" + startRowIndex +
                    "&maximumRows=" + maximumRows +
                    (string.IsNullOrEmpty(Where) ? "" : "&Where=" + Where) +
                     (string.IsNullOrEmpty(Order) ? "" : "&Order=" + Order),
                     Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(true, varRecords);


            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_TelefonicaPagingModel>(false, new Registro_de_Asistencia_TelefonicaPagingModel() { Registro_de_Asistencia_Telefonicas = null, RowCount = 0 });
            }
        }

        public ApiResponse<IList<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica>> ListaSelAll(bool ConRelaciones, string Where)
        {
            throw new NotImplementedException();
        }
		
		public ApiResponse<int> GenerateID()
        {
            try
            {
                var result = RestApiHelper.InvokeApi<int>(baseApi, ApiControllerUrl + "/Registro_de_Asistencia_TelefonicaGenerateID",
                      Method.GET, ApiHeader);

                return new ApiResponse<int>(true, result);
            }
            catch (Exception ex)
            {
                return new ApiResponse<int>(false, -1 );
            }
        }
		
public ApiResponse<int> Update_Datos_Generales(Registro_de_Asistencia_Telefonica_Datos_Generales entity)
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

        public ApiResponse<Registro_de_Asistencia_Telefonica_Datos_Generales> Get_Datos_Generales(string Key)
        {
            try
            {
                var varRecords = RestApiHelper.InvokeApi<Spartane.Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica_Datos_Generales>(baseApi, ApiControllerUrl + "/Get_Datos_Generales?id=" + Key,
                      Method.GET, ApiHeader);

                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica_Datos_Generales>(true, varRecords);
            }
            catch (Exception ex)
            {
                return new ApiResponse<Core.Domain.Registro_de_Asistencia_Telefonica.Registro_de_Asistencia_Telefonica_Datos_Generales>(false, null);
            }
        }


    }
}

