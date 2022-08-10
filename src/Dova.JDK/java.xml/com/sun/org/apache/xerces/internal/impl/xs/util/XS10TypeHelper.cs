/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/util/XS10TypeHelper;", "public")]
public partial class XS10TypeHelper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XS10TypeHelper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/util/XS10TypeHelper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "XS10TypeHelper", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSchemaTypeName", "(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XS10TypeHelper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public XS10TypeHelper() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/util/XS10TypeHelper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xs/XSTypeDefinition;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getSchemaTypeName(Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSTypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
