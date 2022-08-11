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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSInputSource;", "public final")]
public partial class XSInputSource
	: Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSInputSource()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSInputSource;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fGrammars", "[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fComponents", "[Lcom/sun/org/apache/xerces/internal/xs/XSObject;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/org/apache/xerces/internal/xs/XSObject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGrammars", "([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setComponents", "([Lcom/sun/org/apache/xerces/internal/xs/XSObject;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGrammars", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponents", "()[Lcom/sun/org/apache/xerces/internal/xs/XSObject;"));
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> fGrammars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/xs/XSObject;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> fComponents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSInputSource(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "public")]
	public XSInputSource(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xs/XSObject;)V", "public")]
	public XSInputSource(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/util/XSInputSource;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "public")]
	public void setGrammars(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/xerces/internal/xs/XSObject;)V", "public")]
	public void setComponents(JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> getGrammars()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/xs/XSObject;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject> getComponents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject>>(ret);
	}
}
