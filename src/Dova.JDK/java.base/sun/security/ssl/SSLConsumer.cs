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

namespace Dova.JDK.sun.security.ssl;

[JniSignatureAttribute("Lsun/security/ssl/SSLConsumer;", "abstract interface")]
public partial interface SSLConsumer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLConsumer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/ssl/SSLConsumer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "consume", "(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V"));
	}

	[JniSignatureAttribute("(Lsun/security/ssl/ConnectionContext;Ljava/nio/ByteBuffer;)V", "public abstract")]
	void consume(Dova.JDK.sun.security.ssl.ConnectionContext arg0, Dova.JDK.java.nio.ByteBuffer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
