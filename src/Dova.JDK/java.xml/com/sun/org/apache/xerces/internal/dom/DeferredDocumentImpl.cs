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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl;", "public")]
public partial class DeferredDocumentImpl
	: Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DocumentImpl
	, Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DeferredNode
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DeferredDocumentImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_PRINT_REF_COUNTS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_PRINT_TABLES", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_IDS", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHUNK_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHUNK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHUNK_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIAL_CHUNK_COUNT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeType", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeName", "[[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeValue", "[[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeParent", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeLastChild", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodePrevSib", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeURI", "[[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNodeExtra", "[[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdName", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIdElement", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespacesEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fBufferStr", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fStrChunks", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INIT_ARRAY", "[I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "print", "([IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "binarySearch", "([IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(ILjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synchronizeData", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synchronizeChildren", "(Lcom/sun/org/apache/xerces/internal/dom/ParentNode;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synchronizeChildren", "(Lcom/sun/org/apache/xerces/internal/dom/AttrImpl;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "synchronizeChildren", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIdentifier", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputEncoding", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredEntityReference", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRealPrevSibling", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRealPrevSibling", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEntityInfo", "(ILjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredComment", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredProcessingInstruction", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredDocument", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredDocumentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredElement", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredElement", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDeferredAttribute", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZLjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredCDATASection", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredTextNode", "(Ljava/lang/String;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTypeInfo", "(ILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAsLastChild", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValueString", "(IZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValueString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeferredEntityBaseURI", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInternalSubset", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredEntity", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrevSibling", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrevSibling", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredNotation", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupElementDefinition", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredElementDefinition", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredAttribute", "(Ljava/lang/String;Ljava/lang/String;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDeferredAttribute", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNode", "(S)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChunkValue", "([[Ljava/lang/Object;Ljava/lang/Object;II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChunkIndex", "([[IIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeExtra", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeExtra", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChunkIndex", "([[III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChunkValue", "([[Ljava/lang/Object;II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearChunkIndex", "([[III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearChunkValue", "([[Ljava/lang/Object;II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putIdentifier0", "(Ljava/lang/String;Lorg/w3c/dom/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeURI", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeURI", "(IZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeObject", "(I)Lcom/sun/org/apache/xerces/internal/dom/DeferredNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChunk", "([[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createChunk", "([[Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespacesEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNamespacesEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInfo", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementation", "()Lorg/w3c/dom/DOMImplementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeName", "(IZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeType", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeType", "(IZ)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentNode", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentNode", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastChild", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastChild", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertBefore", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cloneNode", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttributeNode", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIdAttribute", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIdAttributeNode", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendChild", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValue", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValue", "(IZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNodeValue", "(II)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_PRINT_REF_COUNTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_PRINT_TABLES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_IDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int CHUNK_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int CHUNK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int CHUNK_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int INITIAL_CHUNK_COUNT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "protected transient")]
	public int fNodeCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[[I", "protected transient")]
	public JavaArray<JavaArray<int>> fNodeType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[Ljava/lang/Object;", "protected transient")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.Object>> fNodeName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.Object>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[Ljava/lang/Object;", "protected transient")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.Object>> fNodeValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.Object>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "protected transient")]
	public JavaArray<JavaArray<int>> fNodeParent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "protected transient")]
	public JavaArray<JavaArray<int>> fNodeLastChild_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "protected transient")]
	public JavaArray<JavaArray<int>> fNodePrevSib_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[Ljava/lang/Object;", "protected transient")]
	public JavaArray<JavaArray<Dova.JDK.java.lang.Object>> fNodeURI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.Object>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[I", "protected transient")]
	public JavaArray<JavaArray<int>> fNodeExtra_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<int>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected transient")]
	public int fIdCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "protected transient")]
	public JavaArray<Dova.JDK.java.lang.String> fIdName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "protected transient")]
	public JavaArray<int> fIdElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool fNamespacesEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final transient")]
	public Dova.JDK.java.lang.StringBuilder fBufferStr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final transient")]
	public Dova.JDK.java.util.List fStrChunks_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> INIT_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DeferredDocumentImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZZ)V", "public")]
	public DeferredDocumentImpl(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public DeferredDocumentImpl(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DeferredDocumentImpl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void print()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("([IIIII)V", "private static")]
	public static void print(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void ensureCapacity(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("([IIII)I", "protected static")]
	public static int binarySearch(JavaArray<int> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getAttribute(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void synchronizeData()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/ParentNode;I)V", "protected final")]
	public void synchronizeChildren(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.ParentNode arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/dom/AttrImpl;I)V", "protected final")]
	public void synchronizeChildren(Dova.JDK.com.sun.org.apache.xerces.@internal.dom.AttrImpl arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void synchronizeChildren()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void putIdentifier(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void setInputEncoding(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredEntityReference(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRealPrevSibling(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getRealPrevSibling(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;)V", "public")]
	public void setEntityInfo(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int createDeferredComment(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredProcessingInstruction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int createDeferredDocument()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredDocumentType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)I", "public")]
	public int createDeferredElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int createDeferredElement(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZLjava/lang/Object;)I", "public")]
	public int setDeferredAttribute(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4, bool arg5, Dova.JDK.java.lang.Object arg6)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int createDeferredCDATASection(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)I", "public")]
	public int createDeferredTextNode(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)V", "public")]
	public void setTypeInfo(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setAsLastChild(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeValueString(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeValueString(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDeferredEntityBaseURI(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void setInternalSubset(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredEntity(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getPrevSibling(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getPrevSibling(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int createDeferredNotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int lookupElementDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int createDeferredElementDefinition(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Z)I", "public")]
	public int createDeferredAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I", "public")]
	public int createDeferredAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNodeIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(S)I", "protected")]
	public int createNode(short arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("([[Ljava/lang/Object;Ljava/lang/Object;II)Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String setChunkValue(JavaArray<JavaArray<Dova.JDK.java.lang.Object>> arg0, Dova.JDK.java.lang.Object arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([[IIII)I", "private final")]
	public int setChunkIndex(JavaArray<JavaArray<int>> arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getNodeExtra(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNodeExtra(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("([[III)I", "private final")]
	public int getChunkIndex(JavaArray<JavaArray<int>> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([[Ljava/lang/Object;II)Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String getChunkValue(JavaArray<JavaArray<Dova.JDK.java.lang.Object>> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([[III)I", "private final")]
	public int clearChunkIndex(JavaArray<JavaArray<int>> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("([[Ljava/lang/Object;II)Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String clearChunkValue(JavaArray<JavaArray<Dova.JDK.java.lang.Object>> arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/Element;)V", "private final")]
	public void putIdentifier0(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.Element arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeURI(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeURI(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/dom/DeferredNode;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DeferredNode getNodeObject(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.dom.DeferredNode>(ret);
	}

	[JniSignatureAttribute("([[II)V", "private final")]
	public void createChunk(JavaArray<JavaArray<int>> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("([[Ljava/lang/Object;I)V", "private final")]
	public void createChunk(JavaArray<JavaArray<Dova.JDK.java.lang.Object>> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool getNamespacesEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setNamespacesEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getTypeInfo(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/DOMImplementation;", "public")]
	public Dova.JDK.org.w3c.dom.DOMImplementation getImplementation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.DOMImplementation>(ret);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeName(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short getNodeType(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)S", "public")]
	public short getNodeType(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getParentNode(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getParentNode(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getLastChild(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int getLastChild(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(III)I", "public")]
	public int insertBefore(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IZ)I", "public")]
	public int cloneNode(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int setAttributeNode(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setIdAttribute(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setIdAttributeNode(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void appendChild(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNodeValue(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String getNodeValue(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$RefCount;", "static final")]
	public partial class RefCount
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RefCount()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$RefCount;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fCount", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("I", "")]
		public int fCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RefCount(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public RefCount() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$RefCount;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$IntVector;", "static final")]
	public partial class IntVector
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IntVector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$IntVector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elementAt", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addElement", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllElements", "()V"));
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int size_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IntVector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public IntVector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/dom/DeferredDocumentImpl$IntVector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureCapacity(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int elementAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void addElement(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void removeAllElements()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}
}
