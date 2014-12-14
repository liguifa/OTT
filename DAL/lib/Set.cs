using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL.lib
{
    public class Set : BaseDAL
    {
        private readonly string table = "sets";

        /// <summary>
        /// 根据条件，单个删除
        /// </summary>
        /// <param name="whereExp">删除条件</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Remove(string whereExp)
        {
            return base.Remove(table, whereExp);
        }

        /// <summary>
        /// 根据条件，进行批量删除
        /// </summary>
        /// <param name="whereExp">删除条件集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Remove(List<string> whereExp)
        {
            return base.Remove(table, whereExp);
        }

        /// <summary>
        /// 单个添加数据
        /// </summary>
        /// <param name="cols">要添加的列名集合</param>
        /// <param name="data">要添加的数据集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Add(List<string> cols, List<string> datas)
        {
            return base.Add(table, cols, datas);
        }

        /// <summary>
        /// 批量添加数据
        /// </summary>
        /// <param name="cols">要添加的列名集合的集合</param>
        /// <param name="datas">要添加的数据集合的集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Add(List<List<string>> cols, List<List<string>> datas)
        {
            return base.Add(table,cols, datas);
        }

        /// <summary>
        /// 单个修改
        /// </summary>
        /// <param name="updataExp">要进行修改的数据的表达式</param>
        /// <param name="whereExp">要进行修改的数据的条件</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Updata(string table, string updataExp, string whereExp)
        {
            return base.Updata(table,updataExp,whereExp);
        }

        /// <summary>
        /// 批量修改
        /// </summary>
        /// <param name="updataExps">要进行修改的数据的表达式集合</param>
        /// <param name="whereExps">要进行修改的数据的条件集合</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Updata(string table, List<string> updataExps, List<string> whereExps)
        {
            return base.Updata(table, updataExps, whereExps);
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns>数据集合</returns>
        public DataTable Select()
        {
            return base.Select(table);
        }

        /// <summary>
        /// 按条件查询
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string where)
        {
            return base.Select(table, where);
        }

        /// <summary>
        /// 排序查询
        /// </summary>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string col, string order)
        {
            return base.Select(table, col, order);
        }

        /// <summary>
        /// 按条件排序查询
        /// </summary>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <param name="where">查询条件</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string col, string order, string where)
        {
            return base.Select(table, col, order, where);
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="col">排序列</param>
        /// <param name="order">排序方式</param>
        /// <param name="where">查询条件</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="mainCol">主键</param>
        /// <returns>数据集合</returns>
        public DataTable Select(string table, string col, string order, string where, int pageIndex, int pageSize, string mainCol)
        {
            return base.Select(table,col,order,where,pageIndex,pageSize,mainCol);
        }

        /// <summary>
        /// 查询数据个数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <returns>数据个数</returns>
        public int Count(string table, string where)
        {
            return base.Count(table, where);
        }
    }
}
