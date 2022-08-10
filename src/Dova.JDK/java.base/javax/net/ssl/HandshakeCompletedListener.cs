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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/HandshakeCompletedListener;", "public abstract interface")]
public partial interface HandshakeCompletedListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HandshakeCompletedListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/HandshakeCompletedListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handshakeCompleted", "(Ljavax/net/ssl/HandshakeCompletedEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/HandshakeCompletedEvent;)V", "public abstract")]
	void handshakeCompleted(Dova.JDK.javax.net.ssl.HandshakeCompletedEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
