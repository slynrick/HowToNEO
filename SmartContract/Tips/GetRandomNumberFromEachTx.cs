using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;

namespace NeoContractExample
{
    /**
        Snippet: Random Number
        This will be random because the the SmartContract only runs after the block is made, 
		so get the txid of the invocation make it a random number per transaction. That can be improve 
		to be random by usage.
    */
    public class NeoContractExample : SmartContract
    {
        public static BigInteger GetRandomNumber(int size_in_bytes)
        {
            Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
            Header bl = Blockchain.GetHeader(Blockchain.GetHeight());
            byte[] hash = Hash256(bl.Hash.Concat(tx.Hash));
            byte[] rand = hash.Range(0, size_in_bytes);
            return rand.AsBigInteger();
        }

        public static BigInteger Main()
        {
            return GetRandomNumber(8);
        }
    }
}
