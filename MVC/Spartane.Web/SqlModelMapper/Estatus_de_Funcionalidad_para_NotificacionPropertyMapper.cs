﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spartane.Core.Domain.Estatus_de_Funcionalidad_para_Notificacion;

namespace Spartane.Web.SqlModelMapper
{
    public class Estatus_de_Funcionalidad_para_NotificacionPropertyMapper : ISqlPropertyMapper
    {
        public string GetPropertyName(string propertyName)
        {
            switch (propertyName)
            {
                case "Folio":
                    return "Estatus_de_Funcionalidad_para_Notificacion.Folio";
                case "Campo_para_Estatus":
                    return "Estatus_de_Funcionalidad_para_Notificacion.Campo_para_Estatus";
                case "Nombre_Fisico_del_Campo":
                    return "Estatus_de_Funcionalidad_para_Notificacion.Nombre_Fisico_del_Campo";
                case "Nombre_Fisico_de_la_Tabla":
                    return "Estatus_de_Funcionalidad_para_Notificacion.Nombre_Fisico_de_la_Tabla";

                default:
                    return propertyName;
            }
        }

        public SqlOperationType GetOperationType(string columnName)
        {
            var t = (typeof(Estatus_de_Funcionalidad_para_Notificacion).GetProperty(columnName));
            if ( t !=null && t.PropertyType.FullName.Contains(typeof(System.DateTime).Name))
                return SqlOperationType.Equals;
            else return SqlOperationType.Contains;
        }


        public string GetOperatorString(object value, string columnName)
        {


            var operatorCondition = GetOperationType(columnName);
            columnName = GetPropertyName(columnName);

            switch (operatorCondition)
            {
                case SqlOperationType.Contains:
                    return string.IsNullOrEmpty(Convert.ToString(value)) ? "" : columnName + " LIKE '%" + value + "%'";
                case SqlOperationType.Equals:
                    return Convert.ToString(value) == "0" || Convert.ToString(value) == "" ? "" : columnName + "='" + value + "'";

            }
            return null;
        }
    }
}

