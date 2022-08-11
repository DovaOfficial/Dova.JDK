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

namespace Dova.JDK.java.awt.image.renderable;

[JniSignatureAttribute("Ljava/awt/image/renderable/RenderContext;", "public")]
public partial class RenderContext
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RenderContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/renderable/RenderContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hints", "Ljava/awt/RenderingHints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "usr2dev", "Ljava/awt/geom/AffineTransform;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aoi", "Ljava/awt/Shape;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/AffineTransform;Ljava/awt/Shape;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/AffineTransform;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/AffineTransform;Ljava/awt/Shape;Ljava/awt/RenderingHints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preConcetenateTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concetenateTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preConcatenateTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concatenateTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAreaOfInterest", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAreaOfInterest", "()Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHints", "()Ljava/awt/RenderingHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderingHints", "(Ljava/awt/RenderingHints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransform", "(Ljava/awt/geom/AffineTransform;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/RenderingHints;", "")]
	public Dova.JDK.java.awt.RenderingHints hints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/AffineTransform;", "")]
	public Dova.JDK.java.awt.geom.AffineTransform usr2dev_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Shape;", "")]
	public Dova.JDK.java.awt.Shape aoi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RenderContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;Ljava/awt/Shape;)V", "public")]
	public RenderContext(Dova.JDK.java.awt.geom.AffineTransform arg0, Dova.JDK.java.awt.Shape arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)V", "public")]
	public RenderContext(Dova.JDK.java.awt.geom.AffineTransform arg0, Dova.JDK.java.awt.RenderingHints arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public RenderContext(Dova.JDK.java.awt.geom.AffineTransform arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;Ljava/awt/Shape;Ljava/awt/RenderingHints;)V", "public")]
	public RenderContext(Dova.JDK.java.awt.geom.AffineTransform arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.RenderingHints arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/renderable/RenderContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void preConcetenateTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void concetenateTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void preConcatenateTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void concatenateTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public")]
	public void setAreaOfInterest(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getAreaOfInterest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/RenderingHints;", "public")]
	public Dova.JDK.java.awt.RenderingHints getRenderingHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/RenderingHints;)V", "public")]
	public void setRenderingHints(Dova.JDK.java.awt.RenderingHints arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public")]
	public void setTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}
