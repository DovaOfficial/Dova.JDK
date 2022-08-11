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

namespace Dova.JDK.sun.font;

[JniSignatureAttribute("Lsun/font/TextSourceLabel;", "public")]
public partial class TextSourceLabel
	: Dova.JDK.sun.font.TextLabel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextSourceLabel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/TextSourceLabel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Lsun/font/TextSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lb", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ab", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vb", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ib", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gv", "Ljava/awt/font/GlyphVector;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/TextSource;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/TextSource;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/Rectangle2D;Ljava/awt/font/GlyphVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "()Lsun/font/TextSource;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItalicBounds", "(FF)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisualBounds", "(FF)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixelBounds", "(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignBounds", "(FF)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLogicalBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVisualBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAlignBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createItalicBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGV", "()Ljava/awt/font/GlyphVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGV", "()Ljava/awt/font/GlyphVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaselineTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Ljava/awt/Graphics2D;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalBounds", "(FF)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutline", "(FF)Ljava/awt/Shape;"));
	}

	[JniSignatureAttribute("Lsun/font/TextSource;", "")]
	public Dova.JDK.sun.font.TextSource source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextSource>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "")]
	public Dova.JDK.java.awt.geom.Rectangle2D lb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "")]
	public Dova.JDK.java.awt.geom.Rectangle2D ab_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "")]
	public Dova.JDK.java.awt.geom.Rectangle2D vb_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "")]
	public Dova.JDK.java.awt.geom.Rectangle2D ib_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/font/GlyphVector;", "")]
	public Dova.JDK.java.awt.font.GlyphVector gv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TextSourceLabel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/TextSource;)V", "public")]
	public TextSourceLabel(Dova.JDK.sun.font.TextSource arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/font/TextSource;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/Rectangle2D;Ljava/awt/font/GlyphVector;)V", "public")]
	public TextSourceLabel(Dova.JDK.sun.font.TextSource arg0, Dova.JDK.java.awt.geom.Rectangle2D arg1, Dova.JDK.java.awt.geom.Rectangle2D arg2, Dova.JDK.java.awt.font.GlyphVector arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/TextSourceLabel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lsun/font/TextSource;", "public")]
	public Dova.JDK.sun.font.TextSource getSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextSource>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getItalicBounds(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/geom/Rectangle2D;", "public final")]
	public Dova.JDK.java.awt.geom.Rectangle2D getVisualBounds(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getPixelBounds(Dova.JDK.java.awt.font.FontRenderContext arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/geom/Rectangle2D;", "public final")]
	public Dova.JDK.java.awt.geom.Rectangle2D getAlignBounds(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "protected")]
	public Dova.JDK.java.awt.geom.Rectangle2D createLogicalBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "protected")]
	public Dova.JDK.java.awt.geom.Rectangle2D createVisualBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "protected")]
	public Dova.JDK.java.awt.geom.Rectangle2D createAlignBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "protected")]
	public Dova.JDK.java.awt.geom.Rectangle2D createItalicBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/font/GlyphVector;", "private")]
	public Dova.JDK.java.awt.font.GlyphVector getGV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphVector>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/font/GlyphVector;", "protected")]
	public Dova.JDK.java.awt.font.GlyphVector createGV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.font.GlyphVector>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public")]
	public Dova.JDK.java.awt.geom.AffineTransform getBaselineTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;FF)V", "public")]
	public void draw(Dova.JDK.java.awt.Graphics2D arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/geom/Rectangle2D;", "public final")]
	public Dova.JDK.java.awt.geom.Rectangle2D getLogicalBounds(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape getOutline(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}
}
