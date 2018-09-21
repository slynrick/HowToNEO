# OpCodes

The OpCodes are instructions that the NEO Virtual Machine understands.

They are 1byte length instruction and they are the heart of the Smart Contracts.

Every smart contract on every language are converted to this opcodes and the file that have these codes receive the name ``AVM``.

You can check the opcodes and the explanations of each one inside the [code](https://github.com/neo-project/neo-devpack-dotnet/blob/e0a263ee8d6f30553b58e2926deeb2ec3445103b/Neo.SmartContract.Framework/OpCode.cs). If i write it here i was just rpeating and not adding anything new.

It's good for intermediate and advanced NEO Smart Contract developer get used with those instructions and how they works because it can be life consuming trying to understand why some code works or not.

## Example

**Code:**
```CSharp
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;
namespace NeoContract1
{
    public class Contract1 : SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "Hello", "World");
        }
    }
}
```

**AVM in a human readable way:**
```json
00 PUSH0  #An empty array of bytes is pushed onto the stack
c5 NEWARRAY  #
6b TOALTSTACK  # Puts the input onto the top of the alt stack. Removes it from the main stack.
61 NOP  # Does nothing.
68 SYSCALL 164e656f2e53746f726167652e476574436f6e74657874 # Neo.Storage.GetContext
05 PUSHBYTES5 48656c6c6f # Hello
05 PUSHBYTES5 576f726c64 # World
61 NOP  # Does nothing.
52 PUSH2  # The number 2 is pushed onto the stack.
72 XSWAP  #
68 SYSCALL 0f4e656f2e53746f726167652e507574 # Neo.Storage.Put
61 NOP  # Does nothing.
6c FROMALTSTACK  # Puts the input onto the top of the main stack. Removes it from the alt stack.
75 DROP  # Removes the top stack item.
66 RET  #
```

[Back](../neo-vm.md)