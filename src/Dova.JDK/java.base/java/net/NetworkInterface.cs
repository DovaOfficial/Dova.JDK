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

namespace Dova.JDK.java.net;

[JniSignatureAttribute("Ljava/net/NetworkInterface;", "public final")]
public partial class NetworkInterface
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NetworkInterface()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/net/NetworkInterface;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "displayName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addrs", "[Ljava/net/InetAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindings", "[Ljava/net/InterfaceAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childs", "[Ljava/net/NetworkInterface;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljava/net/NetworkInterface;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "virtual", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultInterface", "Ljava/net/NetworkInterface;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultIndex", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I[Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefault", "()Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent", "()Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "init", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "networkInterfaces", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inetAddresses", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInetAddresses", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNetworkInterfaces", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isBoundInetAddress", "(Ljava/net/InetAddress;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCheckedInetAddresses", "()[Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enumerationFromArray", "([Ljava/lang/Object;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "streamFromArray", "([Ljava/lang/Object;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByName0", "(Ljava/lang/String;)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByIndex0", "(I)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByInetAddress0", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAll", "()[Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundInetAddress0", "(Ljava/net/InetAddress;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isUp0", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLoopback0", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isP2P0", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "supportsMulticast0", "(Ljava/lang/String;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMacAddr0", "([BLjava/lang/String;I)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMTU0", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaceAddresses", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubInterfaces", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subInterfaces", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByIndex", "(I)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUp", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLoopback", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPointToPoint", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportsMulticast", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHardwareAddress", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMTU", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVirtual", "()Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String displayName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("[Ljava/net/InetAddress;", "private")]
	public JavaArray<Dova.JDK.java.net.InetAddress> addrs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.InetAddress>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/net/InterfaceAddress;", "private")]
	public JavaArray<Dova.JDK.java.net.InterfaceAddress> bindings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.InterfaceAddress>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/net/NetworkInterface;", "private")]
	public JavaArray<Dova.JDK.java.net.NetworkInterface> childs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.NetworkInterface>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/NetworkInterface;", "private")]
	public Dova.JDK.java.net.NetworkInterface parent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool @virtual_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/NetworkInterface;", "private static final")]
	public static Dova.JDK.java.net.NetworkInterface defaultInterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int defaultIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NetworkInterface(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public NetworkInterface() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I[Ljava/net/InetAddress;)V", "")]
	public NetworkInterface(Dova.JDK.java.lang.String arg0, int arg1, JavaArray<Dova.JDK.java.net.InetAddress> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/net/NetworkInterface;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/NetworkInterface;", "static")]
	public static Dova.JDK.java.net.NetworkInterface getDefault()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/NetworkInterface;", "public")]
	public Dova.JDK.java.net.NetworkInterface getParent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("()V", "private static native")]
	public static void init()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/NetworkInterface;", "public static")]
	public static Dova.JDK.java.net.NetworkInterface getByName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream networkInterfaces()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream inetAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getInetAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public static")]
	public static Dova.JDK.java.util.Enumeration getNetworkInterfaces()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Z", "static")]
	public static bool isBoundInetAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/net/InetAddress;", "private")]
	public JavaArray<Dova.JDK.java.net.InetAddress> getCheckedInetAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.InetAddress>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/Enumeration;", "private static")]
	public static Dova.JDK.java.util.Enumeration enumerationFromArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/util/stream/Stream;", "private static")]
	public static Dova.JDK.java.util.stream.Stream streamFromArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/NetworkInterface;", "private static native")]
	public static Dova.JDK.java.net.NetworkInterface getByName0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/NetworkInterface;", "private static native")]
	public static Dova.JDK.java.net.NetworkInterface getByIndex0(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", "private static native")]
	public static Dova.JDK.java.net.NetworkInterface getByInetAddress0(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("()[Ljava/net/NetworkInterface;", "private static native")]
	public static JavaArray<Dova.JDK.java.net.NetworkInterface> getAll()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.NetworkInterface>>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Z", "private static native")]
	public static bool boundInetAddress0(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "private static native")]
	public static bool isUp0(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "private static native")]
	public static bool isLoopback0(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "private static native")]
	public static bool isP2P0(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Z", "private static native")]
	public static bool supportsMulticast0(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BLjava/lang/String;I)[B", "private static native")]
	public static JavaArray<byte> getMacAddr0(JavaArray<byte> arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "private static native")]
	public static int getMTU0(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getInterfaceAddresses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getSubInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
	public Dova.JDK.java.util.stream.Stream subInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDisplayName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/NetworkInterface;", "public static")]
	public static Dova.JDK.java.net.NetworkInterface getByIndex(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;", "public static")]
	public static Dova.JDK.java.net.NetworkInterface getByInetAddress(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUp()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLoopback()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPointToPoint()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool supportsMulticast()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> getHardwareAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMTU()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isVirtual()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}
}
