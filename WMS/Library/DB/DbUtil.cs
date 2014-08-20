using Devart.Data.Universal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;


namespace WMS
{


    /// <summary>
    /// Summary description for DbUtil
    /// </summary>
    public class DbUtil
    {

        private static string connstring = String.Empty;
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(connstring))
                    connstring = ConfigurationManager.ConnectionStrings["WMS.Properties.Settings.beroebo_wmsConnectionString"].ConnectionString;

                return connstring;
            }
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
            string sqlStatement = createSqlStatement(Tablename, null, 1, null, where);
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
            if (dRow.ItemArray.Length > 0)
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
            string sqlStatement = createSqlStatement(tableName, null, 1, null);
            string sqlStLastInsertID = "SELECT LAST_INSERT_ID()";

            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(sqlStatement, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();
                        command.Transaction = conn.BeginTransaction();

                        //fill dataset and take its first datatable
                        using (var adapter = new UniDataAdapter(command))
                        {
                            UniCommandBuilder bld = new UniCommandBuilder(adapter);

                            adapter.UpdateCommand = bld.GetUpdateCommand();
                            adapter.InsertCommand = bld.GetInsertCommand();
                            adapter.DeleteCommand = bld.GetDeleteCommand();

                            result = adapter.Update(dtable);

                        }
                        conn.Commit();

                    }
                    catch (Exception ex)
                    {
                        conn.Rollback();
                        //Log.writeError(ex);
                        if ("Concurrency violation: the UpdateCommand affected 0 of the expected 1 records." != ex.Message)
                        {
                            return -1;
                        }
                    }
                }
            }

            string res = execute(sqlStLastInsertID).MakeString();
            return result;
        }

        /// <summary>
        /// make insert/update for specific table
        /// </summary>
        /// <param name="tableName">table name</param>
        /// <param name="dtable">datatable with values </param>
        /// <returns></returns>
        public static int saveChanges(String tableName, DataTable dtable, ref long resID)
        {
            int result = 0;
            string sqlStatement = createSqlStatement(tableName, null, 1, null);
            string sqlStLastInsertID = "SELECT LAST_INSERT_ID()";

            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(sqlStatement, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();
                        command.Transaction = conn.BeginTransaction();

                        //fill dataset and take its first datatable
                        using (var adapter = new UniDataAdapter(command))
                        {
                            UniCommandBuilder bld = new UniCommandBuilder(adapter);
                            adapter.UpdateCommand = bld.GetUpdateCommand();
                            adapter.InsertCommand = bld.GetInsertCommand();
                            result = adapter.Update(dtable);

                        }

                        //Взима ID-то на въведеният запис
                        using (var commandLAST_ID = new UniCommand(sqlStLastInsertID, conn))
                        {


                            ///Log.Trace(sqlStLastInsertID); IFD DD



                            resID = commandLAST_ID.ExecuteScalar().MakeLong();

                        }

                        conn.Commit();

                    }
                    catch (Exception ex)
                    {
                        conn.Rollback();
                        //Log.writeError(ex);
                        if ("Concurrency violation: the UpdateCommand affected 0 of the expected 1 records." != ex.Message)
                        {
                            return -1;
                        }
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
                    }
                }
            }

            return result;
        }

        public static int saveChangesNoTran(String tableName, DataTable dtable)
        {
            int result = 0;
            string sqlStatement = "SELECT * FROM " + tableName;
            string sqlStLastInsertID = "SELECT LAST_INSERT_ID()";

            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(sqlStatement, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();
                        using (var adapter = new UniDataAdapter(command))
                        {
                            UniCommandBuilder bld = new UniCommandBuilder(adapter);

                            adapter.UpdateCommand = bld.GetUpdateCommand();
                            adapter.InsertCommand = bld.GetInsertCommand();
                            adapter.DeleteCommand = bld.GetDeleteCommand();

                            result = adapter.Update(dtable);
                            string res = execute(sqlStLastInsertID).MakeString();

                        }
                    }
                    catch (Exception ex)
                    {
                        //Log.writeError(ex);
                        return 0;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }

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
            return execute(sqlStatement, where);
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
            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(commandText, conn))
                {
                    //try to execute
                    try
                    {
                        conn.Open();
                        //  Log.Trace(commandText); IFD DD
                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());


                        processedCount = command.ExecuteScalar().MakeInt();
                    }
                    catch (Exception ex)
                    {
                        //Log.writeError(ex);

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

            if (null == columns)
            {
                //ако колоните не са подадени отвън, четем ги от базата
                DataTable dt = getTableSchema(TableName);

                columns = new String[dt.Columns.Count];
                int idc = 0;
                foreach (DataColumn item in dt.Columns)
                {
                    columns[idc++] = "`" + item.ColumnName + "`";
                }
            }
            //добавяме колоните към statement
            sqlStatement.Append(appendColumns(columns));

            sqlStatement.AppendFormat(" FROM {0} ", TableName);

            //generate where clause from params
            sqlStatement.Append(p_generateWhereClause(whereClause));

            //добавяме orderBy клаузата
            if (!String.IsNullOrEmpty(orderBy))
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
            string columns = string.Empty;
            if (dtColumns != null && dtColumns.Count() > 0)
            {
                columns = String.Join(",", dtColumns);
            }
            return columns;
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

            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(commandText.ToString(), conn))
                {
                    //try to execute
                    try
                    {
                        // Log.Trace(String.Format("DataTable:{0}", commandText)); IFD DD
                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());

                        conn.Open();

                        //fill dataset and take its first datatable
                        using (UniDataAdapter adapter = new UniDataAdapter(command))
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
                        //Log.writeError(ex);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                            conn.Dispose();
                        }
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
            DataSet schemaDS = new DataSet();

            String statement = "SELECT * FROM " + TableName;


            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand(statement.ToString(), conn))
                {
                    //try to execute
                    try
                    {
                        //  Log.Trace(String.Format("Table schema:{0}", statement)); IFD DD

                        conn.Open();
                        //fill dataset and take its first datatable
                        using (UniDataAdapter adapter = new UniDataAdapter(command))
                        {
                            adapter.Fill(schemaDS, 0, 1, TableName);

                        }
                    }
                    catch (Exception ex)
                    {
                        //Log.writeError(ex);
                    }
                }
            }
            if (schemaDS.Tables.Count == 0)
            {
                // throw new Exception("check");
            }

            return schemaDS.Tables[0];
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
            using (var conn = new UniConnection(ConnectionString))
            {
                using (var command = new UniCommand())
                {
                    //try to execute
                    try
                    {
                        command.Connection = conn;
                        command.CommandText = stProcName;
                        //  Log.Trace(String.Format("Stored Procedure:{0} ", stProcName)); IFD DD
                        command.CommandType = CommandType.StoredProcedure;

                        if (whereClause != null)
                            command.Parameters.AddRange(p_createParamList(whereClause).ToArray());

                        conn.Open();

                        UniDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            resultDT.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
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
        private static List<UniParameter> p_createParamList(WhereClause whereClause)
        {
            List<UniParameter> paramCol = null;
            //add all parameters to current command
            if (whereClause != null)
            {
                paramCol = new List<UniParameter>();
                for (int i = 0; i < whereClause.Count; i++)
                {

                    String Key = whereClause.ElementAt(i).Key;
                    valueObject Value = whereClause.ElementAt(i).Value as valueObject;


                    //if currnt value is string array , add parameters
                    if (Value.inValue.GetType().Name == (typeof(System.String[]).Name))
                    {
                        String[] columns = Value.inValue as String[];
                        for (int j = 0; j < columns.Length; j++)
                        {
                            //add parameters to command in format IN (:COLUMNNAME1,:COLUMNAME2....)
                            UniParameter parameter = new UniParameter(String.Format("{0}{1}", Key, j), columns[j]);
                            paramCol.Add(parameter);
                        }

                    }
                    //else add regular parameter
                    else
                    {

                        UniParameter parameter = new UniParameter(Key, Value.inValue);
                        paramCol.Add(parameter);
                    }
                    //  Log.Trace(String.Format("{0}. {1} = {2}", i, Key, Value)); IFD DD
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
                if (((valueObject)whereClause.ElementAt(i).Value).inValue.GetType().Name == (typeof(System.String[]).Name))
                {
                    whereBuilder.Append(createINString(whereClause.ElementAt(i)));
                }
                //regular parameter
                else
                {
                    valueObject whereValue = whereClause.ElementAt(i).Value as valueObject;

                    //create where clause : [ColumnName] [operator] @[parameter]
                    whereBuilder.AppendFormat(" {0} {1} @{0} ", whereClause.ElementAt(i).Key, whereValue.getOperationString());
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
        private static string createINString(KeyValuePair<string, valueObject> keyValuePair)
        {
            StringBuilder inString = new StringBuilder();
            String[] columnInParams = keyValuePair.Value.inValue as String[];

            //if in values array is empty - return
            if (columnInParams.Length == 0)
            {
                return string.Empty;
            }


            String columnName = keyValuePair.Key;
            //if column name starts with ! then we want to create NOT  IN clause
            if (columnName.StartsWith("!"))
            {
                //remove ! and add the columnName
                inString.AppendFormat(" {0} NOT IN ( ", columnName.Remove(0, 1));
            }
            else
            {
                inString.AppendFormat(" {0} IN ( ", columnName);
            }

            //inString.Append(String.Join(",",columnInParams));
            //create param List informat COLUMN IN ( :COLUMN1, :COLUMN2...)
            for (int j = 0; j < columnInParams.Length; j++)
            {
                inString.AppendFormat(" @{0}{1},", columnName, j);
            }

            //remove last  "AND "(4 characters)

            inString.Remove(inString.Length - 1, 1).Append(")");

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