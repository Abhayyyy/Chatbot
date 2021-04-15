using EmergencySite.ClassLibraries.Exception;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace EmergencySite.ClassLibraries.DataLayer
{
    public class DataLayerCommanMethod
    {
        SqlCommand _cmdObj;
        protected int Flage = 0;
        DataSet _dsObj;
        DataTable _dtObj;
        SqlDataAdapter _adptObj;

        #region Execute Procedure With Parameter Return Scalar Object
        public Object ExecuteProcedureWithParameterReturnScalar(string procedureName, ArrayList list)
        {
            _dtObj = new DataTable();
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection()) { CommandType = CommandType.StoredProcedure };
                _cmdObj.Parameters.Clear();

                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                DbConnection.OpenConnection();
                return _cmdObj.ExecuteScalar();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteProcedureWithParameterWithoutReturn] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        
        #region Execute Procedure With Parameter With Return
        public int ExecuteProcedureWithParameterWithReturn(string procedureName, ArrayList list)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                _cmdObj.Parameters.Clear();

                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                DbConnection.OpenConnection();
                return _cmdObj.ExecuteNonQuery();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteProcedureWithParameterWithoutReturn] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute Procedure With Parameter Without Return
        public void ExecuteProcedureWithParameterWithoutReturn(string procedureName, ArrayList list)
        {
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }
                DbConnection.OpenConnection();
                _cmdObj.ExecuteNonQuery();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterNew] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute Procedure Without Parameter and Return DataSet
        public DataSet ExecProcParameterDataSet(string procedureName)
        {
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                _adptObj = new SqlDataAdapter(_cmdObj);
                _dsObj = new DataSet();
                _adptObj.Fill(_dsObj);
                return _dsObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterDataSet] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }            
        }
        #endregion
        #region Execute Procedure With Parameter and Return DataSet
        public DataSet ExecProcParameterDataSet(string procedureName, ArrayList list)
        {            
            _dsObj = new DataSet();
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                _adptObj = new SqlDataAdapter(_cmdObj);                
                _adptObj.Fill(_dsObj);
                return _dsObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterDataSet] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute Procedure With Parameter and Return DataTable
        public DataTable ExecProcParameterDataTable(string procedureName, ArrayList list)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                _adptObj = new SqlDataAdapter(_cmdObj);
                _dtObj = new DataTable();
                _adptObj.Fill(_dtObj);
                return _dtObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterDataTable] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }            
        }

        public Task<DataTable> ExecProcParameterDataTableAsync(string procedureName, ArrayList list)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                { CommandType = CommandType.StoredProcedure };
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                _adptObj = new SqlDataAdapter(_cmdObj);
                _dtObj = new DataTable();
                Task.Factory.StartNew(() => _adptObj.Fill(_dtObj));
                return Task.FromResult<DataTable>(_dtObj);
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterDataTable] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }

        #endregion
        #region Execute Procedure WithOut Parameter and Return DataTable
        public DataTable ExecuteProcedureNoParameter(string procedureName)
        {            
            _dtObj = new DataTable();
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                _adptObj = new SqlDataAdapter(_cmdObj);
                _adptObj.Fill(_dtObj);
                return _dtObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteProcedureNoParameter] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion 
        #region Execute Procedure With Parameter and Return ScalarValue
        public string ExecProcScalarValue(string procedureName, ArrayList list)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }
                DbConnection.OpenConnection();
                return _cmdObj.ExecuteScalar().ToString();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcScalarValue] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion       
        #region Execute Procedure Without Parameter and return ScalarValue
        public string ExecProcParameterScalarValue(string procedureName)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};

                DbConnection.OpenConnection();
                return _cmdObj.ExecuteScalar().ToString();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcParameterScalarValue] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion 
        #region Execute Procedure With Parameter And Return String
        public string ExecuteProcedureWithParameterAndReturnString(string procedureName, ArrayList list)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(procedureName, DbConnection.GetDbConnection())
                    {CommandType = CommandType.StoredProcedure};
                _cmdObj.Parameters.Clear();
                foreach (SqlParameter parameter in list)
                {
                    _cmdObj.Parameters.Add(parameter);
                }

                var outputParameter = new SqlParameter("@outputParameter", SqlDbType.VarChar)
                    {Direction = ParameterDirection.Output};
                _cmdObj.Parameters.Add(outputParameter);

                DbConnection.OpenConnection();
                _cmdObj.ExecuteNonQuery();
                return outputParameter.Value.ToString();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteProcedureWithParameterAndReturnString] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion                
        #region Execute SQL Return Integer
        public int ExecuteSqlReturnInteger(string strQuery)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(strQuery, DbConnection.GetDbConnection()) {CommandType = CommandType.Text};
                DbConnection.OpenConnection();
                return _cmdObj.ExecuteNonQuery();
            }

            catch(System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteSQLReturnInteger] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }            
        }
        #endregion
        #region Execute SQL Without Return
        public void ExecuteSql(string strQuery)
        {
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(strQuery, DbConnection.GetDbConnection()) {CommandType = CommandType.Text};
                DbConnection.OpenConnection();
                _cmdObj.ExecuteNonQuery();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteSQL] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute SQL Return DataSet
        public DataSet ExecuteSqlReturnDataSet(string strQuery)
        {            
            _dsObj = new DataSet();
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(strQuery, DbConnection.GetDbConnection()) {CommandType = CommandType.Text};
                _adptObj = new SqlDataAdapter(_cmdObj);
                _adptObj.Fill(_dsObj);
                return _dsObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteSQLReturnDataSet] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute SQL Return DataTable
        public DataTable ExecuteSqlReturnDataTable(string strQuery)
        {            
            _dtObj = new DataTable();
            _cmdObj = new SqlCommand();
            try
            {
                _cmdObj = new SqlCommand(strQuery, DbConnection.GetDbConnection()) {CommandType = CommandType.Text};
                _adptObj = new SqlDataAdapter(_cmdObj);
                _adptObj.Fill(_dtObj);
                return _dtObj;
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecuteSQLReturnDataTable] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
        #region Execute Sql With Parameter and Return ScalarValue
        public string ExecSqlReturnScalarValue(string sqlQuery)
        {                        
            try
            {                
                _cmdObj = new SqlCommand(sqlQuery, DbConnection.GetDbConnection()) {CommandType = CommandType.Text};
                DbConnection.OpenConnection();
                return _cmdObj.ExecuteScalar().ToString();
            }

            catch (System.Exception ex)
            {
                throw new ExceptionClass("Class[DataLayerCommanMethods] " + "Methods[ExecProcScalarValue] " + ex.Message);
            }

            finally
            {
                DbConnection.CloseConnection();
                _cmdObj.Dispose();
            }
        }
        #endregion
    }
}
