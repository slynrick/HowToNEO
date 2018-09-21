# HowToNEO - NEO Network

You can create directories here to better split the data :). Create an MD inside that directory to explain what are you doing there.

## Proposals
Anyone from the community can send a PR to the proposals project of NEO. It intends to create an standard for NEO.

You can see the accepted proposals and the ones that is being reviewed [here](https://github.com/neo-project/proposals)

## How NEO Network Works
 - [RPC](RPC/RPC.md)
 - [Consensus](Consensus/Consensus.md)
 
## Networks

There are 3 types of networks:
 - Main NET ( Primary net and cost real money to deploy and invoke SmartContracs)
 - Test NET ( have lots of them and it cost nothing )
   - NEO Test NET
   - CoZ Test NET
   - NeoCompiler-Eco Shared NET
 - Private NET ( your local private net with as many money you want to)

The deal is go from the bottom to the **TOP**.

When you're trying to test your code, try to do it first on the private net that you have all the control, after that go to the Test NET for a larger scale test and finally, when everything is working as it should go to the Main NET!!

For you to set up your own private net, check the official tutorial [here](http://docs.neo.org/en-us/network/private-chain.html)

Or, if you're felling a little bit lazy, use the docker file that has everything done!!!
 - [This](https://github.com/CityOfZion/neo-privatenet-docker) link has only the private net
 - [This one](https://github.com/slipo/neo-scan-docker) the private net with the neoscan ( it is used by the neon-js that we're gonna see late on this tutorial)

Maybe you don't like to have this stuffs installed inside your computer. **No Problem**, you can use the shared net of the [neocompiler-eco](https://neocompiler.io)


[Back](../README.md)