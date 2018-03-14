using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace NorthwindApp.CORE.SQL.DAPPER
{
    public class Execute<TEntity>
    {
        SqlConnection _con;

        public Execute()
        {
            //Burada şifreleme olacak
            _con = new SqlConnection("Data source=ÇAĞRı-ÇAĞRı;initial catalog=NORTHWND;user Id=sa;password=hasan");
        }

        public List<TEntity> GetList(string query, object parameters)
        {
            return _con
                .Query<TEntity>(query, parameters, commandType: CommandType.StoredProcedure).ToList();
        }

        public TEntity Get(string query, object parameters)
        {
            return _con
                .QuerySingleOrDefault<TEntity>(query, parameters, commandType: CommandType.StoredProcedure);
        }

        public T Scalar<T>(string query, object parameters)
        {
            return (T)Convert.ChangeType(_con.ExecuteScalar(query, parameters, commandType: CommandType.StoredProcedure), typeof(T));
        }

        public int ExecuteQuery(string query, object parameters)
        {
            return _con
                .Execute(query, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
