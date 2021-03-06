﻿using ServiceStack.ServiceHost;

namespace ServiceStack.WebHost.IntegrationTests.Services
{
    public class GetsOnly { }
    public class PostsOnly { }
    public class PutsOnly { }
    public class DeletesOnly { }
    public class AnyRequest { }
    public class Response { }

    [Restrict(VisibleLocalhostOnly = true)]
    public class VisibleLocalhost { }
    [Restrict(VisibleInternalOnly = true)]
    public class VisibleInternal { }

    [Restrict(LocalhostOnly = true)]
    public class LocalhostOnly { }
    [Restrict(InternalOnly = true)]
    public class InternalOnly { }

    [Restrict(EndpointAttributes.Xml)]
    public class XmlOnly { }
    [Restrict(EndpointAttributes.Json)]
    public class JsonOnly { }
    [Restrict(EndpointAttributes.Jsv)]
    public class JsvOnly { }
    [Restrict(EndpointAttributes.Csv)]
    public class CsvOnly { }
    [Restrict(EndpointAttributes.ProtoBuf)]
    public class ProtoBufOnly { }
    [Restrict(EndpointAttributes.Soap11)]
    public class Soap11Only { }
    [Restrict(EndpointAttributes.Soap12)]
    public class Soap12Only { }
    [Restrict(EndpointAttributes.FormatOther)]
    public class OtherFormatOnly { }

    public class EndpointAccessService : ServiceInterface.Service
    {
        public Response Get(GetsOnly request)
        {
            return new Response();
        }
        
        public Response Post(PostsOnly request)
        {
            return new Response();
        }
        
        public Response Put(PutsOnly request)
        {
            return new Response();
        }
        
        public Response Delete(DeletesOnly request)
        {
            return new Response();
        }

        public Response Any(AnyRequest request)
        {
            return new Response();
        }

        public Response Any(VisibleLocalhost request)
        {
            return new Response();
        }

        public Response Any(VisibleInternal request)
        {
            return new Response();
        }

        public Response Any(LocalhostOnly request)
        {
            return new Response();
        }

        public Response Any(InternalOnly request)
        {
            return new Response();
        }

        public Response Any(XmlOnly request)
        {
            return new Response();
        }

        public Response Any(JsonOnly request)
        {
            return new Response();
        }

        public Response Any(JsvOnly request)
        {
            return new Response();
        }

        public Response Any(CsvOnly request)
        {
            return new Response();
        }

        public Response Any(ProtoBufOnly request)
        {
            return new Response();
        }

        public Response Any(Soap11Only request)
        {
            return new Response();
        }

        public Response Any(Soap12Only request)
        {
            return new Response();
        }

        public Response Any(OtherFormatOnly request)
        {
            return new Response();
        }
    }
}