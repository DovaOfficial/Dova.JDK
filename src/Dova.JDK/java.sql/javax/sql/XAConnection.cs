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

namespace Dova.JDK.javax.sql;

[JniSignatureAttribute("Ljavax/sql/XAConnection;", "public abstract interface")]
public partial interface XAConnection
	: IJavaObject
	, Dova.JDK.javax.sql.PooledConnection
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XAConnection()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/sql/XAConnection;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getXAResource", "()Ljavax/transaction/xa/XAResource;"));
	}

	[JniSignatureAttribute("()Ljavax/transaction/xa/XAResource;", "public abstract")]
	Dova.JDK.javax.transaction.xa.XAResource getXAResource()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.transaction.xa.XAResource>(ret);
	}
}
