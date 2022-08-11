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

[JniSignatureAttribute("Lsun/font/CompositeStrike;", "public final")]
public partial class CompositeStrike
	: Dova.JDK.sun.font.FontStrike
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompositeStrike()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/CompositeStrike;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLOTMASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compFont", "Lsun/font/CompositeFont;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strikes", "[Lsun/font/PhysicalStrike;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numGlyphs", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/font/CompositeFont;Lsun/font/FontStrikeDesc;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphAdvance", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphMetrics", "(I)Ljava/awt/geom/Point2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutlineBounds", "(I)Ljava/awt/geom/Rectangle2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphOutline", "(IFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphVectorOutline", "([IFF)Ljava/awt/geom/GeneralPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumGlyphs", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStrikeForSlot", "(I)Lsun/font/PhysicalStrike;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStrikeForGlyph", "(I)Lsun/font/PhysicalStrike;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCodePointAdvance", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharMetrics", "(C)Ljava/awt/geom/Point2D$Float;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImagePtrs", "([I[JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImagePtr", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphImageBounds", "(ILjava/awt/geom/Point2D$Float;Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "()Lsun/font/StrikeMetrics;"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SLOTMASK_Property
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

	[JniSignatureAttribute("Lsun/font/CompositeFont;", "private")]
	public Dova.JDK.sun.font.CompositeFont compFont_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.font.CompositeFont>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lsun/font/PhysicalStrike;", "private")]
	public JavaArray<Dova.JDK.sun.font.PhysicalStrike> strikes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.font.PhysicalStrike>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int numGlyphs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompositeStrike(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/font/CompositeFont;Lsun/font/FontStrikeDesc;)V", "")]
	public CompositeStrike(Dova.JDK.sun.font.CompositeFont arg0, Dova.JDK.sun.font.FontStrikeDesc arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/CompositeStrike;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)F", "")]
	public float getGlyphAdvance(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Point2D$Float;", "")]
	public Dova.JDK.java.awt.geom.Point2D.Float getGlyphMetrics(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Float>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Rectangle2D$Float;", "")]
	public Dova.JDK.java.awt.geom.Rectangle2D.Float getGlyphOutlineBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D.Float>(ret);
	}

	[JniSignatureAttribute("(IFF)Ljava/awt/geom/GeneralPath;", "")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphOutline(int arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("([IFF)Ljava/awt/geom/GeneralPath;", "")]
	public Dova.JDK.java.awt.geom.GeneralPath getGlyphVectorOutline(JavaArray<int> arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.GeneralPath>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNumGlyphs()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lsun/font/PhysicalStrike;", "")]
	public Dova.JDK.sun.font.PhysicalStrike getStrikeForSlot(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.PhysicalStrike>(ret);
	}

	[JniSignatureAttribute("(I)Lsun/font/PhysicalStrike;", "")]
	public Dova.JDK.sun.font.PhysicalStrike getStrikeForGlyph(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.PhysicalStrike>(ret);
	}

	[JniSignatureAttribute("(I)F", "")]
	public float getCodePointAdvance(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Ljava/awt/geom/Point2D$Float;", "")]
	public Dova.JDK.java.awt.geom.Point2D.Float getCharMetrics(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D.Float>(ret);
	}

	[JniSignatureAttribute("([I[JI)V", "")]
	public void getGlyphImagePtrs(JavaArray<int> arg0, JavaArray<long> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)J", "")]
	public long getGlyphImagePtr(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/geom/Point2D$Float;Ljava/awt/Rectangle;)V", "")]
	public void getGlyphImageBounds(int arg0, Dova.JDK.java.awt.geom.Point2D.Float arg1, Dova.JDK.java.awt.Rectangle arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lsun/font/StrikeMetrics;", "")]
	public Dova.JDK.sun.font.StrikeMetrics getFontMetrics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.StrikeMetrics>(ret);
	}
}
