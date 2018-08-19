# Tips

This is how to deal with problems such as Runtime randomness, how to get amount of assets attached to the transactions, etc.

## Problems Solved

### CSharp
 - Get Random Number at Runtime
    - [One random number per Transaction](GetRandomNumberFromEachTx.cs)
    - [One random number per call inside the transaction](GetRandomNumberFromEachCall.cs)
        - You can also remove the block header of the two examples above if a secure random number is not necessary. Your AVM will cost less than using the block hash.
 - [Get GAS or NEO Attached](GetGASorNEOAttached.cs)
 - [Get Sender and Receiver of Smart Contract](SenderAndReceiver.cs)
 - [Notify With Constantly ByteArray](NotifyWithByteArray.cs)
 
[Back](../SmartContract.md)