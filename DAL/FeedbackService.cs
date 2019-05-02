using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace UFB.DAL
{
	/// <summary>
	/// 数据访问类:FeedbackService
	/// </summary>
	public partial class FeedbackService
	{
		public FeedbackService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("feedbackID", "Feedback"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int feedbackID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Feedback");
			strSql.Append(" where feedbackID=@feedbackID");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4)
			};
			parameters[0].Value = feedbackID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(UFB.Model.Feedback model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Feedback(");
			strSql.Append("UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@feedbackTime,@category,@Info,@contact,@image,@isInvalid,@solutionState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@feedbackTime", SqlDbType.SmallDateTime),
					new SqlParameter("@category", SqlDbType.VarChar,64),
					new SqlParameter("@Info", SqlDbType.VarChar,128),
					new SqlParameter("@contact", SqlDbType.VarChar,64),
					new SqlParameter("@image", SqlDbType.VarChar,64),
					new SqlParameter("@isInvalid", SqlDbType.VarChar,16),
					new SqlParameter("@solutionState", SqlDbType.VarChar,16)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.feedbackTime;
			parameters[2].Value = model.category;
			parameters[3].Value = model.Info;
			parameters[4].Value = model.contact;
			parameters[5].Value = model.image;
			parameters[6].Value = model.isInvalid;
			parameters[7].Value = model.solutionState;

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
		public bool Update(UFB.Model.Feedback model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Feedback set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("feedbackTime=@feedbackTime,");
			strSql.Append("category=@category,");
			strSql.Append("Info=@Info,");
			strSql.Append("contact=@contact,");
			strSql.Append("image=@image,");
			strSql.Append("isInvalid=@isInvalid,");
			strSql.Append("solutionState=@solutionState");
			strSql.Append(" where feedbackID=@feedbackID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@feedbackTime", SqlDbType.SmallDateTime),
					new SqlParameter("@category", SqlDbType.VarChar,64),
					new SqlParameter("@Info", SqlDbType.VarChar,128),
					new SqlParameter("@contact", SqlDbType.VarChar,64),
					new SqlParameter("@image", SqlDbType.VarChar,64),
					new SqlParameter("@isInvalid", SqlDbType.VarChar,16),
					new SqlParameter("@solutionState", SqlDbType.VarChar,16),
					new SqlParameter("@feedbackID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.feedbackTime;
			parameters[2].Value = model.category;
			parameters[3].Value = model.Info;
			parameters[4].Value = model.contact;
			parameters[5].Value = model.image;
			parameters[6].Value = model.isInvalid;
			parameters[7].Value = model.solutionState;
			parameters[8].Value = model.feedbackID;

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
		public bool Delete(int feedbackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Feedback ");
			strSql.Append(" where feedbackID=@feedbackID");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4)
			};
			parameters[0].Value = feedbackID;

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
		public bool DeleteList(string feedbackIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Feedback ");
			strSql.Append(" where feedbackID in ("+feedbackIDlist + ")  ");
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
		public UFB.Model.Feedback GetModel(int feedbackID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 feedbackID,UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState from Feedback ");
			strSql.Append(" where feedbackID=@feedbackID");
			SqlParameter[] parameters = {
					new SqlParameter("@feedbackID", SqlDbType.Int,4)
			};
			parameters[0].Value = feedbackID;

			UFB.Model.Feedback model=new UFB.Model.Feedback();
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
		public UFB.Model.Feedback DataRowToModel(DataRow row)
		{
			UFB.Model.Feedback model=new UFB.Model.Feedback();
			if (row != null)
			{
				if(row["feedbackID"]!=null && row["feedbackID"].ToString()!="")
				{
					model.feedbackID=int.Parse(row["feedbackID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["feedbackTime"]!=null && row["feedbackTime"].ToString()!="")
				{
					model.feedbackTime=DateTime.Parse(row["feedbackTime"].ToString());
				}
				if(row["category"]!=null)
				{
					model.category=row["category"].ToString();
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["contact"]!=null)
				{
					model.contact=row["contact"].ToString();
				}
				if(row["image"]!=null)
				{
					model.image=row["image"].ToString();
				}
				if(row["isInvalid"]!=null)
				{
					model.isInvalid=row["isInvalid"].ToString();
				}
				if(row["solutionState"]!=null)
				{
					model.solutionState=row["solutionState"].ToString();
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
			strSql.Append("select feedbackID,UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState ");
			strSql.Append(" FROM Feedback ");
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
			strSql.Append(" feedbackID,UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState ");
			strSql.Append(" FROM Feedback ");
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
			strSql.Append("select count(1) FROM Feedback ");
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
				strSql.Append("order by T.feedbackID desc");
			}
			strSql.Append(")AS Row, T.*  from Feedback T ");
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
			parameters[0].Value = "Feedback";
			parameters[1].Value = "feedbackID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        public DataSet Search(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select feedbackID,UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState where Info like%无法%");
            strSql.Append(" FROM Feedback ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());

        }
   //     StringBuilder strSql = new StringBuilder();
   //     strSql.Append("select feedbackID,UserID,feedbackTime,category,Info,contact,image,isInvalid,solutionState ");
			//strSql.Append(" FROM Feedback ");
			//if(strWhere.Trim()!="")
			//{
			//	strSql.Append(" where "+strWhere);
			//}
			//return DbHelperSQL.Query(strSql.ToString());

         //    feedbackID, UserID, feedbackTime, category, Info, contact, image, isInvalid, solutionState

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

