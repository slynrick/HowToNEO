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
        One different number per call.
    */
    public class NeoContractExample : SmartContract
    {
        public class Random
        {
            public static byte[] Ran(byte[] salt, int size = 1)
            {
                Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
                return Hash256(tx.Hash.Concat(salt)).Range(0, size);
            }
            public static byte[] Gen(int size = 1)
            {
                byte[] zero = new byte[0];
                return Ran(zero, size);
            }
        }

        public static void Main()
        {
            byte[] a1 = Random.Gen();
            byte[] a2 = Random.Ran(a1, 10);
            byte[] a3 = Random.Ran(a2, 3);
            byte[] a4 = Random.Ran(a3, 3);
            byte[] a5 = Random.Ran(a4, 5);

            Runtime.Notify(a1, a2, a3, a4, a5);
        }
    }
}
