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

[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAOperations;", "public")]
public partial class EdDSAOperations
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EdDSAOperations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/EdDSAOperations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "params", "Lsun/security/ec/ed/EdDSAParameters;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ec/ed/EdDSAParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode", "(ILsun/security/ec/point/Point;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode", "(ILsun/security/ec/point/AffinePoint;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lsun/security/ec/ed/EdDSAParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sign", "(Ljava/security/spec/EdDSAParameterSpec;[B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Ljava/security/spec/EdDSAParameterSpec;Lsun/security/ec/point/AffinePoint;[B[B[B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "verify", "(Ljava/security/spec/EdDSAParameterSpec;[B[B[B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatePrivate", "(Ljava/security/SecureRandom;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prune", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prune", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeAffinePoint", "(Ljava/util/function/Function;[B)Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeAffinePoint", "(Ljava/util/function/Function;Ljava/security/spec/EdECPoint;)Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asEdECPoint", "(Lsun/security/ec/point/AffinePoint;)Ljava/security/spec/EdECPoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePublic", "([B)Ljava/security/spec/EdECPoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "maskHighOrder", "([BI)I"));
	}

	[JniSignatureAttribute("Lsun/security/ec/ed/EdDSAParameters;", "private final")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters @params_Property
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
	public EdDSAOperations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ec/ed/EdDSAParameters;)V", "public")]
	public EdDSAOperations(Dova.JDK.sun.security.ec.ed.EdDSAParameters arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/ed/EdDSAOperations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILsun/security/ec/point/Point;)[B", "private static")]
	public static JavaArray<byte> encode(int arg0, Dova.JDK.sun.security.ec.point.Point arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(ILsun/security/ec/point/AffinePoint;)[B", "private static")]
	public static JavaArray<byte> encode(int arg0, Dova.JDK.sun.security.ec.point.AffinePoint arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/ed/EdDSAParameters;", "public")]
	public Dova.JDK.sun.security.ec.ed.EdDSAParameters getParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.ed.EdDSAParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;[B[B)[B", "public")]
	public JavaArray<byte> sign(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0, JavaArray<byte> arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;Lsun/security/ec/point/AffinePoint;[B[B[B)Z", "public")]
	public bool verify(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0, Dova.JDK.sun.security.ec.point.AffinePoint arg1, JavaArray<byte> arg2, JavaArray<byte> arg3, JavaArray<byte> arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/spec/EdDSAParameterSpec;[B[B[B)Z", "public")]
	public bool verify(Dova.JDK.java.security.spec.EdDSAParameterSpec arg0, JavaArray<byte> arg1, JavaArray<byte> arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandom;)[B", "public")]
	public JavaArray<byte> generatePrivate(Dova.JDK.java.security.SecureRandom arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BII)V", "private static")]
	public static void prune(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([B)V", "")]
	public void prune(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;[B)Lsun/security/ec/point/AffinePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.AffinePoint decodeAffinePoint(Dova.JDK.java.util.function.Function arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;Ljava/security/spec/EdECPoint;)Lsun/security/ec/point/AffinePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.AffinePoint decodeAffinePoint(Dova.JDK.java.util.function.Function arg0, Dova.JDK.java.security.spec.EdECPoint arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Ljava/security/spec/EdECPoint;", "private static")]
	public static Dova.JDK.java.security.spec.EdECPoint asEdECPoint(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.EdECPoint>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/security/spec/EdECPoint;", "public")]
	public Dova.JDK.java.security.spec.EdECPoint computePublic(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.spec.EdECPoint>(ret);
	}

	[JniSignatureAttribute("([BI)I", "private static")]
	public static int maskHighOrder(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}
}
