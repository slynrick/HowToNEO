# Interaction with the SC inside the Blockchain 

We have many SDK's inside the community, i'm going to list below some of them:
 - [Official - NEO and NEOVM ](http://docs.neo.org/en-us/utility/sdk/introduction.html)
 - [NeoLux](https://github.com/CityOfZion/neo-lux)
 - [neon-js](https://github.com/CityOfZion/neon-js)
 - [neo-python](https://github.com/CityOfZion/neo-python)
 - [neo-go](https://github.com/CityOfZion/neo-go)
 - [Poseidon-SDK](https://github.com/CityOfZion/Poseidon-SDK)
 - [neo-go-sdk](https://github.com/CityOfZion/neo-go-sdk)

You can choose any of them. I'm acutally in love wit the neon-js. Why? Because it's very simple to use and it's very simple to implement on your app or webpage.

So i'm going to talk about the neon-js here.

## Requirements

You must have an neo-scan to set up your network using neon-js. [CoZ](https://github.com/CityOfZion) already have neo-scan for Test NET and Main NET, so you just need to install your own neo-scan if you're using a Private NET.

Now you can understand why i like the neo-scan-docker to set up your Private NET. You can find the instalation guide [here](../Installation/Installation.md)

## Choosing the RPC Node

For you to interact with the Blockchain you must use one RPC Node. You can find RPCs Nodes from Main NET and Test NET on [NEO Network Status Monitor](http://monitor.cityofzion.io/).

If you're using a Private NET just use the Node you already have from the installation part.

>OBS: Take into account that Python nodes do not have all the methods that C# Nodes have!!!


## How to Use

### Setting up the Network

You can set any Network as follows

```js
const config = {
  name: 'Network',
  extra: {
    neoscan: 'Put_Here_The_NEOSCAN/api/main_net'
  }
}
const NeoCompilerNet = new Neon.rpc.Network(config)
Neon.default.add.network(NeoCompilerNet)
```

### Invoking the Smart Contract

```js
const config = {
    net: 'Network', // use the name you already set
    url: 'url', // url of the NEO RPC
    script: Neon.default.create.script({
        scriptHash: ..., // contract scripthash in hex string
        operation: '...', // operation that you want to call
        args: [ Neon.u.num2fixed8(10/100000000), 
                Neon.u.num2fixed8(20)/100000000), 
                Neon.u.str2hexstring("hello"), 
                Neon.u.reverseHex(Neon.wallet.getScriptHashFromAddress(address))
                ] // put the params of your Smart Contract
    }),
    address: address, // the address that is invoking
    privateKey: privateKey, // private key of the invoking address
    gas: 0 // attach gas
}

Neon.default.doInvoke(config).then(res => {
    // handle the result of the invocation as json object
}).catch(err => {
    // it was not possible to send the invocation to the blockchain
});
```

### OBS

Be careful using neon-js methods, there are 3 invokes that just test the invocation but did not write anything inside the chain.

The only one that make real changes inside the chain is the one used above **doInvoke**.


You can find some informations on neon-js docs: http://cityofzion.io/neon-js/en/


### OBS2

Reminding that the blockchain takes about 30s to process the transaction, so you must keep that in mind when you're using the SDK's. Maybe if you look for the transaction right after you send it to the chain you may not find it.


[Back](../SmartContract.md)