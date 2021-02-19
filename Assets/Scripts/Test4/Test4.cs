using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ApiSetup<T>
{
}

public static class ApiExtension
{
    public static void SetupObjectA(this ObjectA T)
    {

    }
    public static void SetupObjectB(this ObjectB T)
    {

    }
}
class Api
{
    public ApiSetup<T> For<T>(T obj)
    {
        return new ApiSetup<T>();
    }
}
interface ISomeInterfaceA
{ }
interface ISomeInterfaceB
{ }
public class ObjectA : ISomeInterfaceA
{ }
public class ObjectB : ISomeInterfaceB
{ }
class SomeClass2
{
    public void Setup()
    {
        Api apiObject = new Api();

        //apiObject.For(new ObjectA()).SetupObjectA();
        //apiObject.For(new ObjectB()).SetupObjectB();
    }
}

