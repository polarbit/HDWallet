using HDWallet.Core;

namespace HDWallet.Ed25519.Sample
{
    public class TestHDWalletEd25519 : HdWalletEd25519<CardanoWallet>
    {
        public TestHDWalletEd25519(string seed) : base(seed) {}
    }
}