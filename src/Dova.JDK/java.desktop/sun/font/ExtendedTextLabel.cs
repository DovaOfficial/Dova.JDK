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

[JniSignatureAttribute("Lsun/font/ExtendedTextLabel;", "public abstract")]
public partial class ExtendedTextLabel
	: Dova.JDK.sun.font.TextLabel
	, Dova.JDK.sun.font.TextLineComponent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExtendedTextLabel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/font/ExtendedTextLabel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharVisualBounds", "(IFF)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharVisualBounds", "(I)Ljava/awt/geom/Rectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumCharacters", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCoreMetrics", "()Lsun/font/CoreMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharX", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharY", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharAdvance", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "logicalToVisual", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visualToLogical", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineBreakIndex", "(IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdvanceBetween", "(II)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "caretAtOffsetIsValid", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubset", "(III)Lsun/font/TextLineComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumJustificationInfos", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJustificationInfos", "([Ljava/awt/font/GlyphJustificationInfo;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyJustificationDeltas", "([FI[Z)Lsun/font/TextLineComponent;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExtendedTextLabel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ExtendedTextLabel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/font/ExtendedTextLabel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IFF)Ljava/awt/geom/Rectangle2D;", "public abstract")]
	public Dova.JDK.java.awt.geom.Rectangle2D getCharVisualBounds(int arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/awt/geom/Rectangle2D;", "public")]
	public Dova.JDK.java.awt.geom.Rectangle2D getCharVisualBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getNumCharacters()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/font/CoreMetrics;", "public abstract")]
	public Dova.JDK.sun.font.CoreMetrics getCoreMetrics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.CoreMetrics>(ret);
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	public float getCharX(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	public float getCharY(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public abstract")]
	public float getCharAdvance(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	public int logicalToVisual(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	public int visualToLogical(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IF)I", "public abstract")]
	public int getLineBreakIndex(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)F", "public abstract")]
	public float getAdvanceBetween(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	public bool caretAtOffsetIsValid(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(III)Lsun/font/TextLineComponent;", "public abstract")]
	public Dova.JDK.sun.font.TextLineComponent getSubset(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextLineComponent>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getNumJustificationInfos()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/awt/font/GlyphJustificationInfo;III)V", "public abstract")]
	public void getJustificationInfos(JavaArray<Dova.JDK.java.awt.font.GlyphJustificationInfo> arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([FI[Z)Lsun/font/TextLineComponent;", "public abstract")]
	public Dova.JDK.sun.font.TextLineComponent applyJustificationDeltas(JavaArray<float> arg0, int arg1, JavaArray<bool> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.font.TextLineComponent>(ret);
	}
}
