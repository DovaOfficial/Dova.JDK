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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;", "public final")]
public partial class UnionIterator
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnionIterator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_dom", "Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addIterator", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "private final")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM _dom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnionIterator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;)V", "public")]
	public UnionIterator(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.UnionIterator addIterator(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.UnionIterator>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator$LookAheadIterator;", "private final")]
	public partial class LookAheadIterator
		: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LookAheadIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator$LookAheadIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iterator", "Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "step", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneHeapNode", "()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLessThan", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMark", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gotoMark", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartNode", "(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator iterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;", "final")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.UnionIterator this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.UnionIterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LookAheadIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V", "public")]
		public LookAheadIterator(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.UnionIterator arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/UnionIterator$LookAheadIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;", "public")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode reset()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int step()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;", "public")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode cloneHeapNode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;)Z", "public")]
		public bool isLessThan(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "public")]
		public void setMark()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void gotoMark()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;", "public")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode setStartNode(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode>(ret);
		}
	}
}
