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

namespace Dova.JDK.sun.java2d.opengl;

[JniSignatureAttribute("Lsun/java2d/opengl/OGLSurfaceDataProxy;", "public")]
public partial class OGLSurfaceDataProxy
	: Dova.JDK.sun.java2d.SurfaceDataProxy
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OGLSurfaceDataProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLSurfaceDataProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "oglgc", "Lsun/java2d/opengl/OGLGraphicsConfig;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transparency", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/opengl/OGLGraphicsConfig;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOperation", "(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateSurfaceData", "(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;II)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createProxy", "(Lsun/java2d/SurfaceData;Lsun/java2d/opengl/OGLGraphicsConfig;)Lsun/java2d/SurfaceDataProxy;"));
	}

	[JniSignatureAttribute("Lsun/java2d/opengl/OGLGraphicsConfig;", "")]
	public Dova.JDK.sun.java2d.opengl.OGLGraphicsConfig oglgc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.OGLGraphicsConfig>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int transparency_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OGLSurfaceDataProxy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/opengl/OGLGraphicsConfig;I)V", "public")]
	public OGLSurfaceDataProxy(Dova.JDK.sun.java2d.opengl.OGLGraphicsConfig arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/opengl/OGLSurfaceDataProxy;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;ILsun/java2d/loops/CompositeType;Ljava/awt/Color;)Z", "public")]
	public bool isSupportedOperation(Dova.JDK.sun.java2d.SurfaceData arg0, int arg1, Dova.JDK.sun.java2d.loops.CompositeType arg2, Dova.JDK.java.awt.Color arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;II)Lsun/java2d/SurfaceData;", "public")]
	public Dova.JDK.sun.java2d.SurfaceData validateSurfaceData(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.SurfaceData arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Lsun/java2d/opengl/OGLGraphicsConfig;)Lsun/java2d/SurfaceDataProxy;", "public static")]
	public static Dova.JDK.sun.java2d.SurfaceDataProxy createProxy(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.sun.java2d.opengl.OGLGraphicsConfig arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceDataProxy>(ret);
	}
}
