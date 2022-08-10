/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.net.http.websocket;

[JniSignatureAttribute("Ljdk/internal/net/http/websocket/TransportFactoryImpl;", "public")]
public partial class TransportFactoryImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.@internal.net.http.websocket.TransportFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TransportFactoryImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/websocket/TransportFactoryImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "channel", "Ljdk/internal/net/http/websocket/RawChannel;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TransportFactoryImpl", "(Ljdk/internal/net/http/websocket/RawChannel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTransport", "(Ljdk/internal/net/http/websocket/MessageQueue;Ljdk/internal/net/http/websocket/MessageStreamConsumer;)Ljdk/internal/net/http/websocket/Transport;"));
	}

	[JniSignatureAttribute("Ljdk/internal/net/http/websocket/RawChannel;", "private final")]
	public Dova.JDK.jdk.@internal.net.http.websocket.RawChannel channel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.RawChannel>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TransportFactoryImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/RawChannel;)V", "public")]
	public TransportFactoryImpl(Dova.JDK.jdk.@internal.net.http.websocket.RawChannel arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/net/http/websocket/TransportFactoryImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/net/http/websocket/MessageQueue;Ljdk/internal/net/http/websocket/MessageStreamConsumer;)Ljdk/internal/net/http/websocket/Transport;", "public")]
	public Dova.JDK.jdk.@internal.net.http.websocket.Transport createTransport(Dova.JDK.jdk.@internal.net.http.websocket.MessageQueue arg0, Dova.JDK.jdk.@internal.net.http.websocket.MessageStreamConsumer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.websocket.Transport>(ret);
	}
}
