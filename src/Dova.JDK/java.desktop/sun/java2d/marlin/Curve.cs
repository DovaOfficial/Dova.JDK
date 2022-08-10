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

namespace Dova.JDK.sun.java2d.marlin;

[JniSignatureAttribute("Lsun/java2d/marlin/Curve;", "final")]
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
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/marlin/Curve;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ax", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ay", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bx", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "by", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cx", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cy", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dx", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dy", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dax", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "day", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dbx", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "dby", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Curve", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "([DI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(DDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(DDDDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "set", "(DDDDDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "perpendiculardfddf", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ROCsq", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "falsePositionROCsqMinusX", "(DDDD)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "eliminateInf", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "sameSign", "(DD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dxRoots", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dyRoots", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "infPoints", "([DI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "rootsOfROCMinusW", "([DIDD)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "xPoints", "([DID)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "yPoints", "([DID)I"));
	}

	[JniSignatureAttribute("D", "")]
	public double ax_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("D", "")]
	public double ay_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("D", "")]
	public double bx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("D", "")]
	public double by_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("D", "")]
	public double cx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("D", "")]
	public double cy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("D", "")]
	public double dx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("D", "")]
	public double dy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("D", "")]
	public double dax_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("D", "")]
	public double day_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("D", "")]
	public double dbx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("D", "")]
	public double dby_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Curve(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Curve() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/marlin/Curve;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([DI)V", "")]
	public void set(JavaArray<double> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(DDDD)V", "")]
	public void set(double arg0, double arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(DDDDDDDD)V", "")]
	public void set(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5, double arg6, double arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(DDDDDD)V", "")]
	public void set(double arg0, double arg1, double arg2, double arg3, double arg4, double arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([DI)I", "private")]
	public int perpendiculardfddf(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "private")]
	public double ROCsq(double arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DDDD)D", "private")]
	public double falsePositionROCsqMinusX(double arg0, double arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "private static")]
	public static double eliminateInf(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(DD)Z", "private static")]
	public static bool sameSign(double arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "")]
	public int dxRoots(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "")]
	public int dyRoots(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DI)I", "")]
	public int infPoints(JavaArray<double> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([DIDD)I", "")]
	public int rootsOfROCMinusW(JavaArray<double> arg0, int arg1, double arg2, double arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("([DID)I", "")]
	public int xPoints(JavaArray<double> arg0, int arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([DID)I", "")]
	public int yPoints(JavaArray<double> arg0, int arg1, double arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return ret;
	}
}
