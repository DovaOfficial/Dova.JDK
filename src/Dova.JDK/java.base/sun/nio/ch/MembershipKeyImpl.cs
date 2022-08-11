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

[JniSignatureAttribute("Lsun/nio/ch/MembershipKeyImpl;", "")]
public partial class MembershipKeyImpl
	: Dova.JDK.java.nio.channels.MembershipKey
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MembershipKeyImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/MembershipKeyImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ch", "Ljava/nio/channels/MulticastChannel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "Ljava/net/InetAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interf", "Ljava/net/NetworkInterface;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Ljava/net/InetAddress;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invalid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stateLock", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "blockedSet", "Ljava/util/HashSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "block", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "channel", "()Ljava/nio/channels/MulticastChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drop", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "networkInterface", "()Ljava/net/NetworkInterface;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unblock", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sourceAddress", "()Ljava/net/InetAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "()V"));
	}

	[JniSignatureAttribute("Ljava/nio/channels/MulticastChannel;", "private final")]
	public Dova.JDK.java.nio.channels.MulticastChannel ch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MulticastChannel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetAddress;", "private final")]
	public Dova.JDK.java.net.InetAddress group_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/NetworkInterface;", "private final")]
	public Dova.JDK.java.net.NetworkInterface interf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/net/InetAddress;", "private final")]
	public Dova.JDK.java.net.InetAddress source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool invalid_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object stateLock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashSet;", "private")]
	public Dova.JDK.java.util.HashSet blockedSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MembershipKeyImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;)V", "private")]
	public MembershipKeyImpl(Dova.JDK.java.nio.channels.MulticastChannel arg0, Dova.JDK.java.net.InetAddress arg1, Dova.JDK.java.net.NetworkInterface arg2, Dova.JDK.java.net.InetAddress arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/MembershipKeyImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/net/InetAddress;", "public")]
	public Dova.JDK.java.net.InetAddress group()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", "public")]
	public Dova.JDK.java.nio.channels.MembershipKey block(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/channels/MulticastChannel;", "public")]
	public Dova.JDK.java.nio.channels.MulticastChannel channel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MulticastChannel>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void drop()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Ljava/net/NetworkInterface;", "public")]
	public Dova.JDK.java.net.NetworkInterface networkInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.NetworkInterface>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", "public")]
	public Dova.JDK.java.nio.channels.MembershipKey unblock(Dova.JDK.java.net.InetAddress arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.MembershipKey>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/InetAddress;", "public")]
	public Dova.JDK.java.net.InetAddress sourceAddress()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.InetAddress>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void invalidate()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("Lsun/nio/ch/MembershipKeyImpl$Type6;", "static")]
	public partial class Type6
		: Dova.JDK.sun.nio.ch.MembershipKeyImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type6()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/MembershipKeyImpl$Type6;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupAddress", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceAddress", "[B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;[BI[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "index", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "source", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupAddress", "()[B"));
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> groupAddress_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> sourceAddress_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type6(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;[BI[B)V", "")]
		public Type6(Dova.JDK.java.nio.channels.MulticastChannel arg0, Dova.JDK.java.net.InetAddress arg1, Dova.JDK.java.net.NetworkInterface arg2, Dova.JDK.java.net.InetAddress arg3, JavaArray<byte> arg4, int arg5, JavaArray<byte> arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/MembershipKeyImpl$Type6;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int index()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()[B", "")]
		public JavaArray<byte> source()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()[B", "")]
		public JavaArray<byte> groupAddress()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/MembershipKeyImpl$Type4;", "static")]
	public partial class Type4
		: Dova.JDK.sun.nio.ch.MembershipKeyImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type4()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/MembershipKeyImpl$Type4;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "groupAddress", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfAddress", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceAddress", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "source", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "groupAddress", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaceAddress", "()I"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int groupAddress_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int interfAddress_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int sourceAddress_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type4(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/channels/MulticastChannel;Ljava/net/InetAddress;Ljava/net/NetworkInterface;Ljava/net/InetAddress;III)V", "")]
		public Type4(Dova.JDK.java.nio.channels.MulticastChannel arg0, Dova.JDK.java.net.InetAddress arg1, Dova.JDK.java.net.NetworkInterface arg2, Dova.JDK.java.net.InetAddress arg3, int arg4, int arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/MembershipKeyImpl$Type4;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "")]
		public int source()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int groupAddress()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int interfaceAddress()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
