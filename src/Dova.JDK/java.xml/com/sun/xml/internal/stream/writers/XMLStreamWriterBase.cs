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

namespace Dova.JDK.com.sun.xml.@internal.stream.writers;

[JniSignatureAttribute("Lcom/sun/xml/internal/stream/writers/XMLStreamWriterBase;", "public abstract interface")]
public partial interface XMLStreamWriterBase
	: IJavaObject
	, Dova.JDK.javax.xml.stream.XMLStreamWriter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMLStreamWriterBase()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/xml/internal/stream/writers/XMLStreamWriterBase;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeStartDocument", "(Ljava/lang/String;Ljava/lang/String;ZZ)V"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZZ)V", "public abstract")]
	void writeStartDocument(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}
}
