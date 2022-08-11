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

namespace Dova.JDK.com.sun.java.accessibility.util;

[JniSignatureAttribute("Lcom/sun/java/accessibility/util/EventQueueMonitorItem;", "")]
public partial class EventQueueMonitorItem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventQueueMonitorItem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/accessibility/util/EventQueueMonitorItem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "event", "Ljava/awt/AWTEvent;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lcom/sun/java/accessibility/util/EventQueueMonitorItem;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/AWTEvent;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/AWTEvent;", "")]
	public Dova.JDK.java.awt.AWTEvent @event_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.AWTEvent>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/accessibility/util/EventQueueMonitorItem;", "")]
	public Dova.JDK.com.sun.java.accessibility.util.EventQueueMonitorItem next_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.accessibility.util.EventQueueMonitorItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EventQueueMonitorItem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/AWTEvent;)V", "")]
	public EventQueueMonitorItem(Dova.JDK.java.awt.AWTEvent arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/EventQueueMonitorItem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
