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

namespace Dova.JDK.javax.sql.rowset.spi;

[JniSignatureAttribute("Ljavax/sql/rowset/spi/XmlReader;", "public abstract interface")]
public partial interface XmlReader
	: IJavaObject
	, Dova.JDK.javax.sql.RowSetReader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XmlReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/rowset/spi/XmlReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readXML", "(Ljavax/sql/rowset/WebRowSet;Ljava/io/Reader;)V"));
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/WebRowSet;Ljava/io/Reader;)V", "public abstract")]
	void readXML(Dova.JDK.javax.sql.rowset.WebRowSet arg0, Dova.JDK.java.io.Reader arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
