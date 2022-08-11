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

namespace Dova.JDK.sun.java2d.xr;

[JniSignatureAttribute("Lsun/java2d/xr/XrSwToPMTransformedBlit;", "")]
public partial class XrSwToPMTransformedBlit
	: Dova.JDK.sun.java2d.loops.TransformBlit
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XrSwToPMTransformedBlit()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XrSwToPMTransformedBlit;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pmToSurfaceBlit", "Lsun/java2d/loops/TransformBlit;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Transform", "(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIII)V"));
	}

	[JniSignatureAttribute("Lsun/java2d/loops/TransformBlit;", "")]
	public Dova.JDK.sun.java2d.loops.TransformBlit pmToSurfaceBlit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.TransformBlit>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XrSwToPMTransformedBlit(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;)V", "")]
	public XrSwToPMTransformedBlit(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.SurfaceType arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XrSwToPMTransformedBlit;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;Ljava/awt/geom/AffineTransform;IIIIIII)V", "public")]
	public void Transform(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.Composite arg2, Dova.JDK.sun.java2d.pipe.Region arg3, Dova.JDK.java.awt.geom.AffineTransform arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
	}
}
