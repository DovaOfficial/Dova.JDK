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

namespace Dova.JDK.com.sun.jdi.@event;

[JniSignatureAttribute("Lcom/sun/jdi/event/AccessWatchpointEvent;", "public abstract interface")]
public partial interface AccessWatchpointEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.WatchpointEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static AccessWatchpointEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/AccessWatchpointEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
