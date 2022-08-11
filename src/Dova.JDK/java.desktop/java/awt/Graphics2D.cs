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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/Graphics2D;", "public abstract")]
public partial class Graphics2D
	: Dova.JDK.java.awt.Graphics
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Graphics2D()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/Graphics2D;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scale", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rotate", "(D)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rotate", "(DDD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hit", "(Ljava/awt/Rectangle;Ljava/awt/Shape;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComposite", "()Ljava/awt/Composite;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeviceConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawGlyphVector", "(Ljava/awt/font/GlyphVector;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHints", "()Ljava/awt/RenderingHints;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shear", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPaint", "(Ljava/awt/Paint;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRenderedImage", "(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStroke", "(Ljava/awt/Stroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderingHint", "(Ljava/awt/RenderingHints$Key;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderingHints", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRenderingHints", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaint", "()Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStroke", "()Ljava/awt/Stroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawRenderableImage", "(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clip", "(Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Ljava/text/AttributedCharacterIterator;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw3DRect", "(IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fill3DRect", "(IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawImage", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransform", "(Ljava/awt/geom/AffineTransform;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontRenderContext", "()Ljava/awt/font/FontRenderContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComposite", "(Ljava/awt/Composite;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderingHint", "(Ljava/awt/RenderingHints$Key;Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Graphics2D(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Graphics2D() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/Graphics2D;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(DD)V", "public abstract")]
	public void scale(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public abstract")]
	public void fill(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public abstract")]
	public void transform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(D)V", "public abstract")]
	public void rotate(double arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(DDD)V", "public abstract")]
	public void rotate(double arg0, double arg1, double arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;Ljava/awt/Shape;Z)Z", "public abstract")]
	public bool hit(Dova.JDK.java.awt.Rectangle arg0, Dova.JDK.java.awt.Shape arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Composite;", "public abstract")]
	public Dova.JDK.java.awt.Composite getComposite()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Composite>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "public abstract")]
	public Dova.JDK.java.awt.GraphicsConfiguration getDeviceConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public abstract")]
	public void draw(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/font/GlyphVector;FF)V", "public abstract")]
	public void drawGlyphVector(Dova.JDK.java.awt.font.GlyphVector arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/RenderingHints;", "public abstract")]
	public Dova.JDK.java.awt.RenderingHints getRenderingHints()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.RenderingHints>(ret);
	}

	[JniSignatureAttribute("(DD)V", "public abstract")]
	public void shear(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Paint;)V", "public abstract")]
	public void setPaint(Dova.JDK.java.awt.Paint arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;Ljava/awt/geom/AffineTransform;)V", "public abstract")]
	public void drawRenderedImage(Dova.JDK.java.awt.image.RenderedImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Stroke;)V", "public abstract")]
	public void setStroke(Dova.JDK.java.awt.Stroke arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/RenderingHints$Key;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object getRenderingHint(Dova.JDK.java.awt.RenderingHints.Key arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public abstract")]
	public void setRenderingHints(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public abstract")]
	public void addRenderingHints(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Paint;", "public abstract")]
	public Dova.JDK.java.awt.Paint getPaint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Stroke;", "public abstract")]
	public Dova.JDK.java.awt.Stroke getStroke()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Stroke>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/RenderableImage;Ljava/awt/geom/AffineTransform;)V", "public abstract")]
	public void drawRenderableImage(Dova.JDK.java.awt.image.renderable.RenderableImage arg0, Dova.JDK.java.awt.geom.AffineTransform arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public abstract")]
	public Dova.JDK.java.awt.Color getBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public abstract")]
	public void setBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(II)V", "public abstract")]
	public void translate(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(DD)V", "public abstract")]
	public void translate(double arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)V", "public abstract")]
	public void clip(Dova.JDK.java.awt.Shape arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;FF)V", "public abstract")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;FF)V", "public abstract")]
	public void drawString(Dova.JDK.java.lang.String arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public abstract")]
	public void drawString(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/text/AttributedCharacterIterator;II)V", "public abstract")]
	public void drawString(Dova.JDK.java.text.AttributedCharacterIterator arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIIIZ)V", "public")]
	public void draw3DRect(int arg0, int arg1, int arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(IIIIZ)V", "public")]
	public void fill3DRect(int arg0, int arg1, int arg2, int arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z", "public abstract")]
	public bool drawImage(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.image.ImageObserver arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V", "public abstract")]
	public void drawImage(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImageOp arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public abstract")]
	public Dova.JDK.java.awt.geom.AffineTransform getTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/geom/AffineTransform;)V", "public abstract")]
	public void setTransform(Dova.JDK.java.awt.geom.AffineTransform arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/font/FontRenderContext;", "public abstract")]
	public Dova.JDK.java.awt.font.FontRenderContext getFontRenderContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.FontRenderContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Composite;)V", "public abstract")]
	public void setComposite(Dova.JDK.java.awt.Composite arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/RenderingHints$Key;Ljava/lang/Object;)V", "public abstract")]
	public void setRenderingHint(Dova.JDK.java.awt.RenderingHints.Key arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}
}
