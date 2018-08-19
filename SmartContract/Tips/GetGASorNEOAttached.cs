using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;

namespace NeoContractExample
{
    /**
        Snippet: Get GAS or NEO Attached
    */
    public class NeoContractExample : SmartContract
    {
        private static readonly byte[] NEO_ID = { 155, 124, 255, 218, 166, 116, 190, 174, 15, 147, 14, 190, 96, 133, 175, 144, 147, 229, 254, 86, 179, 74, 92, 34, 12, 205, 207, 110, 252, 51, 111, 197 };
        private static readonly byte[] GAS_ID = { 231, 45, 40, 105, 121, 238, 108, 177, 183, 230, 93, 253, 223, 178, 227, 132, 16, 11, 141, 20, 142, 119, 88, 222, 66, 228, 22, 139, 113, 121, 44, 96 };

        public static BigInteger GetNEOAttached()
        {
            Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
            foreach (TransactionOutput output in tx.GetOutputs())
            {
                if (output.ScriptHash == ExecutionEngine.ExecutingScriptHash
                    && output.AssetId == NEO_ID)
                    return output.Value;
            }
            return 0;
        }

        public static BigInteger GetGASAttached()
        {
            Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
            foreach (TransactionOutput output in tx.GetOutputs())
            {
                if (output.ScriptHash == ExecutionEngine.ExecutingScriptHash
                    && output.AssetId == GAS_ID)
                    return output.Value;
            }
            return 0;
        }

        public static void Main()
        {
            Runtime.Notify(GetGASAttached());
            Runtime.Notify(GetNEOAttached());
        }
    }
}
