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

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaObjectInputStreamAccess;", "public abstract interface")]
public partial interface JavaObjectInputStreamAccess
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaObjectInputStreamAccess()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljdk/internal/access/JavaObjectInputStreamAccess;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "checkArray", "(Ljava/io/ObjectInputStream;Ljava/lang/Class;I)V"));
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;Ljava/lang/Class;I)V", "public abstract")]
	void checkArray(Dova.JDK.java.io.ObjectInputStream arg0, Dova.JDK.java.lang.Class arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}
}