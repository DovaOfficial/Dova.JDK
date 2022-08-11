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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/InstructionFinder;", "public")]
public partial class InstructionFinder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InstructionFinder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/util/InstructionFinder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_OPCODES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "map", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "il", "Lcom/sun/org/apache/bcel/internal/generic/InstructionList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ilString", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handles", "[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionList;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "search", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstructionList", "()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatch", "(II)[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "precompile", "(SSS)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reread", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compilePattern", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeChar", "(S)C"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int OFFSET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int NO_OPCODES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/InstructionList;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList il_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String ilString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> handles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InstructionFinder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionList;)V", "public")]
	public InstructionFinder(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/util/InstructionFinder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;)Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator search(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.util.InstructionFinder.CodeConstraint arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator search(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator search(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;)Ljava/util/Iterator;", "public final")]
	public Dova.JDK.java.util.Iterator search(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.util.InstructionFinder.CodeConstraint arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String mapName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList getInstructionList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList>(ret);
	}

	[JniSignatureAttribute("(II)[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> getMatch(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>>(ret);
	}

	[JniSignatureAttribute("(SSS)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String precompile(short arg0, short arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void reread()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String compilePattern(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(S)C", "private static")]
	public static char makeChar(short arg0)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;", "public abstract static interface")]
	public partial interface CodeConstraint
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CodeConstraint()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/util/InstructionFinder$CodeConstraint;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCode", "([Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z"));
		}

		[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z", "public abstract")]
		bool checkCode(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}
}
