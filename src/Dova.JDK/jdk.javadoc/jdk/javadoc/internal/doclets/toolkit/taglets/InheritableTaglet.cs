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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/InheritableTaglet;", "public abstract interface")]
public partial interface InheritableTaglet
	: IJavaObject
	, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.Taglet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InheritableTaglet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/InheritableTaglet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inherit", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Input;Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Output;)V"));
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Input;Ljdk/javadoc/internal/doclets/toolkit/util/DocFinder$Output;)V", "public abstract")]
	void inherit(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFinder.Input arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFinder.Output arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
