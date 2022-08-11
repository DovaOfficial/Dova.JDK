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

namespace Dova.JDK.javax.swing.@event;

[JniSignatureAttribute("Ljavax/swing/event/MouseInputListener;", "public abstract interface")]
public partial interface MouseInputListener
	: IJavaObject
	, Dova.JDK.java.awt.@event.MouseListener
	, Dova.JDK.java.awt.@event.MouseMotionListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static MouseInputListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/event/MouseInputListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
