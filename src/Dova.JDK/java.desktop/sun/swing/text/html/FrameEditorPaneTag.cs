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

namespace Dova.JDK.sun.swing.text.html;

[JniSignatureAttribute("Lsun/swing/text/html/FrameEditorPaneTag;", "public abstract interface")]
public partial interface FrameEditorPaneTag
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static FrameEditorPaneTag()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/swing/text/html/FrameEditorPaneTag;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
	}
}
