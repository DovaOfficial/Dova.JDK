/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/NodeIteratorImpl;", "public")]
public partial class NodeIteratorImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.org.w3c.dom.traversal.NodeIterator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NodeIteratorImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/NodeIteratorImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fDocument", "Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fRoot", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fWhatToShow", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fNodeFilter", "Lorg/w3c/dom/traversal/NodeFilter;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fDetach", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fCurrentNode", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fForward", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fEntityReferenceExpansion", "Z"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NodeIteratorImpl", "(Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getRoot", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nextNode", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "nextNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getFilter", "()Lorg/w3c/dom/traversal/NodeFilter;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "detach", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "previousNode", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "previousNode", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "matchNodeOrParent", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpandEntityReferences", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getWhatToShow", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "acceptNode", "(Lorg/w3c/dom/Node;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl fDocument_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node fRoot_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int fWhatToShow_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Lorg/w3c/dom/traversal/NodeFilter;", "private")]
	public Dova.JDK.org.w3c.dom.traversal.NodeFilter fNodeFilter_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeFilter>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fDetach_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node fCurrentNode_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fForward_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fEntityReferenceExpansion_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NodeIteratorImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;Lorg/w3c/dom/Node;ILorg/w3c/dom/traversal/NodeFilter;Z)V", "public")]
	public NodeIteratorImpl(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl arg0, Dova.JDK.org.w3c.dom.Node arg1, int arg2, Dova.JDK.org.w3c.dom.traversal.NodeFilter arg3, bool arg4) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/NodeIteratorImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getRoot()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void removeNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node nextNode()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node nextNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/traversal/NodeFilter;", "public")]
	public Dova.JDK.org.w3c.dom.traversal.NodeFilter getFilter()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeFilter>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void detach()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node previousNode()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node previousNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node matchNodeOrParent(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getExpandEntityReferences()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getWhatToShow()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Z", "")]
	public bool acceptNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}
}