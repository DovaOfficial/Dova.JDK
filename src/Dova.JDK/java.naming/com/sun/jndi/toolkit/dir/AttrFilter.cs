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

namespace Dova.JDK.com.sun.jndi.toolkit.dir;

[JniSignatureAttribute("Lcom/sun/jndi/toolkit/dir/AttrFilter;", "public abstract interface")]
public partial interface AttrFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AttrFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jndi/toolkit/dir/AttrFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "check", "(Ljavax/naming/directory/Attributes;)Z"));
	}

	[JniSignatureAttribute("(Ljavax/naming/directory/Attributes;)Z", "public abstract")]
	bool check(Dova.JDK.javax.naming.directory.Attributes arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}
}
