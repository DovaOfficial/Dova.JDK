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

[JniSignatureAttribute("Lsun/security/ssl/SSLAlgorithmConstraints;", "final")]
public partial class SSLAlgorithmConstraints
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.security.AlgorithmConstraints
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLAlgorithmConstraints()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLAlgorithmConstraints;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tlsDisabledAlgConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "x509DisabledAlgConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userSpecifiedConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peerSpecifiedConstraints", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabledX509DisabledAlgConstraints", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Ljava/security/AlgorithmConstraints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_SSL_ONLY", "Ljava/security/AlgorithmConstraints;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLEngine;[Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocket;[Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLEngine;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLSocket;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/AlgorithmConstraints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/lang/String;Ljava/security/Key;Ljava/security/AlgorithmParameters;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/lang/String;Ljava/security/AlgorithmParameters;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/security/Key;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUserSpecifiedConstraints", "(Ljavax/net/ssl/SSLEngine;)Ljava/security/AlgorithmConstraints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUserSpecifiedConstraints", "(Ljavax/net/ssl/SSLSocket;)Ljava/security/AlgorithmConstraints;"));
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "private static final")]
	public static Dova.JDK.java.security.AlgorithmConstraints tlsDisabledAlgConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "private static final")]
	public static Dova.JDK.java.security.AlgorithmConstraints x509DisabledAlgConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "private final")]
	public Dova.JDK.java.security.AlgorithmConstraints userSpecifiedConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "private final")]
	public Dova.JDK.java.security.AlgorithmConstraints peerSpecifiedConstraints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool enabledX509DisabledAlgConstraints_Property
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

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "static final")]
	public static Dova.JDK.java.security.AlgorithmConstraints DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/AlgorithmConstraints;", "static final")]
	public static Dova.JDK.java.security.AlgorithmConstraints DEFAULT_SSL_ONLY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLAlgorithmConstraints(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngine;[Ljava/lang/String;Z)V", "")]
	public SSLAlgorithmConstraints(Dova.JDK.javax.net.ssl.SSLEngine arg0, JavaArray<Dova.JDK.java.lang.String> arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocket;[Ljava/lang/String;Z)V", "")]
	public SSLAlgorithmConstraints(Dova.JDK.javax.net.ssl.SSLSocket arg0, JavaArray<Dova.JDK.java.lang.String> arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngine;Z)V", "")]
	public SSLAlgorithmConstraints(Dova.JDK.javax.net.ssl.SSLEngine arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocket;Z)V", "")]
	public SSLAlgorithmConstraints(Dova.JDK.javax.net.ssl.SSLSocket arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/security/AlgorithmConstraints;)V", "")]
	public SSLAlgorithmConstraints(Dova.JDK.java.security.AlgorithmConstraints arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLAlgorithmConstraints;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/security/Key;Ljava/security/AlgorithmParameters;)Z", "public")]
	public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.Key arg2, Dova.JDK.java.security.AlgorithmParameters arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/security/AlgorithmParameters;)Z", "public")]
	public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.AlgorithmParameters arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/security/Key;)Z", "public")]
	public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.security.Key arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngine;)Ljava/security/AlgorithmConstraints;", "private static")]
	public static Dova.JDK.java.security.AlgorithmConstraints getUserSpecifiedConstraints(Dova.JDK.javax.net.ssl.SSLEngine arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSocket;)Ljava/security/AlgorithmConstraints;", "private static")]
	public static Dova.JDK.java.security.AlgorithmConstraints getUserSpecifiedConstraints(Dova.JDK.javax.net.ssl.SSLSocket arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.AlgorithmConstraints>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ssl/SSLAlgorithmConstraints$SupportedSignatureAlgorithmConstraints;", "private static")]
	public partial class SupportedSignatureAlgorithmConstraints
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.security.AlgorithmConstraints
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SupportedSignatureAlgorithmConstraints()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLAlgorithmConstraints$SupportedSignatureAlgorithmConstraints;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportedAlgorithms", "[Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/lang/String;Ljava/security/Key;Ljava/security/AlgorithmParameters;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/security/Key;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permits", "(Ljava/util/Set;Ljava/lang/String;Ljava/security/AlgorithmParameters;)Z"));
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
		public JavaArray<Dova.JDK.java.lang.String> supportedAlgorithms_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SupportedSignatureAlgorithmConstraints(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/String;)V", "")]
		public SupportedSignatureAlgorithmConstraints(JavaArray<Dova.JDK.java.lang.String> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ssl/SSLAlgorithmConstraints$SupportedSignatureAlgorithmConstraints;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/security/Key;Ljava/security/AlgorithmParameters;)Z", "public final")]
		public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.Key arg2, Dova.JDK.java.security.AlgorithmParameters arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/security/Key;)Z", "public final")]
		public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.security.Key arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/lang/String;Ljava/security/AlgorithmParameters;)Z", "public")]
		public bool permits(Dova.JDK.java.util.Set arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.AlgorithmParameters arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}
}
