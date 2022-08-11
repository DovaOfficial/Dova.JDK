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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/ApplicableOverloadedMethods;", "")]
public partial class ApplicableOverloadedMethods
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ApplicableOverloadedMethods()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/ApplicableOverloadedMethods;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varArgs", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPLICABLE_BY_SUBTYPING", "Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPLICABLE_BY_METHOD_INVOCATION_CONVERSION", "Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPLICABLE_BY_VARIABLE_ARITY", "Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Ljava/lang/invoke/MethodType;Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findMaximallySpecificMethods", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List methods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool varArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;", "static final")]
	public static Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest APPLICABLE_BY_SUBTYPING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;", "static final")]
	public static Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest APPLICABLE_BY_METHOD_INVOCATION_CONVERSION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;", "static final")]
	public static Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest APPLICABLE_BY_VARIABLE_ARITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ApplicableOverloadedMethods(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/invoke/MethodType;Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;)V", "")]
	public ApplicableOverloadedMethods(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.invoke.MethodType arg1, Dova.JDK.jdk.dynalink.beans.ApplicableOverloadedMethods.ApplicabilityTest arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/ApplicableOverloadedMethods;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List getMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "")]
	public Dova.JDK.java.util.List findMaximallySpecificMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;", "abstract static")]
	public partial class ApplicabilityTest
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ApplicabilityTest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isApplicable", "(Ljava/lang/invoke/MethodType;Ljdk/dynalink/beans/SingleDynamicMethod;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ApplicabilityTest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ApplicabilityTest() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/ApplicableOverloadedMethods$ApplicabilityTest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;Ljdk/dynalink/beans/SingleDynamicMethod;)Z", "abstract")]
		public bool isApplicable(Dova.JDK.java.lang.invoke.MethodType arg0, Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}
}
