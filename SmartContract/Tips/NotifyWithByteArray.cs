using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace NeoContractExample
{
    /**
        Snippet: Notify With Constantly ByteArray
        
    */
    public class NeoContractExample : SmartContract
    {

	    public static void Main()
        {
            byte[] empty = new byte[0];
            
            for (int i = 186; i >= 184; i -= 1)
            {
                BigInteger b0 = i;

                byte[] ba = empty.Concat(b0.AsByteArray());
		        /** If using "byte[] ba = b0.AsByteArray();", it may no-yet-deterministically be convert to Integer in Runtime.Notify. 
		             Replace the above line with the following one for test
		        */

		        //byte[] ba = empty.Concat(b0.AsByteArray());

                Runtime.Notify(ba);
            }
        }
    }
}
