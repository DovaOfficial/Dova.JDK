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

namespace Dova.JDK.javax.lang.model.type;

[JniSignatureAttribute("Ljavax/lang/model/type/ReferenceType;", "public abstract interface")]
public partial interface ReferenceType
	: IJavaObject
	, Dova.JDK.javax.lang.model.type.TypeMirror
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static ReferenceType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/type/ReferenceType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
