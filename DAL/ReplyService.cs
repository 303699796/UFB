using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace UFB.DAL
{
	/// <summary>
	/// 数据访问类:ReplyService
	/// </summary>
	public partial class ReplyService
	{
		public ReplyService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("replyID", "Reply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int replyID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Reply");
			strSql.Append(" where replyID=@replyID");
			SqlParameter[] parameters = {
					new SqlParameter("@replyID", SqlDbType.Int,4)
			};
			parameters[0].Value = replyID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UFB.Model.Reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Reply(");
			strSql.Append("feedbackID,replier,replyText,replyTime,number,isRead)");
			strSql.Append(" values (");
			strSql.Append("@feedbackID,@replier,@replyText,@replyTime,@number,@isRead)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4),
					new SqlParameter("@replier", SqlDbType.VarChar,64),
					new SqlParameter("@replyText", SqlDbType.VarChar,128),
					new SqlParameter("@replyTime", SqlDbType.SmallDateTime),
					new SqlParameter("@number", SqlDbType.Int,4),
					new SqlParameter("@isRead", SqlDbType.VarChar,16)};
			parameters[0].Value = model.feedbackID;
			parameters[1].Value = model.replier;
			parameters[2].Value = model.replyText;
			parameters[3].Value = model.replyTime;
			parameters[4].Value = model.number;
			parameters[5].Value = model.isRead;

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
		public bool Update(UFB.Model.Reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Reply set ");
			strSql.Append("feedbackID=@feedbackID,");
			strSql.Append("replier=@replier,");
			strSql.Append("replyText=@replyText,");
			strSql.Append("replyTime=@replyTime,");
			strSql.Append("number=@number,");
			strSql.Append("isRead=@isRead");
			strSql.Append(" where replyID=@replyID");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4),
					new SqlParameter("@replier", SqlDbType.VarChar,64),
					new SqlParameter("@replyText", SqlDbType.VarChar,128),
					new SqlParameter("@replyTime", SqlDbType.SmallDateTime),
					new SqlParameter("@number", SqlDbType.Int,4),
					new SqlParameter("@isRead", SqlDbType.VarChar,16),
					new SqlParameter("@replyID", SqlDbType.Int,4)};
			parameters[0].Value = model.feedbackID;
			parameters[1].Value = model.replier;
			parameters[2].Value = model.replyText;
			parameters[3].Value = model.replyTime;
			parameters[4].Value = model.number;
			parameters[5].Value = model.isRead;
			parameters[6].Value = model.replyID;

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
		public bool Delete(int replyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reply ");
			strSql.Append(" where replyID=@replyID");
			SqlParameter[] parameters = {
					new SqlParameter("@replyID", SqlDbType.Int,4)
			};
			parameters[0].Value = replyID;

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
		public bool DeleteList(string replyIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Reply ");
			strSql.Append(" where replyID in ("+replyIDlist + ")  ");
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
		public UFB.Model.Reply GetModel(int replyID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 replyID,feedbackID,replier,replyText,replyTime,number,isRead from Reply ");
			strSql.Append(" where replyID=@replyID");
			SqlParameter[] parameters = {
					new SqlParameter("@replyID", SqlDbType.Int,4)
			};
			parameters[0].Value = replyID;

			UFB.Model.Reply model=new UFB.Model.Reply();
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
		public UFB.Model.Reply DataRowToModel(DataRow row)
		{
			UFB.Model.Reply model=new UFB.Model.Reply();
			if (row != null)
			{
				if(row["replyID"]!=null && row["replyID"].ToString()!="")
				{
					model.replyID=int.Parse(row["replyID"].ToString());
				}
				if(row["feedbackID"]!=null && row["feedbackID"].ToString()!="")
				{
					model.feedbackID=int.Parse(row["feedbackID"].ToString());
				}
				if(row["replier"]!=null)
				{
					model.replier=row["replier"].ToString();
				}
				if(row["replyText"]!=null)
				{
					model.replyText=row["replyText"].ToString();
				}
				if(row["replyTime"]!=null && row["replyTime"].ToString()!="")
				{
					model.replyTime=DateTime.Parse(row["replyTime"].ToString());
				}
				if(row["number"]!=null && row["number"].ToString()!="")
				{
					model.number=int.Parse(row["number"].ToString());
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
			strSql.Append("select replyID,feedbackID,replier,replyText,replyTime,number,isRead ");
			strSql.Append(" FROM Reply ");
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
			strSql.Append(" replyID,feedbackID,replier,replyText,replyTime,number,isRead ");
			strSql.Append(" FROM Reply ");
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
			strSql.Append("select count(1) FROM Reply ");
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
				strSql.Append("order by T.replyID desc");
			}
			strSql.Append(")AS Row, T.*  from Reply T ");
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
			parameters[0].Value = "Reply";
			parameters[1].Value = "replyID";
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

