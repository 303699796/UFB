using System;
namespace UFB.Model
{
	/// <summary>
	/// Reply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Reply
	{
		public Reply()
		{}
		#region Model
		private int _replyid;
		private int _feedbackid;
		private string _replier;
		private string _replytext;
		private DateTime _replytime= DateTime.Now;
		private int _number;
		private string _isread;
		/// <summary>
		/// 
		/// </summary>
		public int replyID
		{
			set{ _replyid=value;}
			get{return _replyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int feedbackID
		{
			set{ _feedbackid=value;}
			get{return _feedbackid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string replier
		{
			set{ _replier=value;}
			get{return _replier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string replyText
		{
			set{ _replytext=value;}
			get{return _replytext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime replyTime
		{
			set{ _replytime=value;}
			get{return _replytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int number
		{
			set{ _number=value;}
			get{return _number;}
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

