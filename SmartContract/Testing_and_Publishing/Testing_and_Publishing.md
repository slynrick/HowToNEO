# Testing and Deploying

**First things first!!!**

Before you start test your SmartContract and Deploy it you must first compile!

## Compiling

Each language has their own compile the code into a binary file called **AVM** that has all the instuctions that the NEO Virtual Machine understand.

If you did not installed the compiler, go to the section [Installation](../Installation/Installation.md) 

>OBS: Usually neon compiler generate a smaller AVM than the neo-boa

**Now that you already have your AVM file, let's start!!**

## Networks

You can deploy you code into 3 differents kinds of Networks:
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

## Deploying the contract

For you to deploy the contract you can use [neo-cli](https://github.com/neo-project/neo-cli) or [neo-gui](https://github.com/neo-project/neo-gui) for windows and [neo-python](https://github.com/CityOfZion/neo-python) for any OS.

On each of those options we have the code to deploy the contract, so it's not that interesting repeat everything here again. Le'ts go to the most interesting part of deploying the contract:

### Contract params 
We use the contract params to tell the blockchain the **parameters types** of the entry point method and the **return type** of that same method:

    Signature - 00
    Boolean - 01
    Integer - 02
    Hash160 - 03
    Hash256 - 04
    ByteArray - 05
    PublicKey - 06
    String - 07
    Array - 10
    InteropInterface - f0
    Void - ff

besides the AVM file, there are 3 more parameters that it's very interesting too. They'll decide how expensive you're deloy is!!

All the 2 params above is boolean:
 - Need Storage : Put it ``true`` if you use the storage inside your SmartContract.
 - Need Dynamic Call: Put it ``true`` if you call another SmartContract inside yours.

 >OBS: Attention on this part because if you do not check one of these two and you're SC need it, you must change something inside your code for you to deploy the contract again.

 ### Passing informations

 After you call the deploy function you must pass information about your SmartContract as follows:

 ```JSON
 Name: ...( the name of the SmartContract )
 Version: ...( the version of it )
 Author: ...( Who made it )
 Email: ...( support email )
 Description: ...( little resume of your SmartContract)
 ```

 ## Testing your Smart Contract
 You can test your smart contract using an SDK, but i'll still use the softwares i told you about on ``Deploying the contract`` section because i'll talk about the SDK's later on this tutorial.

 ### Invocation

 The invocation depends on what software you're using, and those i told you about have the explanation on theirs docs, so i'll focus on the most important thing!!

 Everytime you call the SmartContract you're calling his unique name on the blockchain, that is the ``scripthash``.

 How can i get my contract scripthash? it can be calculated by your hands using [the conversor tab](https://neocompiler.io/#/ecolab) or you can keep what the deployment gives you!

 Each contract ``scripthash`` is an ``Address``, so you can send money to them!!

 >OBS: what it's actually doing is calling the RPC node, that we're gonna talk on [Network part](../../Network/Network.md)

 ### Response

 After your invoke transaction is mined and executed you can have the blockchain response that have the notifications and the return value of the SmartContract!!

 It's probably in hex, so you just need to convert it. But be careful the hex is **inverted**, so invert it before you cast it to some type you want to!

 The status of you're invocation is there and it's going to be ``FAULT`` or ``HALT``. If it's ``FAULT`` something went wrong and you must debug it, if it's ``HALT`` the SC executed and everything goes OK.

 ### Debuging Tools

Now a days on NEO we have two possibilities:
  - [neo-debugger-tools](https://github.com/Relfos/neo-debugger-tools)
  - [Neunity](https://github.com/norchain/Neunity)
    - [Video Tutorial](https://www.youtube.com/watch?v=vTkNzx403p8&feature=youtu.be)


[Back](../SmartContract.md)