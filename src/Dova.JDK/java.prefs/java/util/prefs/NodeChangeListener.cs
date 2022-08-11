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

namespace Dova.JDK.java.util.prefs;

[JniSignatureAttribute("Ljava/util/prefs/NodeChangeListener;", "public abstract interface")]
public partial interface NodeChangeListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NodeChangeListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/prefs/NodeChangeListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "childAdded", "(Ljava/util/prefs/NodeChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "childRemoved", "(Ljava/util/prefs/NodeChangeEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/util/prefs/NodeChangeEvent;)V", "public abstract")]
	void childAdded(Dova.JDK.java.util.prefs.NodeChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/prefs/NodeChangeEvent;)V", "public abstract")]
	void childRemoved(Dova.JDK.java.util.prefs.NodeChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
