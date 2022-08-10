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

[JniSignatureAttribute("Ljavax/sql/rowset/spi/XmlWriter;", "public abstract interface")]
public partial interface XmlWriter
	: IJavaObject
	, Dova.JDK.javax.sql.RowSetWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XmlWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/sql/rowset/spi/XmlWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeXML", "(Ljavax/sql/rowset/WebRowSet;Ljava/io/Writer;)V"));
	}

	[JniSignatureAttribute("(Ljavax/sql/rowset/WebRowSet;Ljava/io/Writer;)V", "public abstract")]
	void writeXML(Dova.JDK.javax.sql.rowset.WebRowSet arg0, Dova.JDK.java.io.Writer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
