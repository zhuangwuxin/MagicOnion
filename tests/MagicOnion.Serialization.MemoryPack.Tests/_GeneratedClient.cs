// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace MagicOnion.Serialization.MemoryPack.Tests.Generated
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

        public static void Register()
        {
            if (isRegistered) return;
            isRegistered = true;

            global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default =
                (global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider immutableMagicOnionClientFactoryProvider)
                    ? immutableMagicOnionClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);

            global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default =
                (global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider immutableStreamingHubClientFactoryProvider)
                    ? immutableStreamingHubClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);
        }
    }

    public partial class MagicOnionGeneratedClientFactoryProvider : global::MagicOnion.Client.IMagicOnionClientFactoryProvider, global::MagicOnion.Client.IStreamingHubClientFactoryProvider
    {
        public static MagicOnionGeneratedClientFactoryProvider Instance { get; } = new MagicOnionGeneratedClientFactoryProvider();

        MagicOnionGeneratedClientFactoryProvider() {}

        bool global::MagicOnion.Client.IMagicOnionClientFactoryProvider.TryGetFactory<T>(out global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> factory)
            => (factory = MagicOnionClientFactoryCache<T>.Factory) != null;

        bool global::MagicOnion.Client.IStreamingHubClientFactoryProvider.TryGetFactory<TStreamingHub, TReceiver>(out global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> factory)
            => (factory = StreamingHubClientFactoryCache<TStreamingHub, TReceiver>.Factory) != null;

        static class MagicOnionClientFactoryCache<T> where T : global::MagicOnion.IService<T>
        {
            public readonly static global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> Factory;

            static MagicOnionClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>);

                if (typeof(T) == typeof(global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestService))
                {
                    factory = ((global::MagicOnion.Client.MagicOnionClientFactoryDelegate<global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestService>)((x, y) => new MagicOnion.Serialization.MemoryPack.Tests.MemoryPackSerializerTestServiceClient(x, y)));
                }
                Factory = (global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>)factory;
            }
        }
        
        static class StreamingHubClientFactoryCache<TStreamingHub, TReceiver> where TStreamingHub : global::MagicOnion.IStreamingHub<TStreamingHub, TReceiver>
        {
            public readonly static global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> Factory;

            static StreamingHubClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>);

                if (typeof(TStreamingHub) == typeof(global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub) && typeof(TReceiver) == typeof(global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHubReceiver))
                {
                    factory = ((global::MagicOnion.Client.StreamingHubClientFactoryDelegate<global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub, global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHubReceiver>)((a, _, b, c, d, e) => new MagicOnion.Serialization.MemoryPack.Tests.MemoryPackSerializerTestHubClient(a, b, c, d, e)));
                }

                Factory = (global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>)factory;
            }
        }
    }

}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.
namespace MagicOnion.Serialization.MemoryPack.Tests.Generated
{
    using global::System;
    using global::MemoryPack;
    public class MagicOnionMemoryPackFormatterProvider
    {
        public static void RegisterFormatters()
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MagicOnion.Serialization.MemoryPack.DynamicArgumentTupleFormatter<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.String>());
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MagicOnion.Serialization.MemoryPack.DynamicArgumentTupleFormatter<global::System.Int32, global::System.String>());
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ValueTupleFormatter<global::System.String, global::System.Int32>());
        }
    }
}
#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace MagicOnion.Serialization.MemoryPack.Tests
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class MemoryPackSerializerTestServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestService>, global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MessagePack.Nil, global::MessagePack.Nil> UnaryReturnNil;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MessagePack.Nil, global::System.Int32> UnaryParameterless;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MessagePack.Nil, global::MagicOnion.Serialization.MemoryPack.Tests.MyObject> UnaryReturnCustomObject;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.Serialization.MemoryPack.Tests.MyObject, global::System.ValueTuple<global::System.String, global::System.Int32>> UnaryCustomObject;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.String>, global::System.Int32> Unary1;
            public ClientCore(global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider)
            {
                this.UnaryReturnNil = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MessagePack.Nil, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IMemoryPackSerializerTestService", "UnaryReturnNil", serializerProvider);
                this.UnaryParameterless = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MessagePack.Nil, global::System.Int32>(global::Grpc.Core.MethodType.Unary, "IMemoryPackSerializerTestService", "UnaryParameterless", serializerProvider);
                this.UnaryReturnCustomObject = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_RefType<global::MessagePack.Nil, global::MagicOnion.Serialization.MemoryPack.Tests.MyObject>(global::Grpc.Core.MethodType.Unary, "IMemoryPackSerializerTestService", "UnaryReturnCustomObject", serializerProvider);
                this.UnaryCustomObject = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::MagicOnion.Serialization.MemoryPack.Tests.MyObject, global::System.ValueTuple<global::System.String, global::System.Int32>>(global::Grpc.Core.MethodType.Unary, "IMemoryPackSerializerTestService", "UnaryCustomObject", serializerProvider);
                this.Unary1 = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.String>, global::System.Int32>(global::Grpc.Core.MethodType.Unary, "IMemoryPackSerializerTestService", "Unary1", serializerProvider);
            }
        }
        
        readonly ClientCore core;
        
        public MemoryPackSerializerTestServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider) : base(options)
        {
            this.core = new ClientCore(serializerProvider);
        }
        
        private MemoryPackSerializerTestServiceClient(MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IMemoryPackSerializerTestService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new MemoryPackSerializerTestServiceClient(options, core);
        
        public global::MagicOnion.UnaryResult<global::MessagePack.Nil> UnaryReturnNil()
            => this.core.UnaryReturnNil.InvokeUnary(this, "IMemoryPackSerializerTestService/UnaryReturnNil", global::MessagePack.Nil.Default);
        public global::MagicOnion.UnaryResult<global::System.Int32> UnaryParameterless()
            => this.core.UnaryParameterless.InvokeUnary(this, "IMemoryPackSerializerTestService/UnaryParameterless", global::MessagePack.Nil.Default);
        public global::MagicOnion.UnaryResult<global::MagicOnion.Serialization.MemoryPack.Tests.MyObject> UnaryReturnCustomObject()
            => this.core.UnaryReturnCustomObject.InvokeUnary(this, "IMemoryPackSerializerTestService/UnaryReturnCustomObject", global::MessagePack.Nil.Default);
        public global::MagicOnion.UnaryResult<global::System.ValueTuple<global::System.String, global::System.Int32>> UnaryCustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyObject obj)
            => this.core.UnaryCustomObject.InvokeUnary(this, "IMemoryPackSerializerTestService/UnaryCustomObject", obj);
        public global::MagicOnion.UnaryResult<global::System.Int32> Unary1(global::System.Int32 arg0, global::System.Int32 arg1, global::System.Int32 arg2, global::System.Int32 arg3, global::System.Int32 arg4, global::System.Int32 arg5, global::System.Int32 arg6, global::System.Int32 arg7, global::System.Int32 arg8, global::System.Int32 arg9, global::System.Int32 arg10, global::System.Int32 arg11, global::System.Int32 arg12, global::System.Int32 arg13, global::System.String arg14)
            => this.core.Unary1.InvokeUnary(this, "IMemoryPackSerializerTestService/Unary1", new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.String>(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
    }
}


