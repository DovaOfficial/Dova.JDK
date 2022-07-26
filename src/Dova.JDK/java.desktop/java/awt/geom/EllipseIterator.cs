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

namespace Dova.JDK.java.awt.geom;

[JniSignatureAttribute("Ljava/awt/geom/EllipseIterator;", "")]
public partial class EllipseIterator
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.geom.PathIterator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EllipseIterator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/geom/EllipseIterator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "y", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "w", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "h", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "affine", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CtrlVal", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pcv", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ncv", "D"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ctrlpts", "[[D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Ellipse2D;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDone", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentSegment", "([D)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "currentSegment", "([F)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWindingRule", "()I"));
	}

	[JniSignatureAttribute("D", "")]
	public double x_Property
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

	[JniSignatureAttribute("D", "")]
	public double y_Property
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

	[JniSignatureAttribute("D", "")]
	public double w_Property
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

	[JniSignatureAttribute("D", "")]
	public double h_Property
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

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "")]
	public Dova.JDK.java.awt.geom.AffineTransform affine_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("D", "public static final")]
	public static double CtrlVal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double pcv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double ncv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[[D", "private static")]
	public static JavaArray<JavaArray<double>> ctrlpts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<double>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EllipseIterator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Ellipse2D;Ljava/awt/geom/AffineTransform;)V", "")]
	public EllipseIterator(Dova.JDK.java.awt.geom.Ellipse2D arg0, Dova.JDK.java.awt.geom.AffineTransform arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/geom/EllipseIterator;";
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

	[JniSignatureAttribute("([D)I", "public")]
	public int currentSegment(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("([F)I", "public")]
	public int currentSegment(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWindingRule()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
