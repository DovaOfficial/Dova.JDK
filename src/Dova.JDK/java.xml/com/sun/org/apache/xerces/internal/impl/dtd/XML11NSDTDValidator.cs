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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/dtd/XML11NSDTDValidator;", "public")]
public partial class XML11NSDTDValidator
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dtd.XML11DTDValidator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XML11NSDTDValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/dtd/XML11NSDTDValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fAttributeQName", "Lcom/sun/org/apache/xerces/internal/xni/QName;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startNamespaceScope", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endNamespaceScope", "(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xni/QName;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName fAttributeQName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XML11NSDTDValidator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XML11NSDTDValidator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/dtd/XML11NSDTDValidator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/XMLAttributes;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;)V", "protected final")]
	public void startNamespaceScope(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLAttributes arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;Lcom/sun/org/apache/xerces/internal/xni/Augmentations;Z)V", "protected")]
	public void endNamespaceScope(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.Augmentations arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}
}
