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

namespace Dova.JDK.java.awt.dnd;

[JniSignatureAttribute("Ljava/awt/dnd/DnDEventMulticaster;", "")]
public partial class DnDEventMulticaster
	: Dova.JDK.java.awt.AWTEventMulticaster
	, Dova.JDK.java.awt.dnd.DragSourceListener
	, Dova.JDK.java.awt.dnd.DragSourceMotionListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DnDEventMulticaster()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/dnd/DnDEventMulticaster;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DnDEventMulticaster", "(Ljava/util/EventListener;Ljava/util/EventListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/dnd/DragSourceMotionListener;Ljava/awt/dnd/DragSourceMotionListener;)Ljava/awt/dnd/DragSourceMotionListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "add", "(Ljava/awt/dnd/DragSourceListener;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/dnd/DragSourceMotionListener;Ljava/awt/dnd/DragSourceMotionListener;)Ljava/awt/dnd/DragSourceMotionListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "remove", "(Ljava/awt/dnd/DragSourceListener;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "remove", "(Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "save", "(Ljava/io/ObjectOutputStream;Ljava/lang/String;Ljava/util/EventListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragDropEnd", "(Ljava/awt/dnd/DragSourceDropEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragMouseMoved", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "removeInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "addInternal", "(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragEnter", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragOver", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dragExit", "(Ljava/awt/dnd/DragSourceEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dropActionChanged", "(Ljava/awt/dnd/DragSourceDragEvent;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DnDEventMulticaster(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)V", "protected")]
	public DnDEventMulticaster(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/dnd/DnDEventMulticaster;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceMotionListener;Ljava/awt/dnd/DragSourceMotionListener;)Ljava/awt/dnd/DragSourceMotionListener;", "public static")]
	public static Dova.JDK.java.awt.dnd.DragSourceMotionListener add(Dova.JDK.java.awt.dnd.DragSourceMotionListener arg0, Dova.JDK.java.awt.dnd.DragSourceMotionListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceMotionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceListener;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceListener;", "public static")]
	public static Dova.JDK.java.awt.dnd.DragSourceListener add(Dova.JDK.java.awt.dnd.DragSourceListener arg0, Dova.JDK.java.awt.dnd.DragSourceListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceMotionListener;Ljava/awt/dnd/DragSourceMotionListener;)Ljava/awt/dnd/DragSourceMotionListener;", "public static")]
	public static Dova.JDK.java.awt.dnd.DragSourceMotionListener remove(Dova.JDK.java.awt.dnd.DragSourceMotionListener arg0, Dova.JDK.java.awt.dnd.DragSourceMotionListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceMotionListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceListener;Ljava/awt/dnd/DragSourceListener;)Ljava/awt/dnd/DragSourceListener;", "public static")]
	public static Dova.JDK.java.awt.dnd.DragSourceListener remove(Dova.JDK.java.awt.dnd.DragSourceListener arg0, Dova.JDK.java.awt.dnd.DragSourceListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.dnd.DragSourceListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;)Ljava/util/EventListener;", "protected")]
	public Dova.JDK.java.util.EventListener remove(Dova.JDK.java.util.EventListener arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;Ljava/lang/String;Ljava/util/EventListener;)V", "protected static")]
	public static void save(Dova.JDK.java.io.ObjectOutputStream arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.EventListener arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDropEvent;)V", "public")]
	public void dragDropEnd(Dova.JDK.java.awt.dnd.DragSourceDropEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public")]
	public void dragMouseMoved(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener removeInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/EventListener;Ljava/util/EventListener;)Ljava/util/EventListener;", "protected static")]
	public static Dova.JDK.java.util.EventListener addInternal(Dova.JDK.java.util.EventListener arg0, Dova.JDK.java.util.EventListener arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.EventListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public")]
	public void dragEnter(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public")]
	public void dragOver(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceEvent;)V", "public")]
	public void dragExit(Dova.JDK.java.awt.dnd.DragSourceEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/dnd/DragSourceDragEvent;)V", "public")]
	public void dropActionChanged(Dova.JDK.java.awt.dnd.DragSourceDragEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}
}
