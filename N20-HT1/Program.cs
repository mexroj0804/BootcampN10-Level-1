using N20_HT1.Models;
using N20_HT1.Services;

var MarketCard = new KapitalUzcard(8600123456789012, "UzBank", 0);
var provider = new PaymePaymentProvider();

var OnlineMarket = new OnlineMarket(provider, MarketCard);

OnlineMarket.Add(new Product("Lenovo", 1_500_000));
OnlineMarket.Add(new Product("HP-Pavilion", 2_250_000));
OnlineMarket.Add(new Product("HP-Victus", 2_500_000));

var MyPersonalCard = new KapitalUzcard(860011222233334444, "UzBankN1", 50_000_000);
