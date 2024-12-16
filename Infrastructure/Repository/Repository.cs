using Dapper;
using Infrastructure.DataBaseConnect;
using Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{

    /// <summary>
    /// 仓储基类
    /// </summary>
    /// <typeparam name="T">实体类型</typeparam>
    /// <typeparam name="TPrimaryKey">主键类型</typeparam>
    public abstract class Repository<T> : IRepository<T> where T : class, new()
    {
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="deleteSql">删除sql</param>
        /// <returns></returns>
        public int Delete(string key, string deleteSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.Execute(deleteSql, new { Key = key });
        }

        /// <summary>
        /// 根据主键获取模型
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="selectSql">查询sql</param>
        /// <returns></returns>
        public T GetByKey(string id, string selectSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.QueryFirstOrDefault<T>(selectSql, new { Key = id });
        }

        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <param name="selectAllSql">查询sql</param>
        /// <returns></returns>
        public List<T> GetAll(string selectAllSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.Query<T>(selectAllSql).ToList();
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">新增实体</param>
        /// <param name="innserSql">新增sql</param>
        /// <returns></returns>
        public int Insert(T entity, string innserSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.Execute(innserSql, entity);
        }

        /// <summary>
        /// 根据唯一主键验证数据是否存在
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="selectSql">查询sql</param>
        /// <returns>返回true存在，false不存在</returns>
        public bool IsExist(string id, string selectSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            var count = connection.QueryFirst<int>(selectSql, new { Key = id });
            if (count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">更新实体</param>
        /// <param name="updateSql">更新sql</param>
        /// <returns></returns>
        public int Update(T entity, string updateSql)
        {
            using var connection = DataBaseConnectConfig.GetSqlConnection();
            return connection.Execute(updateSql, entity);
        }
    }
}
