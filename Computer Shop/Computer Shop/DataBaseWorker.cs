using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;

namespace Computer_Shop
{
    internal class DataBaseWorker
    {
        DataBase dataBase = null;
        Dictionary<string, string[]> tableColumns = new Dictionary<string, string[]>();
        Dictionary<string, string[]> tableColumnsWithId = new Dictionary<string, string[]>();

        public DataBaseWorker()
        {
            dataBase = DataBase.getInstance();
            tableColumns.Add("Сотрудники", new string[] { "Фамилия", "Имя", "Отчество", "Должность", "Телефон", "Логин", "Пароль" });
            tableColumns.Add("Поставщики", new string[] { "НазваниеКомпании", "Адрес", "ЭлПочта", "НомерТелефона" });
            tableColumns.Add("Должности", new string[] { "Должность", "Зарплата", "ЛокацияРаботы" });
            tableColumns.Add("Заказы", new string[] { "IDТовара", "ФамилияЗаказчика", "АдресДоставки", "ТелефонЗаказчика", "ДатаЗаказа", "СтатусЗаказа" });
            tableColumns.Add("Отмены", new string[] { "IDЗаказа" });
            tableColumns.Add("Поломки", new string[] { "IDМастера", "IDТовара", "ДатаПоломки", "ПодлежитПочинке" });
            tableColumns.Add("Поставки", new string[] { "IDПоставщика", "IDТовара", "ДатаПоставки", "КоличествоТовара" });
            tableColumns.Add("Ревизии", new string[] { "ДатаРевизии", "ОтветственныйСотрудник", "Недостача" });
            tableColumns.Add("ТипыТоваров", new string[] { "ТипТовара", "ПроцентНакрутки", "ТехСложныйТовар" });
            tableColumns.Add("Товары", new string[] { "НазваниеТовара", "ТипТовара", "ЦенаЗакупки", "ЦенаПродажи", "КоличествоНаСкладе" });
            tableColumns.Add("ТоварыКлиент", new string[] { "НазваниеТовара", "ТипТовара" });

            tableColumnsWithId.Add("Сотрудники", new string[] { "IDСотрудника", "Фамилия", "Имя", "Отчество", "Должность", "Телефон", "Логин", "Пароль" });
            tableColumnsWithId.Add("Поставщики", new string[] { "IDПоставщика", "НазваниеКомпании", "Адрес", "ЭлПочта", "НомерТелефона" });
            tableColumnsWithId.Add("Должности", new string[] { "Должность", "Зарплата", "ЛокацияРаботы" });
            tableColumnsWithId.Add("Заказы", new string[] { "IDЗаказа", "IDТовара", "ФамилияЗаказчика", "АдресДоставки", "ТелефонЗаказчика", "ДатаЗаказа", "СтатусЗаказа" });
            tableColumnsWithId.Add("Отмены", new string[] { "IDОтмены", "IDЗаказа" });
            tableColumnsWithId.Add("Поломки", new string[] { "IDПоломки", "IDМастера", "IDТовара", "ДатаПоломки", "ПодлежитПочинке" });
            tableColumnsWithId.Add("Поставки", new string[] { "IDпоставки", "IDПоставщика", "IDТовара", "ДатаПоставки", "КоличествоТовара" });
            tableColumnsWithId.Add("Ревизии", new string[] { "IDРевизии", "ДатаРевизии", "ОтветственныйСотрудник", "Недостача" });
            tableColumnsWithId.Add("ТипыТоваров", new string[] { "ТипТовара", "ПроцентНакрутки", "ТехСложныйТовар" });
            tableColumnsWithId.Add("Товары", new string[] { "IDТовара", "НазваниеТовара", "ТипТовара", "ЦенаЗакупки", "ЦенаПродажи", "КоличествоНаСкладе" });
            tableColumnsWithId.Add("ТоварыКлиент", new string[] { "IDТовара", "НазваниеТовара", "ТипТовара" });
        }

        public System.Data.DataTable select(string select)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();

            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }

        public DataTable selectAllTable(string table)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();
            DataTable dataTable = new DataTable();

            StringBuilder sb = new StringBuilder("SELECT ");
            foreach (string column in tableColumnsWithId[table])
            {
                sb.Append($"{column}, ");
            }
            sb.Remove((sb.Length - 2), 2);
            sb.Append($" FROM {table}");
            SqlCommand command = new SqlCommand(sb.ToString(), connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            dataBase.closeConnection();
            return dataTable;
        }

