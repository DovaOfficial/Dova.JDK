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

namespace Dova.JDK.jdk.dynalink.linker;

[JniSignatureAttribute("Ljdk/dynalink/linker/ConversionComparator;", "public abstract interface")]
public partial interface ConversionComparator
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConversionComparator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/ConversionComparator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareConversion", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public abstract")]
	Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison compareConversion(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static final")]
	public partial class Comparison
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Comparison()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/linker/ConversionComparator$Comparison;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDETERMINATE", "Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_1_BETTER", "Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_2_BETTER", "Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/dynalink/linker/ConversionComparator$Comparison;"));
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static final")]
		public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison INDETERMINATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static final")]
		public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison TYPE_1_BETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static final")]
		public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison TYPE_2_BETTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/dynalink/linker/ConversionComparator$Comparison;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Comparison(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Comparison(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/linker/ConversionComparator$Comparison;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static")]
		public static JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/dynalink/linker/ConversionComparator$Comparison;", "public static")]
		public static Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/dynalink/linker/ConversionComparator$Comparison;", "private static")]
		public static JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.dynalink.linker.ConversionComparator.Comparison>>(ret);
		}
	}
}
