/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jdi/event/AccessWatchpointEvent;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}