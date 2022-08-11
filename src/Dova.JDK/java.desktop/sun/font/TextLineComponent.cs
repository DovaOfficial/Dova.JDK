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

[JniSignatureAttribute("Lsun/font/TextLineComponent;", "public abstract interface")]
public partial interface TextLineComponent
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextLineComponent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/TextLineComponent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT_TO_RIGHT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT_TO_LEFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNCHANGED", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdvance", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "draw", "(Ljava/awt/Graphics2D;FF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharVisualBounds", "(I)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumCharacters", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCoreMetrics", "()Lsun/font/CoreMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharX", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharY", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharAdvance", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineBreakIndex", "(IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdvanceBetween", "(II)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "caretAtOffsetIsValid", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubset", "(III)Lsun/font/TextLineComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumJustificationInfos", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJustificationInfos", "([Ljava/awt/font/GlyphJustificationInfo;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyJustificationDeltas", "([FI[Z)Lsun/font/TextLineComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisualBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItalicBounds", "()Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSimple", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPixelBounds", "(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaselineTransform", "()Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutline", "(FF)Ljava/awt/Shape;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LEFT_TO_RIGHT_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int RIGHT_TO_LEFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int UNCHANGED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("()F", "public abstract")]
	float getAdvance()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;FF)V", "public abstract")]
	void draw(Dova.JDK.java.awt.Graphics2D arg0, float arg1, float arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Rectangle2D;", "public abstract")]
	Dova.JDK.java.awt.geom.Rectangle2D getCharVisualBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getNumCharacters()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/font/CoreMetrics;", "public abstract")]
	Dova.JDK.sun.font.CoreMetrics getCoreMetrics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.CoreMetrics>(ret);
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	float getCharX(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	float getCharY(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	float getCharAdvance(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IF)I", "public abstract")]
	int getLineBreakIndex(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)F", "public abstract")]
	float getAdvanceBetween(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool caretAtOffsetIsValid(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(III)Lsun/font/TextLineComponent;", "public abstract")]
	Dova.JDK.sun.font.TextLineComponent getSubset(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextLineComponent>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getNumJustificationInfos()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/awt/font/GlyphJustificationInfo;III)V", "public abstract")]
	void getJustificationInfos(JavaArray<Dova.JDK.java.awt.font.GlyphJustificationInfo> arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([FI[Z)Lsun/font/TextLineComponent;", "public abstract")]
	Dova.JDK.sun.font.TextLineComponent applyJustificationDeltas(JavaArray<float> arg0, int arg1, JavaArray<bool> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextLineComponent>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public abstract")]
	Dova.JDK.java.awt.geom.Rectangle2D getVisualBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public abstract")]
	Dova.JDK.java.awt.geom.Rectangle2D getLogicalBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Rectangle2D;", "public abstract")]
	Dova.JDK.java.awt.geom.Rectangle2D getItalicBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isSimple()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/font/FontRenderContext;FF)Ljava/awt/Rectangle;", "public abstract")]
	Dova.JDK.java.awt.Rectangle getPixelBounds(Dova.JDK.java.awt.font.FontRenderContext arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/AffineTransform;", "public abstract")]
	Dova.JDK.java.awt.geom.AffineTransform getBaselineTransform()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("(FF)Ljava/awt/Shape;", "public abstract")]
	Dova.JDK.java.awt.Shape getOutline(float arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}
}
