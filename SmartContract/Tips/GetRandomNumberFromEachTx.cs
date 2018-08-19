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
        public static BigInteger GetRandomNumber()
        {
	        Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
	        byte[] rand = tx.Hash;
	        return rand.AsBigInteger();
        }

        public static BigInteger Main()
        {
            return GetRandomNumber();
        }
    }
}
