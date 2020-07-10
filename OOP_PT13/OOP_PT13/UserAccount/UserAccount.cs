using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class UserAccount
	{
		/// <summary>
		/// The access status.
		/// </summary>
		protected bool _accessStatus;

		/// <summary>
		/// Verification component.
		/// </summary>
		protected Verification _verify;

		/// <summary>
		/// The category management module.
		/// </summary>
		protected CategoryManagementModule _categoryManagementModule;

		/// <summary>
		/// The order management module.
		/// </summary>
		protected OrderManagementModule _orderManagementModule;

		/// <summary>
		/// The product management module.
		/// </summary>
		protected ProductManagementModule _productManagementModule;

		/// <summary>
		/// The member management module.
		/// </summary>
		protected MemberManagementModule _memberManagementModule;

		/// <summary>
		/// The management module.
		/// </summary>
		protected ManagementModule _managementModule = null;

		public UserAccount()
		{
			/// <summary>
			/// Set the initial value of access status to false.
			/// </summary>
			_accessStatus = false;
			_memberManagementModule = new MemberManagementModule();
			_categoryManagementModule = new CategoryManagementModule();
			_orderManagementModule = new OrderManagementModule();
			_productManagementModule = new ProductManagementModule(_categoryManagementModule);
		}

		/// <summary>
		/// Gets access status.
		/// </summary>
		public bool AccessStatus
		{
			get{return _accessStatus;}
		}

		/// <summary>
		/// Sets the module.
		/// </summary>
		public void SetModule(string managementModule)
		{
			switch (managementModule)
			{
				case "ProductManagementModule":
					_managementModule = _productManagementModule;
					break;
				case "OrderManagementModule":
					_managementModule = _orderManagementModule;
					break;
				case "CategoryManagementModule":
					_managementModule = _categoryManagementModule;
					break;
				case "MemberManagementModule":
					_managementModule = _memberManagementModule;
					break;
				default:
					break;
			}
		}

		/// <summary>
		/// Add according to the component chosen. 
		/// </summary>
		public void Add()
		{
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					_accessStatus = true;
					_managementModule.Add();
				}
				return;
			}
			_managementModule.Add();
		}


		/// <summary>
		/// Edit according to the component chosen. 
		/// </summary>
		public void Edit()
		{
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					_accessStatus = true;
					_managementModule.Edit();
				}
				return;
			}
			_managementModule.Edit();
		}

		/// <summary>
		/// Remove according to the component chosen. 
		/// </summary>
		public void Remove()
		{
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					_accessStatus = true;
					_managementModule.Remove();
				}
				return;
			}
			_managementModule.Remove();
		}

		/// <summary>
		/// Use the verification component to perform authentication. 
		/// </summary>
		public bool Verify()
		{
			if (_verify.Verify())
			{
				_accessStatus = true;
				return true;
			}
			return false;
		}

		/// <summary>
		/// Views the customer orders.
		/// </summary>
		public void ViewCustomerOrders()
		{
			_orderManagementModule.ViewCustomerOrders();
		}

		/// <summary>
		/// Views the order details.
		/// </summary>
		public void ViewOrderDetails()
		{
			_orderManagementModule.ViewOrderDetails();
		}

		/// <summary>
		/// Changes the status.
		/// </summary>
		public void ChangeStatus()
		{
			_orderManagementModule.ChangeStatus();
		}

		/// <summary>
		/// Views the member details.
		/// </summary>
		public void ViewMemberDetails()
		{
			_memberManagementModule.ViewMemberDetails();
		}

		/// <summary>
		/// Disables the member status.
		/// </summary>
		public void DisableMemberStatus()
		{
			_memberManagementModule.DisableMemberStatus();
		}
			
	}
}
