using System;
namespace UFB.Model
{
	/// <summary>
	/// Apply_Message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Apply_Message
	{
		public Apply_Message()
		{}
		#region Model
		private int _applyid;
		private string _name;
		private string _department;
		private string _job;
		private string _permission;
		private string _applystate;
		private string _isread;
		/// <summary>
		/// 
		/// </summary>
		public int ApplyID
		{
			set{ _applyid=value;}
			get{return _applyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string job
		{
			set{ _job=value;}
			get{return _job;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string permission
		{
			set{ _permission=value;}
			get{return _permission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string applyState
		{
			set{ _applystate=value;}
			get{return _applystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isRead
		{
			set{ _isread=value;}
			get{return _isread;}
		}
		#endregion Model

	}
}

