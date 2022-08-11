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

namespace Dova.JDK.sun.security.ec.ed;

[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAKeyFactory;", "public")]
public partial class EdDSAKeyFactory
	: Dova.JDK.java.security.KeyFactorySpi
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdDSAKeyFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAKeyFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lockedParams", "Lsun/security/ec/ed/EdDSAParameters;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/spec/NamedParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatePublicImpl", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkLockedParams", "(Ljava/util/function/Function;Ljava/security/spec/NamedParameterSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkLockedParams", "(Ljava/util/function/Function;Lsun/security/ec/ed/EdDSAParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatePrivateImpl", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;"));
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters;", "private")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters lockedParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EdDSAKeyFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public EdDSAKeyFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/security/spec/NamedParameterSpec;)V", "protected")]
	public EdDSAKeyFactory(Dova.JDK.java.security.spec.NamedParameterSpec arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAKeyFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "protected")]
	public Dova.JDK.java.security.PublicKey engineGeneratePublic(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", "protected")]
	public Dova.JDK.java.security.PrivateKey engineGeneratePrivate(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;)Ljava/security/Key;", "protected")]
	public Dova.JDK.java.security.Key engineTranslateKey(Dova.JDK.java.security.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.Key>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", "protected")]
	public Dova.JDK.java.lang.Object engineGetKeySpec(Dova.JDK.java.security.Key arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", "private")]
	public Dova.JDK.java.security.PublicKey generatePublicImpl(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PublicKey>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/security/spec/NamedParameterSpec;)V", "private")]
	public void checkLockedParams(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.security.spec.NamedParameterSpec arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Lsun/security/ec/ed/EdDSAParameters;)V", "private")]
	public void checkLockedParams(Dova.JDK.java.util.function.Function arg0, Dova.JDK.sun.security.ec.ed.EdDSAParameters arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", "private")]
	public Dova.JDK.java.security.PrivateKey generatePrivateImpl(Dova.JDK.java.security.spec.KeySpec arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivateKey>(ret);
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAKeyFactory$Ed448;", "public static")]
	public partial class Ed448
		: Dova.JDK.sun.security.ec.ed.EdDSAKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ed448()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAKeyFactory$Ed448;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ed448(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Ed448() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAKeyFactory$Ed448;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAKeyFactory$Ed25519;", "public static")]
	public partial class Ed25519
		: Dova.JDK.sun.security.ec.ed.EdDSAKeyFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Ed25519()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAKeyFactory$Ed25519;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Ed25519(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Ed25519() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAKeyFactory$Ed25519;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
