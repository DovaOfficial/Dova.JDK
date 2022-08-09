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

namespace Dova.JDK.org.jcp.xml.dsig.@internal.dom;

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/DOMBase64Transform;", "public final")]
public partial class DOMBase64Transform
	: Dova.JDK.org.jcp.xml.dsig.@internal.dom.ApacheTransform
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMBase64Transform()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/DOMBase64Transform;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DOMBase64Transform", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "init", "(Ljavax/xml/crypto/dsig/spec/TransformParameterSpec;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMBase64Transform(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DOMBase64Transform() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lorg/jcp/xml/dsig/internal/dom/DOMBase64Transform;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/xml/crypto/dsig/spec/TransformParameterSpec;)V", "public")]
	public void init(Dova.JDK.javax.xml.crypto.dsig.spec.TransformParameterSpec arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}