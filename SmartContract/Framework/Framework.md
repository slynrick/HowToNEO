# Frameworks

This is how to use the NEO's frameworks.
How to use the functions, what you can do or do not!!.


## [.NET framework](https://github.com/neo-project/neo-devpack-dotnet) (C#)

This is the framework developed by NEO.

It provides lots of utilities methods and classes to work with the NEO blockchain structure.

### Namespaces
|  Namespace |  Description |
|---|---|
| Neo  |  It provides the possibility to work with the blockchain and the storage |
| System  | It allows you to have some information of the VM  |

### Reference

All the official reference is here: 
 - [Official - NEO](http://docs.neo.org/en-us/sc/reference/api/neo.html)
    - All the blockchain methods get the information of the last block ( the last one mined!! The one that is running your SC is the next one!!)
 
 - [Official - System](http://docs.neo.org/en-us/sc/reference/api/System.html)
    - It takes the information of the actual transaction, the one that is running you SC. So you can use it to have some informations of the invoke transaction that calls your SC. Look some examples at [Tips](../Tips/Tips.md)

The official reference above is not updated. I'll put the new methods below:

|  Method |  Description |
|---|---|
| Neo.Runtime.Serialize | Serialize a c like class |
| Neo.Runtime.Deserialize | Deserialize bytes to a c like class |
| Neo.Storage.Find | Find the key inside the storage using a prefix of the key |


The best part of this Framework is that is the most updated of the community, since all the new features is made here first.

The worse part is that it uses C#, and it's not that easy for others OS to use it.

## [neo-boa](https://github.com/CityOfZion/neo-boa) (Python)

The official reference is here: [Official](https://neo-boa.readthedocs.io/en/latest/)

This framework is the best framework since it uses Python language and it can be use in any OS.

May it is not that well updated becase the changes do not came here first, must someone of the community or from CoZ that is the owner of this project to update with the new changes. **But relax, it's very well updated, however it's not the first framework to have the changes done!**

[Back](../SmartContract.md)