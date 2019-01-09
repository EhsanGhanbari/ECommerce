using System;
using ECommerce.Infrastructure.Domain;

namespace ECommerce.Model.Payments
{
    public class Payment : EntityBase<Guid>, IAggregateRoot
    {
        private readonly DateTime _datePaid;
        private readonly string _transactionId;
        private readonly string _merchant;
        private readonly decimal _amount;

        public Payment()
        {
        }

        public Payment(DateTime paidDateTime, string transactionId,
                       string merchant, decimal amount)
        {
            _datePaid = paidDateTime;
            _transactionId = transactionId;
            _merchant = merchant;
            _amount = amount;

            //ThrowExceptionIfInvalid();
        }

        public virtual DateTime DatePaid
        {
            get { return _datePaid; }
        }

        public virtual string TransactionId
        {
            get { return _transactionId; }
        }

        public virtual string Merchant
        {
            get { return _merchant; }
        }

        public virtual decimal Amount
        {
            get { return _amount; }
        }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(_transactionId))
                AddBrokenRule(PaymentBusinessRules.TransactionIdRequired);

            if (string.IsNullOrEmpty(_merchant))
                AddBrokenRule(PaymentBusinessRules.MerchantRequired);

            if (_amount < 0)
                AddBrokenRule(PaymentBusinessRules.AmountValid);
        }
    }
}
