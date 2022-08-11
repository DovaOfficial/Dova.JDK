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

namespace Dova.JDK.jdk.jfr.@internal.jfc.model;

[JniSignatureAttribute("Ljdk/jfr/internal/jfc/model/XmlCondition;", "final")]
public partial class XmlCondition
	: Dova.JDK.jdk.jfr.@internal.jfc.model.XmlExpression
	, Dova.JDK.jdk.jfr.@internal.jfc.model.ControlElement
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XmlCondition()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/jfc/model/XmlCondition;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attributes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "evaluate", "()Ljdk/jfr/internal/jfc/model/Result;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateChildConstraints", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrueValue", "()Ljdk/jfr/internal/jfc/model/Result;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFalseValue", "()Ljdk/jfr/internal/jfc/model/Result;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XmlCondition(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XmlCondition() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/jfc/model/XmlCondition;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List attributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/jfc/model/Result;", "protected")]
	public Dova.JDK.jdk.jfr.@internal.jfc.model.Result evaluate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.jfc.model.Result>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void validateChildConstraints()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/jfc/model/Result;", "public")]
	public Dova.JDK.jdk.jfr.@internal.jfc.model.Result getTrueValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.jfc.model.Result>(ret);
	}

	[JniSignatureAttribute("()Ljdk/jfr/internal/jfc/model/Result;", "public")]
	public Dova.JDK.jdk.jfr.@internal.jfc.model.Result getFalseValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.jfc.model.Result>(ret);
	}
}
