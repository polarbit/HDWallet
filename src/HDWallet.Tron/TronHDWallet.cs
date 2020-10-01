using HDWallet.Core;
using HDWallet.Secp256k1;

namespace HDWallet.Tron
{
    public class TronHDWallet : HDWallet<TronWallet>
    {
        private static readonly HDWallet.Core.CoinPath _path = Purpose.Create(PurposeNumber.BIP44).Coin(CoinType.Tron);

        public TronHDWallet(string words, string seedPassword = "") : base(words, seedPassword, _path, new AddressGenerator()) {}
    }
}