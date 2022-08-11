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

namespace Dova.JDK.org.w3c.dom.ranges;

[JniSignatureAttribute("Lorg/w3c/dom/ranges/Range;", "public abstract interface")]
public partial interface Range
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Range()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/ranges/Range;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_TO_START", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_TO_END", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_TO_END", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_TO_START", "S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStart", "(Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteContents", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCollapsed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommonAncestorContainer", "()Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnd", "(Lorg/w3c/dom/Node;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartBefore", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartAfter", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEndBefore", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEndAfter", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectNodeContents", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareBoundaryPoints", "(SLorg/w3c/dom/ranges/Range;)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractContents", "()Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneContents", "()Lorg/w3c/dom/DocumentFragment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertNode", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "surroundContents", "(Lorg/w3c/dom/Node;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneRange", "()Lorg/w3c/dom/ranges/Range;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collapse", "(Z)V"));
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short START_TO_START_Property
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

	[JniSignatureAttribute("S", "public static final")]
	public static short START_TO_END_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short END_TO_END_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short END_TO_START_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void detach()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)V", "public abstract")]
	void setStart(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void deleteContents()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void selectNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node getStartContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node getEndContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool getCollapsed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Node;", "public abstract")]
	Dova.JDK.org.w3c.dom.Node getCommonAncestorContainer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;I)V", "public abstract")]
	void setEnd(Dova.JDK.org.w3c.dom.Node arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void setStartBefore(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void setStartAfter(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void setEndBefore(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void setEndAfter(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void selectNodeContents(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(SLorg/w3c/dom/ranges/Range;)S", "public abstract")]
	short compareBoundaryPoints(short arg0, Dova.JDK.org.w3c.dom.ranges.Range arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DocumentFragment;", "public abstract")]
	Dova.JDK.org.w3c.dom.DocumentFragment extractContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DocumentFragment;", "public abstract")]
	Dova.JDK.org.w3c.dom.DocumentFragment cloneContents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DocumentFragment>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void insertNode(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;)V", "public abstract")]
	void surroundContents(Dova.JDK.org.w3c.dom.Node arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ranges/Range;", "public abstract")]
	Dova.JDK.org.w3c.dom.ranges.Range cloneRange()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ranges.Range>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getStartOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getEndOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void collapse(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}
}
