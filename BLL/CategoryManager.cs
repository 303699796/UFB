using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using UFB.Model;
namespace UFB.BLL
{
	/// <summary>
	/// CategoryManager
	/// </summary>
	public partial class CategoryManager
	{
		private readonly UFB.DAL.CategoryService dal=new UFB.DAL.CategoryService();
		public CategoryManager()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string category)
		{
			return dal.Exists(category);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(UFB.Model.Category model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(UFB.Model.Category model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string category)
		{
			
			return dal.Delete(category);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string categorylist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(categorylist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public UFB.Model.Category GetModel(string category)
		{
			
			return dal.GetModel(category);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public UFB.Model.Category GetModelByCache(string category)
		{
			
			string CacheKey = "CategoryModel-" + category;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(category);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (UFB.Model.Category)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<UFB.Model.Category> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<UFB.Model.Category> DataTableToList(DataTable dt)
		{
			List<UFB.Model.Category> modelList = new List<UFB.Model.Category>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				UFB.Model.Category model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

