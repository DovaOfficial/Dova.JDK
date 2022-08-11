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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DeferredNode;", "public abstract interface")]
public partial interface DeferredNode
	: IJavaObject
	, Dova.JDK.org.w3c.dom.Node
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DeferredNode()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DeferredNode;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_NODE", "S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeIndex", "()I"));
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short TYPE_NODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getNodeIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}
}
