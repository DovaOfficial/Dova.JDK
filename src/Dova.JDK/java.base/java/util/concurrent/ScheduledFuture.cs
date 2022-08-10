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

[JniSignatureAttribute("Ljava/util/concurrent/ScheduledFuture;", "public abstract interface")]
public partial interface ScheduledFuture
	: IJavaObject
	, Dova.JDK.java.util.concurrent.Delayed
	, Dova.JDK.java.util.concurrent.Future
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static ScheduledFuture()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/concurrent/ScheduledFuture;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
