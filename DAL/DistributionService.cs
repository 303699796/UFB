using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace UFB.DAL
{
	/// <summary>
	/// 数据访问类:DistributionService
	/// </summary>
	public partial class DistributionService
	{
		public DistributionService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("distributionID", "Distribution"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int distributionID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Distribution");
			strSql.Append(" where distributionID=@distributionID");
			SqlParameter[] parameters = {
					new SqlParameter("@distributionID", SqlDbType.Int,4)
			};
			parameters[0].Value = distributionID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UFB.Model.Distribution model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Distribution(");
			strSql.Append("feedbackID,adminName,distributor,description,distributionTime,state)");
			strSql.Append(" values (");
			strSql.Append("@feedbackID,@adminName,@distributor,@description,@distributionTime,@state)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4),
					new SqlParameter("@adminName", SqlDbType.VarChar,64),
					new SqlParameter("@distributor", SqlDbType.VarChar,64),
					new SqlParameter("@description", SqlDbType.VarChar,128),
					new SqlParameter("@distributionTime", SqlDbType.SmallDateTime),
					new SqlParameter("@state", SqlDbType.VarChar,16)};
			parameters[0].Value = model.feedbackID;
			parameters[1].Value = model.adminName;
			parameters[2].Value = model.distributor;
			parameters[3].Value = model.description;
			parameters[4].Value = model.distributionTime;
			parameters[5].Value = model.state;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(UFB.Model.Distribution model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Distribution set ");
			strSql.Append("feedbackID=@feedbackID,");
			strSql.Append("adminName=@adminName,");
			strSql.Append("distributor=@distributor,");
			strSql.Append("description=@description,");
			strSql.Append("distributionTime=@distributionTime,");
			strSql.Append("state=@state");
			strSql.Append(" where distributionID=@distributionID");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4),
					new SqlParameter("@adminName", SqlDbType.VarChar,64),
					new SqlParameter("@distributor", SqlDbType.VarChar,64),
					new SqlParameter("@description", SqlDbType.VarChar,128),
					new SqlParameter("@distributionTime", SqlDbType.SmallDateTime),
					new SqlParameter("@state", SqlDbType.VarChar,16),
					new SqlParameter("@distributionID", SqlDbType.Int,4)};
			parameters[0].Value = model.feedbackID;
			parameters[1].Value = model.adminName;
			parameters[2].Value = model.distributor;
			parameters[3].Value = model.description;
			parameters[4].Value = model.distributionTime;
			parameters[5].Value = model.state;
			parameters[6].Value = model.distributionID;

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
		public bool Delete(int distributionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Distribution ");
			strSql.Append(" where distributionID=@distributionID");
			SqlParameter[] parameters = {
					new SqlParameter("@distributionID", SqlDbType.Int,4)
			};
			parameters[0].Value = distributionID;

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
		public bool DeleteList(string distributionIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Distribution ");
			strSql.Append(" where distributionID in ("+distributionIDlist + ")  ");
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
		public UFB.Model.Distribution GetModel(int distributionID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 distributionID,feedbackID,adminName,distributor,description,distributionTime,state from Distribution ");
			strSql.Append(" where distributionID=@distributionID");
			SqlParameter[] parameters = {
					new SqlParameter("@distributionID", SqlDbType.Int,4)
			};
			parameters[0].Value = distributionID;

			UFB.Model.Distribution model=new UFB.Model.Distribution();
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
		public UFB.Model.Distribution DataRowToModel(DataRow row)
		{
			UFB.Model.Distribution model=new UFB.Model.Distribution();
			if (row != null)
			{
				if(row["distributionID"]!=null && row["distributionID"].ToString()!="")
				{
					model.distributionID=int.Parse(row["distributionID"].ToString());
				}
				if(row["feedbackID"]!=null && row["feedbackID"].ToString()!="")
				{
					model.feedbackID=int.Parse(row["feedbackID"].ToString());
				}
				if(row["adminName"]!=null)
				{
					model.adminName=row["adminName"].ToString();
				}
				if(row["distributor"]!=null)
				{
					model.distributor=row["distributor"].ToString();
				}
				if(row["description"]!=null)
				{
					model.description=row["description"].ToString();
				}
				if(row["distributionTime"]!=null && row["distributionTime"].ToString()!="")
				{
					model.distributionTime=DateTime.Parse(row["distributionTime"].ToString());
				}
				if(row["state"]!=null)
				{
					model.state=row["state"].ToString();
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
			strSql.Append("select distributionID,feedbackID,adminName,distributor,description,distributionTime,state ");
			strSql.Append(" FROM Distribution ");
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
			strSql.Append(" distributionID,feedbackID,adminName,distributor,description,distributionTime,state ");
			strSql.Append(" FROM Distribution ");
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
			strSql.Append("select count(1) FROM Distribution ");
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
				strSql.Append("order by T.distributionID desc");
			}
			strSql.Append(")AS Row, T.*  from Distribution T ");
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
			parameters[0].Value = "Distribution";
			parameters[1].Value = "distributionID";
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

