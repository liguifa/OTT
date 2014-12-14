using Data.Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL.lib
{
    /// <summary>
    /// 数据库操作基类
    /// </summary>
    public class BaseDAL
    {
        AccessHelper ah = new AccessHelper();

        /// <summary>
        /// 根据条件，进行单个删除
        /// </summary>
        /// <param name="table">要进行删除的数据所在的表</param>
        /// <param name="whereExp">删除条件</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Remove(string table, string whereExp)
        {
            return ah.AccessQuery("delete table " + table + " where " + whereExp) == 1 ? true : false;
        }

        /// <summary>
        /// 根据条件，进行批量删除
        /// </summary>
        /// <param name="table">要进行删除的数据所在的表</param>
        /// <param name="whereExp">删除条件集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Remove(string table, List<string> whereExp)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("BEGIN TRANSATION;");
            foreach (string we in whereExp)
            {
                sql.Append("delete table " + table + " where " + we + ";");
            }
            sql.Append("ROLIBACK;");
            return ah.AccessQuery(sql.ToString()) == 0 ? false : true;
        }

        /// <summary>
        /// 单个添加数据
        /// </summary>
        /// <param name="table">要进行添加的数据所在的表</param>
        /// <param name="cols">要添加的列名集合</param>
        /// <param name="data">要添加的数据集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Add(string table, List<string> cols, List<string> datas)
        {
            if (cols.Count == datas.Count)
            {
                string col = String.Empty;
                foreach (string c in cols)
                {
                    col += "" + c + " ,";
                }
                col = col.Substring(0, col.Length - 1);
                string data = String.Empty;
                foreach (string d in datas)
                {
                    data += "'" + d + "',";
                }
                data = data.Substring(0, data.Length - 1);
                return ah.AccessQuery("insert into "+table+" (" + col + ") values (" + data + ")") == 1 ? true : false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量添加数据
        /// </summary>
        /// <param name="table">要进行添加的数据所在的表</param>
        /// <param name="cols">要添加的列名集合的集合</param>
        /// <param name="datas">要添加的数据集合的集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Add(string table, List<List<string>> cols, List<List<string>> datas)
        {
            if (cols.Count == datas.Count)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("BEGIN TRANSATION;");
                for (int i = 0; i < cols.Count; i++)
                {
                    string col = String.Empty;
                    foreach (string c in cols[i])
                    {
                        col += "'" + c + "' ,";
                    }
                    string data = String.Empty;
                    foreach (string d in datas[i])
                    {
                        data += "'" + d + "'";
                    }
                    sql.Append("insert into (" + col + ") values (" + data + ");");
                }
                sql.Append("ROLIBACK;");
                return ah.AccessQuery(sql.ToString()) == 0 ? false : true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 单个修改
        /// </summary>
        /// <param name="table">要进行修改的数据所在的表</param>
        /// <param name="updataExp">要进行修改的数据的表达式</param>
        /// <param name="whereExp">要进行修改的数据的条件</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Updata(string table, string updataExp, string whereExp)
        {
            return ah.AccessQuery("Update set " + updataExp + " from table where " + whereExp) == 1 ? true : false;
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="table">要进行修改的数据所在的表</param>
        /// <param name="updataExps">要进行修改的数据的表达式集合</param>
        /// <param name="whereExps">要进行修改的数据的条件集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Updata(string table, List<string> updataExps, List<string> whereExps)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("BEGIN TRANSATION;");
            for (int i = 0; i < updataExps.Count; i++)
            {
                sql.Append("Update set " + updataExps[i] + " from table where " + whereExps[i]);
            }
            sql.Append("ROLIBACK;");
            return ah.AccessQuery(sql.ToString()) == 0 ? false : true;
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table)
        {
            return ah.AccessReader("select * from " + table);
        }

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <param name="where">查询条件</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string where)
        {
            return ah.AccessReader("select * from " + table + " where " + where);
        }

        /// <summary>
        /// 排序查询
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table,string col,string order)
        {
            return ah.AccessReader("select * from " + table + " order by " + col+" "+order);
        }

        /// <summary>
        /// 按条件排序查询
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <param name="where">查询条件</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string col, string order, string where)
        {
            return ah.AccessReader("select * from " + table + " where "+where +" order by " + col + " " + order);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <param name="where">查询条件</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="mainCol">主键</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string col, string order, string where, int pageIndex, int pageSize,string mainCol)
        {
            return ah.AccessReader("select top "+pageSize+" * from " + table + " where " + mainCol + " not in (select top "+(pageIndex-1)*pageSize+" "+mainCol+" from "+table+" where "+where+" order by "+col+" "+order+") order by " + col + " " + order);
        }

        /// <summary>
        /// 查询数据个数
        /// </summary>
        /// <param name="table">要查询的表</param>
        /// <param name="where">查询条件</param>
        /// <returns>数据个数</returns>
        public int Count(string table, string where)
        {
            return Convert.ToInt32(ah.AccessScaler("select count(*) from " + table + " where " + where));
        }
    }
}
