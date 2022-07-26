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

[JniSignatureAttribute("Lsun/awt/geom/Order3;", "final")]
public partial class Order3
	: Dova.JDK.sun.awt.geom.Curve
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Order3()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/geom/Order3;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cx0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cy0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cx1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cy1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xmin", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xmax", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xcoeff0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xcoeff1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xcoeff2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xcoeff3", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ycoeff0", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ycoeff1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ycoeff2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ycoeff3", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "TforY1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "YforT1", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "TforY2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "YforT2", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "TforY3", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "YforT3", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(DDDDDDDDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "insert", "(Ljava/util/Vector;[DDDDDDDDDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "split", "([DID)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enlarge", "(Ljava/awt/geom/Rectangle2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSegment", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refine", "(DDDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCX1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCY1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYTop", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXBot", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYBot", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubCurve", "(DDI)Lsun/awt/geom/Curve;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXTop", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "XforY", "(D)D"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dXforT", "(DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dYforT", "(DI)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHorizontalParams", "(DDDD[D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addInstance", "(Ljava/util/Vector;DDDDDDDDI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCX0", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCY0", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrder", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getX1", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getY1", "()D"));
	}

	[JniSignatureAttribute("D", "private")]
	public double x0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double y0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double cx0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double cy0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double cx1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double cy1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double x1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double y1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xmin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xmax_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xcoeff0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xcoeff1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xcoeff2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double xcoeff3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double ycoeff0_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double ycoeff1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double ycoeff2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double ycoeff3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double TforY1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double YforT1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double TforY2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double YforT2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double TforY3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("D", "private")]
	public double YforT3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Order3(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(DDDDDDDDI)V", "public")]
	public Order3(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, int arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/geom/Order3;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Vector;[DDDDDDDDDI)V", "public static")]
	public static void insert(Dova.JDK.java.util.Vector arg0, JavaArray<double> arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, int arg10)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("([DID)V", "public static")]
	public static void split(JavaArray<double> arg0, int arg1, double arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)V", "public")]
	public void enlarge(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("([D)I", "public")]
	public int getSegment(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DDDDD)D", "public")]
	public double refine(double arg0, double arg1, double arg2, double arg3, double arg4)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getCX1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getCY1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getYTop()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getXBot()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getYBot()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(DDI)Lsun/awt/geom/Curve;", "public")]
	public Dova.JDK.sun.awt.geom.Curve getSubCurve(double arg0, double arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getXTop()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public")]
	public double XforY(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/awt/geom/Curve;", "public")]
	public Dova.JDK.sun.awt.geom.Curve getReversedCurve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.geom.Curve>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getX0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getY0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String controlPointString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getXMax()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getXMin()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public")]
	public double TforY(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public")]
	public double XforT(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)D", "public")]
	public double nextVertical(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "public")]
	public double YforT(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DI)D", "public")]
	public double dXforT(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DI)D", "public")]
	public double dYforT(double arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(DDDD[D)I", "public static")]
	public static int getHorizontalParams(double arg0, double arg1, double arg2, double arg3, JavaArray<double> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Vector;DDDDDDDDI)V", "public static")]
	public static void addInstance(Dova.JDK.java.util.Vector arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, int arg9)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getCX0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getCY0()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOrder()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getX1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double getY1()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}
}
