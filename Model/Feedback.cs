using System;
namespace UFB.Model
{
	/// <summary>
	/// Feedback:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Feedback
	{
		public Feedback()
		{}
		#region Model
		private int _feedbackid;
		private int _userid;
		private DateTime _feedbacktime;
		private string _category;
		private string _info;
		private string _contact;
		private string _image;
		private string _isinvalid;
		private string _solutionstate;
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
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime feedbackTime
		{
			set{ _feedbacktime=value;}
			get{return _feedbacktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isInvalid
		{
			set{ _isinvalid=value;}
			get{return _isinvalid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string solutionState
		{
			set{ _solutionstate=value;}
			get{return _solutionstate;}
		}
		#endregion Model

	}
}

