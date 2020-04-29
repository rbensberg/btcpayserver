using NBitcoin;

namespace BTCPayServer
{
    public partial class BTCPayNetworkProvider
    {
        public void InitLiquidAssets()
        {
            var nbxplorerNetwork = NBXplorerNetworkProvider.GetFromCryptoCode("LBTC");
            Add(new ElementsBTCPayNetwork()
            {
                CryptoCode = "USDt",
                NetworkCryptoCode = "LBTC",
                ShowSyncSummary = false,
                DefaultRateRules = new[]
                {
                    "USDT_UST = 1",
                    "USDT_X = USDT_BTC * BTC_X",
                    "USDT_BTC = bitfinex(UST_BTC)",
                },
                AssetId = new uint256("ce091c998b83c78bb71a632313ba3760f1763d9cfcffae02258ffa9865a37bd2"),
                DisplayName = "Liquid Tether",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "liquidnetwork",
                CryptoImagePath = "imlegacy/liquid-tether.svg",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true,
                SupportLightning = false
            });

            Add(new ElementsBTCPayNetwork()
            {
                CryptoCode = "HOOD",
                NetworkCryptoCode = "LBTC",
                ShowSyncSummary = false,
                DefaultRateRules = new[]
                {
                    "HOOD_USD = 25",
                    "HOOD_X = HOOD_BTC * BTC_X",
                    "HOOD_BTC = 25 * bitpay(USD_BTC)"
                },
                Divisibility = 8,
                AssetId = new uint256("aa775044c32a7df391902b3659f46dfe004ccb2644ce2ddc7dba31e889391caf"),
                DisplayName = "Hoodie Token",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "liquidnetwork",
                CryptoImagePath = "imlegacy/hood.png",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true,
                SupportLightning = false
            });

            Add(new ElementsBTCPayNetwork()
            {
                CryptoCode = "AUDL",
                NetworkCryptoCode = "LBTC",
                ShowSyncSummary = false,
                DefaultRateRules = new[]
                {
                    "STIK_USD = 3",
                    "STIK_X = STIK_BTC * BTC_X",
                    "STIK_BTC = 3 * bitpay(USD_BTC)"
                },
                Divisibility = 8,
                AssetId = new uint256("f59c5f3e8141f322276daa63ed5f307085808aea6d4ef9ba61e28154533fdec7"),
                DisplayName = "Sticker Token",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "liquidnetwork",
                CryptoImagePath = "imlegacy/stikers.png",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true,
                SupportLightning = false
            });

              Add(new ElementsBTCPayNetwork()
            {
                CryptoCode = "LCAD",
                NetworkCryptoCode = "LBTC",
                ShowSyncSummary = false,
                DefaultRateRules = new[]
                {
                    "LCAD_CAD = 1",
                    "LCAD_X = CAD_BTC * BTC_X",
                    "LCAD_BTC = bylls(CAD_BTC)",
                },
                AssetId = new uint256("0e99c1a6da379d1f4151fb9df90449d40d0608f6cb33a5bcbfc8c265f42bab0a"),
                DisplayName = "Liquid CAD",
                BlockExplorerLink = NetworkType == NetworkType.Mainnet ? "https://blockstream.info/liquid/tx/{0}" : "https://blockstream.info/testnet/liquid/tx/{0}",
                NBXplorerNetwork = nbxplorerNetwork,
                UriScheme = "liquidnetwork",
                CryptoImagePath = "imlegacy/lcad.png",
                DefaultSettings = BTCPayDefaultSettings.GetDefaultSettings(NetworkType),
                CoinType = NetworkType == NetworkType.Mainnet ? new KeyPath("1776'") : new KeyPath("1'"),
                SupportRBF = true,
                SupportLightning = false
            });
        }
    }


}
