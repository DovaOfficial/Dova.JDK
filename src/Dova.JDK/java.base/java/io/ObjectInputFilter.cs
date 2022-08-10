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

namespace Dova.JDK.java.io;

[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "public abstract interface")]
public partial interface ObjectInputFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjectInputFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "merge", "(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "allowFilter", "(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;)Ljava/io/ObjectInputFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "rejectFilter", "(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;)Ljava/io/ObjectInputFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "rejectUndecidedClass", "(Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;", "public static")]
	static Dova.JDK.java.io.ObjectInputFilter merge(Dova.JDK.java.io.ObjectInputFilter arg0, Dova.JDK.java.io.ObjectInputFilter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;)Ljava/io/ObjectInputFilter;", "public static")]
	static Dova.JDK.java.io.ObjectInputFilter allowFilter(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.java.io.ObjectInputFilter.Status arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;)Ljava/io/ObjectInputFilter;", "public static")]
	static Dova.JDK.java.io.ObjectInputFilter rejectFilter(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.java.io.ObjectInputFilter.Status arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;", "public static")]
	static Dova.JDK.java.io.ObjectInputFilter rejectUndecidedClass(Dova.JDK.java.io.ObjectInputFilter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "public abstract")]
	Dova.JDK.java.io.ObjectInputFilter.Status checkInput(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
	}

	[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config;", "public static final")]
	public partial class Config
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Config()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialFilterLock", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERIAL_FILTER_PROPNAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SERIAL_FILTER_FACTORY_PROPNAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialFilter", "Ljava/io/ObjectInputFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "invalidFilterMessage", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialFilterFactory", "Ljava/util/function/BinaryOperator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "invalidFactoryMessage", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "filterFactoryNoReplace", "Ljava/util/concurrent/atomic/AtomicBoolean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "configLog", "Ljava/lang/System$Logger;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Config", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createFilter2", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "invalidFilterFactoryMessage", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createFilter", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "traceFilter", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setSerialFilter", "(Ljava/io/ObjectInputFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setSerialFilterFactory", "(Ljava/util/function/BinaryOperator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSerialFilterFactorySingleton", "()Ljava/util/function/BinaryOperator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSerialFilter", "()Ljava/io/ObjectInputFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getSerialFilterFactory", "()Ljava/util/function/BinaryOperator;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
		public static Dova.JDK.java.lang.Object serialFilterLock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String SERIAL_FILTER_PROPNAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String SERIAL_FILTER_FACTORY_PROPNAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private static volatile")]
		public static Dova.JDK.java.io.ObjectInputFilter serialFilter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String invalidFilterMessage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/BinaryOperator;", "private static volatile")]
		public static Dova.JDK.java.util.function.BinaryOperator serialFilterFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String invalidFactoryMessage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicBoolean;", "private static final")]
		public static Dova.JDK.java.util.concurrent.atomic.AtomicBoolean filterFactoryNoReplace_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicBoolean>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/System$Logger;", "private static final")]
		public static Dova.JDK.java.lang.System.Logger configLog_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.System.Logger>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Config(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Config() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/ObjectInputFilter;", "static")]
		public static Dova.JDK.java.io.ObjectInputFilter createFilter2(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "private static")]
		public static Dova.JDK.java.lang.String invalidFilterFactoryMessage()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/ObjectInputFilter;", "public static")]
		public static Dova.JDK.java.io.ObjectInputFilter createFilter(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private static transient")]
		public static void traceFilter(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;)V", "public static")]
		public static void setSerialFilter(Dova.JDK.java.io.ObjectInputFilter arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/function/BinaryOperator;)V", "public static")]
		public static void setSerialFilterFactory(Dova.JDK.java.util.function.BinaryOperator arg0)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/function/BinaryOperator;", "static")]
		public static Dova.JDK.java.util.function.BinaryOperator getSerialFilterFactorySingleton()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/ObjectInputFilter;", "public static")]
		public static Dova.JDK.java.io.ObjectInputFilter getSerialFilter()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/function/BinaryOperator;", "public static")]
		public static Dova.JDK.java.util.function.BinaryOperator getSerialFilterFactory()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.BinaryOperator>(ret);
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$Global;", "static final")]
		public partial class Global
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.io.ObjectInputFilter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Global()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$Global;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pattern", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filters", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxStreamBytes", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxDepth", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxReferences", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxArrayLength", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "checkComponentType", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Global", "(Ljava/lang/String;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createFilter", "(Ljava/lang/String;Z)Ljava/io/ObjectInputFilter;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parseLimit", "(Ljava/lang/String;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "matchesPackage", "(Ljava/lang/Class;Ljava/lang/String;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "parseValue", "(Ljava/lang/String;)J"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String pattern_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List filters_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("J", "private")]
			public long maxStreamBytes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("J", "private")]
			public long maxDepth_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("J", "private")]
			public long maxReferences_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
			}

			[JniSignatureAttribute("J", "private")]
			public long maxArrayLength_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool checkComponentType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Global(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Z)V", "private")]
			public Global(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$Global;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/io/ObjectInputFilter;", "static")]
			public static Dova.JDK.java.io.ObjectInputFilter createFilter(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
			public bool parseLimit(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Z", "private static")]
			public static bool matchesPackage(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "public")]
			public Dova.JDK.java.io.ObjectInputFilter.Status checkInput(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)J", "private static")]
			public static long parseValue(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$BuiltinFilterFactory;", "private static final")]
		public partial class BuiltinFilterFactory
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.function.BinaryOperator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BuiltinFilterFactory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$BuiltinFilterFactory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BuiltinFilterFactory", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "apply", "(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BuiltinFilterFactory(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public BuiltinFilterFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$BuiltinFilterFactory;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)Ljava/io/ObjectInputFilter;", "public")]
			public Dova.JDK.java.io.ObjectInputFilter apply(Dova.JDK.java.io.ObjectInputFilter arg0, Dova.JDK.java.io.ObjectInputFilter arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object apply(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter;", "private static")]
		public partial class RejectUndecidedFilter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.io.ObjectInputFilter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RejectUndecidedFilter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filter", "Ljava/io/ObjectInputFilter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RejectUndecidedFilter", "(Ljava/io/ObjectInputFilter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private final")]
			public Dova.JDK.java.io.ObjectInputFilter filter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RejectUndecidedFilter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;)V", "private")]
			public RejectUndecidedFilter(Dova.JDK.java.io.ObjectInputFilter arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "public")]
			public Dova.JDK.java.io.ObjectInputFilter.Status checkInput(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter$SerialInfo;", "static")]
			public partial class SerialInfo
				: Dova.JDK.java.lang.Object
				, Dova.JDK.java.io.ObjectInputFilter.FilterInfo
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static SerialInfo()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter$SerialInfo;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "base", "Ljava/io/ObjectInputFilter$FilterInfo;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "clazz", "Ljava/lang/Class;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SerialInfo", "(Ljava/io/ObjectInputFilter$FilterInfo;Ljava/lang/Class;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "depth", "()J"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arrayLength", "()J"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "references", "()J"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "serialClass", "()Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "streamBytes", "()J"));
				}

				[JniSignatureAttribute("Ljava/io/ObjectInputFilter$FilterInfo;", "private final")]
				public Dova.JDK.java.io.ObjectInputFilter.FilterInfo @base_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.FilterInfo>(ret);
					}
					set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
				public Dova.JDK.java.lang.Class clazz_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
					}
					set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public SerialInfo(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;Ljava/lang/Class;)V", "")]
				public SerialInfo(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$RejectUndecidedFilter$SerialInfo;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()J", "public")]
				public long depth()
				{
					var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
					return ret;
				}

				[JniSignatureAttribute("()J", "public")]
				public long arrayLength()
				{
					var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("()J", "public")]
				public long references()
				{
					var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class serialClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("()J", "public")]
				public long streamBytes()
				{
					var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$MergeFilter;", "private static")]
		public partial class MergeFilter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.io.ObjectInputFilter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MergeFilter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$MergeFilter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "first", "Ljava/io/ObjectInputFilter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "second", "Ljava/io/ObjectInputFilter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MergeFilter", "(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private final")]
			public Dova.JDK.java.io.ObjectInputFilter first_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private final")]
			public Dova.JDK.java.io.ObjectInputFilter second_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MergeFilter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;Ljava/io/ObjectInputFilter;)V", "")]
			public MergeFilter(Dova.JDK.java.io.ObjectInputFilter arg0, Dova.JDK.java.io.ObjectInputFilter arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$MergeFilter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "public")]
			public Dova.JDK.java.io.ObjectInputFilter.Status checkInput(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Config$PredicateFilter;", "private static")]
		public partial class PredicateFilter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.io.ObjectInputFilter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PredicateFilter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Config$PredicateFilter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "predicate", "Ljava/util/function/Predicate;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ifTrueStatus", "Ljava/io/ObjectInputFilter$Status;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ifFalseStatus", "Ljava/io/ObjectInputFilter$Status;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PredicateFilter", "(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;Ljava/io/ObjectInputFilter$Status;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;"));
			}

			[JniSignatureAttribute("Ljava/util/function/Predicate;", "private final")]
			public Dova.JDK.java.util.function.Predicate predicate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "private final")]
			public Dova.JDK.java.io.ObjectInputFilter.Status ifTrueStatus_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "private final")]
			public Dova.JDK.java.io.ObjectInputFilter.Status ifFalseStatus_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PredicateFilter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/function/Predicate;Ljava/io/ObjectInputFilter$Status;Ljava/io/ObjectInputFilter$Status;)V", "")]
			public PredicateFilter(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.java.io.ObjectInputFilter.Status arg1, Dova.JDK.java.io.ObjectInputFilter.Status arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Config$PredicateFilter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", "public")]
			public Dova.JDK.java.io.ObjectInputFilter.Status checkInput(Dova.JDK.java.io.ObjectInputFilter.FilterInfo arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "public static final")]
	public partial class Status
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Status()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$Status;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNDECIDED", "Ljava/io/ObjectInputFilter$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ALLOWED", "Ljava/io/ObjectInputFilter$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REJECTED", "Ljava/io/ObjectInputFilter$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/io/ObjectInputFilter$Status;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Status", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/io/ObjectInputFilter$Status;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter$Status;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/io/ObjectInputFilter$Status;"));
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "public static final")]
		public static Dova.JDK.java.io.ObjectInputFilter.Status UNDECIDED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "public static final")]
		public static Dova.JDK.java.io.ObjectInputFilter.Status ALLOWED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/io/ObjectInputFilter$Status;", "public static final")]
		public static Dova.JDK.java.io.ObjectInputFilter.Status REJECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/io/ObjectInputFilter$Status;", "private static final")]
		public static JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Status(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Status(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/io/ObjectInputFilter$Status;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/io/ObjectInputFilter$Status;", "public static")]
		public static JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/ObjectInputFilter$Status;", "public static")]
		public static Dova.JDK.java.io.ObjectInputFilter.Status valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter.Status>(ret);
		}

		[JniSignatureAttribute("()[Ljava/io/ObjectInputFilter$Status;", "private static")]
		public static JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.io.ObjectInputFilter.Status>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/io/ObjectInputFilter$FilterInfo;", "public abstract static interface")]
	public partial interface FilterInfo
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FilterInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/io/ObjectInputFilter$FilterInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "depth", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "arrayLength", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "references", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "serialClass", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "streamBytes", "()J"));
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long depth()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long arrayLength()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long references()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public abstract")]
		Dova.JDK.java.lang.Class serialClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()J", "public abstract")]
		long streamBytes()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}
}
