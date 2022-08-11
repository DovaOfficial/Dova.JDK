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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XCustomCursor;", "public")]
public partial class XCustomCursor
	: Dova.JDK.sun.awt.X11CustomCursor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XCustomCursor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XCustomCursor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Image;Ljava/awt/Point;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCursor", "([B[BIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBestCursorSize", "(II)Ljava/awt/Dimension;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XCustomCursor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Point;Ljava/lang/String;)V", "public")]
	public XCustomCursor(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Point arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XCustomCursor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([B[BIIIIII)V", "protected")]
	public void createCursor(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Dimension;", "static")]
	public static Dova.JDK.java.awt.Dimension getBestCursorSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}
}
