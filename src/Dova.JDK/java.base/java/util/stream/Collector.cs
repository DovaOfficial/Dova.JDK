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

namespace Dova.JDK.java.util.stream;

[JniSignatureAttribute("Ljava/util/stream/Collector;", "public abstract interface")]
public partial interface Collector
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Collector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Collector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "characteristics", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combiner", "()Ljava/util/function/BinaryOperator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supplier", "()Ljava/util/function/Supplier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accumulator", "()Ljava/util/function/BiConsumer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finisher", "()Ljava/util/function/Function;"));
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;Ljava/util/function/Function;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", "public static transient")]
	static Dova.JDK.java.util.stream.Collector of(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2, Dova.JDK.java.util.function.Function arg3, JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics> arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Supplier;Ljava/util/function/BiConsumer;Ljava/util/function/BinaryOperator;[Ljava/util/stream/Collector$Characteristics;)Ljava/util/stream/Collector;", "public static transient")]
	static Dova.JDK.java.util.stream.Collector of(Dova.JDK.java.util.function.Supplier arg0, Dova.JDK.java.util.function.BiConsumer arg1, Dova.JDK.java.util.function.BinaryOperator arg2, JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics> arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set characteristics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/BinaryOperator;", "public abstract")]
	Dova.JDK.java.util.function.BinaryOperator combiner()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/Supplier;", "public abstract")]
	Dova.JDK.java.util.function.Supplier supplier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Supplier>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/BiConsumer;", "public abstract")]
	Dova.JDK.java.util.function.BiConsumer accumulator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BiConsumer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/function/Function;", "public abstract")]
	Dova.JDK.java.util.function.Function finisher()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Function>(ret);
	}

	[JniSignatureAttribute("Ljava/util/stream/Collector$Characteristics;", "public static final")]
	public partial class Characteristics
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Characteristics()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/stream/Collector$Characteristics;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONCURRENT", "Ljava/util/stream/Collector$Characteristics;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNORDERED", "Ljava/util/stream/Collector$Characteristics;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTITY_FINISH", "Ljava/util/stream/Collector$Characteristics;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/util/stream/Collector$Characteristics;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/util/stream/Collector$Characteristics;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/util/stream/Collector$Characteristics;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/util/stream/Collector$Characteristics;"));
		}

		[JniSignatureAttribute("Ljava/util/stream/Collector$Characteristics;", "public static final")]
		public static Dova.JDK.java.util.stream.Collector.Characteristics CONCURRENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector.Characteristics>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Collector$Characteristics;", "public static final")]
		public static Dova.JDK.java.util.stream.Collector.Characteristics UNORDERED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector.Characteristics>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/stream/Collector$Characteristics;", "public static final")]
		public static Dova.JDK.java.util.stream.Collector.Characteristics IDENTITY_FINISH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector.Characteristics>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/util/stream/Collector$Characteristics;", "private static final")]
		public static JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Characteristics(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Characteristics(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/stream/Collector$Characteristics;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/util/stream/Collector$Characteristics;", "public static")]
		public static JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/stream/Collector$Characteristics;", "public static")]
		public static Dova.JDK.java.util.stream.Collector.Characteristics valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Collector.Characteristics>(ret);
		}

		[JniSignatureAttribute("()[Ljava/util/stream/Collector$Characteristics;", "private static")]
		public static JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.stream.Collector.Characteristics>>(ret);
		}
	}
}
