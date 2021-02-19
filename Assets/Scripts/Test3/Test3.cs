using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ISomeInterface
{
    void Call();
}
struct SomeStruct : ISomeInterface
{
    public void Call()
    { }
}
class SomeClass
{
    public void Run()
    {
        var someStruct = new SomeStruct();
        SomeMethod((ISomeInterface)someStruct);
    }
    public void SomeMethod(ISomeInterface @interface)
    {
        @interface.Call();
    }
}
