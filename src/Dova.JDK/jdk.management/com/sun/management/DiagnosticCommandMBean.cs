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

namespace Dova.JDK.com.sun.management;

[JniSignatureAttribute("Lcom/sun/management/DiagnosticCommandMBean;", "public abstract interface")]
public partial interface DiagnosticCommandMBean
	: IJavaObject
	, Dova.JDK.javax.management.DynamicMBean
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static DiagnosticCommandMBean()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/management/DiagnosticCommandMBean;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
