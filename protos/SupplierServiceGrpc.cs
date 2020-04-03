// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SupplierService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class SupplierService
{
  static readonly string __ServiceName = "SupplierService";

  static readonly grpc::Marshaller<global::FindAllPreferredSuppliersRequest> __Marshaller_FindAllPreferredSuppliersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindAllPreferredSuppliersRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::FindAllPreferredSuppliersResponse> __Marshaller_FindAllPreferredSuppliersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindAllPreferredSuppliersResponse.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::FindPreferredSupplierRequest> __Marshaller_FindPreferredSupplierRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindPreferredSupplierRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::FindPreferredSupplierResponse> __Marshaller_FindPreferredSupplierResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindPreferredSupplierResponse.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::SetPreferredSupplierForProductRequest> __Marshaller_SetPreferredSupplierForProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SetPreferredSupplierForProductRequest.Parser.ParseFrom);
  static readonly grpc::Marshaller<global::SetPreferredSupplierForProductResponse> __Marshaller_SetPreferredSupplierForProductResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SetPreferredSupplierForProductResponse.Parser.ParseFrom);

  static readonly grpc::Method<global::FindAllPreferredSuppliersRequest, global::FindAllPreferredSuppliersResponse> __Method_findAllPreferredSuppliers = new grpc::Method<global::FindAllPreferredSuppliersRequest, global::FindAllPreferredSuppliersResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "findAllPreferredSuppliers",
      __Marshaller_FindAllPreferredSuppliersRequest,
      __Marshaller_FindAllPreferredSuppliersResponse);

  static readonly grpc::Method<global::FindPreferredSupplierRequest, global::FindPreferredSupplierResponse> __Method_findPreferredSupplier = new grpc::Method<global::FindPreferredSupplierRequest, global::FindPreferredSupplierResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "findPreferredSupplier",
      __Marshaller_FindPreferredSupplierRequest,
      __Marshaller_FindPreferredSupplierResponse);

  static readonly grpc::Method<global::SetPreferredSupplierForProductRequest, global::SetPreferredSupplierForProductResponse> __Method_setPreferredSupplierForProduct = new grpc::Method<global::SetPreferredSupplierForProductRequest, global::SetPreferredSupplierForProductResponse>(
      grpc::MethodType.Unary,
      __ServiceName,
      "setPreferredSupplierForProduct",
      __Marshaller_SetPreferredSupplierForProductRequest,
      __Marshaller_SetPreferredSupplierForProductResponse);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::SupplierServiceReflection.Descriptor.Services[0]; }
  }

  /// <summary>Base class for server-side implementations of SupplierService</summary>
  [grpc::BindServiceMethod(typeof(SupplierService), "BindService")]
  public abstract partial class SupplierServiceBase
  {
    public virtual global::System.Threading.Tasks.Task<global::FindAllPreferredSuppliersResponse> findAllPreferredSuppliers(global::FindAllPreferredSuppliersRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    public virtual global::System.Threading.Tasks.Task<global::FindPreferredSupplierResponse> findPreferredSupplier(global::FindPreferredSupplierRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

    public virtual global::System.Threading.Tasks.Task<global::SetPreferredSupplierForProductResponse> setPreferredSupplierForProduct(global::SetPreferredSupplierForProductRequest request, grpc::ServerCallContext context)
    {
      throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
    }

  }

  /// <summary>Client for SupplierService</summary>
  public partial class SupplierServiceClient : grpc::ClientBase<SupplierServiceClient>
  {
    /// <summary>Creates a new client for SupplierService</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public SupplierServiceClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for SupplierService that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public SupplierServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected SupplierServiceClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected SupplierServiceClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual global::FindAllPreferredSuppliersResponse findAllPreferredSuppliers(global::FindAllPreferredSuppliersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return findAllPreferredSuppliers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::FindAllPreferredSuppliersResponse findAllPreferredSuppliers(global::FindAllPreferredSuppliersRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_findAllPreferredSuppliers, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::FindAllPreferredSuppliersResponse> findAllPreferredSuppliersAsync(global::FindAllPreferredSuppliersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return findAllPreferredSuppliersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::FindAllPreferredSuppliersResponse> findAllPreferredSuppliersAsync(global::FindAllPreferredSuppliersRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_findAllPreferredSuppliers, null, options, request);
    }
    public virtual global::FindPreferredSupplierResponse findPreferredSupplier(global::FindPreferredSupplierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return findPreferredSupplier(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::FindPreferredSupplierResponse findPreferredSupplier(global::FindPreferredSupplierRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_findPreferredSupplier, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::FindPreferredSupplierResponse> findPreferredSupplierAsync(global::FindPreferredSupplierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return findPreferredSupplierAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::FindPreferredSupplierResponse> findPreferredSupplierAsync(global::FindPreferredSupplierRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_findPreferredSupplier, null, options, request);
    }
    public virtual global::SetPreferredSupplierForProductResponse setPreferredSupplierForProduct(global::SetPreferredSupplierForProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return setPreferredSupplierForProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::SetPreferredSupplierForProductResponse setPreferredSupplierForProduct(global::SetPreferredSupplierForProductRequest request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_setPreferredSupplierForProduct, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::SetPreferredSupplierForProductResponse> setPreferredSupplierForProductAsync(global::SetPreferredSupplierForProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return setPreferredSupplierForProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::SetPreferredSupplierForProductResponse> setPreferredSupplierForProductAsync(global::SetPreferredSupplierForProductRequest request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_setPreferredSupplierForProduct, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override SupplierServiceClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new SupplierServiceClient(configuration);
    }
  }

  /// <summary>Creates service definition that can be registered with a server</summary>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static grpc::ServerServiceDefinition BindService(SupplierServiceBase serviceImpl)
  {
    return grpc::ServerServiceDefinition.CreateBuilder()
        .AddMethod(__Method_findAllPreferredSuppliers, serviceImpl.findAllPreferredSuppliers)
        .AddMethod(__Method_findPreferredSupplier, serviceImpl.findPreferredSupplier)
        .AddMethod(__Method_setPreferredSupplierForProduct, serviceImpl.setPreferredSupplierForProduct).Build();
  }

  /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
  /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
  /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
  /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
  public static void BindService(grpc::ServiceBinderBase serviceBinder, SupplierServiceBase serviceImpl)
  {
    serviceBinder.AddMethod(__Method_findAllPreferredSuppliers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::FindAllPreferredSuppliersRequest, global::FindAllPreferredSuppliersResponse>(serviceImpl.findAllPreferredSuppliers));
    serviceBinder.AddMethod(__Method_findPreferredSupplier, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::FindPreferredSupplierRequest, global::FindPreferredSupplierResponse>(serviceImpl.findPreferredSupplier));
    serviceBinder.AddMethod(__Method_setPreferredSupplierForProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SetPreferredSupplierForProductRequest, global::SetPreferredSupplierForProductResponse>(serviceImpl.setPreferredSupplierForProduct));
  }

}
#endregion
