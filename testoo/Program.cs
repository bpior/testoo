using System.Runtime.CompilerServices;
using System.Security.Cryptography;
for (int i = 0; i < 100_000_000; i++) { Consume(CryptoConfig.CreateFromName("RSA")); }
[MethodImpl(MethodImplOptions.NoInlining)] static void Consume<T>(in T _) { }