#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace MagicOnion.Serialization.MemoryPack.Tests
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class MemoryPackSerializerTestHubClient : global::MagicOnion.Client.StreamingHubClientBase<global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub, global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHubReceiver>, global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub
    {
        protected override global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]> DuplexStreamingAsyncMethod { get; }
        
        public MemoryPackSerializerTestHubClient(global::Grpc.Core.CallInvoker callInvoker, global::System.String host, global::Grpc.Core.CallOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider, global::MagicOnion.Client.IMagicOnionClientLogger logger)
            : base(callInvoker, host, options, serializerProvider, logger)
        {
            var marshaller = global::MagicOnion.MagicOnionMarshallers.ThroughMarshaller;
            DuplexStreamingAsyncMethod = new global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]>(global::Grpc.Core.MethodType.DuplexStreaming, "IMemoryPackSerializerTestHub", "Connect", marshaller, marshaller);
        }
        
        public global::System.Threading.Tasks.Task MethodReturnWithoutValue()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-925124953, global::MessagePack.Nil.Default);
        public global::System.Threading.Tasks.Task<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse> MethodReturnCustomObject()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse>(-1962697054, global::MessagePack.Nil.Default);
        public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameterless()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::System.Int32>(-545082062, global::MessagePack.Nil.Default);
        public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_One(global::System.Int32 arg0)
            => base.WriteMessageWithResponseAsync<global::System.Int32, global::System.Int32>(85995236, arg0);
        public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_Many(global::System.Int32 arg0, global::System.String arg1)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>, global::System.Int32>(1242061127, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>(arg0, arg1));
        public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_CustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse, global::System.Int32>(304013616, arg0);
        public global::System.Threading.Tasks.Task<global::System.Int32> Callback(global::System.Int32 arg0, global::System.String arg1)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>, global::System.Int32>(-2118022106, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>(arg0, arg1));
        public global::System.Threading.Tasks.Task<global::System.Int32> CallbackCustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
            => base.WriteMessageWithResponseAsync<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse, global::System.Int32>(-2048231118, arg0);
        public global::System.Threading.Tasks.Task ThrowReturnStatusException()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(28149104, global::MessagePack.Nil.Default);
        public global::System.Threading.Tasks.Task Throw()
            => base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(540272591, global::MessagePack.Nil.Default);
        
        public global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub FireAndForget()
            => new FireAndForgetClient(this);
        
        [global::MagicOnion.Ignore]
        class FireAndForgetClient : global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub
        {
            readonly MemoryPackSerializerTestHubClient parent;
        
            public FireAndForgetClient(MemoryPackSerializerTestHubClient parent)
                => this.parent = parent;
        
            public global::MagicOnion.Serialization.MemoryPack.Tests.IMemoryPackSerializerTestHub FireAndForget() => this;
            public global::System.Threading.Tasks.Task DisposeAsync() => throw new global::System.NotSupportedException();
            public global::System.Threading.Tasks.Task WaitForDisconnect() => throw new global::System.NotSupportedException();
        
            public global::System.Threading.Tasks.Task MethodReturnWithoutValue()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-925124953, global::MessagePack.Nil.Default);
            public global::System.Threading.Tasks.Task<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse> MethodReturnCustomObject()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse>(-1962697054, global::MessagePack.Nil.Default);
            public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameterless()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::System.Int32>(-545082062, global::MessagePack.Nil.Default);
            public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_One(global::System.Int32 arg0)
                => parent.WriteMessageFireAndForgetAsync<global::System.Int32, global::System.Int32>(85995236, arg0);
            public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_Many(global::System.Int32 arg0, global::System.String arg1)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>, global::System.Int32>(1242061127, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>(arg0, arg1));
            public global::System.Threading.Tasks.Task<global::System.Int32> MethodParameter_CustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse, global::System.Int32>(304013616, arg0);
            public global::System.Threading.Tasks.Task<global::System.Int32> Callback(global::System.Int32 arg0, global::System.String arg1)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>, global::System.Int32>(-2118022106, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>(arg0, arg1));
            public global::System.Threading.Tasks.Task<global::System.Int32> CallbackCustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
                => parent.WriteMessageFireAndForgetAsync<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse, global::System.Int32>(-2048231118, arg0);
            public global::System.Threading.Tasks.Task ThrowReturnStatusException()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(28149104, global::MessagePack.Nil.Default);
            public global::System.Threading.Tasks.Task Throw()
                => parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(540272591, global::MessagePack.Nil.Default);
            
        }
        
        protected override void OnBroadcastEvent(global::System.Int32 methodId, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -1262822265: // Void OnMessage(global::System.Int32 arg0, global::System.String arg1)
                    {
                        var value = base.Deserialize<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String>>(data);
                        receiver.OnMessage(value.Item1, value.Item2);
                    }
                    break;
                case 1200849283: // Void OnMessageCustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
                    {
                        var value = base.Deserialize<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse>(data);
                        receiver.OnMessageCustomObject(value);
                    }
                    break;
            }
        }
        
        protected override void OnResponseEvent(global::System.Int32 methodId, global::System.Object taskCompletionSource, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -925124953: // Task MethodReturnWithoutValue()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -1962697054: // Task<MyRequestResponse> MethodReturnCustomObject()
                    base.SetResultForResponse<global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse>(taskCompletionSource, data);
                    break;
                case -545082062: // Task<Int32> MethodParameterless()
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case 85995236: // Task<Int32> MethodParameter_One(global::System.Int32 arg0)
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case 1242061127: // Task<Int32> MethodParameter_Many(global::System.Int32 arg0, global::System.String arg1)
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case 304013616: // Task<Int32> MethodParameter_CustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case -2118022106: // Task<Int32> Callback(global::System.Int32 arg0, global::System.String arg1)
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case -2048231118: // Task<Int32> CallbackCustomObject(global::MagicOnion.Serialization.MemoryPack.Tests.MyRequestResponse arg0)
                    base.SetResultForResponse<global::System.Int32>(taskCompletionSource, data);
                    break;
                case 28149104: // Task ThrowReturnStatusException()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 540272591: // Task Throw()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
            }
        }
        
    }
}


