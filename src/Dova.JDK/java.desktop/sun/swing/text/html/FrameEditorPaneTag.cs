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

namespace Dova.JDK.sun.swing.text.html;

[JniSignatureAttribute("Lsun/swing/text/html/FrameEditorPaneTag;", "public abstract interface")]
public partial interface FrameEditorPaneTag
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static FrameEditorPaneTag()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/text/html/FrameEditorPaneTag;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
