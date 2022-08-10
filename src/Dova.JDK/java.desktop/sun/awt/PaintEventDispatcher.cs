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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/PaintEventDispatcher;", "public")]
public partial class PaintEventDispatcher
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PaintEventDispatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/PaintEventDispatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "dispatcher", "Lsun/awt/PaintEventDispatcher;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PaintEventDispatcher", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createPaintEvent", "(Ljava/awt/Component;IIII)Ljava/awt/event/PaintEvent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "queueSurfaceDataReplacing", "(Ljava/awt/Component;Ljava/lang/Runnable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shouldDoNativeBackgroundErase", "(Ljava/awt/Component;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPaintEventDispatcher", "()Lsun/awt/PaintEventDispatcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setPaintEventDispatcher", "(Lsun/awt/PaintEventDispatcher;)V"));
	}

	[JniSignatureAttribute("Lsun/awt/PaintEventDispatcher;", "private static")]
	public static Dova.JDK.sun.awt.PaintEventDispatcher dispatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.PaintEventDispatcher>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PaintEventDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PaintEventDispatcher() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/PaintEventDispatcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Component;IIII)Ljava/awt/event/PaintEvent;", "public")]
	public Dova.JDK.java.awt.@event.PaintEvent createPaintEvent(Dova.JDK.java.awt.Component arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.PaintEvent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/lang/Runnable;)Z", "public")]
	public bool queueSurfaceDataReplacing(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public")]
	public bool shouldDoNativeBackgroundErase(Dova.JDK.java.awt.Component arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/awt/PaintEventDispatcher;", "public static")]
	public static Dova.JDK.sun.awt.PaintEventDispatcher getPaintEventDispatcher()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.PaintEventDispatcher>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/PaintEventDispatcher;)V", "public static")]
	public static void setPaintEventDispatcher(Dova.JDK.sun.awt.PaintEventDispatcher arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}
}
