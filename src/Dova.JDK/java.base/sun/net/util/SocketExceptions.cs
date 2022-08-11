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

namespace Dova.JDK.sun.net.util;

[JniSignatureAttribute("Lsun/net/util/SocketExceptions;", "public final")]
public partial class SocketExceptions
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SocketExceptions()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/util/SocketExceptions;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "enhancedExceptionText", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/io/IOException;Ljava/net/SocketAddress;)Ljava/io/IOException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/io/IOException;Ljava/lang/String;)Ljava/io/IOException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofUnixDomain", "(Ljava/io/IOException;Ljava/net/UnixDomainSocketAddress;)Ljava/io/IOException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInet", "(Ljava/io/IOException;Ljava/net/InetSocketAddress;)Ljava/io/IOException;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool enhancedExceptionText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SocketExceptions(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public SocketExceptions() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/util/SocketExceptions;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/IOException;Ljava/net/SocketAddress;)Ljava/io/IOException;", "public static")]
	public static Dova.JDK.java.io.IOException of(Dova.JDK.java.io.IOException arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/IOException;Ljava/lang/String;)Ljava/io/IOException;", "private static")]
	public static Dova.JDK.java.io.IOException create(Dova.JDK.java.io.IOException arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/IOException;Ljava/net/UnixDomainSocketAddress;)Ljava/io/IOException;", "private static")]
	public static Dova.JDK.java.io.IOException ofUnixDomain(Dova.JDK.java.io.IOException arg0, Dova.JDK.java.net.UnixDomainSocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/IOException;Ljava/net/InetSocketAddress;)Ljava/io/IOException;", "private static")]
	public static Dova.JDK.java.io.IOException ofInet(Dova.JDK.java.io.IOException arg0, Dova.JDK.java.net.InetSocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.IOException>(ret);
	}
}
