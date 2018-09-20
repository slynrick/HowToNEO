# First Dapp

For your first DApp nothing more convinient that an Hello World example.

## C#

All Smart Contract on C# must be inherited from ``Framework.SmartContract``.

**C# template:**

```CSharp
using ... // namespaces
namespace Neo.SmartContract
{
    public class Template : Framework.SmartContract
    {
        public static void Main()
        {
            // code
        }
    }
}
```

As you can see above, every smart contract on C# must have a Main function ( with or without params) as entry point!.

The ``Storage`` class handle the read and write inside the blockchain. Now for our first DApp we want to write the word ``World`` inside the key ``Hello``.

>Information: The smart contract can only change his storage, so everybody can read but only the SC can change. The storage is also a map that we store data ( **value** ) inside a **key**.

With all i talked about we can manage the code below:

```CSharp
using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class HelloWorld : Framework.SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
```

So is that **Simple** and our first Dapp using C# is read to use.

> The Put method handle the writing and the Get method handle the reading.

## Python

In python the script is smaller and very simple.

**Python template:**

```Python
import ... # neo-boa modules

def Main():
    ... # code
    
                                            
```

> Now we can use the method ``Put`` and ``GetContext`` to write data inside the blockchain using neo.

The first DApp in python is as follows:

```Python
from boa.interop.Neo.Storage import Put, GetContext

ctx = GetContext()

def Main():
    Put(ctx, 'Hello', 'World')                                
```

[Back](../SmartContract.md)