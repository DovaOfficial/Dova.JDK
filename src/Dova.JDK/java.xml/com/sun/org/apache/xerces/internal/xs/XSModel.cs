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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSModel;", "public abstract interface")]
public partial interface XSModel
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSModel()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xs/XSModel;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaces", "()Lcom/sun/org/apache/xerces/internal/xs/StringList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceItems", "()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItemList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponents", "(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentsByNamespace", "(SLjava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeGroup", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelGroupDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNotationDeclaration", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIDCDefinition", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSubstitutionGroup", "(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;)Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration getElementDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition getTypeDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeDeclaration;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration getAttributeDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeDeclaration>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/StringList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList getNamespaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.StringList>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSNamespaceItemList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItemList getNamespaceItems()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamespaceItemList>(ret);
	}

	[JniSignatureAttribute("(S)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap getComponents(short arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>(ret);
	}

	[JniSignatureAttribute("(SLjava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNamedMap;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap getComponentsByNamespace(short arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNamedMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSAttributeGroupDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition getAttributeGroup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAttributeGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition getModelGroupDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroupDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSNotationDeclaration;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration getNotationDeclaration(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSNotationDeclaration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/xs/XSIDCDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition getIDCDefinition(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSIDCDefinition>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSElementDeclaration;)Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getSubstitutionGroup(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSElementDeclaration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}
}
