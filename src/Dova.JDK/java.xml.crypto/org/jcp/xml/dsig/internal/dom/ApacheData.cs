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

[JniSignatureAttribute("Lorg/jcp/xml/dsig/internal/dom/ApacheData;", "public abstract interface")]
public partial interface ApacheData
	: IJavaObject
	, Dova.JDK.javax.xml.crypto.Data
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ApacheData()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/jcp/xml/dsig/internal/dom/ApacheData;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getXMLSignatureInput", "()Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/security/signature/XMLSignatureInput;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureInput getXMLSignatureInput()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureInput>(ret);
	}
}