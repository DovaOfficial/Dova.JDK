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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter;", "public abstract")]
public partial class MultipleNodeCounter
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.NodeCounter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultipleNodeCounter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_precSiblings", "Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCounter", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultNodeCounter", "(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xalan/internal/xsltc/dom/NodeCounter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartNode", "(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/NodeCounter;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator _precSiblings_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MultipleNodeCounter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V", "public")]
	public MultipleNodeCounter(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)V", "public")]
	public MultipleNodeCounter(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCounter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)Lcom/sun/org/apache/xalan/internal/xsltc/dom/NodeCounter;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.NodeCounter getDefaultNodeCounter(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.NodeCounter>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/NodeCounter;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.NodeCounter setStartNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.NodeCounter>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter$DefaultMultipleNodeCounter;", "static")]
	public partial class DefaultMultipleNodeCounter
		: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultipleNodeCounter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultMultipleNodeCounter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter$DefaultMultipleNodeCounter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultMultipleNodeCounter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/Translet;Lcom/sun/org/apache/xalan/internal/xsltc/DOM;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;)V", "public")]
		public DefaultMultipleNodeCounter(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.Translet arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg1, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultipleNodeCounter$DefaultMultipleNodeCounter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
