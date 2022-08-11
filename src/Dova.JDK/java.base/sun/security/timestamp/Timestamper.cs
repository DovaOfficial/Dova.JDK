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

namespace Dova.JDK.sun.security.timestamp;

[JniSignatureAttribute("Lsun/security/timestamp/Timestamper;", "public abstract interface")]
public partial interface Timestamper
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Timestamper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/security/timestamp/Timestamper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateTimestamp", "(Lsun/security/timestamp/TSRequest;)Lsun/security/timestamp/TSResponse;"));
	}

	[JniSignatureAttribute("(Lsun/security/timestamp/TSRequest;)Lsun/security/timestamp/TSResponse;", "public abstract")]
	Dova.JDK.sun.security.timestamp.TSResponse generateTimestamp(Dova.JDK.sun.security.timestamp.TSRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.security.timestamp.TSResponse>(ret);
	}
}
