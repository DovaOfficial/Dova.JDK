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

[JniSignatureAttribute("Lsun/java2d/loops/SetDrawPolygonsANY;", "")]
public partial class SetDrawPolygonsANY
	: Dova.JDK.sun.java2d.loops.DrawPolygons
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SetDrawPolygonsANY()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/loops/SetDrawPolygonsANY;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DrawPolygons", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;[I[I[IIIIZ)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SetDrawPolygonsANY(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SetDrawPolygonsANY() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/loops/SetDrawPolygonsANY;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;[I[I[IIIIZ)V", "public")]
	public void DrawPolygons(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.SurfaceData arg1, JavaArray<int> arg2, JavaArray<int> arg3, JavaArray<int> arg4, int arg5, int arg6, int arg7, bool arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}
}
