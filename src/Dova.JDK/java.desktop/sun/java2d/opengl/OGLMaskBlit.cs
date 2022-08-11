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

[JniSignatureAttribute("Lsun/java2d/opengl/OGLMaskBlit;", "")]
public partial class OGLMaskBlit
	: Dova.JDK.sun.java2d.pipe.BufferedMaskBlit
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OGLMaskBlit()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLMaskBlit;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateContext", "(Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OGLMaskBlit(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/CompositeType;)V", "private")]
	public OGLMaskBlit(Dova.JDK.sun.java2d.loops.SurfaceType arg0, Dova.JDK.sun.java2d.loops.CompositeType arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/opengl/OGLMaskBlit;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "static")]
	public static void register()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Ljava/awt/Composite;Lsun/java2d/pipe/Region;)V", "protected")]
	public void validateContext(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.java.awt.Composite arg1, Dova.JDK.sun.java2d.pipe.Region arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}
}
