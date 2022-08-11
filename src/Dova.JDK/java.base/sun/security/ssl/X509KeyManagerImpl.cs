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

[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl;", "final")]
public partial class X509KeyManagerImpl
	: Dova.JDK.javax.net.ssl.X509ExtendedKeyManager
	, Dova.JDK.javax.net.ssl.X509KeyManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static X509KeyManagerImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "verificationDate", "Ljava/util/Date;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "builders", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uidCounter", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entryCacheMap", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/KeyStore$Builder;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntry", "(Ljava/lang/String;)Ljava/security/KeyStore$PrivateKeyEntry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getKeyTypes", "([Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseEngineClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseEngineServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithmConstraints", "(Ljavax/net/ssl/SSLEngine;)Ljava/security/AlgorithmConstraints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlgorithmConstraints", "(Ljava/net/Socket;)Ljava/security/AlgorithmConstraints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseAlias", "(Ljava/util/List;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "chooseAlias", "(Ljava/util/List;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIssuerSet", "([Ljava/security/Principal;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeAlias", "(Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAliases", "(Ljava/util/List;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "conformsToAlgorithmConstraints", "(Ljava/security/AlgorithmConstraints;[Ljava/security/cert/Certificate;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAliases", "(Ljava/lang/String;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAliases", "(ILjava/util/List;Ljava/util/Set;ZLsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;Ljava/util/List;Ljava/lang/String;)Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/util/Date;", "private static")]
	public static Dova.JDK.java.util.Date verificationDate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Date>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List builders_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private final")]
	public Dova.JDK.java.util.concurrent.atomic.AtomicLong uidCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map entryCacheMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public X509KeyManagerImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/security/KeyStore$Builder;)V", "")]
	public X509KeyManagerImpl(Dova.JDK.java.security.KeyStore.Builder arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "")]
	public X509KeyManagerImpl(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/security/KeyStore$PrivateKeyEntry;", "private")]
	public Dova.JDK.java.security.KeyStore.PrivateKeyEntry getEntry(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.KeyStore.PrivateKeyEntry>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/List;", "private static transient")]
	public static Dova.JDK.java.util.List getKeyTypes(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getClientAliases(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.security.Principal> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String chooseClientAlias(JavaArray<Dova.JDK.java.lang.String> arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.java.net.Socket arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getServerAliases(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.security.Principal> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String chooseServerAlias(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.java.net.Socket arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String chooseEngineClientAlias(JavaArray<Dova.JDK.java.lang.String> arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String chooseEngineServerAlias(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.javax.net.ssl.SSLEngine arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngine;)Ljava/security/AlgorithmConstraints;", "private")]
	public Dova.JDK.java.security.AlgorithmConstraints getAlgorithmConstraints(Dova.JDK.javax.net.ssl.SSLEngine arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/Socket;)Ljava/security/AlgorithmConstraints;", "private")]
	public Dova.JDK.java.security.AlgorithmConstraints getAlgorithmConstraints(Dova.JDK.java.net.Socket arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", "public")]
	public JavaArray<Dova.JDK.java.security.cert.X509Certificate> getCertificateChain(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.security.cert.X509Certificate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/security/PrivateKey;", "public")]
	public Dova.JDK.java.security.PrivateKey getPrivateKey(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String chooseAlias(Dova.JDK.java.util.List arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType arg2, Dova.JDK.java.security.AlgorithmConstraints arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.lang.String arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String chooseAlias(Dova.JDK.java.util.List arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType arg2, Dova.JDK.java.security.AlgorithmConstraints arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/security/Principal;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set getIssuerSet(JavaArray<Dova.JDK.java.security.Principal> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String makeAlias(Dova.JDK.sun.security.ssl.X509KeyManagerImpl.EntryStatus arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)[Ljava/lang/String;", "private")]
	public JavaArray<Dova.JDK.java.lang.String> toAliases(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;[Ljava/security/cert/Certificate;Ljava/lang/String;)Z", "private static")]
	public static bool conformsToAlgorithmConstraints(Dova.JDK.java.security.AlgorithmConstraints arg0, JavaArray<Dova.JDK.java.security.cert.Certificate> arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/security/Principal;Lsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getAliases(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.security.Principal> arg1, Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType arg2, Dova.JDK.java.security.AlgorithmConstraints arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/List;Ljava/util/Set;ZLsun/security/ssl/X509KeyManagerImpl$CheckType;Ljava/security/AlgorithmConstraints;Ljava/util/List;Ljava/lang/String;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getAliases(int arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Set arg2, bool arg3, Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType arg4, Dova.JDK.java.security.AlgorithmConstraints arg5, Dova.JDK.java.util.List arg6, Dova.JDK.java.lang.String arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$SizedMap;", "private static")]
	public partial class SizedMap
		: Dova.JDK.java.util.LinkedHashMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SizedMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl$SizedMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeEldestEntry", "(Ljava/util/Map$Entry;)Z"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SizedMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public SizedMap() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl$SizedMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Map$Entry;)Z", "protected")]
		public bool removeEldestEntry(Dova.JDK.java.util.Map.Entry arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "private static final")]
	public partial class CheckType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl$CheckType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLIENT", "Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERVER", "Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validEku", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljava/security/cert/X509Certificate;Ljava/util/Date;Ljava/util/List;Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/X509KeyManagerImpl$CheckType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValidator", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBit", "([ZI)Z"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType CLIENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType SERVER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set validEku_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Set;)V", "private")]
		public CheckType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Set arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl$CheckType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "public static")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/cert/X509Certificate;Ljava/util/Date;Ljava/util/List;Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "")]
		public Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult check(Dova.JDK.java.security.cert.X509Certificate arg0, Dova.JDK.java.util.Date arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/X509KeyManagerImpl$CheckType;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckType>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getValidator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("([ZI)Z", "private static")]
		public static bool getBit(JavaArray<bool> arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;", "private static")]
	public partial class EntryStatus
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Comparable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EntryStatus()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "builderIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alias", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "checkResult", "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/lang/String;[Ljava/security/cert/Certificate;Lsun/security/ssl/X509KeyManagerImpl$CheckResult;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		}

		[JniSignatureAttribute("I", "final")]
		public int builderIndex_Property
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

		[JniSignatureAttribute("I", "final")]
		public int keyIndex_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String alias_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "final")]
		public Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult checkResult_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EntryStatus(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IILjava/lang/String;[Ljava/security/cert/Certificate;Lsun/security/ssl/X509KeyManagerImpl$CheckResult;)V", "")]
		public EntryStatus(int arg0, int arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.security.cert.Certificate> arg3, Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lsun/security/ssl/X509KeyManagerImpl$EntryStatus;)I", "public")]
		public int compareTo(Dova.JDK.sun.security.ssl.X509KeyManagerImpl.EntryStatus arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$KeyType;", "private static")]
	public partial class KeyType
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl$KeyType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keyAlgorithm", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sigKeyAlgorithm", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "([Ljava/security/cert/Certificate;)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String keyAlgorithm_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String sigKeyAlgorithm_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public KeyType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl$KeyType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([Ljava/security/cert/Certificate;)Z", "")]
		public bool matches(JavaArray<Dova.JDK.java.security.cert.Certificate> arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "private static final")]
	public partial class CheckResult
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CheckResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OK", "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSENSITIVE", "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPIRED", "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENSION_MISMATCH", "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;"));
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult INSENSITIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult EXPIRED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static final")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult EXTENSION_MISMATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "private static final")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CheckResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public CheckResult(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/X509KeyManagerImpl$CheckResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "public static")]
		public static Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>(ret);
		}

		[JniSignatureAttribute("()[Lsun/security/ssl/X509KeyManagerImpl$CheckResult;", "private static")]
		public static JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.security.ssl.X509KeyManagerImpl.CheckResult>>(ret);
		}
	}
}
