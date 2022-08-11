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

namespace Dova.JDK.javax.sql;

[JniSignatureAttribute("Ljavax/sql/RowSetReader;", "public abstract interface")]
public partial interface RowSetReader
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RowSetReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/RowSetReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readData", "(Ljavax/sql/RowSetInternal;)V"));
	}

	[JniSignatureAttribute("(Ljavax/sql/RowSetInternal;)V", "public abstract")]
	void readData(Dova.JDK.javax.sql.RowSetInternal arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
