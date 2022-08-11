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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/CompositeContext;", "public abstract interface")]
public partial interface CompositeContext
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompositeContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/CompositeContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compose", "(Ljava/awt/image/Raster;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/image/Raster;Ljava/awt/image/WritableRaster;)V", "public abstract")]
	void compose(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.image.Raster arg1, Dova.JDK.java.awt.image.WritableRaster arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}
}
