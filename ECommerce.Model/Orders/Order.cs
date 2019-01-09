using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Infrastructure.Domain;
using ECommerce.Model.Customers;
using ECommerce.Model.Payments;

namespace ECommerce.Model.Orders
{
    public class Order : EntityBase<Guid>, IAggregateRoot
    {

        private readonly IList<OrderItem> _items;
        private Payment _payment;
        private readonly IOrderState _orderState;

        /// <summary>
        /// Default Constructure
        /// </summary>
        public Order()
        {
        }


        public Order(IOrderState orderState)
        {
            _orderState = orderState;
            _items = new List<OrderItem>();
        }

        public virtual decimal ShippingCharge { get; set; }

        public virtual Customer Customer { get; set; }

        public decimal ItemTotal()
        {
            return Items.Sum(i => i.LineTotal());
        }


        public virtual Payment Payment { get; set; }

        public virtual DateTime CreationTime { get; set; }

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }

        public decimal Total()
        {
            return Items.Sum(i => i.LineTotal()) + ShippingCharge;
        }

        public void SetPayment(Payment payment)
        {
            if (OrderHasBeenPaidFor())
                throw new OrderAlreadyPaidForException(
                                           GetDetailsOnExisitingPayment());

            if (OrderTotalMatches(payment))
                _payment = payment;
            else
                throw new PaymentAmountDoesNotEqualOrderTotalException(
                                             GetDetailsOnIssueWith(payment));

            _orderState.Submit(this);
        }

        public bool OrderHasBeenPaidFor()
        {
            return Payment != null && OrderTotalMatches(Payment);
        }

        private bool OrderTotalMatches(Payment payment)
        {
            return Total() == payment.Amount;
        }

        private string GetDetailsOnExisitingPayment()
        {
            return String.Format("Order has already been paid for. " +
                                 "{0} was paid on {1}. Payment token '{2}'",
                                 Payment.Amount, Payment.DatePaid,
                                 Payment.TransactionId);
        }

        private string GetDetailsOnIssueWith(Payment payment)
        {
            return String.Format("Payment amount is invalid. " +
                                "Order total is {0} but payment for {1}." +
                                " Payment token '{2}'",
                                this.Total(), payment.Amount, payment.TransactionId);
        }



        protected override void Validate()
        {
            if (CreationTime == DateTime.MinValue)
                base.AddBrokenRule(OrderBusinessRules.CreatedDateRequired);

            if (Customer == null)
                AddBrokenRule(OrderBusinessRules.CustomerRequired);

            if (Items == null || Items.Count() == 0)
                AddBrokenRule(OrderBusinessRules.ItemsRequired);
            else
            {
                if (Items.Any(i => i.GetBrokenRules().Count() > 0))
                {
                    foreach (OrderItem item in Items.Where(i => i.GetBrokenRules().Count() > 0))
                    {
                        foreach (BusinessRule businessRule in item.GetBrokenRules())
                        {
                            AddBrokenRule(businessRule);
                        }
                    }
                }
            }
        }
    }
}
