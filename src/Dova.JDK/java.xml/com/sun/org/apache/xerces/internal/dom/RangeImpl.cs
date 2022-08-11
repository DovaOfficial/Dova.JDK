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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/RangeImpl;", "public")]
public partial class RangeImpl
	: Dova.JDK.java.lang.Object
	, Dova.JDK.org.w3c.dom.ranges.Range
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RangeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/RangeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDocument", "Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStartContainer", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEndContainer", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStartOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEndOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIsCollapsed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDetach", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fInsertNode", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fDeleteNode", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSplitNode", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fInsertedFromRange", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fRemoveChild", "Lorg/w3c/dom/Node;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTRACT_CONTENTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLONE_CONTENTS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELETE_CONTENTS", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkIndex", "(Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextNode", "(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStart", "(Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalContainer", "(Lorg/w3c/dom/Node;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommonAncestorContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasLegalRootContainer", "(Lorg/w3c/dom/Node;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalContainedNode", "(Lorg/w3c/dom/Node;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseContents", "(I)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "signalSplitData", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractContents", "()Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSameContainer", "(I)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseCommonStartContainer", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseCommonEndContainer", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseCommonAncestors", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedNode", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseFullySelected", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseRightBoundary", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEndBefore", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseLeftBoundary", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartAfter", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseNode", "(Lorg/w3c/dom/Node;ZZI)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseTextNode", "(Lorg/w3c/dom/Node;ZI)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traversePartiallySelected", "(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootContainer", "(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCollapsed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartBefore", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEndAfter", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectNodeContents", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareBoundaryPoints", "(SLorg/w3c/dom/ranges/Range;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteContents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneContents", "()Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "surroundContents", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneRange", "()Lorg/w3c/dom/ranges/Range;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collapse", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnd", "(Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertData", "(Lorg/w3c/dom/CharacterData;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteData", "(Lorg/w3c/dom/CharacterData;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiveReplacedText", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiveDeletedText", "(Lorg/w3c/dom/Node;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiveInsertedText", "(Lorg/w3c/dom/Node;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiveSplitData", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertedNodeFromDOM", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeChild", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAncestorOf", "(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl fDocument_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fStartContainer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fEndContainer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int fStartOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int fEndOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fIsCollapsed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fDetach_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fInsertNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fDeleteNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fSplitNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool fInsertedFromRange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node fRemoveChild_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int EXTRACT_CONTENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int CLONE_CONTENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int DELETE_CONTENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RangeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/DocumentImpl;)V", "public")]
	public RangeImpl(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/RangeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)V", "")]
	public void checkIndex(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)I", "")]
	public int indexOf(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
	public void removeNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Z)Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node nextNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void detach()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)V", "public")]
	public void setStart(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Z", "private")]
	public bool isLegalContainer(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getCommonAncestorContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Z", "private")]
	public bool hasLegalRootContainer(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Z", "private")]
	public bool isLegalContainedNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getStartContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public")]
	public Dova.JDK.org.w3c.dom.Node getEndContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/DocumentFragment;", "private")]
	public Dova.JDK.org.w3c.dom.DocumentFragment traverseContents(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)V", "")]
	public void signalSplitData(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DocumentFragment;", "public")]
	public Dova.JDK.org.w3c.dom.DocumentFragment extractContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void insertNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void selectNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(I)Lorg/w3c/dom/DocumentFragment;", "private")]
	public Dova.JDK.org.w3c.dom.DocumentFragment traverseSameContainer(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;", "private")]
	public Dova.JDK.org.w3c.dom.DocumentFragment traverseCommonStartContainer(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;", "private")]
	public Dova.JDK.org.w3c.dom.DocumentFragment traverseCommonEndContainer(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)Lorg/w3c/dom/DocumentFragment;", "private")]
	public Dova.JDK.org.w3c.dom.DocumentFragment traverseCommonAncestors(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node getSelectedNode(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traverseFullySelected(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traverseRightBoundary(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void setEndBefore(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traverseLeftBoundary(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void setStartAfter(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;ZZI)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traverseNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1, bool arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;ZI)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traverseTextNode(Dova.JDK.org.w3c.dom.Node arg0, bool arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node traversePartiallySelected(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "private")]
	public Dova.JDK.org.w3c.dom.Node getRootContainer(Dova.JDK.org.w3c.dom.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getCollapsed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void setStartBefore(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void setEndAfter(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void selectNodeContents(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(SLorg/w3c/dom/ranges/Range;)S", "public")]
	public short compareBoundaryPoints(short arg0, Dova.JDK.org.w3c.dom.ranges.Range arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void deleteContents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DocumentFragment;", "public")]
	public Dova.JDK.org.w3c.dom.DocumentFragment cloneContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void surroundContents(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ranges/Range;", "public")]
	public Dova.JDK.org.w3c.dom.ranges.Range cloneRange()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ranges.Range>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void collapse(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEndOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)V", "public")]
	public void setEnd(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/CharacterData;ILjava/lang/String;)V", "")]
	public void insertData(Dova.JDK.org.w3c.dom.CharacterData arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/CharacterData;II)V", "")]
	public void deleteData(Dova.JDK.org.w3c.dom.CharacterData arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "")]
	public void receiveReplacedText(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;II)V", "")]
	public void receiveDeletedText(Dova.JDK.org.w3c.dom.Node arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;II)V", "")]
	public void receiveInsertedText(Dova.JDK.org.w3c.dom.Node arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;I)V", "")]
	public void receiveSplitData(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public")]
	public void insertedNodeFromDOM(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "")]
	public Dova.JDK.org.w3c.dom.Node removeChild(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Lorg/w3c/dom/Node;)Z", "")]
	public bool isAncestorOf(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.org.w3c.dom.Node arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return ret;
	}
}
