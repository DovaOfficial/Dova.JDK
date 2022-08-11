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

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/UnixDomainSockets;", "")]
public partial class UnixDomainSockets
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixDomainSockets()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/UnixDomainSockets;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supported", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tempDir", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "accessUnixDomainSocket", "Ljava/net/NetPermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "random", "Ljava/util/Random;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPermission", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "init", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "connect", "(Ljava/io/FileDescriptor;Ljava/nio/file/Path;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "connect", "(Ljava/io/FileDescriptor;Ljava/net/SocketAddress;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "accept", "(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bind", "(Ljava/io/FileDescriptor;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "socket", "()Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unnamed", "()Ljava/net/UnixDomainSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "localAddress0", "(Ljava/io/FileDescriptor;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "socket0", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPathBytes", "(Ljava/nio/file/Path;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bind0", "(Ljava/io/FileDescriptor;[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "connect0", "(Ljava/io/FileDescriptor;[B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "accept0", "(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRandom", "()Ljava/util/Random;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "localAddress", "(Ljava/io/FileDescriptor;)Ljava/net/UnixDomainSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRevealedLocalAddress", "(Ljava/net/SocketAddress;)Ljava/net/UnixDomainSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "generateTempName", "()Ljava/net/UnixDomainSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkAddress", "(Ljava/net/SocketAddress;)Ljava/net/UnixDomainSocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRevealedLocalAddressAsString", "(Ljava/net/SocketAddress;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool supported_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String tempDir_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/NetPermission;", "private static final")]
	public static Dova.JDK.java.net.NetPermission accessUnixDomainSocket_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetPermission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Random;", "private static final")]
	public static Dova.JDK.java.util.Random random_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Random>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixDomainSockets(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public UnixDomainSockets() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/UnixDomainSockets;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "static")]
	public static void checkPermission()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Z", "private static native")]
	public static bool init()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool isSupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/file/Path;)I", "static")]
	public static int connect(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/net/SocketAddress;)I", "static")]
	public static int connect(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.net.SocketAddress arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/lang/String;)I", "static")]
	public static int accept(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.io.FileDescriptor arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/file/Path;)V", "static")]
	public static void bind(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/io/FileDescriptor;", "static")]
	public static Dova.JDK.java.io.FileDescriptor socket()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/UnixDomainSocketAddress;", "static")]
	public static Dova.JDK.java.net.UnixDomainSocketAddress unnamed()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;)[B", "private static native")]
	public static JavaArray<byte> localAddress0(Dova.JDK.java.io.FileDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "private static native")]
	public static int socket0()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)[B", "static")]
	public static JavaArray<byte> getPathBytes(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[B)V", "private static native")]
	public static void bind0(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<byte> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[B)I", "private static native")]
	public static int connect0(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/io/FileDescriptor;[Ljava/lang/Object;)I", "private static native")]
	public static int accept0(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.io.FileDescriptor arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Random;", "private static")]
	public static Dova.JDK.java.util.Random getRandom()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Random>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;)Ljava/net/UnixDomainSocketAddress;", "static")]
	public static Dova.JDK.java.net.UnixDomainSocketAddress localAddress(Dova.JDK.java.io.FileDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/net/UnixDomainSocketAddress;", "static")]
	public static Dova.JDK.java.net.UnixDomainSocketAddress getRevealedLocalAddress(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/UnixDomainSocketAddress;", "static")]
	public static Dova.JDK.java.net.UnixDomainSocketAddress generateTempName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/net/UnixDomainSocketAddress;", "static")]
	public static Dova.JDK.java.net.UnixDomainSocketAddress checkAddress(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String getRevealedLocalAddressAsString(Dova.JDK.java.net.SocketAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lsun/nio/ch/UnixDomainSockets$UnnamedHolder;", "private static")]
	public partial class UnnamedHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnnamedHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/UnixDomainSockets$UnnamedHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNNAMED", "Ljava/net/UnixDomainSocketAddress;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/net/UnixDomainSocketAddress;", "static final")]
		public static Dova.JDK.java.net.UnixDomainSocketAddress UNNAMED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.UnixDomainSocketAddress>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnnamedHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public UnnamedHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/UnixDomainSockets$UnnamedHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
