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

namespace Dova.JDK.com.sun.tools.javac.api;

[JniSignatureAttribute("Lcom/sun/tools/javac/api/JavacScope;", "public")]
public partial class JavacScope
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.tree.Scope
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavacScope()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/JavacScope;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIDATOR", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Lcom/sun/tools/javac/comp/Env;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/comp/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingClass", "()Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Ljavax/lang/model/element/ExecutableElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/api/JavacScope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalElements", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStarImportScope", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnv", "()Lcom/sun/tools/javac/comp/Env;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingScope_0", "()Lcom/sun/tools/javac/api/JavacScope;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingScope_1", "()Lcom/sun/source/tree/Scope;"));
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "private static final")]
	public static Dova.JDK.java.util.function.Predicate VALIDATOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/comp/Env;", "protected final")]
	public Dova.JDK.com.sun.tools.javac.comp.Env env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavacScope(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)V", "private")]
	public JavacScope(Dova.JDK.com.sun.tools.javac.comp.Env arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/JavacScope;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getEnclosingClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/ExecutableElement;", "public")]
	public Dova.JDK.javax.lang.model.element.ExecutableElement getEnclosingMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ExecutableElement>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/comp/Env;)Lcom/sun/tools/javac/api/JavacScope;", "static")]
	public static Dova.JDK.com.sun.tools.javac.api.JavacScope create(Dova.JDK.com.sun.tools.javac.comp.Env arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.JavacScope>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable getLocalElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStarImportScope()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/comp/Env;", "public")]
	public Dova.JDK.com.sun.tools.javac.comp.Env getEnv()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.comp.Env>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/api/JavacScope;", "public")]
	public Dova.JDK.com.sun.tools.javac.api.JavacScope getEnclosingScope_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.JavacScope>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/Scope;", "public volatile")]
	public Dova.JDK.com.sun.source.tree.Scope getEnclosingScope_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Scope>(ret);
	}
}
