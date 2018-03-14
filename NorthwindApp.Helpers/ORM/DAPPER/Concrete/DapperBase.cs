using Dapper;
using NorthwindApp.Helpers.ORM.DAPPER.Abtract;
using NorthwindApp.Helpers.Utilities.Search;
using System.Collections.Generic;

namespace NorthwindApp.Repository.DAPPER.Concrete
{
    public class DapperBase<TEntity>
        : IBaseRepository<TEntity>
    {

        protected NorthwindApp.CORE.SQL.DAPPER.Execute<TEntity> ExecuteSQL;
        protected int EKS;

        public DapperBase()
        {
            ExecuteSQL = new CORE.SQL.DAPPER.Execute<TEntity>();
        }

        public virtual int Execute(string tanim, params QueryParam[] parametreler)
        {
            DynamicParameters parameters = new DynamicParameters();
            SetParameterValues(parametreler, parameters);
            return ExecuteSQL.ExecuteQuery(tanim, parameters);
        }

        public virtual TEntity Get(string tanim, params QueryParam[] parametreler)
        {
            DynamicParameters parameters = new DynamicParameters();
            SetParameterValues(parametreler, parameters);
            return ExecuteSQL.Get(tanim, parameters);
        }

        public virtual List<TEntity> GetList(string tanim, params QueryParam[] parametreler)
        {
            DynamicParameters parameters = new DynamicParameters();
            SetParameterValues(parametreler, parameters);
            return ExecuteSQL.GetList(tanim, parameters);
        }

        public virtual T Scalar<T>(string tanim, params QueryParam[] parametreler)
        {
            DynamicParameters parameters = new DynamicParameters();
            SetParameterValues(parametreler, parameters);
            return ExecuteSQL.Scalar<T>(tanim, parameters);
        }

        private static void SetParameterValues(QueryParam[] parametreler, DynamicParameters parameters)
        {
            if (parametreler != null)
            {
                foreach (QueryParam parametre in parametreler)
                {
                    parameters.Add(parametre.ParamName, parametre.ParamValue);
                }
            }
        }
    }
}
