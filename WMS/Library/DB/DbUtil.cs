
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;



/// <summary>
/// Клас за объщение към базата
/// </summary>
/// 
namespace WMS
{
    public static class DbUtil
    {

        private static string connstring = String.Empty;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(connstring))
                    connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

                connstring = GetFilePathFromConnectionString(connstring);
                return connstring;
            }
        }

        public static string GetFilePathFromConnectionString(string connectionString)
        {
            string attachDbFileName = connectionString;
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            return attachDbFileName.Replace("|DataDirectory|", path);
        }

        /// <summary>
        /// Execute sql statement. 
        /// Unnamed parameters are used
        /// </summary>
        /// <param name="commandText">Full sql statement</param>
        /// <param name="inParams">unnamed params</param>
        /// <returns>count of processed records</returns>
        public static int execute(String commandText, params Object[] inParams)
        {
            return execute(commandText, p_convertToWhereClause(inParams));
        }
        /// <summary>
        /// get first row for tableName specified
        /// </summary>
        /// <param name="Tablename"></param>
        /// <param name="whereClause">named parameters</param>
        /// <returns></returns>
        public static DataRow getFirstRowForTable(String Tablename, WhereClause where = null)
        {
            string sqlStatement = createSqlStatement(Tablename, null, 0, null, where);
            return getFirstRow(sqlStatement, where);
        }
        /// <summary>
        /// get first row for specific sql statement
        /// </summary>
        /// <param name="commandText">full sql statement</param>
        /// <param name="whereClause">named parameters</param>
        /// <returns></returns>
        public static DataRow getFirstRow(String commandText, WhereClause where = null)
        {
            DataTable dTable = getDataTable(commandText, where);
            if (dTable.Rows.Count > 0)
            {
                return dTable.Rows[0];
            }
            return null;
        }

        /// <summary>
        /// returns first value of first row
        /// </summary>
        /// <param name="commandText">full sql statement</param>
        /// <param name="inParams">input params</param>
        /// <returns>object from db</returns>
        public static Object getValue(String commandText, params Object[] inParams)
        {
            return getValue(commandText, p_convertToWhereClause(inParams));

        }
        /// <summary>
        /// returns first value of first row
        /// </summary>
        /// <param name="commandText">full sql statement</param>
        /// <param name="whereClause">named parameters</param>
        /// <returns></returns>
        public static Object getValue(String commandText, WhereClause where = null)
        {
            DataRow dRow = getFirstRow(commandText, where);
            if (dRow.ItemArray.Rank > 0)
                return dRow[0];
            return null;
        }
        /// <summary>
        /// record count for sql statement
        /// </summary>
        /// <param name="commandText">full sql statement</param>
        /// <param name="where"> named params</param>
        /// <returns>count of records</returns>
        public static int countForSql(String commandText, WhereClause where = null)
        {
            return getDataTable(commandText, where).Rows.Count;
        }
        /// <summary>
        /// get record count for specific talbe
        /// </summary>
        /// <param name="TableName"> table name</param>
        /// <param name="where"> filter parameters</param>
        /// <returns>record count</returns>
        public static int countForTable(String TableName, WhereClause where = null)
        {
            return getDataTableForTableName(TableName, null, 0, where).Rows.Count;
        }

        /// <summary>
        /// make insert/update for specific table
        /// </summary>
        /// <param name="tableName">table name</param>
        /// <param name="dtable">datatable with values </param>
        /// <returns></returns>
        public static int saveChanges(String tableName, DataTable dtable)
        {
            int result = 0;
            string sqlStatement = createSqlStatement(tableName, null, 0, null);
            //   string sqlStLastInsertID = "SELECT LAST_INSERT_ID()";

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(sqlStatement, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();
                        //     conn.BeginTransaction();

                        //fill dataset and take its first datatable
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            SqlCommandBuilder bld = new SqlCommandBuilder(adapter);
                            adapter.UpdateCommand = bld.GetUpdateCommand();
                            adapter.InsertCommand = bld.GetInsertCommand();
                            result = adapter.Update(dtable);

                        }


                    }
                    catch (Exception ex)
                    {
                        System.IO.StreamWriter stringWriter = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "ErrorLog.txt");


                        stringWriter.WriteLine("saveChangesException: " + ex); // Write text to textfile. 

                        stringWriter.Close();
                        // throw ex);
                        return 0;
                    }
                }
            }

            //  string res = execute(sqlStLastInsertID).MakeString();
            return result;
        }
        /// <summary>
        /// delete from specific table 
        /// </summary>
        /// <param name="tableName">table name</param>
        /// <param name="where"> where clause params</param>
        /// <returns>processed records count</returns>
        public static int delete(String tableName, WhereClause where = null)
        {
            string sqlStatement = createDeleteStatement(tableName, where);
            return execute(sqlStatement);
        }

        /// <summary>
        /// delete from specific table 
        /// </summary>
        /// <param name="tableName">table name</param>
        /// <param name="where"> where clause params</param>
        /// <returns>processed records count</returns>
        public static int delete(String tableName, params Object[] inParams)
        {
            string sqlStatement = createDeleteStatement(tableName, p_convertToWhereClause(inParams));
            return execute(sqlStatement);
        }


        /// <summary>
        /// Execute sql statment.
        /// Named parameters are used
        /// </summary>
        /// <param name="commandText">Full sql statment</param>
        /// <param name="whereClause">named parameters</param>
        /// <returns></returns>
        public static int execute(String commandText, WhereClause whereClause = null)
        {
            int processedCount = 0;
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(commandText, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();

                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());


                        processedCount = command.ExecuteScalar().MakeInt();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        System.IO.StreamWriter stringWriter = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory+"ErrorLog.txt");


                        stringWriter.WriteLine("execute Exception: " + ex); // Write text to textfile. 

                        stringWriter.Close();

                    }
                }
            }
            return processedCount;
        }

        /// <summary>
        /// get datatable for specific sql statement with unnamed parameters
        /// </summary>
        /// <param name="commandText">full sql statment. Parameters are</param>
        /// <param name="inParams">unnamed params</param>
        /// <returns>DataTable</returns>
        public static DataTable getDataTable(String commandText, params Object[] inParams)
        {
            return getDataTable(commandText, p_convertToWhereClause(inParams));
        }
        /// <summary>
        /// get all records for specific table
        /// </summary>
        /// <param name="TableName">table name</param>
        /// <param name="columns">columns for datatable</param>
        /// <param name="rowLimit">rowLimit for datatable</param>
        /// <param name="whereClause">where clause</param>
        /// <returns>DataTable</returns>
        public static DataTable getDataTableForTableName(String TableName, String[] columns, int rowLimit, WhereClause whereClause = null)
        {
            String statement = createSqlStatement(TableName, columns, rowLimit, null, whereClause);

            return getDataTable(statement, whereClause);
        }
        /// <summary>
        /// get all records for specific table
        /// </summary>
        /// <param name="TableName">table name</param>
        /// <param name="columns">columns for datatable</param>
        /// <param name="rowLimit">rowLimit for datatable</param>
        /// <param name="orderBy">order by clause </param>
        /// <param name="whereClause">where clause</param>
        /// <returns>DataTable</returns>
        public static DataTable getDataTableForTableName(String TableName, String[] columns, int rowLimit, String orderBy, WhereClause whereClause = null)
        {
            String statement = createSqlStatement(TableName, columns, rowLimit, orderBy, whereClause);

            return getDataTable(statement, whereClause);
        }
        /// <summary>
        /// create sql statement
        /// </summary>
        /// <param name="TableName">table name</param>
        /// <param name="columns"> array of columns</param>
        /// <param name="rowLimit">row limit </param>
        /// <param name="orderBy">order by clause </param>
        /// <param name="whereClause">where clause</param>
        /// <returns></returns>
        private static String createSqlStatement(String TableName, String[] columns, int rowLimit, String orderBy, WhereClause whereClause = null)
        {
            StringBuilder sqlStatement = new StringBuilder("SELECT ");

            //add all required columns to sql statement
            if (columns != null)
            {
                sqlStatement.Append(appendColumns(columns));
            }
            else
            {
                //ако колоните не са подадени отвън, четем ги от базата
                DataTable dt = getDataTable("SELECT * FROM " + TableName);

                columns = new String[dt.Columns.Count];
                int idc = 0;
                foreach (DataColumn item in dt.Columns)
                {
                    columns[idc++] = item.ColumnName;
                }
            }
            //добавяме колоните към statement
            sqlStatement.Append(appendColumns(columns));

            sqlStatement.AppendFormat(" FROM {0} ", TableName);

            //generate where clause from params
            sqlStatement.Append(p_generateWhereClause(whereClause));

            //добавяме orderBy клаузата
            if (String.IsNullOrEmpty(orderBy))
            {
                sqlStatement.Append(orderBy);
            }

            //set row limit 
            sqlStatement.Append(addRowLimit(rowLimit));
            return sqlStatement.ToString();
        }

        /// <summary>
        /// create delete sql statement
        /// </summary>
        /// <param name="TableName">table name</param>
        /// <param name="columns"> array of columns</param>
        /// <param name="rowLimit">row limit </param>
        /// <param name="orderBy">order by clause </param>
        /// <param name="whereClause">where clause</param>
        /// <returns></returns>
        private static String createDeleteStatement(String TableName, WhereClause whereClause)
        {
            StringBuilder sqlStatement = new StringBuilder("DELETE ");

            sqlStatement.AppendFormat(" FROM {0} ", TableName);

            //generate where clause from params
            sqlStatement.Append(p_generateWhereClause(whereClause));


            return sqlStatement.ToString();
        }

        private static string appendColumns(string[] dtColumns)
        {
            StringBuilder stBuild = new StringBuilder();
            if (dtColumns != null && dtColumns.Count() > 0)
            {
                foreach (String columnName in dtColumns)
                {
                    stBuild.AppendFormat(" {0},", columnName);
                }
                //remove last comma
                stBuild = stBuild.Remove(stBuild.Length - 1, 1);
            }
            return stBuild.ToString();
        }

        /// <summary>
        /// get datatable for specific sql statement
        /// </summary>
        /// <param name="commandText"> full sql statemnent</param>
        /// <param name="whereClause"> input parameters.Parameters must be marked with '@' in sql query</param>
        /// <returns>DataTable</returns>
        public static DataTable getDataTable(String commandText, WhereClause whereClause = null)
        {
            DataTable resultDT = new DataTable();

            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(commandText.ToString(), conn))
                {
                    //try to execute
                    try
                    {
                        // Log.Trace(String.Format("DataTable:{0}", commandText));
                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());

                        conn.Open();

                        //fill dataset and take its first datatable
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds, "DbUtilTable");
                            if (ds.Tables.Count > 0)
                            {
                                resultDT = ds.Tables["DbUtilTable"];
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;

                        System.IO.StreamWriter stringWriter = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "ErrorLog.txt");


                        stringWriter.WriteLine("getDataTable Exception: " + ex); // Write text to textfile. 

                        stringWriter.Close();
                        //Log.writeError(ex);
                    }
                }
            }
            return resultDT;
        }

        /// <summary>
        /// get table schema for table specified
        /// </summary>
        /// <param name="TableName">db table name</param>
        /// <returns> data schema</returns>
        public static DataTable getTableSchema(String TableName)
        {
            DataTable schemaDT = new DataTable();

            String statement = createSqlStatement(TableName, null, 0, null);


            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand(statement.ToString(), conn))
                {
                    //try to execute
                    try
                    {
                        //  Log.Trace(String.Format("Table schema:{0}", statement));
                        conn.Open();

                        schemaDT = command.ExecuteReader().GetSchemaTable();
                    }
                    catch (Exception ex)
                    {
                        System.IO.StreamWriter stringWriter = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "ErrorLog.txt");


                        stringWriter.WriteLine("Exception: " + ex); // Write text to textfile. 

                        stringWriter.Close();
                        //Log.writeError(ex);
                    }
                }
            }
            return schemaDT;
        }
        /// <summary>
        /// execute stored procedure
        /// </summary>
        /// <param name="stProcName">Stored Procedure const name from StProc.cs file </param>
        /// <param name="whereClause"> parameters </param>
        /// <returns>DataTable</returns>
        public static DataTable execStoredProc(String stProcName, WhereClause whereClause = null)
        {
            DataTable resultDT = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    //try to execute
                    try
                    {
                        command.Connection = conn;
                        command.CommandText = stProcName;
                        // Log.Trace(String.Format("Stored Procedure:{0} ", stProcName));
                        command.CommandType = CommandType.StoredProcedure;

                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());

                        conn.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            resultDT.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                        //Log.writeError(ex);
                    }
                }
            }
            return resultDT;
        }




        #region HelpFunctions
        /// <summary>
        /// bind all UNNAMED parameters to sql statement
        /// </summary>
        /// <param name="inParams"></param>
        /// <returns></returns>
        private static WhereClause p_convertToWhereClause(object[] inParams)
        {
            WhereClause paramsDict = new WhereClause();
            //create parameter collection
            if (inParams != null
                && inParams.Count() > 0)
            {
                for (int i = 0; i < inParams.Count(); i++)
                {
                    paramsDict.Add("Param" + i, inParams[i]);
                }

            }
            return paramsDict;
        }


        /// <summary>
        /// bind NAMED parameters to sql statement
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        private static List<SqlParameter> p_createParamList(WhereClause whereClause)
        {
            List<SqlParameter> paramCol = null;
            //add all parameters to current command
            if (whereClause != null)
            {
                paramCol = new List<SqlParameter>();
                for (int i = 0; i < whereClause.Count; i++)
                {

                    String Key = whereClause.ElementAt(i).Key;
                    Object Value = whereClause.ElementAt(i).Value;
                    SqlParameter parameter = new SqlParameter(Key, Value);
                    paramCol.Add(parameter);
                    //Log.Trace(String.Format("{0}. {1} = {2}", i, Key, Value));
                }

            }
            return paramCol;
        }

        /// <summary>
        /// create where string from params
        /// </summary>
        /// <param name="whereClause"> params collection</param>
        /// <returns> converted string </returns>
        private static String p_generateWhereClause(WhereClause whereClause)
        {
            StringBuilder whereBuilder = new StringBuilder();
            //generate where clause
            if (whereClause == null)
            {
                return whereBuilder.ToString();
            }

            whereBuilder.Append(" WHERE ");
            //convert all columns from whereParameter to where clause
            // as result we have WHERE col1 = @col1 and col2 = @col2......
            for (int i = 0; i < whereClause.Count; i++)
            {

                //if current paramater is a string array , then we have IN clause.
                //example : columnName IN ( value1, value2)...
                if (whereClause.ElementAt(i).Value.GetType().Name == (typeof(System.String[]).Name))
                {
                    whereBuilder.Append(createINString(whereClause.ElementAt(i)));
                }
                //regular parameter
                else
                {
                    whereBuilder.AppendFormat(" {0} = @{0} ", whereClause.ElementAt(i).Key);
                }
                whereBuilder.Append(" AND ");
            }
            //remove last  "AND "(4 characters)
            whereBuilder.Remove(whereBuilder.Length - 4, 4);

            return whereBuilder.ToString();
        }

        /// <summary>
        /// create IN string in where clause
        /// </summary>
        /// <param name="keyValuePair"></param>
        /// <returns> complete IN string clause</returns>
        private static string createINString(KeyValuePair<string, object> keyValuePair)
        {
            StringBuilder inString = new StringBuilder();
            String[] columnInParams = keyValuePair.Value as String[];
            String columnName = keyValuePair.Key;
            //if column name starts with ! then we want to create NOT  IN clause
            if (columnName.StartsWith("!"))
            {
                //remove ! and add the columnName
                inString.AppendFormat(" {0} IN ( ", columnName.Remove(0, 1));
            }
            else
            {
                inString.AppendFormat(" {0} IN ( ", columnName);
            }


            for (int j = 0; j < columnInParams.Length; j++)
            {
                inString.AppendFormat(" {0},", columnInParams[j]);
            }
            //replace last comma with ')'
            inString.Replace(',', ')', inString.Length - 1, 1);
            return inString.ToString();
        }


        private static String addRowLimit(int rowLimit)
        {
            if (rowLimit > 0)
            {
                return " LIMIT " + rowLimit;
            }
            return string.Empty;
        }

        #endregion

    }

}