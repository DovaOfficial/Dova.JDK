/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.sql.rowset;

[JniSignatureAttribute("Ljavax/sql/rowset/FilteredRowSet;", "public abstract interface")]
public partial interface FilteredRowSet
	: IJavaObject
	, Dova.JDK.javax.sql.rowset.WebRowSet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FilteredRowSet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/rowset/FilteredRowSet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFilter", "()Ljavax/sql/rowset/Predicate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setFilter", "(Ljavax/sql/rowset/Predicate;)V"));
	}

	[JniSignatureAttribute("()Ljavax/sql/rowset/Predicate;", "public abstract")]
	Dova.JDK.javax.sql.rowset.Predicate getFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.sql.rowset.Predicate>(ret);
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/Predicate;)V", "public abstract")]
	void setFilter(Dova.JDK.javax.sql.rowset.Predicate arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
