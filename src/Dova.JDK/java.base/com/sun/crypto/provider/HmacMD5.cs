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

namespace Dova.JDK.com.sun.crypto.provider;

[JniSignatureAttribute("Lcom/sun/crypto/provider/HmacMD5;", "public final")]
public partial class HmacMD5
	: Dova.JDK.com.sun.crypto.provider.HmacCore
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HmacMD5()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/crypto/provider/HmacMD5;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HmacMD5", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HmacMD5(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HmacMD5() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/crypto/provider/HmacMD5;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
