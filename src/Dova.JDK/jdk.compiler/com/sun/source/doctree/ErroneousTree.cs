/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.source.doctree;

[JniSignatureAttribute("Lcom/sun/source/doctree/ErroneousTree;", "public abstract interface")]
public partial interface ErroneousTree
	: IJavaObject
	, Dova.JDK.com.sun.source.doctree.TextTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ErroneousTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/doctree/ErroneousTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDiagnostic", "()Ljavax/tools/Diagnostic;"));
	}

	[JniSignatureAttribute("()Ljavax/tools/Diagnostic;", "public abstract")]
	Dova.JDK.javax.tools.Diagnostic getDiagnostic()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.Diagnostic>(ret);
	}
}
