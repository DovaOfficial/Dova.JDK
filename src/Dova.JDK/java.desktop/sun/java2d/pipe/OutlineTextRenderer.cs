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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/OutlineTextRenderer;", "public")]
public partial class OutlineTextRenderer
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.TextPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OutlineTextRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/OutlineTextRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THRESHHOLD", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawString", "(Lsun/java2d/SunGraphics2D;Ljava/lang/String;DD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawChars", "(Lsun/java2d/SunGraphics2D;[CIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drawGlyphVector", "(Lsun/java2d/SunGraphics2D;Ljava/awt/font/GlyphVector;FF)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int THRESHHOLD_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OutlineTextRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public OutlineTextRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/OutlineTextRenderer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/lang/String;DD)V", "public")]
	public void drawString(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.lang.String arg1, double arg2, double arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[CIIII)V", "public")]
	public void drawChars(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<char> arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/font/GlyphVector;FF)V", "public")]
	public void drawGlyphVector(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.font.GlyphVector arg1, float arg2, float arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}
}
