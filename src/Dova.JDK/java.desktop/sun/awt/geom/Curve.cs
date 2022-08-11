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

namespace Dova.JDK.sun.awt.geom;

[JniSignatureAttribute("Lsun/awt/geom/Curve;", "public abstract")]
public partial class Curve
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Curve()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/geom/Curve;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCREASING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECREASING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "direction", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECT_INTERSECTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TMIN", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lsun/awt/geom/Curve;[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "next", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prev", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "round", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enlarge", "(Ljava/awt/geom/Rectangle2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSegment", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pointCrossingsForPath", "(Ljava/awt/geom/PathIterator;DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rectCrossingsForPath", "(Ljava/awt/geom/PathIterator;DDDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pointCrossingsForLine", "(DDDDDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pointCrossingsForQuad", "(DDDDDDDDI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pointCrossingsForCubic", "(DDDDDDDDDDI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rectCrossingsForLine", "(IDDDDDDDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rectCrossingsForQuad", "(IDDDDDDDDDDI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rectCrossingsForCubic", "(IDDDDDDDDDDDDI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "orderof", "(DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYTop", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXBot", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYBot", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWithDirection", "(I)Lsun/awt/geom/Curve;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubCurve", "(DD)Lsun/awt/geom/Curve;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubCurve", "(DDI)Lsun/awt/geom/Curve;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXTop", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XforY", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulateCrossings", "(Lsun/awt/geom/Crossings;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertQuad", "(Ljava/util/Vector;DD[D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertCubic", "(Ljava/util/Vector;DD[D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReversedCurve", "()Lsun/awt/geom/Curve;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX0", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY0", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "controlPointString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMax", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXMin", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TforY", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XforT", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextVertical", "(DD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "YforT", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refineTforY", "(DDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fairlyClose", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findIntersect", "(Lsun/awt/geom/Curve;[DDIIDDDDDDDDDDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertMove", "(Ljava/util/Vector;DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insertLine", "(Ljava/util/Vector;DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "signeddiffbits", "(DD)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "diffbits", "(DD)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dXforT", "(DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dYforT", "(DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "crossingsFor", "(DD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrder", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirection", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY1", "()D"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int INCREASING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DECREASING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int direction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int RECT_INTERSECTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("D", "public static final")]
	public static double TMIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Curve(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public Curve(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/geom/Curve;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/geom/Curve;[D)I", "public")]
	public int compareTo(Dova.JDK.sun.awt.geom.Curve arg0, JavaArray<double> arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public static")]
	public static double next(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public static")]
	public static double prev(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public static")]
	public static double round(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)V", "public abstract")]
	public void enlarge(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("([D)I", "public abstract")]
	public int getSegment(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;DD)I", "public static")]
	public static int pointCrossingsForPath(Dova.JDK.java.awt.geom.PathIterator arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/geom/PathIterator;DDDD)I", "public static")]
	public static int rectCrossingsForPath(Dova.JDK.java.awt.geom.PathIterator arg0, double arg1, double arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDD)I", "public static")]
	public static int pointCrossingsForLine(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDDI)I", "public static")]
	public static int pointCrossingsForQuad(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(DDDDDDDDDDI)I", "public static")]
	public static int pointCrossingsForCubic(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, int arg10)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return ret;
	}

	[JniSignatureAttribute("(IDDDDDDDD)I", "public static")]
	public static int rectCrossingsForLine(int arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(IDDDDDDDDDDI)I", "public static")]
	public static int rectCrossingsForQuad(int arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10, int arg11)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return ret;
	}

	[JniSignatureAttribute("(IDDDDDDDDDDDDI)I", "public static")]
	public static int rectCrossingsForCubic(int arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10, double arg11, double arg12, int arg13)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
		return ret;
	}

	[JniSignatureAttribute("(DD)I", "public static")]
	public static int orderof(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getYTop()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getXBot()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getYBot()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/awt/geom/Curve;", "public final")]
	public Dova.JDK.sun.awt.geom.Curve getWithDirection(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("(DD)Lsun/awt/geom/Curve;", "public")]
	public Dova.JDK.sun.awt.geom.Curve getSubCurve(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("(DDI)Lsun/awt/geom/Curve;", "public abstract")]
	public Dova.JDK.sun.awt.geom.Curve getSubCurve(double arg0, double arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getXTop()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public abstract")]
	public double XforY(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/geom/Crossings;)Z", "public")]
	public bool accumulateCrossings(Dova.JDK.sun.awt.geom.Crossings arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Vector;DD[D)V", "public static")]
	public static void insertQuad(Dova.JDK.java.util.Vector arg0, double arg1, double arg2, JavaArray<double> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/util/Vector;DD[D)V", "public static")]
	public static void insertCubic(Dova.JDK.java.util.Vector arg0, double arg1, double arg2, JavaArray<double> arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Lsun/awt/geom/Curve;", "public abstract")]
	public Dova.JDK.sun.awt.geom.Curve getReversedCurve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getX0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getY0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String controlPointString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getXMax()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getXMin()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public abstract")]
	public double TforY(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public abstract")]
	public double XforT(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)D", "public abstract")]
	public double nextVertical(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public abstract")]
	public double YforT(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DDD)D", "public")]
	public double refineTforY(double arg0, double arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "public")]
	public bool fairlyClose(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/geom/Curve;[DDIIDDDDDDDDDDDD)Z", "public")]
	public bool findIntersect(Dova.JDK.sun.awt.geom.Curve arg0, JavaArray<double> arg1, double arg2, int arg3, int arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10, double arg11, double arg12, double arg13, double arg14, double arg15, double arg16)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Vector;DD)V", "public static")]
	public static void insertMove(Dova.JDK.java.util.Vector arg0, double arg1, double arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Vector;DDDD)V", "public static")]
	public static void insertLine(Dova.JDK.java.util.Vector arg0, double arg1, double arg2, double arg3, double arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(DD)J", "public static")]
	public static long signeddiffbits(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DD)J", "public static")]
	public static long diffbits(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DI)D", "public abstract")]
	public double dXforT(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DI)D", "public abstract")]
	public double dYforT(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DD)I", "public")]
	public int crossingsFor(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getOrder()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getDirection()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getX1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public abstract")]
	public double getY1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}
}
