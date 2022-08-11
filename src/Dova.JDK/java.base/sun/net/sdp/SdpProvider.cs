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

namespace Dova.JDK.sun.net.sdp;

[JniSignatureAttribute("Lsun/net/sdp/SdpProvider;", "public")]
public partial class SdpProvider
	: Dova.JDK.sun.net.NetHooks.Provider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SdpProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/sdp/SdpProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_PORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rules", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "log", "Ljava/io/PrintStream;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fail", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadRulesFromFile", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parsePortRange", "(Ljava/lang/String;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertTcpToSdpIfMatch", "(Ljava/io/FileDescriptor;Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implBeforeTcpBind", "(Ljava/io/FileDescriptor;Ljava/net/InetAddress;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implBeforeTcpConnect", "(Ljava/io/FileDescriptor;Ljava/net/InetAddress;I)V"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_PORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool enabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List rules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintStream;", "private")]
	public Dova.JDK.java.io.PrintStream log_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SdpProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SdpProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/sdp/SdpProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private static transient")]
	public static void fail(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List loadRulesFromFile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[I", "private static")]
	public static JavaArray<int> parsePortRange(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)V", "private")]
	public void convertTcpToSdpIfMatch(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.sun.net.sdp.SdpProvider.Action arg1, Dova.JDK.java.net.InetAddress arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/net/InetAddress;I)V", "public")]
	public void implBeforeTcpBind(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.net.InetAddress arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/net/InetAddress;I)V", "public")]
	public void implBeforeTcpConnect(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.net.InetAddress arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$Action;", "private static final")]
	public partial class Action
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Action()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/sdp/SdpProvider$Action;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIND", "Lsun/net/sdp/SdpProvider$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONNECT", "Lsun/net/sdp/SdpProvider$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/net/sdp/SdpProvider$Action;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/net/sdp/SdpProvider$Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/net/sdp/SdpProvider$Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/net/sdp/SdpProvider$Action;"));
		}

		[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$Action;", "public static final")]
		public static Dova.JDK.sun.net.sdp.SdpProvider.Action BIND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.sdp.SdpProvider.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$Action;", "public static final")]
		public static Dova.JDK.sun.net.sdp.SdpProvider.Action CONNECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.sdp.SdpProvider.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/net/sdp/SdpProvider$Action;", "private static final")]
		public static JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Action(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Action(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/sdp/SdpProvider$Action;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/net/sdp/SdpProvider$Action;", "public static")]
		public static JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/sdp/SdpProvider$Action;", "public static")]
		public static Dova.JDK.sun.net.sdp.SdpProvider.Action valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.sdp.SdpProvider.Action>(ret);
		}

		[JniSignatureAttribute("()[Lsun/net/sdp/SdpProvider$Action;", "private static")]
		public static JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.sdp.SdpProvider.Action>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$PortRangeRule;", "private static")]
	public partial class PortRangeRule
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.net.sdp.SdpProvider.Rule
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PortRangeRule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/sdp/SdpProvider$PortRangeRule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Lsun/net/sdp/SdpProvider$Action;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "portStart", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "portEnd", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/sdp/SdpProvider$Action;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "action", "()Lsun/net/sdp/SdpProvider$Action;"));
		}

		[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$Action;", "private final")]
		public Dova.JDK.sun.net.sdp.SdpProvider.Action action_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.sdp.SdpProvider.Action>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int portStart_Property
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
		public int portEnd_Property
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
		public PortRangeRule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/net/sdp/SdpProvider$Action;II)V", "")]
		public PortRangeRule(Dova.JDK.sun.net.sdp.SdpProvider.Action arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/sdp/SdpProvider$PortRangeRule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z", "public")]
		public bool match(Dova.JDK.sun.net.sdp.SdpProvider.Action arg0, Dova.JDK.java.net.InetAddress arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/net/sdp/SdpProvider$Action;", "")]
		public Dova.JDK.sun.net.sdp.SdpProvider.Action action()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.sdp.SdpProvider.Action>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$AddressPortRangeRule;", "private static")]
	public partial class AddressPortRangeRule
		: Dova.JDK.sun.net.sdp.SdpProvider.PortRangeRule
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AddressPortRangeRule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/sdp/SdpProvider$AddressPortRangeRule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addressAsBytes", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefixByteCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask", "B"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z"));
		}

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> addressAsBytes_Property
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
		public int prefixByteCount_Property
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

		[JniSignatureAttribute("B", "private final")]
		public byte mask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AddressPortRangeRule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;III)V", "")]
		public AddressPortRangeRule(Dova.JDK.sun.net.sdp.SdpProvider.Action arg0, Dova.JDK.java.net.InetAddress arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/sdp/SdpProvider$AddressPortRangeRule;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z", "public")]
		public bool match(Dova.JDK.sun.net.sdp.SdpProvider.Action arg0, Dova.JDK.java.net.InetAddress arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/net/sdp/SdpProvider$Rule;", "private abstract static interface")]
	public partial interface Rule
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Rule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/sdp/SdpProvider$Rule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z"));
		}

		[JniSignatureAttribute("(Lsun/net/sdp/SdpProvider$Action;Ljava/net/InetAddress;I)Z", "public abstract")]
		bool match(Dova.JDK.sun.net.sdp.SdpProvider.Action arg0, Dova.JDK.java.net.InetAddress arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}
}
