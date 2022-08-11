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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;", "public final")]
public partial class XSModelImpl
	: Dova.JDK.java.util.AbstractList
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModel
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItemList
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSModelImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_COMP_IDX", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GLOBAL_COMP", "[Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespaces", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarList", "[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammarMap", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fSubGroupMap", "Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGlobalComponents", "[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNSComponents", "[[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fNamespacesList", "Lcom/sun/org/apache/xerces/internal/xs/StringList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAnnotations", "Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fHasIDC", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listIterator", "(I)Ljava/util/ListIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listIterator", "()Ljava/util/ListIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "item", "(I)Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasIDConstraints", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listIterator0", "(I)Ljava/util/ListIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray0", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildSubGroups", "()Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalElements", "()Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSObjectListImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildSubGroups_Org", "()Lcom/sun/org/apache/xerces/internal/util/SymbolHash;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceItems", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItemList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentsByNamespace", "(SLjava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementDeclaration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeDeclaration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDefinition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeGroup", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeGroup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelGroupDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelGroupDefinition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotationDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotationDeclaration", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDCDefinition", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDCDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubstitutionGroup", "(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;)Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "null2EmptyString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaces", "()Lcom/sun/org/apache/xerces/internal/xs/StringList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponents", "(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
	}

	[JniSignatureAttribute("S", "private static final")]
	public static short MAX_COMP_IDX_Property
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

	[JniSignatureAttribute("[Z", "private static final")]
	public static JavaArray<bool> GLOBAL_COMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<bool>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int fGrammarCount_Property
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

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> fNamespaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "private final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> fGrammarList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fGrammarMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash fSubGroupMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "private final")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap> fGlobalComponents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "private final")]
	public JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>> fNSComponents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/StringList;", "private final")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList fNamespacesList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList fAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool fHasIDC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSModelImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "public")]
	public XSModelImpl(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;S)V", "public")]
	public XSModelImpl(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg0, short arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object get_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem get_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> toArray(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/util/ListIterator;", "public")]
	public Dova.JDK.java.util.ListIterator listIterator(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ListIterator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ListIterator;", "public")]
	public Dova.JDK.java.util.ListIterator listIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ListIterator>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem item(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasIDConstraints()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/util/ListIterator;", "private")]
	public Dova.JDK.java.util.ListIterator listIterator0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ListIterator>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "private")]
	public void toArray0(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash buildSubGroups()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSObjectListImpl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSObjectListImpl getGlobalElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util.XSObjectListImpl>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/util/SymbolHash;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash buildSubGroups_Org()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.util.SymbolHash>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItemList;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItemList getNamespaceItems()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItemList>(ret);
	}

	[JniSignatureAttribute("(SLjava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap getComponentsByNamespace(short arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration getElementDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration getElementDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration getAttributeDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration getAttributeDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getTypeDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getTypeDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition getAttributeGroup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition getAttributeGroup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition getModelGroupDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition getModelGroupDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration getNotationDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration getNotationDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition getIDCDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition getIDCDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;)Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getSubstitutionGroup(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String null2EmptyString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/StringList;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList getNamespaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList>(ret);
	}

	[JniSignatureAttribute("(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "public synchronized")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap getComponents(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl$XSNamespaceItemListIterator;", "private final")]
	public partial class XSNamespaceItemListIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.ListIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XSNamespaceItemListIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl$XSNamespaceItemListIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "set", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasPrevious", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previous_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previous_1", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int index_Property
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

		[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;", "final")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XSNamespaceItemListIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl;I)V", "public")]
		public XSNamespaceItemListIterator(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSModelImpl arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSModelImpl$XSNamespaceItemListIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;)V", "public")]
		public void add(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void add(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;)V", "public")]
		public void set(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
		public void set(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int nextIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int previousIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasPrevious()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object previous_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItem;", "public")]
		public Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem previous_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItem>(ret);
		}
	}
}
