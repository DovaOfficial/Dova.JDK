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

[JniSignatureAttribute("Ljava/awt/image/LookupOp;", "public")]
public partial class LookupOp
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.awt.image.BufferedImageOp
	, Dova.JDK.java.awt.image.RasterOp
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LookupOp()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/LookupOp;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ltable", "Ljava/awt/image/LookupTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numComponents", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hints", "Ljava/awt/RenderingHints;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/image/LookupTable;Ljava/awt/RenderingHints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTable", "()Ljava/awt/image/LookupTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleDestImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/ColorModel;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPoint2D", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCompatibleDestRaster", "(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteFilter", "(Ljava/awt/image/ByteLookupTable;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shortFilter", "(Ljava/awt/image/ShortLookupTable;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds2D", "(Ljava/awt/image/Raster;)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHints", "()Ljava/awt/RenderingHints;"));
	}

	[JniSignatureAttribute("Ljava/awt/image/LookupTable;", "private")]
	public Dova.JDK.java.awt.image.LookupTable ltable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.LookupTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numComponents_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LookupOp(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/image/LookupTable;Ljava/awt/RenderingHints;)V", "public")]
	public LookupOp(Dova.JDK.java.awt.image.LookupTable arg0, Dova.JDK.java.awt.RenderingHints arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/LookupOp;";
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

	[JniSignatureAttribute("()Ljava/awt/image/LookupTable;", "public final")]
	public Dova.JDK.java.awt.image.LookupTable getTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.LookupTable>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/ColorModel;)Ljava/awt/image/BufferedImage;", "public")]
	public Dova.JDK.java.awt.image.BufferedImage createCompatibleDestImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.ColorModel arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;)Ljava/awt/geom/Point2D;", "public final")]
	public Dova.JDK.java.awt.geom.Point2D getPoint2D(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;", "public")]
	public Dova.JDK.java.awt.image.WritableRaster createCompatibleDestRaster(Dova.JDK.java.awt.image.Raster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.WritableRaster>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ByteLookupTable;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;III)V", "private")]
	public void byteFilter(Dova.JDK.java.awt.image.ByteLookupTable arg0, Dova.JDK.java.awt.image.Raster arg1, Dova.JDK.java.awt.image.WritableRaster arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ShortLookupTable;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;III)V", "private")]
	public void shortFilter(Dova.JDK.java.awt.image.ShortLookupTable arg0, Dova.JDK.java.awt.image.Raster arg1, Dova.JDK.java.awt.image.WritableRaster arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5);
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

	[JniSignatureAttribute("()Ljava/awt/RenderingHints;", "public final")]
	public Dova.JDK.java.awt.RenderingHints getRenderingHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
	}
}