        public bool checkInstance(string table, string column, string data)
        {
            if (!tableColumns.ContainsKey(table))
                return false;
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();

            DataTable dataTable = new System.Data.DataTable();
            SqlCommand command;

            StringBuilder sb = new StringBuilder("SELECT ");
            foreach (string column1 in tableColumnsWithId[table])
            {
                sb.Append($"{column1}, ");
            }
            sb.Remove((sb.Length - 2), 2);
            sb.Append($" FROM {table} WHERE {column} = '{data}'");
            command = new SqlCommand(sb.ToString(), connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataBase.closeConnection();
                return true;
            }
            dataBase.closeConnection();
            return false;
        }

        public bool checkInstance(string table, string column, int data)
        {
            if (!tableColumns.ContainsKey(table))
                return false;
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();

            DataTable dataTable = new DataTable();
            SqlCommand command;

            StringBuilder sb = new StringBuilder("SELECT ");
            foreach (string column1 in tableColumnsWithId[table])
            {
                sb.Append($"{column1}, ");
            }
            sb.Remove((sb.Length - 2), 2);
            sb.Append($" FROM {table} WHERE {column} = {data}");
            command = new SqlCommand(sb.ToString(), connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataBase.closeConnection();
                return true;
            }
            dataBase.closeConnection();
            return false;
        }

        public DataTable checkInstanceGetTable(string table, string column, string data)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();

            DataTable dataTable = new DataTable();
            SqlCommand command;

            StringBuilder sb = new StringBuilder("SELECT ");
            foreach (string column1 in tableColumnsWithId[table])
            {
                sb.Append($"{column1}, ");
            }
            sb.Remove((sb.Length - 2), 2);
            sb.Append($" FROM {table} WHERE {column} = '{data}'");
            command = new SqlCommand(sb.ToString(), connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            dataBase.closeConnection();
            return dataTable;
        }

