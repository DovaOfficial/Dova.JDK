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

namespace Dova.JDK.java.awt.geom;

[JniSignatureAttribute("Ljava/awt/geom/ArcIterator;", "")]
public partial class ArcIterator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.geom.PathIterator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArcIterator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/ArcIterator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "x", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "y", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "w", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "h", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "angStRad", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "increment", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cv", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "affine", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "arcSegs", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lineSegs", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ArcIterator", "(Ljava/awt/geom/Arc2D;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDone", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "btan", "(D)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "currentSegment", "([F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "currentSegment", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getWindingRule", "()I"));
	}

	[JniSignatureAttribute("D", "")]
	public double x_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("D", "")]
	public double y_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("D", "")]
	public double w_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("D", "")]
	public double h_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("D", "")]
	public double angStRad_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("D", "")]
	public double increment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("D", "")]
	public double cv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "")]
	public Dova.JDK.java.awt.geom.AffineTransform affine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "")]
	public int arcSegs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("I", "")]
	public int lineSegs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ArcIterator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Arc2D;Ljava/awt/geom/AffineTransform;)V", "")]
	public ArcIterator(Dova.JDK.java.awt.geom.Arc2D arg0, Dova.JDK.java.awt.geom.AffineTransform arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/geom/ArcIterator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void next()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDone()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(D)D", "private static")]
	public static double btan(double arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("([F)I", "public")]
	public int currentSegment(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("([D)I", "public")]
	public int currentSegment(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWindingRule()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}
}
