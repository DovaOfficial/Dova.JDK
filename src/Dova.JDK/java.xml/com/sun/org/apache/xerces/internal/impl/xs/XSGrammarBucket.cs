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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;", "public")]
public partial class XSGrammarBucket
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSGrammarBucket()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fGrammarRegistry", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "fNoNSGrammar", "Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "XSGrammarBucket", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reset", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Z)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ZZ)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "putGrammar", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getGrammar", "(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getGrammars", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map fGrammarRegistry_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar fNoNSGrammar_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSGrammarBucket(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XSGrammarBucket() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/XSGrammarBucket;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void reset()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;Z)Z", "public")]
	public bool putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ZZ)Z", "public")]
	public bool putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0, bool arg1, bool arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)V", "public")]
	public void putGrammar(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar getGrammar(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>(ret);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar> getGrammars()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar>>(ret);
	}
}