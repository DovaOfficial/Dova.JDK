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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.functions;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/functions/FuncNormalizeSpace;", "public")]
public partial class FuncNormalizeSpace
	: Dova.JDK.com.sun.org.apache.xpath.@internal.functions.FunctionDef1Arg
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FuncNormalizeSpace()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/functions/FuncNormalizeSpace;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FuncNormalizeSpace", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "execute", "(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "executeCharsToContentHandler", "(Lcom/sun/org/apache/xpath/internal/XPathContext;Lorg/xml/sax/ContentHandler;)V"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FuncNormalizeSpace(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public FuncNormalizeSpace() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/functions/FuncNormalizeSpace;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject execute(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/XPathContext;Lorg/xml/sax/ContentHandler;)V", "public")]
	public void executeCharsToContentHandler(Dova.JDK.com.sun.org.apache.xpath.@internal.XPathContext arg0, Dova.JDK.org.xml.sax.ContentHandler arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
