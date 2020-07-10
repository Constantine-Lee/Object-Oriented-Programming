using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class OrderManagementModule: ManagementModule
	{
		/// <summary>
		/// The orders.
		/// </summary>
		private List<Order> _orders;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_PT13_3.OrderManagementModule"/> class.
		/// </summary>
		public OrderManagementModule()
		{
			_orders = new List<Order>();
		}

		/// <summary>
		/// Views the customer orders.
		/// </summary>
		public void ViewCustomerOrders()
		{
		}

		/// <summary>
		/// Views the order details.
		/// </summary>
		public void ViewOrderDetails()
		{
		}

		/// <summary>
		/// Changes the status.
		/// </summary>
		public void ChangeStatus()
		{
		}

		/// <summary>
		/// Remove order.
		/// </summary>
		public override void Remove()
		{
		}
	}
}
