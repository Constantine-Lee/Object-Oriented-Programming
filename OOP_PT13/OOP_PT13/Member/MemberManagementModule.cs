using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class MemberManagementModule: ManagementModule
	{
		/// <summary>
		/// The members.
		/// </summary>
		private List<Member> _members;

		/// <summary>
		/// Initializes a new instance of the MemberManagementModule class.
		/// </summary>
		public MemberManagementModule()
		{
			_members = new List<Member>();
		}

		/// <summary>
		/// Views the member details.
		/// </summary>
		public void ViewMemberDetails()
		{
		}

		/// <summary>
		/// Disables the member status.
		/// </summary>
		public void DisableMemberStatus()
		{
		}

		/// <summary>
		/// Remove member.
		/// </summary>
		public override void Remove()
		{
		}

	}
}
