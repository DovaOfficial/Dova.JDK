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

namespace Dova.JDK.com.sun.org.apache.xml.@internal.security.signature;

[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/signature/MissingResourceFailureException;", "public")]
public partial class MissingResourceFailureException
	: Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.XMLSignatureException
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MissingResourceFailureException()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xml/internal/security/signature/MissingResourceFailureException;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "uninitializedReference", "Lcom/sun/org/apache/xml/internal/security/signature/Reference;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/String;Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;[Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;[Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MissingResourceFailureException", "(Ljava/lang/String;[Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReference", "()Lcom/sun/org/apache/xml/internal/security/signature/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setReference", "(Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/security/signature/Reference;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference uninitializedReference_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MissingResourceFailureException(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.Exception arg0, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Exception arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.Exception arg0, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.java.lang.Object> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Exception;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.lang.Exception arg2, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/signature/Reference;Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V", "public")]
	public MissingResourceFailureException(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[7], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xml/internal/security/signature/MissingResourceFailureException;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/security/signature/Reference;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference getReference()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/security/signature/Reference;)V", "public")]
	public void setReference(Dova.JDK.com.sun.org.apache.xml.@internal.security.signature.Reference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
