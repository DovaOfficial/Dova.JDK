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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.models;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;", "public abstract interface")]
public partial interface XSCMValidator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSCMValidator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/models/XSCMValidator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIRST_ERROR", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBSEQUENT_ERROR", "S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMinMaxBounds", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompactedForUPA", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkUniqueParticleAttribution", "(Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "oneTransition", "(Lcom/sun/org/apache/xerces/internal/xni/QName;[ILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "whatCanGoHere", "([I)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "occurenceInfo", "([I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTermName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startContentModel", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endContentModel", "([I)Z"));
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short FIRST_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("S", "public static final")]
	public static short SUBSEQUENT_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List checkMinMaxBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCompactedForUPA()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Z", "public abstract")]
	bool checkUniqueParticleAttribution(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/QName;[ILcom/sun/org/apache/xerces/internal/impl/xs/SubstitutionGroupHandler;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object oneTransition(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg0, JavaArray<int> arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SubstitutionGroupHandler arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([I)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List whatCanGoHere(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([I)[I", "public abstract")]
	JavaArray<int> occurenceInfo(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getTermName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[I", "public abstract")]
	JavaArray<int> startContentModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([I)Z", "public abstract")]
	bool endContentModel(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}
}
