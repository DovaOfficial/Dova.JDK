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

namespace Dova.JDK.sun.reflect.generics.tree;

[JniSignatureAttribute("Lsun/reflect/generics/tree/TypeSignature;", "public abstract interface")]
public partial interface TypeSignature
	: IJavaObject
	, Dova.JDK.sun.reflect.generics.tree.ReturnType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static TypeSignature()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/reflect/generics/tree/TypeSignature;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
