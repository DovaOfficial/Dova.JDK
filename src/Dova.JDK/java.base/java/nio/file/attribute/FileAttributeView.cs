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

namespace Dova.JDK.java.nio.file.attribute;

[JniSignatureAttribute("Ljava/nio/file/attribute/FileAttributeView;", "public abstract interface")]
public partial interface FileAttributeView
	: IJavaObject
	, Dova.JDK.java.nio.file.attribute.AttributeView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static FileAttributeView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/attribute/FileAttributeView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
