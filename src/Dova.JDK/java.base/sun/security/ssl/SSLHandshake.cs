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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "final")]
public partial class SSLHandshake
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.sun.security.ssl.SSLConsumer
	, Dova.JDK.sun.security.ssl.HandshakeProducer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLHandshake()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLHandshake;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELLO_REQUEST", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLIENT_HELLO", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERVER_HELLO", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELLO_RETRY_REQUEST", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELLO_VERIFY_REQUEST", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW_SESSION_TICKET", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_OF_EARLY_DATA", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCRYPTED_EXTENSIONS", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CERTIFICATE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERVER_KEY_EXCHANGE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CERTIFICATE_REQUEST", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERVER_HELLO_DONE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CERTIFICATE_VERIFY", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLIENT_KEY_EXCHANGE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINISHED", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CERTIFICATE_URL", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CERTIFICATE_STATUS", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPLEMENTAL_DATA", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEY_UPDATE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MESSAGE_HASH", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_APPLICABLE", "Lsun/security/ssl/SSLHandshake;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeConsumers", "[Ljava/util/Map$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeProducers", "[Ljava/util/Map$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeAbsences", "[Ljava/util/Map$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/SSLHandshake;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IBLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IBLjava/lang/String;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IBLjava/lang/String;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/SSLHandshake;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/SSLHandshake;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/SSLHandshake;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isKnown", "(B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameOf", "(B)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "kickstart", "(Lsun/security/ssl/HandshakeContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "produce", "(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeConsumer", "(Lsun/security/ssl/ConnectionContext;)Lsun/security/ssl/SSLConsumer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandshakeProducer", "(Lsun/security/ssl/ConnectionContext;)Lsun/security/ssl/HandshakeProducer;"));
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake HELLO_REQUEST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CLIENT_HELLO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake SERVER_HELLO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake HELLO_RETRY_REQUEST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake HELLO_VERIFY_REQUEST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake NEW_SESSION_TICKET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake END_OF_EARLY_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake ENCRYPTED_EXTENSIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CERTIFICATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake SERVER_KEY_EXCHANGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CERTIFICATE_REQUEST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake SERVER_HELLO_DONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CERTIFICATE_VERIFY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CLIENT_KEY_EXCHANGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake FINISHED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CERTIFICATE_URL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake CERTIFICATE_STATUS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake SUPPLEMENTAL_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake KEY_UPDATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake MESSAGE_HASH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake;", "public static final")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake NOT_APPLICABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("B", "final")]
	public byte id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Map$Entry;", "final")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> handshakeConsumers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Map$Entry;", "final")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> handshakeProducers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/util/Map$Entry;", "final")]
	public JavaArray<Dova.JDK.java.util.Map.Entry> handshakeAbsences_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Map.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/security/ssl/SSLHandshake;", "private static final")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLHandshake(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IBLjava/lang/String;)V", "private")]
	public SSLHandshake(Dova.JDK.java.lang.String arg0, int arg1, byte arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IBLjava/lang/String;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V", "private")]
	public SSLHandshake(Dova.JDK.java.lang.String arg0, int arg1, byte arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.util.Map.Entry> arg4, JavaArray<Dova.JDK.java.util.Map.Entry> arg5, JavaArray<Dova.JDK.java.util.Map.Entry> arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IBLjava/lang/String;[Ljava/util/Map$Entry;[Ljava/util/Map$Entry;)V", "private")]
	public SSLHandshake(Dova.JDK.java.lang.String arg0, int arg1, byte arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.util.Map.Entry> arg4, JavaArray<Dova.JDK.java.util.Map.Entry> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLHandshake;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/SSLHandshake;", "public static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/SSLHandshake;", "public static")]
	public static Dova.JDK.sun.security.ssl.SSLHandshake valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
	}

	[JniSignatureAttribute("()[Lsun/security/ssl/SSLHandshake;", "private static")]
	public static JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.SSLHandshake>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V", "public")]
	public void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(B)Z", "static")]
	public static bool isKnown(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String nameOf(byte arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)V", "static final")]
	public static void kickstart(Dova.JDK.sun.security.ssl.HandshakeContext arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Lsun/security/ssl/SSLHandshake$HandshakeMessage;)[B", "public")]
	public JavaArray<byte> produce(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.sun.security.ssl.SSLHandshake.HandshakeMessage arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;)Lsun/security/ssl/SSLConsumer;", "private")]
	public Dova.JDK.sun.security.ssl.SSLConsumer getHandshakeConsumer(Dova.JDK.sun.security.ssl.ConnectionContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLConsumer>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;)Lsun/security/ssl/HandshakeProducer;", "private")]
	public Dova.JDK.sun.security.ssl.HandshakeProducer getHandshakeProducer(Dova.JDK.sun.security.ssl.ConnectionContext arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeProducer>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLHandshake$HandshakeMessage;", "abstract static")]
	public partial class HandshakeMessage
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeMessage()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLHandshake$HandshakeMessage;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handshakeContext", "Lsun/security/ssl/HandshakeContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ssl/HandshakeContext;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lsun/security/ssl/HandshakeOutStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "messageLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handshakeType", "()Lsun/security/ssl/SSLHandshake;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "send", "(Lsun/security/ssl/HandshakeOutStream;)V"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/HandshakeContext;", "final")]
		public Dova.JDK.sun.security.ssl.HandshakeContext handshakeContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.HandshakeContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeMessage(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeContext;)V", "")]
		public HandshakeMessage(Dova.JDK.sun.security.ssl.HandshakeContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLHandshake$HandshakeMessage;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeOutStream;)V", "")]
		public void write(Dova.JDK.sun.security.ssl.HandshakeOutStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()I", "abstract")]
		public int messageLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lsun/security/ssl/SSLHandshake;", "abstract")]
		public Dova.JDK.sun.security.ssl.SSLHandshake handshakeType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.SSLHandshake>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/HandshakeOutStream;)V", "abstract")]
		public void send(Dova.JDK.sun.security.ssl.HandshakeOutStream arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
