# RPCs Nodes

RPC means ``Remote Procedure Call``, so the name already told us for what it came for.

With the RPC's Nodes we can interact with the blockchain, sending information or receiving information from them. You can use one of the calling procedures below:

 - dumpprivkey ( does not have on python RPC, it's being implemented)
 - getaccountstate
 - getapplicationlog ( does not have on python RPC, it's being implemented)
 - getassetstate
 - getbalance
 - getbestblockhash
 - getblock
 - getblockcount
 - getblockhash
 - getblockheader
 - getblocksysfee
 - getconnectioncount
 - getcontractstate
 - getnewaddress
 - getrawmempool
 - getrawtransaction
 - getstorage
 - gettxout
 - getpeers
 - getversion
 - getvalidators
 - getwalletheight
 - invoke ( for test only )
 - invokefunction ( for test only )
 - invokescript ( for test only )
 - listaddress
 - sendrawtransaction
 - sendfrom
 - sendtoaddress ( does not have on python RPC, it's being implemented)
 - sendmany ( does not have on python RPC, it's being implemented)
 - submitblock ( does not have on python RPC, it's being implemented)
 - validateaddress 

You can find all the information about those procesures [here](http://docs.neo.org/en-us/node/cli/2.9.0/api.html)


You can chose one of the RPC's from this webpage: [NEO Network Status Monitor](http://monitor.cityofzion.io/). There you can find if the RPC is using neo-cli or neo-python, which version of the code and which one is from Test NET and from Main NET

## OBS

Actually RPC's nodes do not write inside the blockchain, they send the transactions to the consensus nodes pool to be mined on one block. The consensus nodes are responsible for the blockchain writing!!


[Back](../Network.md)