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

namespace Dova.JDK.sun.tools.jconsole.inspector;

[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanOperations;", "public")]
public partial class XMBeanOperations
	: Dova.JDK.sun.tools.jconsole.inspector.XOperations
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMBeanOperations()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanOperations;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/MBeansTab;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateOperations", "([Ljavax/management/MBeanOperationInfo;)[Ljavax/management/MBeanOperationInfo;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMBeanOperations(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/MBeansTab;)V", "public")]
	public XMBeanOperations(Dova.JDK.sun.tools.jconsole.MBeansTab arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanOperations;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljavax/management/MBeanOperationInfo;)[Ljavax/management/MBeanOperationInfo;", "protected")]
	public JavaArray<Dova.JDK.javax.management.MBeanOperationInfo> updateOperations(JavaArray<Dova.JDK.javax.management.MBeanOperationInfo> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanOperationInfo>>(ret);
	}
}
