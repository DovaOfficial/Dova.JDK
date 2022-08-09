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

namespace Dova.JDK.javax.sql.rowset;

[JniSignatureAttribute("Ljavax/sql/rowset/RowSetFactory;", "public abstract interface")]
public partial interface RowSetFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RowSetFactory()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/sql/rowset/RowSetFactory;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createFilteredRowSet", "()Ljavax/sql/rowset/FilteredRowSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createCachedRowSet", "()Ljavax/sql/rowset/CachedRowSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createJdbcRowSet", "()Ljavax/sql/rowset/JdbcRowSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createJoinRowSet", "()Ljavax/sql/rowset/JoinRowSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createWebRowSet", "()Ljavax/sql/rowset/WebRowSet;"));
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/FilteredRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.FilteredRowSet createFilteredRowSet()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.FilteredRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/CachedRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.CachedRowSet createCachedRowSet()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.CachedRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/JdbcRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.JdbcRowSet createJdbcRowSet()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.JdbcRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/JoinRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.JoinRowSet createJoinRowSet()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.JoinRowSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/WebRowSet;", "public abstract")]
	Dova.JDK.javax.sql.rowset.WebRowSet createWebRowSet()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.WebRowSet>(ret);
	}
}
