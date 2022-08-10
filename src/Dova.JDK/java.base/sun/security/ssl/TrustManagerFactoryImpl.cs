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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/TrustManagerFactoryImpl;", "abstract")]
public partial class TrustManagerFactoryImpl
	: Dova.JDK.javax.net.ssl.TrustManagerFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TrustManagerFactoryImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/TrustManagerFactoryImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "trustManager", "Ljavax/net/ssl/X509TrustManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isInitialized", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TrustManagerFactoryImpl", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getFileInputStream", "(Ljava/io/File;)Ljava/io/FileInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "engineInit", "(Ljava/security/KeyStore;)V"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/X509TrustManager;", "private")]
	public Dova.JDK.javax.net.ssl.X509TrustManager trustManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isInitialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TrustManagerFactoryImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public TrustManagerFactoryImpl() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/TrustManagerFactoryImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;", "abstract")]
	public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;", "abstract")]
	public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/net/ssl/TrustManager;", "protected")]
	public JavaArray<Dova.JDK.javax.net.ssl.TrustManager> engineGetTrustManagers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.TrustManager>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/io/FileInputStream;", "private static")]
	public static Dova.JDK.java.io.FileInputStream getFileInputStream(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)V", "protected")]
	public void engineInit(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/security/KeyStore;)V", "protected")]
	public void engineInit(Dova.JDK.java.security.KeyStore arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("Lsun/security/ssl/TrustManagerFactoryImpl$PKIXFactory;", "public static final")]
	public partial class PKIXFactory
		: Dova.JDK.sun.security.ssl.TrustManagerFactoryImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PKIXFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/TrustManagerFactoryImpl$PKIXFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PKIXFactory", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PKIXFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public PKIXFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/TrustManagerFactoryImpl$PKIXFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;", "")]
		public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;", "")]
		public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/security/ssl/TrustManagerFactoryImpl$SimpleFactory;", "public static final")]
	public partial class SimpleFactory
		: Dova.JDK.sun.security.ssl.TrustManagerFactoryImpl
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/TrustManagerFactoryImpl$SimpleFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SimpleFactory", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SimpleFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/TrustManagerFactoryImpl$SimpleFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Collection;)Ljavax/net/ssl/X509TrustManager;", "")]
		public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}

		[JniSignatureAttribute("(Ljavax/net/ssl/ManagerFactoryParameters;)Ljavax/net/ssl/X509TrustManager;", "")]
		public Dova.JDK.javax.net.ssl.X509TrustManager getInstance(Dova.JDK.javax.net.ssl.ManagerFactoryParameters arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.X509TrustManager>(ret);
		}
	}
}
