﻿using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.MS_Sexo_Ejercicios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.MS_Sexo_Ejercicios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class MS_Sexo_EjerciciosService : IMS_Sexo_EjerciciosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> _MS_Sexo_EjerciciosRepository;
        #endregion

        #region Ctor
        public MS_Sexo_EjerciciosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> MS_Sexo_EjerciciosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._MS_Sexo_EjerciciosRepository = MS_Sexo_EjerciciosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> SelAll(bool ConRelaciones)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public IList<Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> SelAllComplete(bool ConRelaciones)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_EjerciciosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            MS_Sexo_EjerciciosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._MS_Sexo_EjerciciosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData MS_Sexo_EjerciciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios entity, Spartane.Core.Domain.User.GlobalData MS_Sexo_EjerciciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.MS_Sexo_Ejercicios.MS_Sexo_Ejercicios entity, Spartane.Core.Domain.User.GlobalData MS_Sexo_EjerciciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

