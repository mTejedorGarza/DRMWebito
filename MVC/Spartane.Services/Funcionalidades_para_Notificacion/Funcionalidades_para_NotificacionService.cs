﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Funcionalidades_para_Notificacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Funcionalidades_para_Notificacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Funcionalidades_para_NotificacionService : IFuncionalidades_para_NotificacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> _Funcionalidades_para_NotificacionRepository;
        #endregion

        #region Ctor
        public Funcionalidades_para_NotificacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> Funcionalidades_para_NotificacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Funcionalidades_para_NotificacionRepository = Funcionalidades_para_NotificacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> SelAll(bool ConRelaciones)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_NotificacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Funcionalidades_para_NotificacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Funcionalidades_para_NotificacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Funcionalidades_para_NotificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion entity, Spartane.Core.Domain.User.GlobalData Funcionalidades_para_NotificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Funcionalidades_para_Notificacion.Funcionalidades_para_Notificacion entity, Spartane.Core.Domain.User.GlobalData Funcionalidades_para_NotificacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

