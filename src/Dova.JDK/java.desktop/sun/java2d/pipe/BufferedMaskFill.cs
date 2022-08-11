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

[JniSignatureAttribute("Lsun/java2d/pipe/BufferedMaskFill;", "public abstract")]
public partial class BufferedMaskFill
	: Dova.JDK.sun.java2d.loops.MaskFill
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferedMaskFill()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/BufferedMaskFill;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rq", "Lsun/java2d/pipe/RenderQueue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "MaskFill", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;Ljava/awt/Composite;IIII[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maskFill", "(IIIIIII[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateContext", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Composite;I)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/pipe/RenderQueue;", "protected final")]
	public Dova.JDK.sun.java2d.pipe.RenderQueue rq_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.RenderQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferedMaskFill(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;Lsun/java2d/loops/SurfaceType;)V", "protected")]
	public BufferedMaskFill(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.sun.java2d.loops.SurfaceType arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/BufferedMaskFill;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/SurfaceData;Ljava/awt/Composite;IIII[BII)V", "public")]
	public void MaskFill(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.Composite arg2, int arg3, int arg4, int arg5, int arg6, JavaArray<byte> arg7, int arg8, int arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(IIIIIII[B)V", "protected abstract")]
	public void maskFill(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, JavaArray<byte> arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Composite;I)V", "protected abstract")]
	public void validateContext(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Composite arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}
}
