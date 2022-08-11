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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/ClassFile;", "public")]
public partial class ClassFile
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassFile()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/ClassFile;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "magic", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minor_version", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "major_version", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constant_pool", "Lcom/sun/tools/classfile/ConstantPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "access_flags", "Lcom/sun/tools/classfile/AccessFlags;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this_class", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "super_class", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "[Lcom/sun/tools/classfile/Field;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "[Lcom/sun/tools/classfile/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributes", "Lcom/sun/tools/classfile/Attributes;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;Lcom/sun/tools/classfile/Attribute$Factory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIILcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/AccessFlags;II[I[Lcom/sun/tools/classfile/Field;[Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/Attributes;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/File;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/nio/file/Path;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/InputStream;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/nio/file/Path;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/InputStream;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/File;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttribute", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteLength", "([Lcom/sun/tools/classfile/Field;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteLength", "([I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteLength", "([Lcom/sun/tools/classfile/Method;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperclassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaceName", "(I)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "public final")]
	public int magic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int minor_version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int major_version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool;", "public final")]
	public Dova.JDK.com.sun.tools.classfile.ConstantPool constant_pool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/AccessFlags;", "public final")]
	public Dova.JDK.com.sun.tools.classfile.AccessFlags access_flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.AccessFlags>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int this_class_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int super_class_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("[I", "public final")]
	public JavaArray<int> interfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Field;", "public final")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.Field> fields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Field>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/tools/classfile/Method;", "public final")]
	public JavaArray<Dova.JDK.com.sun.tools.classfile.Method> methods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Method>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Attributes;", "public final")]
	public Dova.JDK.com.sun.tools.classfile.Attributes attributes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Attributes>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassFile(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Lcom/sun/tools/classfile/Attribute$Factory;)V", "")]
	public ClassFile(Dova.JDK.java.io.InputStream arg0, Dova.JDK.com.sun.tools.classfile.Attribute.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(IIILcom/sun/tools/classfile/ConstantPool;Lcom/sun/tools/classfile/AccessFlags;II[I[Lcom/sun/tools/classfile/Field;[Lcom/sun/tools/classfile/Method;Lcom/sun/tools/classfile/Attributes;)V", "public")]
	public ClassFile(int arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.classfile.ConstantPool arg3, Dova.JDK.com.sun.tools.classfile.AccessFlags arg4, int arg5, int arg6, JavaArray<int> arg7, JavaArray<Dova.JDK.com.sun.tools.classfile.Field> arg8, JavaArray<Dova.JDK.com.sun.tools.classfile.Method> arg9, Dova.JDK.com.sun.tools.classfile.Attributes arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/ClassFile;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isInterface()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.classfile.Attribute.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.io.InputStream arg0, Dova.JDK.com.sun.tools.classfile.Attribute.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;Lcom/sun/tools/classfile/Attribute$Factory;)Lcom/sun/tools/classfile/ClassFile;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.ClassFile read(Dova.JDK.java.io.File arg0, Dova.JDK.com.sun.tools.classfile.Attribute.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Attribute;", "public")]
	public Dova.JDK.com.sun.tools.classfile.Attribute getAttribute(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int byteLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/tools/classfile/Field;)I", "private")]
	public int byteLength(JavaArray<Dova.JDK.com.sun.tools.classfile.Field> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("([I)I", "private")]
	public int byteLength(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/tools/classfile/Method;)I", "private")]
	public int byteLength(JavaArray<Dova.JDK.com.sun.tools.classfile.Method> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSuperclassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getInterfaceName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
