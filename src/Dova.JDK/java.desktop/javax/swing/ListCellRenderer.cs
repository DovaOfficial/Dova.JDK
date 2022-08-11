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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/ListCellRenderer;", "public abstract interface")]
public partial interface ListCellRenderer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ListCellRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/ListCellRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListCellRendererComponent", "(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;"));
	}

	[JniSignatureAttribute("(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;", "public abstract")]
	Dova.JDK.java.awt.Component getListCellRendererComponent(Dova.JDK.javax.swing.JList arg0, Dova.JDK.java.lang.Object arg1, int arg2, bool arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}
}
