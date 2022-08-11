/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.sjavac.comp;

[JniSignatureAttribute("Lcom/sun/tools/sjavac/comp/PubapiVisitor;", "public")]
public partial class PubapiVisitor
	: Dova.JDK.javax.lang.model.util.ElementScanner14
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PubapiVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/sjavac/comp/PubapiVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "collectedApi", "Lcom/sun/tools/sjavac/pubapi/PubApi;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymous", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCollectedPubApi", "()Lcom/sun/tools/sjavac/pubapi/PubApi;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVariable", "(Ljavax/lang/model/element/VariableElement;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVariable", "(Ljavax/lang/model/element/VariableElement;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNonPrivate", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParamTypes", "(Ljavax/lang/model/element/ExecutableElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescs", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encodeChar", "(I)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/pubapi/PubApi;", "private")]
	public Dova.JDK.com.sun.tools.sjavac.pubapi.PubApi collectedApi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.pubapi.PubApi>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PubapiVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PubapiVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/sjavac/comp/PubapiVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getTypeParameters(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitRecordComponent(Dova.JDK.javax.lang.model.element.RecordComponentElement arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitRecordComponent(Dova.JDK.javax.lang.model.element.RecordComponentElement arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "private")]
	public bool isAnonymous(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/sjavac/pubapi/PubApi;", "public")]
	public Dova.JDK.com.sun.tools.sjavac.pubapi.PubApi getCollectedPubApi()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.pubapi.PubApi>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitVariable(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitVariable(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool isNonPrivate(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getParamTypes(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List getTypeDescs(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String encodeChar(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
