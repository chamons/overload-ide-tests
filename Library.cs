using System.Threading;
using Azure;
using Azure.Core;

namespace Foo.Bar
{
    public class OptionsBag 
    {
        CancellationToken CancellationToken;
        public OptionsBag ()
        {
            CancellationToken = default;
        }
    }

    public class ThingResource
    {

    }

    public class FooClient
    {
        public FooClient ()
        {

        }
        
        // TODO - Does this need to be non-default?
        public Response DoThing (RequestContent body, OptionsBag options = default) => null;
        public Response CheckThing (OptionsBag options = default) => null;

        public Response<ThingResource> DoThing (ThingResource resource, CancellationToken cancellationToken = default) => null;
        public Response<bool> CheckThing (CancellationToken cancellationToken = default) => null;
    }
}