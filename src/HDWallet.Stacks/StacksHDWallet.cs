using HDWallet.Core;
using HDWallet.Secp256k1;

namespace HDWallet.Stacks
{
    public class StacksHDWallet : HDWallet<StacksWallet>
    {
        private static readonly HDWallet.Core.CoinPath _path = M.BIP44.CreateCoinPath(CoinType.Blockstack);

        public StacksHDWallet(string mnemonic, string passphrase = "") : base(mnemonic, passphrase, _path) {}

        /// <summary>
        /// Generates Account from master. Doesn't derive new path by accountIndexInfo
        /// </summary>
        /// <param name="accountMasterKey">Used to generate wallet</param>
        /// <param name="accountIndexInfo">Used only to store information</param>
        /// <returns></returns>
        public static IAccount<StacksWallet> GetAccountFromMasterKey(string accountMasterKey, uint accountIndexInfo)
        {
            IAccountHDWallet<StacksWallet> accountHDWallet = new AccountHDWallet<StacksWallet>(accountMasterKey, accountIndexInfo);
            return accountHDWallet.Account;
        }
    }
}