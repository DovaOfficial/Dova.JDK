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

namespace Dova.JDK.jdk.@internal.vm.annotation;

[JniSignatureAttribute("Ljdk/internal/vm/annotation/DontInline;", "public abstract interface")]
public partial interface DontInline
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static DontInline()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/vm/annotation/DontInline;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
