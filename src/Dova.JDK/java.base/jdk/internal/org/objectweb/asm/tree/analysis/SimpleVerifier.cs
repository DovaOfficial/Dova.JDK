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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/SimpleVerifier;", "public")]
public partial class SimpleVerifier
	: Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicVerifier
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleVerifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/analysis/SimpleVerifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentClass", "Ljdk/internal/org/objectweb/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentSuperClass", "Ljdk/internal/org/objectweb/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentClassInterfaces", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInterface", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loader", "Ljava/lang/ClassLoader;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Ljava/util/List;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Ljava/util/List;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClass", "(Ljdk/internal/org/objectweb/asm/Type;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "(Ljdk/internal/org/objectweb/asm/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_0", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_1", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setClassLoader", "(Ljava/lang/ClassLoader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newArrayValue", "(Ljdk/internal/org/objectweb/asm/Type;I)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArrayValue", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementValue", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubTypeOf", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Type;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Type currentClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Type;", "private final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Type currentSuperClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List currentClassInterfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isInterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader loader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleVerifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Ljava/util/List;Z)V", "protected")]
	public SimpleVerifier(int arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg2, Dova.JDK.java.util.List arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Ljava/util/List;Z)V", "public")]
	public SimpleVerifier(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1, Dova.JDK.java.util.List arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;Z)V", "public")]
	public SimpleVerifier(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SimpleVerifier() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/analysis/SimpleVerifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljava/lang/Class;", "protected")]
	public Dova.JDK.java.lang.Class getClass(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;Ljdk/internal/org/objectweb/asm/Type;)Z", "protected")]
	public bool isAssignableFrom(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Z", "protected")]
	public bool isInterface(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue merge(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value merge(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue newValue_0(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value newValue_1(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public")]
	public void setClassLoader(Dova.JDK.java.lang.ClassLoader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;I)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "private")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue newArrayValue(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/Type;", "protected")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Type getSuperClass(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z", "protected")]
	public bool isArrayValue(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "protected")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue getElementValue(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z", "protected")]
	public bool isSubTypeOf(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}
}
