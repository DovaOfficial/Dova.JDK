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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;", "public")]
public partial class KeyIndex
	: Dova.JDK.com.sun.org.apache.xml.@internal.dtm.@ref.DTMAxisIteratorBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static KeyIndex()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_index", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_currentDocumentNode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_rootToIndexMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_nodes", "Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_dom", "Lcom/sun/org/apache/xalan/internal/xsltc/DOM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_enhancedDOM", "Lcom/sun/org/apache/xalan/internal/xsltc/DOMEnhancedForDTM;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_markedPosition", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_NODES", "Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsKey", "(ILjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLast", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gotoMark", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartNode", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartNode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReverse", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneIterator", "()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRestartable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMNodeById", "(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyIndexIterator", "(Ljava/lang/Object;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyIndexIterator", "(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeyIndexIterator", "(Ljava/lang/String;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupId", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupKey", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsID", "(ILjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDom", "(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMark", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "()I"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _currentDocumentNode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _rootToIndexMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray _nodes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/DOM;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM _dom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/DOMEnhancedForDTM;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOMEnhancedForDTM _enhancedDOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOMEnhancedForDTM>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _markedPosition_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "private static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray EMPTY_NODES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public KeyIndex(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public KeyIndex(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
	public void add(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public")]
	public int next()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;)V", "public")]
	public void merge(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)I", "public")]
	public int containsKey(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator reset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLast()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void gotoMark()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator setStartNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartNode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isReverse()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator cloneIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRestartable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray getDOMNodeById(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator getKeyIndexIterator(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator getKeyIndexIterator(Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator getKeyIndexIterator(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void lookupId(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void lookupKey(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)I", "public")]
	public int containsID(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/DOM;I)V", "public")]
	public void setDom(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.DOM arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void setMark()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;", "public")]
	public partial class KeyIndexIterator
		: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeyIndexIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_nodes", "Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_keyValueIterator", "Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_keyValue", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_isKeyIterator", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;Ljava/lang/String;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLast", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartNode", "(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeByPosition", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupNodes", "(ILjava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "private")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray _nodes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "private")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator _keyValueIterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String _keyValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool _isKeyIterator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;", "final")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public KeyIndexIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;Ljava/lang/String;Z)V", "")]
		public KeyIndexIterator(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex arg0, Dova.JDK.java.lang.String arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex;Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;Z)V", "")]
		public KeyIndexIterator(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex arg0, Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int next()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected")]
		public void init()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator reset()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getLast()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/org/apache/xml/internal/dtm/DTMAxisIterator;", "public")]
		public Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator setStartNode(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.dtm.DTMAxisIterator>(ret);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getNodeByPosition(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "protected")]
		public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray lookupNodes(int arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator$KeyIndexHeapNode;", "protected")]
		public partial class KeyIndexHeapNode
			: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static KeyIndexHeapNode()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator$KeyIndexHeapNode;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_nodes", "Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_position", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_markPosition", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "step", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gotoMark", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStartNode", "(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneHeapNode", "()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLessThan", "(Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMark", "()V"));
			}

			[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;", "private")]
			public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray _nodes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int _position_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int _markPosition_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public KeyIndexHeapNode(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator;Lcom/sun/org/apache/xalan/internal/xsltc/util/IntegerArray;)V", "")]
			public KeyIndexHeapNode(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.KeyIndex.KeyIndexIterator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.util.IntegerArray arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/dom/KeyIndex$KeyIndexIterator$KeyIndexHeapNode;";
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

			[JniSignatureAttribute("()V", "public")]
			public void gotoMark()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(I)Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;", "public")]
			public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode setStartNode(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;", "public")]
			public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode cloneHeapNode()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/dom/MultiValuedNodeHeapIterator$HeapNode;)Z", "public")]
			public bool isLessThan(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.dom.MultiValuedNodeHeapIterator.HeapNode arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return ret;
			}

			[JniSignatureAttribute("()V", "public")]
			public void setMark()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
			}
		}
	}
}
