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

namespace Dova.JDK.java.awt.image;

[JniSignatureAttribute("Ljava/awt/image/ConvolveOp;", "public")]
public partial class ConvolveOp
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.image.BufferedImageOp
	, Dova.JDK.java.awt.image.RasterOp
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConvolveOp()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/ConvolveOp;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kernel", "Ljava/awt/image/Kernel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "edgeHint", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hints", "Ljava/awt/RenderingHints;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDGE_ZERO_FILL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDGE_NO_OP", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/Kernel;ILjava/awt/RenderingHints;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/Kernel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEdgeCondition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKernel", "()Ljava/awt/image/Kernel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleDestImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/ColorModel;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoint2D", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleDestRaster", "(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHints", "()Ljava/awt/RenderingHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "(Ljava/awt/image/Raster;)Ljava/awt/geom/Rectangle2D;"));
	}

	[JniSignatureAttribute("Ljava/awt/image/Kernel;", "")]
	public Dova.JDK.java.awt.image.Kernel kernel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Kernel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int edgeHint_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/RenderingHints;", "")]
	public Dova.JDK.java.awt.RenderingHints hints_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int EDGE_ZERO_FILL_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int EDGE_NO_OP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConvolveOp(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/Kernel;ILjava/awt/RenderingHints;)V", "public")]
	public ConvolveOp(Dova.JDK.java.awt.image.Kernel arg0, int arg1, Dova.JDK.java.awt.RenderingHints arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/Kernel;)V", "public")]
	public ConvolveOp(Dova.JDK.java.awt.image.Kernel arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/ConvolveOp;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;", "public final")]
	public Dova.JDK.java.awt.image.WritableRaster filter(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.image.WritableRaster arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;", "public final")]
	public Dova.JDK.java.awt.image.BufferedImage filter(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEdgeCondition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/image/Kernel;", "public final")]
	public Dova.JDK.java.awt.image.Kernel getKernel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.Kernel>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/ColorModel;)Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage createCompatibleDestImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.ColorModel arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Ljava/awt/geom/Point2D;", "public final")]
	public Dova.JDK.java.awt.geom.Point2D getPoint2D(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;", "public")]
	public Dova.JDK.java.awt.image.WritableRaster createCompatibleDestRaster(Dova.JDK.java.awt.image.Raster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/RenderingHints;", "public final")]
	public Dova.JDK.java.awt.RenderingHints getRenderingHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;", "public final")]
	public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;)Ljava/awt/geom/Rectangle2D;", "public final")]
	public Dova.JDK.java.awt.geom.Rectangle2D getBounds2D(Dova.JDK.java.awt.image.Raster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}
}
