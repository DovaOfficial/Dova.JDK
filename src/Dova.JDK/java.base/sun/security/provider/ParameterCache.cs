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

namespace Dova.JDK.sun.security.provider;

[JniSignatureAttribute("Lsun/security/provider/ParameterCache;", "public final")]
public partial class ParameterCache
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParameterCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/provider/ParameterCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "dsaCache", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "dhCache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParameterCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDSAParameterSpec", "(IILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDSAParameterSpec", "(ILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCachedDHParameterSpec", "(I)Ljavax/crypto/spec/DHParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDHParameterSpec", "(ILjava/security/SecureRandom;)Ljavax/crypto/spec/DHParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getNewDSAParameterSpec", "(IILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getCachedDSAParameterSpec", "(II)Ljava/security/spec/DSAParameterSpec;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map dsaCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map dhCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ParameterCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ParameterCache() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/provider/ParameterCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.DSAParameterSpec getDSAParameterSpec(int arg0, int arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.DSAParameterSpec>(ret);
	}

	[JniSignatureAttribute("(ILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.DSAParameterSpec getDSAParameterSpec(int arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.DSAParameterSpec>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/crypto/spec/DHParameterSpec;", "public static")]
	public static Dova.JDK.javax.crypto.spec.DHParameterSpec getCachedDHParameterSpec(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.DHParameterSpec>(ret);
	}

	[JniSignatureAttribute("(ILjava/security/SecureRandom;)Ljavax/crypto/spec/DHParameterSpec;", "public static")]
	public static Dova.JDK.javax.crypto.spec.DHParameterSpec getDHParameterSpec(int arg0, Dova.JDK.java.security.SecureRandom arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.crypto.spec.DHParameterSpec>(ret);
	}

	[JniSignatureAttribute("(IILjava/security/SecureRandom;)Ljava/security/spec/DSAParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.DSAParameterSpec getNewDSAParameterSpec(int arg0, int arg1, Dova.JDK.java.security.SecureRandom arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.DSAParameterSpec>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/security/spec/DSAParameterSpec;", "public static")]
	public static Dova.JDK.java.security.spec.DSAParameterSpec getCachedDSAParameterSpec(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.DSAParameterSpec>(ret);
	}
}
