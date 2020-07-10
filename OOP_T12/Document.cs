using System;
namespace OOP_T1_P3
{
	public class Document: Resources
	{
		/// <summary>
		/// The subject.
		/// </summary>
		private string _subject;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Document"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">status.</param>
		/// <param name="subject">Subject.</param>
		public Document(string id, bool status, string subject):base(id, status)
		{
			this._subject = subject;
		}

		/// <summary>
		/// Gets or sets the subject.
		/// </summary>
		/// <value>The subject.</value>
		public string Subject
		{
			get{return _subject;}
			set{_subject = value;}
		}

		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public override string Deploy()
		{
			return _subject;
		}
	}
}
