/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/GlyphListLoopPipe;", "public abstract")]
public partial class GlyphListLoopPipe
	: Dova.JDK.sun.java2d.pipe.GlyphListPipe
	, Dova.JDK.sun.java2d.pipe.LoopBasedPipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GlyphListLoopPipe()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/java2d/pipe/GlyphListLoopPipe;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "GlyphListLoopPipe", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "drawGlyphList", "(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "drawGlyphListSegment", "(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;IIIZ)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GlyphListLoopPipe(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public GlyphListLoopPipe() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/GlyphListLoopPipe;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;I)V", "protected")]
	public void drawGlyphList(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.font.GlyphList arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/font/GlyphList;IIIZ)V", "private")]
	public void drawGlyphListSegment(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.font.GlyphList arg1, int arg2, int arg3, int arg4, bool arg5)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}
}
