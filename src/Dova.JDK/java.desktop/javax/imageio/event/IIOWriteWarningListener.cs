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

namespace Dova.JDK.javax.imageio.@event;

[JniSignatureAttribute("Ljavax/imageio/event/IIOWriteWarningListener;", "public abstract interface")]
public partial interface IIOWriteWarningListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IIOWriteWarningListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/event/IIOWriteWarningListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warningOccurred", "(Ljavax/imageio/ImageWriter;ILjava/lang/String;)V"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;ILjava/lang/String;)V", "public abstract")]
	void warningOccurred(Dova.JDK.javax.imageio.ImageWriter arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}
