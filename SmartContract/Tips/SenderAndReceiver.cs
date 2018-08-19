using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;

namespace NeoContractExample
{
    /**
        Snippet: Get Sender or Receiver of Assets Attached
    */
    public class NeoContractExample : SmartContract
    {		
	    public static byte[] GetTransReceiver()
        {
	        return ExecutionEngine.ExecutingScriptHash;
        }

        public static byte[] GetTransSender()
        {
    		Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
    		TransactionInput[] inputs = tx.GetInputs();
    		if (inputs.Length > 0)
    		{
    			Transaction tx2 = (Transaction)Blockchain.GetTransaction(inputs[0].PrevHash);
    			TransactionOutput[] output = tx2.GetOutputs();
    			return output[0].ScriptHash;
    		}
    		return null;
        }

        public static void Main()
        {
	        Runtime.Notify(GetTransSender());
	        Runtime.Notify(GetTransReceiver());
        }
    }
}
