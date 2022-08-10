/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/DescriptorAccess;", "public abstract interface")]
public partial interface DescriptorAccess
	: IJavaObject
	, Dova.JDK.javax.management.DescriptorRead
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DescriptorAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/DescriptorAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDescriptor", "(Ljavax/management/Descriptor;)V"));
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;)V", "public abstract")]
	void setDescriptor(Dova.JDK.javax.management.Descriptor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
