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

namespace Dova.JDK.javax.swing.table;

[JniSignatureAttribute("Ljavax/swing/table/TableCellRenderer;", "public abstract interface")]
public partial interface TableCellRenderer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TableCellRenderer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/table/TableCellRenderer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellRendererComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;"));
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;", "public abstract")]
	Dova.JDK.java.awt.Component getTableCellRendererComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}
}
