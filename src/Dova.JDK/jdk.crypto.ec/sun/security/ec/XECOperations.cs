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

namespace Dova.JDK.sun.security.ec;

[JniSignatureAttribute("Lsun/security/ec/XECOperations;", "public")]
public partial class XECOperations
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XECOperations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/XECOperations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "params", "Lsun/security/ec/XECParameters;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Lsun/security/util/math/IntegerFieldModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zero", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "one", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "a24", "Lsun/security/util/math/SmallValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "basePoint", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/security/ec/XECParameters;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lsun/security/ec/XECParameters;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generatePrivate", "(Ljava/security/SecureRandom;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computePublic", "([B)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getIntegerFieldModulo", "(Ljava/math/BigInteger;)Lsun/security/util/math/IntegerFieldModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pruneK", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pruneK", "([BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pointMultiply", "([BLsun/security/util/math/ImmutableIntegerModuloP;)Lsun/security/util/math/IntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeU", "([BI)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeU", "([B)Lsun/security/util/math/ImmutableIntegerModuloP;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "maskHighOrder", "([BI)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bitAt", "([BI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cswap", "(ILsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodedPointMultiply", "([BLjava/math/BigInteger;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "encodedPointMultiply", "([B[B)[B"));
	}

	[JniSignatureAttribute("Lsun/security/ec/XECParameters;", "private final")]
	public Dova.JDK.sun.security.ec.XECParameters @params_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.XECParameters>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/IntegerFieldModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.IntegerFieldModuloP field_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP zero_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP one_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/SmallValue;", "private final")]
	public Dova.JDK.sun.security.util.math.SmallValue a24_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.SmallValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP basePoint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XECOperations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/ec/XECParameters;)V", "public")]
	public XECOperations(Dova.JDK.sun.security.ec.XECParameters arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/XECOperations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/security/ec/XECParameters;", "public")]
	public Dova.JDK.sun.security.ec.XECParameters getParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.XECParameters>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/SecureRandom;)[B", "public")]
	public JavaArray<byte> generatePrivate(Dova.JDK.java.security.SecureRandom arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger computePublic(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("(Ljava/math/BigInteger;)Lsun/security/util/math/IntegerFieldModuloP;", "private static")]
	public static Dova.JDK.sun.security.util.math.IntegerFieldModuloP getIntegerFieldModulo(Dova.JDK.java.math.BigInteger arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerFieldModuloP>(ret);
	}

	[JniSignatureAttribute("([B)V", "private")]
	public void pruneK(JavaArray<byte> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("([BII)V", "private static")]
	public static void pruneK(JavaArray<byte> arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BLsun/security/util/math/ImmutableIntegerModuloP;)Lsun/security/util/math/IntegerModuloP;", "private")]
	public Dova.JDK.sun.security.util.math.IntegerModuloP pointMultiply(JavaArray<byte> arg0, Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.IntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([BI)Lsun/security/util/math/ImmutableIntegerModuloP;", "private")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP decodeU(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/util/math/ImmutableIntegerModuloP;", "private")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP decodeU(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
	}

	[JniSignatureAttribute("([BI)B", "private static")]
	public static byte maskHighOrder(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticByteMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([BI)I", "private")]
	public int bitAt(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)V", "private static")]
	public static void cswap(int arg0, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("([BLjava/math/BigInteger;)[B", "public")]
	public JavaArray<byte> encodedPointMultiply(JavaArray<byte> arg0, Dova.JDK.java.math.BigInteger arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[B)[B", "public")]
	public JavaArray<byte> encodedPointMultiply(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}
}
