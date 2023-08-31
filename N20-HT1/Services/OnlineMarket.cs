using N20_HT1.Interfaces;
using N20_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1.Services
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _providers;
        private List<Product> _products = new();
        private readonly IDebitCard _debitCard;
        public OnlineMarket(IPaymentProvider provider, IDebitCard marketCard)
        {
            _providers = provider;
            _debitCard = marketCard;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        public bool Buy(string name, int number, IDebitCard card)
        {
            foreach (var product in _products)
            {
                if (product.Name == name)
                {
                    var price = product.Price * number;
                    return _providers.Transfer(sourceCard: card, destinationCard: _debitCard, amount: price);
                }
            }
            return false;
        }
    }
}
