using System;
using Foo.Bar;
using Azure;
using Azure.Core;

namespace Foo.Bar.Example
{
    class Program
    {
        static void Main(string[] args)
        {            
            FooClient client = new FooClient ();

            client.DoThing (RequestContent.Create(""));

            client.CheckThing ();
        }
    }
}
