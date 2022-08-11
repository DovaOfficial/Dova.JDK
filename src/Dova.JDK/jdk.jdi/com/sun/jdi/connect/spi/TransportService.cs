/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.jdi.connect.spi;

[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/TransportService;", "public abstract")]
public partial class TransportService
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TransportService()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/connect/spi/TransportService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/jdi/connect/spi/TransportService$ListenKey;JJ)Lcom/sun/jdi/connect/spi/Connection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attach", "(Ljava/lang/String;JJ)Lcom/sun/jdi/connect/spi/Connection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "description", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "capabilities", "()Lcom/sun/jdi/connect/spi/TransportService$Capabilities;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startListening", "(Ljava/lang/String;)Lcom/sun/jdi/connect/spi/TransportService$ListenKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startListening", "()Lcom/sun/jdi/connect/spi/TransportService$ListenKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopListening", "(Lcom/sun/jdi/connect/spi/TransportService$ListenKey;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TransportService(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TransportService() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jdi/connect/spi/TransportService;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/spi/TransportService$ListenKey;JJ)Lcom/sun/jdi/connect/spi/Connection;", "public abstract")]
	public Dova.JDK.com.sun.jdi.connect.spi.Connection accept(Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.Connection>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;JJ)Lcom/sun/jdi/connect/spi/Connection;", "public abstract")]
	public Dova.JDK.com.sun.jdi.connect.spi.Connection attach(Dova.JDK.java.lang.String arg0, long arg1, long arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.Connection>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String description()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/connect/spi/TransportService$Capabilities;", "public abstract")]
	public Dova.JDK.com.sun.jdi.connect.spi.TransportService.Capabilities capabilities()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.TransportService.Capabilities>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jdi/connect/spi/TransportService$ListenKey;", "public abstract")]
	public Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey startListening(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/connect/spi/TransportService$ListenKey;", "public abstract")]
	public Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey startListening()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/connect/spi/TransportService$ListenKey;)V", "public abstract")]
	public void stopListening(Dova.JDK.com.sun.jdi.connect.spi.TransportService.ListenKey arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/TransportService$ListenKey;", "public abstract static")]
	public partial class ListenKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ListenKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/connect/spi/TransportService$ListenKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "address", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ListenKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ListenKey() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jdi/connect/spi/TransportService$ListenKey;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		public Dova.JDK.java.lang.String address()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jdi/connect/spi/TransportService$Capabilities;", "public abstract static")]
	public partial class Capabilities
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Capabilities()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/connect/spi/TransportService$Capabilities;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsAcceptTimeout", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsHandshakeTimeout", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsAttachTimeout", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsMultipleConnections", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Capabilities(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Capabilities() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jdi/connect/spi/TransportService$Capabilities;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool supportsAcceptTimeout()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool supportsHandshakeTimeout()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool supportsAttachTimeout()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool supportsMultipleConnections()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}
