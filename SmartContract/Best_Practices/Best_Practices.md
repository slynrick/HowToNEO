# Best Practices

## Types ( Only for C# )

Try to use the tives below:
- String
- BigInteger
- byte[]

There are many utilities for this types and it can make your life much easier when you're coding the Smart Contract in C#.

One of the most precious utilities methods is the convertion between these 3 types!

> OBS: the BigInteger type can be only an 32bit number.

## Data Structure

Every time you want to structure data into your code use the the class as c structure using the **Serializable flag** like the example below:

**C#:**
```CSharp
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;
namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        [Serializable]
        public class Ex1{
            public BigInteger bignum1;
            public String string1;
            public Ex2[] list;
        }
        
        [Serializable]
        public class Ex2{
            public BigInteger bignum2;
            public String string2;
        }
        
        public static void Main()
        {
            Ex1 ex1 = new Ex1();
            ex1.bignum1 = 1;
            ex1.string1 = "test";
            
            Ex2 ex21 = new Ex2();
            ex21.bignum2 = 2;
            ex21.string2 = "test2";

            Ex2 ex22 = new Ex2();
            ex22.bignum2 = 2;
            ex22.string2 = "test2";
            
            ex1.list = new Ex2[2];
            ex1.list[0] = ex21;
            ex1.list[1] = ex22;
            
            byte[] se = ex1.Serialize();
            
            Ex1 ex12 = (Ex1)se.Deserialize();
        }
    }
}
```

As you can see using the ``Serialize`` and ``Deserialize`` our Smart contract can be very powerfull and easy to understand and implement.

**Python:**
```Python
from boa.interop.Neo.Runtime import Serialize, Deserialize

def Main(operation):

    # create a list
    struct = ['hello', 123, ['Hello', 2, 'World']]

    # serialize and deserialize
    serialized = Serialize(struct)
    deserialized = Deserialize(serialized)
```

On python, as you can see, is a little bit different. You use a list to store many kinds of data and serialize and deserialize everything.

## Dynamic Array

 - It does not exist in NEO SC. You can concatenate two list at time.

 - It's not possible to use a variable representing the length of the array you want to create.

 - Collections are not implemented on the NEO SC.

Because of those limitations, be careful of what you're trying to do.

## Acess Block data

Take into account that the data you're getting from the blockchain when you're invoking the SC is the block before the one that the invocation was mined!!!

So those information is public for everyone, if it was the block that has the invocation transaction you could at least have some information at Runtime.

## Make everything simple

Try to do your  DApp as simple as possible. Why?
The anser is simple: more code you have more expensive the invocation is!!

Try to do more with less code as possible because when you compile it and turns it to OpCodes you make it smaller. When someone execute the contract they'll be changed.

Take into acount that below 10GAS the tax of executing the code is free, so use that as your limit!!

**Check the system fees [here](http://docs.neo.org/en-us/sc/systemfees.html)**

[Back](../SmartContract.md)