﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Classes;
using Spartane.Core.Data;
using Spartane.Core.Classes.StoredProcedure;
using Spartane.Data.EF;
using Spartane.Core.Classes.Tipo_Frecuencia_Notificacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Frecuencia_Notificacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_Frecuencia_NotificacionService : ITipo_Frecuencia_NotificacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> _Tipo_Frecuencia_NotificacionRepository;
        #endregion

        #region Ctor
        public Tipo_Frecuencia_NotificacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> Tipo_Frecuencia_NotificacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_Frecuencia_NotificacionRepository = Tipo_Frecuencia_NotificacionRepository;


        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return this._Tipo_Frecuencia_NotificacionRepository.Table.Count();
        }

        public IList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> SelAll(bool ConRelaciones)
        {
            return _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion>("sp_SelAllTipo_Frecuencia_Notificacion");
        }

        public IList<Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> SelAllComplete(bool ConRelaciones)
        {
            var data = _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.Sp_SelallTipo_Frecuencia_Notificacion_Complete>("sp_SelAllComplete_Tipo_Frecuencia_Notificacion");
            return data.Select(m => new Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion
            {
                Clave = m.Clave
                ,Descripcion = m.Descripcion


            }).ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            var padWhere = _dataProvider.GetParameter();
            padWhere.ParameterName = "Where";
            padWhere.DbType = DbType.String;
            padWhere.Value = Where;

            var rowCountData = _dbContext.ExecuteStoredProcedureList<Sp_ListSelCount_Tipo_Frecuencia_Notificacion>("sp_ListSelCount_Tipo_Frecuencia_Notificacion", padWhere);
            int rowCount = 0;
            if (rowCountData != null && rowCountData.Any())
                rowCount = rowCountData.FirstOrDefault().RowCount;
            return rowCount;
        }


        public IList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            try
            {
                var padreWhere = _dataProvider.GetParameter();
                padreWhere.ParameterName = "Where";
                padreWhere.DbType = DbType.String;

                padreWhere.Value = Where;

                var padreOrderBy = _dataProvider.GetParameter();
                padreOrderBy.ParameterName = "Order";
                padreOrderBy.DbType = DbType.String;
                padreOrderBy.Value = Order;


                var data = _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.SpListSelAllTipo_Frecuencia_Notificacion>("sp_ListSelAll_Tipo_Frecuencia_Notificacion", padreWhere, padreOrderBy);

                return data.Select(m => new Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion
                {
                    Clave = m.Tipo_Frecuencia_Notificacion_Clave,
                    Descripcion = m.Tipo_Frecuencia_Notificacion_Descripcion,

                    //Id = m.Id,
                }).ToList();
            }
            catch (ExceptionBase ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.Message, ex);
            }

        }

        public IList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_Frecuencia_NotificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_Frecuencia_NotificacionRepository.Table.Where(Where).ToList();
        }

        public Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_NotificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            var padstartRowIndex = _dataProvider.GetParameter();
            padstartRowIndex.ParameterName = "startRowIndex";
            padstartRowIndex.DbType = DbType.Int32;
            padstartRowIndex.Value = startRowIndex;

            var padmaximumRows = _dataProvider.GetParameter();
            padmaximumRows.ParameterName = "maximumRows";
            padmaximumRows.DbType = DbType.Int32;
            padmaximumRows.Value = maximumRows;

            var padWhere = _dataProvider.GetParameter();
            padWhere.ParameterName = "Where";
            padWhere.DbType = DbType.String;
            padWhere.Value = Where;

            var padOrder = _dataProvider.GetParameter();
            padOrder.ParameterName = "Order";
            padOrder.DbType = DbType.String;
            padOrder.Value = Order;

            var data = _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.SpListSelAllTipo_Frecuencia_Notificacion>("sp_ListSelAll_Tipo_Frecuencia_Notificacion", padWhere, padOrder, padstartRowIndex, padmaximumRows);

            Tipo_Frecuencia_NotificacionPagingModel result = null;

            if (data != null)
            {
                result = new Tipo_Frecuencia_NotificacionPagingModel
                {
                    Tipo_Frecuencia_Notificacions =
                        data.Select(m => new Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion
                {
                    Clave = m.Tipo_Frecuencia_Notificacion_Clave
                    ,Descripcion = m.Tipo_Frecuencia_Notificacion_Descripcion

                    //,Id = m.Id
                }).ToList()
                };
            }
            return result;

        }

        public IList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_Frecuencia_NotificacionRepository.Table.Where(Where).ToList();
        }

        public Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion GetByKey(int Key, bool ConRelaciones)
        {
            var padreKey = _dataProvider.GetParameter();
            padreKey.ParameterName = "Clave";
            padreKey.DbType = DbType.Int32;
            padreKey.Value = Key;

            return _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion>("sp_GetTipo_Frecuencia_Notificacion", padreKey).SingleOrDefault();
        }

        public bool Delete(int Key)
        {
            var rta = true;
            try
            {
                var padreKey = _dataProvider.GetParameter();
                padreKey.ParameterName = "Clave";
                padreKey.DbType = DbType.Int32;
                padreKey.Value = Key;

                var padreResult = _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.sp_DelTipo_Frecuencia_Notificacion>("sp_DelTipo_Frecuencia_Notificacion", padreKey).FirstOrDefault();
                if (padreResult != null)
                    rta = padreResult.Result.ToString() == "1";
            }
            catch (ExceptionBase ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.Message, ex);
            }

            return rta;
        }

        public int Insert(Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion entity)
        {
            int rta;
            try
            {

		var padreClave = _dataProvider.GetParameter();
                padreClave.ParameterName = "Clave";
                padreClave.DbType = DbType.Int32;
                padreClave.Value = (object)entity.Clave ?? DBNull.Value;
                var padreDescripcion = _dataProvider.GetParameter();
                padreDescripcion.ParameterName = "Descripcion";
                padreDescripcion.DbType = DbType.String;
                padreDescripcion.Value = (object)entity.Descripcion ?? DBNull.Value;
 

                var empEntity =
                    _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.sp_InsTipo_Frecuencia_Notificacion>("sp_InsTipo_Frecuencia_Notificacion" , padreDescripcion
).FirstOrDefault();

                rta = Convert.ToInt32(empEntity.Clave);

            }
            catch (ExceptionBase ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.Message, ex);
            }

            return rta;
        }

        public int Update(Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion entity)
        {
            int rta;
            try
            {

                var paramUpdClave = _dataProvider.GetParameter();
                paramUpdClave.ParameterName = "Clave";
                paramUpdClave.DbType = DbType.Int32;
                paramUpdClave.Value = (object)entity.Clave ?? DBNull.Value;
                var paramUpdDescripcion = _dataProvider.GetParameter();
                paramUpdDescripcion.ParameterName = "Descripcion";
                paramUpdDescripcion.DbType = DbType.String;
                paramUpdDescripcion.Value = (object)entity.Descripcion ?? DBNull.Value;


                var empEntity =
                    _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.sp_UpdTipo_Frecuencia_Notificacion>("sp_UpdTipo_Frecuencia_Notificacion" , paramUpdClave , paramUpdDescripcion ).FirstOrDefault();

                rta = Convert.ToInt32(empEntity.Clave);
            }
            catch (ExceptionBase ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.Message, ex);
            }

            return rta;
        }
		public int Update_Datos_Generales(Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion entity)
        {
            int rta;
            try
            {
                Spartane.Core.Classes.Tipo_Frecuencia_Notificacion.Tipo_Frecuencia_Notificacion Tipo_Frecuencia_NotificacionDB = GetByKey(entity.Clave, false);
                var paramUpdClave = _dataProvider.GetParameter();
                paramUpdClave.ParameterName = "Clave";
                paramUpdClave.DbType = DbType.Int32;
                paramUpdClave.Value = (object)entity.Clave ?? DBNull.Value;
                var paramUpdDescripcion = _dataProvider.GetParameter();
                paramUpdDescripcion.ParameterName = "Descripcion";
                paramUpdDescripcion.DbType = DbType.String;
                paramUpdDescripcion.Value = (object)entity.Descripcion ?? DBNull.Value;


                var empEntity =
                    _dbContext.ExecuteStoredProcedureList<Spartane.Core.Classes.StoredProcedure.sp_UpdTipo_Frecuencia_Notificacion>("sp_UpdTipo_Frecuencia_Notificacion" , paramUpdClave , paramUpdDescripcion ).FirstOrDefault();

                rta = Convert.ToInt32(empEntity.Clave);
            }
            catch (ExceptionBase ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new ServiceException(ex.Message, ex);
            }

            return rta;
        }


        #endregion
    }
}

