﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace UFB.DAL
{
	/// <summary>
	/// 数据访问类:CategoryService
	/// </summary>
	public partial class CategoryService
	{
		public CategoryService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string category)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Category");
			strSql.Append(" where category=@category ");
			SqlParameter[] parameters = {
					new SqlParameter("@category", SqlDbType.VarChar,64)			};
			parameters[0].Value = category;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(UFB.Model.Category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Category(");
			strSql.Append("category,time)");
			strSql.Append(" values (");
			strSql.Append("@category,@time)");
			SqlParameter[] parameters = {
					new SqlParameter("@category", SqlDbType.VarChar,64),
					new SqlParameter("@time", SqlDbType.SmallDateTime)};
			parameters[0].Value = model.category;
			parameters[1].Value = model.time;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(UFB.Model.Category model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Category set ");
			strSql.Append("time=@time");
			strSql.Append(" where category=@category ");
			SqlParameter[] parameters = {
					new SqlParameter("@time", SqlDbType.SmallDateTime),
					new SqlParameter("@category", SqlDbType.VarChar,64)};
			parameters[0].Value = model.time;
			parameters[1].Value = model.category;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string category)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Category ");
			strSql.Append(" where category=@category ");
			SqlParameter[] parameters = {
					new SqlParameter("@category", SqlDbType.VarChar,64)			};
			parameters[0].Value = category;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string categorylist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Category ");
			strSql.Append(" where category in ("+categorylist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UFB.Model.Category GetModel(string category)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 category,time from Category ");
			strSql.Append(" where category=@category ");
			SqlParameter[] parameters = {
					new SqlParameter("@category", SqlDbType.VarChar,64)			};
			parameters[0].Value = category;

			UFB.Model.Category model=new UFB.Model.Category();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UFB.Model.Category DataRowToModel(DataRow row)
		{
			UFB.Model.Category model=new UFB.Model.Category();
			if (row != null)
			{
				if(row["category"]!=null)
				{
					model.category=row["category"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select category,time ");
			strSql.Append(" FROM Category ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" category,time ");
			strSql.Append(" FROM Category ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Category ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.category desc");
			}
			strSql.Append(")AS Row, T.*  from Category T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Category";
			parameters[1].Value = "category";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

