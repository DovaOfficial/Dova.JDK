/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.access;

[JniSignatureAttribute("Ljdk/internal/access/JavaObjectInputStreamReadString;", "public abstract interface")]
public partial interface JavaObjectInputStreamReadString
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaObjectInputStreamReadString()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/access/JavaObjectInputStreamReadString;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readString", "(Ljava/io/ObjectInputStream;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String readString(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
