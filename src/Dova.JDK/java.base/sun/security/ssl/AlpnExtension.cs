/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension;", "final")]
public partial class AlpnExtension
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AlpnExtension()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "chNetworkProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "chOnLoadConsumer", "Lsun/security/ssl/SSLExtension$ExtensionConsumer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "chOnLoadAbsence", "Lsun/security/ssl/HandshakeAbsence;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "shNetworkProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "shOnLoadConsumer", "Lsun/security/ssl/SSLExtension$ExtensionConsumer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "shOnLoadAbsence", "Lsun/security/ssl/HandshakeAbsence;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "eeNetworkProducer", "Lsun/security/ssl/HandshakeProducer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "eeOnLoadConsumer", "Lsun/security/ssl/SSLExtension$ExtensionConsumer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "eeOnLoadAbsence", "Lsun/security/ssl/HandshakeAbsence;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "alpnStringizer", "Lsun/security/ssl/SSLStringizer;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "alpnCharset", "Ljava/nio/charset/Charset;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AlpnExtension", "()V"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer chNetworkProducer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLExtension$ExtensionConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer chOnLoadConsumer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeAbsence;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeAbsence chOnLoadAbsence_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeAbsence>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer shNetworkProducer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLExtension$ExtensionConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer shOnLoadConsumer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeAbsence;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeAbsence shOnLoadAbsence_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeAbsence>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeProducer;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeProducer eeNetworkProducer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLExtension$ExtensionConsumer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer eeOnLoadConsumer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/HandshakeAbsence;", "static final")]
	public static Dova.JDK.sun.security.ssl.HandshakeAbsence eeOnLoadAbsence_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeAbsence>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLStringizer;", "static final")]
	public static Dova.JDK.sun.security.ssl.SSLStringizer alpnStringizer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLStringizer>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/charset/Charset;", "static final")]
	public static Dova.JDK.java.nio.charset.Charset alpnCharset_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.charset.Charset>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AlpnExtension(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public AlpnExtension() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$CHAlpnProducer;", "private static final")]
	public partial class CHAlpnProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CHAlpnProducer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$CHAlpnProducer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_AP_LENGTH", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_AP_LIST_LENGTH", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CHAlpnProducer", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MAX_AP_LENGTH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "static final")]
		public static int MAX_AP_LIST_LENGTH_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CHAlpnProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CHAlpnProducer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$CHAlpnProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$CHAlpnConsumer;", "private static final")]
	public partial class CHAlpnConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CHAlpnConsumer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$CHAlpnConsumer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CHAlpnConsumer", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CHAlpnConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CHAlpnConsumer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$CHAlpnConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1, Dova.JDK.java.nio.ByteBuffer arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$CHAlpnAbsence;", "private static final")]
	public partial class CHAlpnAbsence
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeAbsence
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CHAlpnAbsence()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$CHAlpnAbsence;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CHAlpnAbsence", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "absent", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CHAlpnAbsence(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public CHAlpnAbsence() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$CHAlpnAbsence;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "public")]
		public void absent(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$SHAlpnProducer;", "private static final")]
	public partial class SHAlpnProducer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeProducer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHAlpnProducer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$SHAlpnProducer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SHAlpnProducer", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHAlpnProducer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SHAlpnProducer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$SHAlpnProducer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
		public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$SHAlpnConsumer;", "private static final")]
	public partial class SHAlpnConsumer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLExtension.ExtensionConsumer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHAlpnConsumer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$SHAlpnConsumer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SHAlpnConsumer", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHAlpnConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SHAlpnConsumer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$SHAlpnConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;Ljava/nio/ByteBuffer;)V", "public")]
		public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1, Dova.JDK.java.nio.ByteBuffer arg2)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$SHAlpnAbsence;", "private static final")]
	public partial class SHAlpnAbsence
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.HandshakeAbsence
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SHAlpnAbsence()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$SHAlpnAbsence;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "SHAlpnAbsence", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "absent", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SHAlpnAbsence(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SHAlpnAbsence() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$SHAlpnAbsence;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)V", "public")]
		public void absent(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
		{
			DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$AlpnStringizer;", "private static final")]
	public partial class AlpnStringizer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLStringizer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AlpnStringizer()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$AlpnStringizer;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AlpnStringizer", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AlpnStringizer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AlpnStringizer() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$AlpnStringizer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/AlpnExtension$AlpnSpec;", "static final")]
	public partial class AlpnSpec
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.security.ssl.SSLExtension.SSLExtensionSpec
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AlpnSpec()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/security/ssl/AlpnExtension$AlpnSpec;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "applicationProtocols", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AlpnSpec", "([Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AlpnSpec", "(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List applicationProtocols_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AlpnSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/String;)V", "private")]
		public AlpnSpec(JavaArray<Dova.JDK.java.lang.String> arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;Ljava/nio/ByteBuffer;)V", "private")]
		public AlpnSpec(Dova.JDK.sun.security.ssl.HandshakeContext arg0, Dova.JDK.java.nio.ByteBuffer arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/AlpnExtension$AlpnSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}