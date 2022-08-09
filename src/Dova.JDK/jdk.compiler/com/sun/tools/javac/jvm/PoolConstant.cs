/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.jvm;

[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant;", "public abstract interface")]
public partial interface PoolConstant
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PoolConstant()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolTag", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolKey", "(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int poolTag()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;", "public")]
	Dova.JDK.java.lang.Object poolKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$NameAndType;", "public static final")]
	public partial class NameAndType
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NameAndType()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant$NameAndType;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NameAndType", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolKey", "(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "final")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "final")]
		public Dova.JDK.com.sun.tools.javac.code.Type type_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NameAndType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Type;)V", "")]
		public NameAndType(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Type arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/PoolConstant$NameAndType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int poolTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object poolKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic;", "public abstract static interface")]
	public partial interface Dynamic
		: IJavaObject
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dynamic()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bootstrapMethod", "()Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolKey", "(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dynamicType", "()Lcom/sun/tools/javac/jvm/PoolConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "staticArgs", "()[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "bsmKey", "(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic$BsmKey;"));
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant bootstrapMethod()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;", "public")]
		Dova.JDK.java.lang.Object poolKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/jvm/PoolConstant;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.jvm.PoolConstant dynamicType()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public abstract")]
		JavaArray<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant> staticArgs()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic$BsmKey;", "public")]
		Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.Dynamic.BsmKey bsmKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.Dynamic.BsmKey>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic$BsmKey;", "public static")]
		public partial class BsmKey
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BsmKey()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic$BsmKey;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bsm", "Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "staticArgs", "[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bsmKey", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "staticArgKeys", "Lcom/sun/tools/javac/util/List;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BsmKey", "(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public final")]
			public Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant bsm_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public final")]
			public JavaArray<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant> staticArgs_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object bsmKey_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "private final")]
			public Dova.JDK.com.sun.tools.javac.util.List staticArgKeys_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BsmKey(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;[Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;)V", "private")]
			public BsmKey(Dova.JDK.com.sun.tools.javac.code.Types arg0, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant arg1, JavaArray<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant> arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/PoolConstant$Dynamic$BsmKey;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public abstract static interface")]
	public partial interface LoadableConstant
		: IJavaObject
		, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LoadableConstant()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "Long", "(J)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "Float", "(F)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "Double", "(D)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "Int", "(I)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "String", "(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;"));
		}

		[JniSignatureAttribute("(J)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public static")]
		static Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant Long(long arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("(F)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public static")]
		static Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant Float(float arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("(D)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public static")]
		static Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant Double(double arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public static")]
		static Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant Int(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant;", "public static")]
		static Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant String(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant$BasicConstant;", "public static")]
		public partial class BasicConstant
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant.LoadableConstant
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BasicConstant()
			{
				ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant$BasicConstant;");
				ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "tag", "I"));
				FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "data", "Ljava/lang/Object;"));
				ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BasicConstant", "(ILjava/lang/Object;)V"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolTag", "()I"));
				MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "poolKey", "(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("I", "")]
			public int tag_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "")]
			public Dova.JDK.java.lang.Object data_Property
			{
				get
				{
					var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BasicConstant(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(ILjava/lang/Object;)V", "private")]
			public BasicConstant(int arg0, Dova.JDK.java.lang.Object arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/jvm/PoolConstant$LoadableConstant$BasicConstant;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int poolTag()
			{
				var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object poolKey(Dova.JDK.com.sun.tools.javac.code.Types arg0)
			{
				var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}
}
