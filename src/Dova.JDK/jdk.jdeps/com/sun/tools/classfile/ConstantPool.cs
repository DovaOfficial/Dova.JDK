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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool;", "public")]
public partial class ConstantPool
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstantPool()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Utf8", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Integer", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Float", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Long", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Double", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Class", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_String", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Fieldref", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Methodref", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_InterfaceMethodref", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_NameAndType", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_MethodHandle", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_MethodType", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Dynamic", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_InvokeDynamic", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Module", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONSTANT_Package", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "pool", "[Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantPool", "(Lcom/sun/tools/classfile/ClassReader;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ConstantPool", "([Lcom/sun/tools/classfile/ConstantPool$CPInfo;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get", "(I)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "get", "(II)Lcom/sun/tools/classfile/ConstantPool$CPInfo;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "entries", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPackageInfo", "(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClassInfo", "(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getUTF8Info", "(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameAndTypeInfo", "(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getUTF8Value", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getModuleInfo", "(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getUTF8Index", "(Ljava/lang/String;)I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Utf8_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Integer_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Float_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Long_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Double_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Class_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_String_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Fieldref_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Methodref_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_InterfaceMethodref_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_NameAndType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_MethodHandle_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_MethodType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Dynamic_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_InvokeDynamic_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Module_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTANT_Package_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "private")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo> pool_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstantPool(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
	public ConstantPool(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("([Lcom/sun/tools/classfile/ConstantPool$CPInfo;)V", "public")]
	public ConstantPool(JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo> arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo get(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("(II)Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "private")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo get(int arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable entries()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info getPackageInfo(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int byteLength()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info getClassInfo(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info getUTF8Info(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info getNameAndTypeInfo(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUTF8Value(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;", "public")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info getModuleInfo(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getUTF8Index(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CPInfo;", "public abstract static")]
	public partial class CPInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CPInfo()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CPInfo;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "cp", "Lcom/sun/tools/classfile/ConstantPool;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CPInfo", "()V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CPInfo", "(Lcom/sun/tools/classfile/ConstantPool;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool;", "protected final")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool cp_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CPInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public CPInfo() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;)V", "")]
		public CPInfo(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CPInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;", "public static")]
	public partial class CONSTANT_Class_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Class_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Class_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Class_info", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBaseName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDimensionCount", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Class_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Class_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
		public CONSTANT_Class_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getBaseName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getDimensionCount()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;", "public static")]
	public partial class CONSTANT_Double_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Double_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "D"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Double_info", "(Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Double_info", "(D)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("D", "public final")]
		public double value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Double_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Double_info(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(D)V", "public")]
		public CONSTANT_Double_info(double arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;", "public static")]
	public partial class CONSTANT_Fieldref_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Fieldref_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Fieldref_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Fieldref_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Fieldref_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Fieldref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_Fieldref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;", "public static")]
	public partial class CONSTANT_Float_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Float_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "F"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Float_info", "(Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Float_info", "(F)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("F", "public final")]
		public float value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Float_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Float_info(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(F)V", "public")]
		public CONSTANT_Float_info(float arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;", "public static")]
	public partial class CONSTANT_Integer_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Integer_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Integer_info", "(Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Integer_info", "(I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Integer_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Integer_info(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public CONSTANT_Integer_info(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;", "public static")]
	public partial class CONSTANT_InterfaceMethodref_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_InterfaceMethodref_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_InterfaceMethodref_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_InterfaceMethodref_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_InterfaceMethodref_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_InterfaceMethodref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_InterfaceMethodref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;", "public static")]
	public partial class CONSTANT_InvokeDynamic_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_InvokeDynamic_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bootstrap_method_attr_index", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_and_type_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_InvokeDynamic_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_InvokeDynamic_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameAndTypeInfo", "()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int bootstrap_method_attr_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_and_type_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_InvokeDynamic_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_InvokeDynamic_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_InvokeDynamic_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info getNameAndTypeInfo()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;", "public static")]
	public partial class CONSTANT_Dynamic_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Dynamic_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "bootstrap_method_attr_index", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_and_type_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Dynamic_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Dynamic_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameAndTypeInfo", "()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int bootstrap_method_attr_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_and_type_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Dynamic_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Dynamic_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_Dynamic_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info getNameAndTypeInfo()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;", "public static")]
	public partial class CONSTANT_Long_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Long_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Long_info", "(Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Long_info", "(J)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "size", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("J", "public final")]
		public long value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Long_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Long_info(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(J)V", "public")]
		public CONSTANT_Long_info(long arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;", "public static")]
	public partial class CONSTANT_MethodHandle_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_MethodHandle_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reference_kind", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "reference_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_MethodHandle_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_MethodHandle_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ConstantPool$RefKind;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCPRefInfo", "()Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public final")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind reference_kind_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "public final")]
		public int reference_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_MethodHandle_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_MethodHandle_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ConstantPool$RefKind;I)V", "public")]
		public CONSTANT_MethodHandle_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo getCPRefInfo()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;", "public static")]
	public partial class CONSTANT_MethodType_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_MethodType_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "descriptor_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_MethodType_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_MethodType_info", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int descriptor_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_MethodType_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_MethodType_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
		public CONSTANT_MethodType_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getType()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;", "public static")]
	public partial class CONSTANT_Methodref_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Methodref_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Methodref_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Methodref_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Methodref_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Methodref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_Methodref_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;", "public static")]
	public partial class CONSTANT_Module_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Module_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Module_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Module_info", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Module_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Module_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
		public CONSTANT_Module_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;", "public static")]
	public partial class CONSTANT_NameAndType_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_NameAndType_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_index", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_NameAndType_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_NameAndType_info", "(Lcom/sun/tools/classfile/ConstantPool;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getType", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int type_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_NameAndType_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_NameAndType_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;II)V", "public")]
		public CONSTANT_NameAndType_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getType()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;", "public static")]
	public partial class CONSTANT_Package_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Package_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Package_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Package_info", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Package_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Package_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
		public CONSTANT_Package_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;", "public static")]
	public partial class CONSTANT_String_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_String_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "string_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_String_info", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_String_info", "(Lcom/sun/tools/classfile/ConstantPool;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int string_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_String_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_String_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;I)V", "public")]
		public CONSTANT_String_info(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;", "public static")]
	public partial class CONSTANT_Utf8_info
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CONSTANT_Utf8_info()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Utf8_info", "(Lcom/sun/tools/classfile/ClassReader;)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CONSTANT_Utf8_info", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isPrintableAscii", "(Ljava/lang/String;)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CONSTANT_Utf8_info(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassReader;)V", "")]
		public CONSTANT_Utf8_info(Dova.JDK.com.sun.tools.classfile.ClassReader arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public CONSTANT_Utf8_info(Dova.JDK.java.lang.String arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$Visitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
		public static bool isPrintableAscii(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$InvalidEntry;", "public static")]
	public partial class InvalidEntry
		: Dova.JDK.com.sun.tools.classfile.ConstantPoolException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvalidEntry()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$InvalidEntry;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "tag", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InvalidEntry", "(II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int tag_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvalidEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(II)V", "")]
		public InvalidEntry(int arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$InvalidEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getMessage()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$InvalidIndex;", "public static")]
	public partial class InvalidIndex
		: Dova.JDK.com.sun.tools.classfile.ConstantPoolException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvalidIndex()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$InvalidIndex;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "InvalidIndex", "(I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvalidIndex(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public InvalidIndex(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$InvalidIndex;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getMessage()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$UnexpectedEntry;", "public static")]
	public partial class UnexpectedEntry
		: Dova.JDK.com.sun.tools.classfile.ConstantPoolException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnexpectedEntry()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$UnexpectedEntry;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expected_tag", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "found_tag", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnexpectedEntry", "(III)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int expected_tag_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int found_tag_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UnexpectedEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(III)V", "")]
		public UnexpectedEntry(int arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$UnexpectedEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getMessage()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$EntryNotFound;", "public static")]
	public partial class EntryNotFound
		: Dova.JDK.com.sun.tools.classfile.ConstantPoolException
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EntryNotFound()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$EntryNotFound;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "value", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "EntryNotFound", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMessage", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public final")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EntryNotFound(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
		public EntryNotFound(Dova.JDK.java.lang.Object arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$EntryNotFound;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getMessage()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;", "public abstract static")]
	public partial class CPRefInfo
		: Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CPRefInfo()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "tag", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "class_index", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "name_and_type_index", "I"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CPRefInfo", "(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;I)V"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "CPRefInfo", "(Lcom/sun/tools/classfile/ConstantPool;III)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClassName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "byteLength", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTag", "()I"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getClassInfo", "()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNameAndTypeInfo", "()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int tag_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int class_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "public final")]
		public int name_and_type_index_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CPRefInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/ClassReader;I)V", "protected")]
		public CPRefInfo(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, Dova.JDK.com.sun.tools.classfile.ClassReader arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool;III)V", "protected")]
		public CPRefInfo(Dova.JDK.com.sun.tools.classfile.ConstantPool arg0, int arg1, int arg2, int arg3) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getClassName()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int byteLength()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getTag()
		{
			var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info getClassInfo()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;", "public")]
		public Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info getNameAndTypeInfo()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$Visitor;", "public abstract static interface")]
	public partial interface Visitor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$Visitor;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
	public partial class RefKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RefKind()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/tools/classfile/ConstantPool$RefKind;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_getField", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_getStatic", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_putField", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_putStatic", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_invokeVirtual", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_invokeStatic", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_invokeSpecial", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_newInvokeSpecial", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REF_invokeInterface", "Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "tag", "I"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RefKind", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getRefkind", "(I)Lcom/sun/tools/classfile/ConstantPool$RefKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_getField_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_getStatic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_putField_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_putStatic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_invokeVirtual_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_invokeStatic_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_invokeSpecial_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_newInvokeSpecial_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind REF_invokeInterface_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "public final")]
		public int tag_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/ConstantPool$RefKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RefKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public RefKind(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ConstantPool$RefKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/ConstantPool$RefKind;", "public static")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/ConstantPool$RefKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/ConstantPool$RefKind;", "static")]
		public static Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind getRefkind(int arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool.RefKind>(ret);
		}
	}
}
