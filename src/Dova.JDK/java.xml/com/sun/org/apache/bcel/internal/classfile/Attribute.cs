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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.classfile;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public abstract")]
public partial class Attribute
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Node
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Attribute()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/classfile/Attribute;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name_index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constant_pool", "Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "readers", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BIILcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "println", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstantPool", "()Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLength", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readAttribute", "(Ljava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readAttribute", "(Ljava/io/DataInputStream;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setConstantPool", "(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addAttributeReader", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/UnknownAttributeReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeAttributeReader", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNameIndex", "(I)V"));
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int name_index_Property
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

	[JniSignatureAttribute("I", "private")]
	public int length_Property
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

	[JniSignatureAttribute("B", "private final")]
	public byte tag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool constant_pool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map readers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Attribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(BIILcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "protected")]
	public Attribute(byte arg0, int arg1, int arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/classfile/Attribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected static")]
	public static void println(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool getConstantPool()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/Visitor;)V", "public abstract")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(I)V", "public final")]
	public void setLength(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public abstract")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute copy(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute readAttribute(Dova.JDK.java.io.DataInput arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataInputStream;Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)Lcom/sun/org/apache/bcel/internal/classfile/Attribute;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute readAttribute(Dova.JDK.java.io.DataInputStream arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.Attribute>(ret);
	}

	[JniSignatureAttribute("()B", "public final")]
	public byte getTag()
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/ConstantPool;)V", "public final")]
	public void setConstantPool(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.ConstantPool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getNameIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/UnknownAttributeReader;)V", "public static")]
	public static void addAttributeReader(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.UnknownAttributeReader arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void removeAttributeReader(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(I)V", "public final")]
	public void setNameIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}
}
