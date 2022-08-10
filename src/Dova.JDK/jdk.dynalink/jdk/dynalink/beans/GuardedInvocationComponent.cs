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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
public partial class GuardedInvocationComponent
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GuardedInvocationComponent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/GuardedInvocationComponent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "guardedInvocation", "Ljdk/dynalink/linker/GuardedInvocation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "validator", "Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljdk/dynalink/linker/GuardedInvocation;Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljava/lang/invoke/MethodHandle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "GuardedInvocationComponent", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compose", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGuardedInvocation", "()Ljdk/dynalink/linker/GuardedInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "replaceInvocation", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "replaceInvocation", "(Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getValidatorClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getValidationType", "()Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
	}

	[JniSignatureAttribute("Ljdk/dynalink/linker/GuardedInvocation;", "private final")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation guardedInvocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;", "private final")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator validator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GuardedInvocationComponent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)V", "private")]
	public GuardedInvocationComponent(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)V", "private")]
	public GuardedInvocationComponent(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/GuardedInvocation;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
	public GuardedInvocationComponent(Dova.JDK.jdk.dynalink.linker.GuardedInvocation arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)V", "")]
	public GuardedInvocationComponent(Dova.JDK.java.lang.invoke.MethodHandle arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
	public GuardedInvocationComponent(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
	public GuardedInvocationComponent(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/GuardedInvocationComponent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent compose(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("()Ljdk/dynalink/linker/GuardedInvocation;", "")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent replaceInvocation(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent replaceInvocation(Dova.JDK.java.lang.invoke.MethodHandle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "")]
	public Dova.JDK.java.lang.Class getValidatorClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType getValidationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "static final")]
	public partial class ValidationType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValidationType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NONE", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCE_OF", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXACT_CLASS", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IS_ARRAY", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ValidationType", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static final")]
		public static Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static final")]
		public static Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType INSTANCE_OF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static final")]
		public static Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType EXACT_CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static final")]
		public static Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType IS_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValidationType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ValidationType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "public static")]
		public static Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;", "private static")]
	public partial class Validator
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Validator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "validatorClass", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "validationType", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Validator", "(Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAssignableFrom", "(Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "compose", "(Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "final")]
		public Dova.JDK.java.lang.Class validatorClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "final")]
		public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType validationType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Validator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
		public Validator(Dova.JDK.java.lang.Class arg0, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)Z", "private")]
		public bool isAssignableFrom(Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;)Ljdk/dynalink/beans/GuardedInvocationComponent$Validator;", "")]
		public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator compose(Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.Validator>(ret);
		}
	}
}