        public DataTable checkInstanceGetTable(string table, string column, int data)
        {
            dataBase.openConnection();
            SqlConnection connection = dataBase.getConnection();

            DataTable dataTable = new DataTable();
            SqlCommand command;
            StringBuilder sb = new StringBuilder("SELECT ");
            foreach (string column1 in tableColumnsWithId[table])
            {
                sb.Append($"{column1}, ");
            }
            sb.Remove((sb.Length - 2), 2);
            sb.Append($" FROM {table} WHERE {column} = {data}");
            command = new SqlCommand(sb.ToString(), connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            dataBase.closeConnection();
            return dataTable;
        }

        public bool insertRow(string table, object[] datas)
        {
            try
            {
                if (!tableColumns.ContainsKey(table))
                    return false;

                string[] columns = tableColumns[table];
                if (columns.Length != datas.Length)
                    return false;

                StringBuilder stringBuilder = new StringBuilder();
                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                stringBuilder.Append($"INSERT INTO {table} (");
                foreach (string column in columns)
                {
                    stringBuilder.Append(column + " ,");
                }
                stringBuilder.Remove((stringBuilder.Length - 2), 2);
                stringBuilder.Append(") VALUES (");
                foreach (object data in datas)
                {
                    if (data.GetType() == typeof(int))
                    {
                        stringBuilder.Append($"{data}, ");
                    }
                    else
                        stringBuilder.Append($"'{data}' ,");
                }
                stringBuilder.Remove(stringBuilder.Length - 2, 2);
                stringBuilder.Append(")");

                SqlCommand command = new SqlCommand(stringBuilder.ToString(), connection);

                if (command.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deleteRow(string tableName, string columnName, object data)
        {
            try
            {
                if (!tableColumns.ContainsKey(tableName))
                    return 0;

                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                SqlCommand command = null;
                if (data.GetType() == typeof(int))
                {
                    command = new SqlCommand($"DELETE FROM {tableName} WHERE {columnName} = {data}", connection);
                }
                else
                {
                    command = new SqlCommand($"DELETE FROM {tableName} WHERE {columnName} = '{data}'", connection);
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int decrementRow(string tableName, string columnName, object wasData, string newColumnName)
        {
            try
            {
                if (!tableColumns.ContainsKey(tableName))
                    return 0;

                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                SqlCommand command = null;
                if (wasData.GetType() == typeof(int))
                {
                    command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} - 1 WHERE {columnName} = {wasData}", connection);
                }
                else
                {
                    command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} - 1 WHERE {columnName} = '{wasData}'", connection);
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int plusRow(string tableName, string columnName, object wasData, string newColumnName, int count)
        {
            try
            {
                if (!tableColumns.ContainsKey(tableName))
                    return 0;

                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                SqlCommand command = null;
                if (wasData.GetType() == typeof(int))
                {
                    if (count >= 0)
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} + {count} WHERE {columnName} = {wasData}", connection);
                    }
                    else
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} - {-count} WHERE {columnName} = {wasData}", connection);
                    }
                }
                else
                {
                    if (count >= 0)
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} + {count} WHERE {columnName} = '{wasData}'", connection);
                    }
                    else
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newColumnName} - {-count} WHERE {columnName} = '{wasData}'", connection);
                    }

                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updateRow(string tableName, string columnName, object wasData, string newColumnName, object newData)
        {
            try
            {
                if (!tableColumns.ContainsKey(tableName))
                    return 0;

                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                SqlCommand command = null;
                if (wasData.GetType() == typeof(int))
                {
                    if (newData.GetType() == typeof(int))
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newData} WHERE {columnName} = {wasData}", connection);
                    }
                    else
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = '{newData}' WHERE {columnName} = {wasData}", connection);
                    }
                }
                else
                {
                    if (newData.GetType() == typeof(int))
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = {newData} WHERE {columnName} = '{wasData}'", connection);
                    }
                    else
                    {
                        command = new SqlCommand($"UPDATE {tableName} SET {newColumnName} = '{newData}' WHERE {columnName} = '{wasData}'", connection);
                    }
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int updateRow(string tableName, object[] datas)
        {
            try
            {
                if (!tableColumns.ContainsKey(tableName))
                    return 0;

                SqlConnection connection = dataBase.getConnection();
                dataBase.openConnection();

                SqlCommand command = null;

                StringBuilder sb = new StringBuilder();
                sb.Append($"UPDATE {tableName} SET ");

                int start = Int32.TryParse((string)datas[0], out _) ? 1 : 0;
                for (int i = start; i < datas.Length; i++)
                {
                    if (datas[i].GetType() == typeof(int))
                    {
                        sb.Append($"{tableColumnsWithId[tableName][i]} = {datas[i]}, ");
                    }
                    else
                    {
                        sb.Append($"{tableColumnsWithId[tableName][i]} = '{datas[i]}', ");
                    }
                }
                sb.Remove((sb.Length - 2), 2);
                if (datas[0].GetType() == typeof(int))
                {
                    sb.Append($" WHERE {tableColumnsWithId[tableName][0]} = {datas[0]}");
                }
                else
                {
                    sb.Append($" WHERE {tableColumnsWithId[tableName][0]} = '{datas[0]}'");
                }

                command = new SqlCommand(sb.ToString(), connection);

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void exportDataToWord(DataGridView DGV, string filename, string table)
        {
            try
            {
                if (DGV.Rows.Count != 0)
                {
                    int RowCount = DGV.Rows.Count;
                    int ColumnCount = DGV.Columns.Count;
                    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                    //add rows
                    int r = 0;
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        for (r = 0; r <= RowCount - 1; r++)
                        {
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        } //end row loop
                    } //end column loop

                    Word.Document oDoc = new Word.Document();
                    oDoc.Application.Visible = true;

                    //page orintation
                    oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;


                    dynamic oRange = oDoc.Content.Application.Selection.Range;
                    string oTemp = "";
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        for (int c = 0; c <= ColumnCount - 1; c++)
                        {
                            oTemp = oTemp + DataArray[r, c] + "\t";

                        }
                    }

                    //table format
                    oRange.Text = oTemp;

                    object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                    object ApplyBorders = true;
                    object AutoFit = true;
                    object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                          Type.Missing, Type.Missing, ref ApplyBorders,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, Type.Missing, Type.Missing,
                                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                    oRange.Select();

                    oDoc.Application.Selection.Tables[1].Select();
                    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.InsertRowsAbove(1);
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();

                    //header row style
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                    //add header row manually
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                    }

                    //table style 
                    oDoc.Application.Selection.Tables[1].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    oDoc.Application.Selection.Tables[1].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble;
                    oDoc.Application.Selection.Tables[1].Rows[1].Select();
                    oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    //header text
                    foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                    {
                        Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                        headerRange.Text = table;
                        headerRange.Font.Size = 16;
                        headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }

                    //save the file
                    oDoc.SaveAs2(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения файла! Обратитесь к адинистратору! Текст ошибки: \n" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
