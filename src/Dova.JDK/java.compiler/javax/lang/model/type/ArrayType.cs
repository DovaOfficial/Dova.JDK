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

namespace Dova.JDK.javax.lang.model.type;

[JniSignatureAttribute("Ljavax/lang/model/type/ArrayType;", "public abstract interface")]
public partial interface ArrayType
	: IJavaObject
	, Dova.JDK.javax.lang.model.type.ReferenceType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArrayType()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/lang/model/type/ArrayType;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getComponentType", "()Ljavax/lang/model/type/TypeMirror;"));
	}

	[JniSignatureAttribute("()Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	Dova.JDK.javax.lang.model.type.TypeMirror getComponentType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}
}
