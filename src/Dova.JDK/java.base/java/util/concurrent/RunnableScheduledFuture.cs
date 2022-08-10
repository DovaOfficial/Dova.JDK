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

namespace Dova.JDK.java.util.concurrent;

[JniSignatureAttribute("Ljava/util/concurrent/RunnableScheduledFuture;", "public abstract interface")]
public partial interface RunnableScheduledFuture
	: IJavaObject
	, Dova.JDK.java.util.concurrent.RunnableFuture
	, Dova.JDK.java.util.concurrent.ScheduledFuture
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RunnableScheduledFuture()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/RunnableScheduledFuture;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isPeriodic", "()Z"));
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isPeriodic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}
}
