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

namespace Dova.JDK.javax.imageio;

[JniSignatureAttribute("Ljavax/imageio/IIOParamController;", "public abstract interface")]
public partial interface IIOParamController
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IIOParamController()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/IIOParamController;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "activate", "(Ljavax/imageio/IIOParam;)Z"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/IIOParam;)Z", "public abstract")]
	bool activate(Dova.JDK.javax.imageio.IIOParam arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
