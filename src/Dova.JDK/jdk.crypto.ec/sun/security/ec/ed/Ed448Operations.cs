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

namespace Dova.JDK.sun.security.ec.ed;

[JniSignatureAttribute("Lsun/security/ec/ed/Ed448Operations;", "public")]
public partial class Ed448Operations
	: Dova.JDK.sun.security.ec.ed.EdECOperations
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Ed448Operations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ec/ed/Ed448Operations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "two", "Lsun/security/util/math/SmallValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "d", "Lsun/security/util/math/ImmutableIntegerModuloP;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "basePoint", "Lsun/security/ec/point/ProjectivePoint$Immutable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TWO", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "THREE", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FIVE", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sizeMinus3", "Ljava/math/BigInteger;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Ed448Operations", "(Lsun/security/util/math/ImmutableIntegerModuloP;Ljava/math/BigInteger;Ljava/math/BigInteger;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "of_0", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ProjectivePoint$Immutable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "of_1", "(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDouble", "(Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDouble", "(Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "basePointMultiply", "([B)Lsun/security/ec/point/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "decodeAffinePoint", "(Ljava/util/function/Function;ILsun/security/util/math/IntegerModuloP;)Lsun/security/ec/point/AffinePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSum", "(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setSum", "(Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/ProjectivePoint$Mutable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNeutral_0", "()Lsun/security/ec/point/ImmutablePoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNeutral_1", "()Lsun/security/ec/point/ProjectivePoint$Immutable;"));
	}

	[JniSignatureAttribute("Lsun/security/util/math/SmallValue;", "private final")]
	public Dova.JDK.sun.security.util.math.SmallValue two_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.SmallValue>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/util/math/ImmutableIntegerModuloP;", "private final")]
	public Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP d_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/security/ec/point/ProjectivePoint$Immutable;", "private final")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable basePoint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private static final")]
	public static Dova.JDK.java.math.BigInteger TWO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private static final")]
	public static Dova.JDK.java.math.BigInteger THREE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private static final")]
	public static Dova.JDK.java.math.BigInteger FIVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private final")]
	public Dova.JDK.java.math.BigInteger sizeMinus3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Ed448Operations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/security/util/math/ImmutableIntegerModuloP;Ljava/math/BigInteger;Ljava/math/BigInteger;)V", "public")]
	public Ed448Operations(Dova.JDK.sun.security.util.math.ImmutableIntegerModuloP arg0, Dova.JDK.java.math.BigInteger arg1, Dova.JDK.java.math.BigInteger arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/security/ec/ed/Ed448Operations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ProjectivePoint$Immutable;", "public")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable of_0(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/AffinePoint;)Lsun/security/ec/point/ImmutablePoint;", "public volatile")]
	public Dova.JDK.sun.security.ec.point.ImmutablePoint of_1(Dova.JDK.sun.security.ec.point.AffinePoint arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/ProjectivePoint$Mutable;", "protected")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable setDouble(Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable arg0, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;", "protected")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setDouble(Dova.JDK.sun.security.ec.point.MutablePoint arg0, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/security/ec/point/Point;", "public")]
	public Dova.JDK.sun.security.ec.point.Point basePointMultiply(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.Point>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Function;ILsun/security/util/math/IntegerModuloP;)Lsun/security/ec/point/AffinePoint;", "public")]
	public Dova.JDK.sun.security.ec.point.AffinePoint decodeAffinePoint(Dova.JDK.java.util.function.Function arg0, int arg1, Dova.JDK.sun.security.util.math.IntegerModuloP arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.AffinePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/MutablePoint;Lsun/security/ec/point/MutablePoint;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/MutablePoint;", "protected")]
	public Dova.JDK.sun.security.ec.point.MutablePoint setSum(Dova.JDK.sun.security.ec.point.MutablePoint arg0, Dova.JDK.sun.security.ec.point.MutablePoint arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg3, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.MutablePoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/ec/point/ProjectivePoint$Mutable;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;Lsun/security/util/math/MutableIntegerModuloP;)Lsun/security/ec/point/ProjectivePoint$Mutable;", "")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable setSum(Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable arg0, Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable arg1, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg2, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg3, Dova.JDK.sun.security.util.math.MutableIntegerModuloP arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Mutable>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ImmutablePoint;", "protected volatile")]
	public Dova.JDK.sun.security.ec.point.ImmutablePoint getNeutral_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ImmutablePoint>(ret);
	}

	[JniSignatureAttribute("()Lsun/security/ec/point/ProjectivePoint$Immutable;", "protected")]
	public Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable getNeutral_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.ec.point.ProjectivePoint.Immutable>(ret);
	}
}
