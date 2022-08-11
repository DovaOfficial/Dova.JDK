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

namespace Dova.JDK.jdk.@internal.reflect;

[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool;", "public")]
public partial class ConstantPool
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstantPool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/ConstantPool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize0", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassAt0", "(Ljava/lang/Object;I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassAtIfLoaded0", "(Ljava/lang/Object;I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassRefIndexAt0", "(Ljava/lang/Object;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodAt0", "(Ljava/lang/Object;I)Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodAtIfLoaded0", "(Ljava/lang/Object;I)Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAt0", "(Ljava/lang/Object;I)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAtIfLoaded0", "(Ljava/lang/Object;I)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberRefInfoAt0", "(Ljava/lang/Object;I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameAndTypeRefIndexAt0", "(Ljava/lang/Object;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameAndTypeRefInfoAt0", "(Ljava/lang/Object;I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntAt0", "(Ljava/lang/Object;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongAt0", "(Ljava/lang/Object;I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatAt0", "(Ljava/lang/Object;I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleAt0", "(Ljava/lang/Object;I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringAt0", "(Ljava/lang/Object;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUTF8At0", "(Ljava/lang/Object;I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagAt0", "(Ljava/lang/Object;I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassAt", "(I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassAtIfLoaded", "(I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassRefIndexAt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodAt", "(I)Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodAtIfLoaded", "(I)Ljava/lang/reflect/Member;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAt", "(I)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAtIfLoaded", "(I)Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberRefInfoAt", "(I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameAndTypeRefIndexAt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameAndTypeRefInfoAt", "(I)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntAt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongAt", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatAt", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleAt", "(I)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringAt", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUTF8At", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagAt", "(I)Ljdk/internal/reflect/ConstantPool$Tag;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstantPool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ConstantPool() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/reflect/ConstantPool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "private native")]
	public int getSize0(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/Class;", "private native")]
	public Dova.JDK.java.lang.Class getClassAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/Class;", "private native")]
	public Dova.JDK.java.lang.Class getClassAtIfLoaded0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)I", "private native")]
	public int getClassRefIndexAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/reflect/Member;", "private native")]
	public Dova.JDK.java.lang.reflect.Member getMethodAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Member>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/reflect/Member;", "private native")]
	public Dova.JDK.java.lang.reflect.Member getMethodAtIfLoaded0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Member>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/reflect/Field;", "private native")]
	public Dova.JDK.java.lang.reflect.Field getFieldAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/reflect/Field;", "private native")]
	public Dova.JDK.java.lang.reflect.Field getFieldAtIfLoaded0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)[Ljava/lang/String;", "private native")]
	public JavaArray<Dova.JDK.java.lang.String> getMemberRefInfoAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)I", "private native")]
	public int getNameAndTypeRefIndexAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)[Ljava/lang/String;", "private native")]
	public JavaArray<Dova.JDK.java.lang.String> getNameAndTypeRefInfoAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)I", "private native")]
	public int getIntAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)J", "private native")]
	public long getLongAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)F", "private native")]
	public float getFloatAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)D", "private native")]
	public double getDoubleAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/String;", "private native")]
	public Dova.JDK.java.lang.String getStringAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)Ljava/lang/String;", "private native")]
	public Dova.JDK.java.lang.String getUTF8At0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)B", "private native")]
	public byte getTagAt0(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getClassAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getClassAtIfLoaded(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getClassRefIndexAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/reflect/Member;", "public")]
	public Dova.JDK.java.lang.reflect.Member getMethodAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Member>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/reflect/Member;", "public")]
	public Dova.JDK.java.lang.reflect.Member getMethodAtIfLoaded(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Member>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field getFieldAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field getFieldAtIfLoaded(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("(I)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getMemberRefInfoAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getNameAndTypeRefIndexAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getNameAndTypeRefInfoAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getIntAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public")]
	public long getLongAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getFloatAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)D", "public")]
	public double getDoubleAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getStringAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUTF8At(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/reflect/ConstantPool$Tag;", "public")]
	public Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag getTagAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
	public partial class Tag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/reflect/ConstantPool$Tag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UTF8", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELDREF", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODREF", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACEMETHODREF", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMEANDTYPE", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODHANDLE", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODTYPE", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKEDYNAMIC", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID", "Ljdk/internal/reflect/ConstantPool$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagCode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/reflect/ConstantPool$Tag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/reflect/ConstantPool$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/reflect/ConstantPool$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(B)Ljdk/internal/reflect/ConstantPool$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/reflect/ConstantPool$Tag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag UTF8_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag FIELDREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag METHODREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag INTERFACEMETHODREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag NAMEANDTYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag METHODHANDLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag METHODTYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag INVOKEDYNAMIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/reflect/ConstantPool$Tag;", "public static final")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag INVALID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int tagCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/reflect/ConstantPool$Tag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public Tag(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/reflect/ConstantPool$Tag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/reflect/ConstantPool$Tag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/reflect/ConstantPool$Tag;", "public static")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
		}

		[JniSignatureAttribute("(B)Ljdk/internal/reflect/ConstantPool$Tag;", "private static")]
		public static Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag valueOf(byte arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/reflect/ConstantPool$Tag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.reflect.ConstantPool.Tag>>(ret);
		}
	}
}
