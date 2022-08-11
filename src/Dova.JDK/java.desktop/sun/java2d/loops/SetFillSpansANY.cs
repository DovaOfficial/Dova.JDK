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

namespace Dova.JDK.sun.java2d.loops;

[JniSignatureAttribute("Lsun/java2d/loops/SetFillSpansANY;", "")]
public partial class SetFillSpansANY
	: Dova.JDK.sun.java2d.loops.FillSpans
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SetFillSpansANY()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/SetFillSpansANY;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "FillSpans", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;Lsun/java2d/pipe/SpanIterator;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SetFillSpansANY(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SetFillSpansANY() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/SetFillSpansANY;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;Lsun/java2d/pipe/SpanIterator;)V", "public")]
	public void FillSpans(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.sun.java2d.pipe.SpanIterator arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}
