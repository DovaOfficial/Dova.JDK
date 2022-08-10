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

namespace Dova.JDK.javax.swing.@event;

[JniSignatureAttribute("Ljavax/swing/event/MenuDragMouseEvent;", "public")]
public partial class MenuDragMouseEvent
	: Dova.JDK.java.awt.@event.MouseEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MenuDragMouseEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/MenuDragMouseEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "path", "[Ljavax/swing/MenuElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "manager", "Ljavax/swing/MenuSelectionManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MenuDragMouseEvent", "(Ljava/awt/Component;IJIIIIZ[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MenuDragMouseEvent", "(Ljava/awt/Component;IJIIIIIIZ[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPath", "()[Ljavax/swing/MenuElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMenuSelectionManager", "()Ljavax/swing/MenuSelectionManager;"));
	}

	[JniSignatureAttribute("[Ljavax/swing/MenuElement;", "private")]
	public JavaArray<Dova.JDK.javax.swing.MenuElement> path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.MenuElement>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/MenuSelectionManager;", "private")]
	public Dova.JDK.javax.swing.MenuSelectionManager manager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.MenuSelectionManager>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MenuDragMouseEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IJIIIIZ[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V", "public")]
	public MenuDragMouseEvent(Dova.JDK.java.awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, JavaArray<Dova.JDK.javax.swing.MenuElement> arg8, Dova.JDK.javax.swing.MenuSelectionManager arg9) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/Component;IJIIIIIIZ[Ljavax/swing/MenuElement;Ljavax/swing/MenuSelectionManager;)V", "public")]
	public MenuDragMouseEvent(Dova.JDK.java.awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, JavaArray<Dova.JDK.javax.swing.MenuElement> arg10, Dova.JDK.javax.swing.MenuSelectionManager arg11) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/event/MenuDragMouseEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljavax/swing/MenuElement;", "public")]
	public JavaArray<Dova.JDK.javax.swing.MenuElement> getPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.MenuElement>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/MenuSelectionManager;", "public")]
	public Dova.JDK.javax.swing.MenuSelectionManager getMenuSelectionManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.MenuSelectionManager>(ret);
	}
}
