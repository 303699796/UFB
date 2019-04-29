using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace UFB.DAL
{
	/// <summary>
	/// 数据访问类:Apply_MessageService
	/// </summary>
	public partial class Apply_MessageService
	{
		public Apply_MessageService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ApplyID", "Apply_Message"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ApplyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Apply_Message");
			strSql.Append(" where ApplyID=@ApplyID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplyID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(UFB.Model.Apply_Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Apply_Message(");
			strSql.Append("name,department,job,permission,applyState,isRead)");
			strSql.Append(" values (");
			strSql.Append("@name,@department,@job,@permission,@applyState,@isRead)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,64),
					new SqlParameter("@department", SqlDbType.VarChar,64),
					new SqlParameter("@job", SqlDbType.VarChar,64),
					new SqlParameter("@permission", SqlDbType.VarChar,16),
					new SqlParameter("@applyState", SqlDbType.VarChar,16),
					new SqlParameter("@isRead", SqlDbType.VarChar,16)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.department;
			parameters[2].Value = model.job;
			parameters[3].Value = model.permission;
			parameters[4].Value = model.applyState;
			parameters[5].Value = model.isRead;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(UFB.Model.Apply_Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Apply_Message set ");
			strSql.Append("name=@name,");
			strSql.Append("department=@department,");
			strSql.Append("job=@job,");
			strSql.Append("permission=@permission,");
			strSql.Append("applyState=@applyState,");
			strSql.Append("isRead=@isRead");
			strSql.Append(" where ApplyID=@ApplyID");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.VarChar,64),
					new SqlParameter("@department", SqlDbType.VarChar,64),
					new SqlParameter("@job", SqlDbType.VarChar,64),
					new SqlParameter("@permission", SqlDbType.VarChar,16),
					new SqlParameter("@applyState", SqlDbType.VarChar,16),
					new SqlParameter("@isRead", SqlDbType.VarChar,16),
					new SqlParameter("@ApplyID", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.department;
			parameters[2].Value = model.job;
			parameters[3].Value = model.permission;
			parameters[4].Value = model.applyState;
			parameters[5].Value = model.isRead;
			parameters[6].Value = model.ApplyID;

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
		public bool Delete(int ApplyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Apply_Message ");
			strSql.Append(" where ApplyID=@ApplyID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplyID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplyID;

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
		public bool DeleteList(string ApplyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Apply_Message ");
			strSql.Append(" where ApplyID in ("+ApplyIDlist + ")  ");
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
		public UFB.Model.Apply_Message GetModel(int ApplyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ApplyID,name,department,job,permission,applyState,isRead from Apply_Message ");
			strSql.Append(" where ApplyID=@ApplyID");
			SqlParameter[] parameters = {
					new SqlParameter("@ApplyID", SqlDbType.Int,4)
			};
			parameters[0].Value = ApplyID;

			UFB.Model.Apply_Message model=new UFB.Model.Apply_Message();
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
		public UFB.Model.Apply_Message DataRowToModel(DataRow row)
		{
			UFB.Model.Apply_Message model=new UFB.Model.Apply_Message();
			if (row != null)
			{
				if(row["ApplyID"]!=null && row["ApplyID"].ToString()!="")
				{
					model.ApplyID=int.Parse(row["ApplyID"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["department"]!=null)
				{
					model.department=row["department"].ToString();
				}
				if(row["job"]!=null)
				{
					model.job=row["job"].ToString();
				}
				if(row["permission"]!=null)
				{
					model.permission=row["permission"].ToString();
				}
				if(row["applyState"]!=null)
				{
					model.applyState=row["applyState"].ToString();
				}
				if(row["isRead"]!=null)
				{
					model.isRead=row["isRead"].ToString();
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
			strSql.Append("select ApplyID,name,department,job,permission,applyState,isRead ");
			strSql.Append(" FROM Apply_Message ");
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
			strSql.Append(" ApplyID,name,department,job,permission,applyState,isRead ");
			strSql.Append(" FROM Apply_Message ");
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
			strSql.Append("select count(1) FROM Apply_Message ");
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
				strSql.Append("order by T.ApplyID desc");
			}
			strSql.Append(")AS Row, T.*  from Apply_Message T ");
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
			parameters[0].Value = "Apply_Message";
			parameters[1].Value = "ApplyID";
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

