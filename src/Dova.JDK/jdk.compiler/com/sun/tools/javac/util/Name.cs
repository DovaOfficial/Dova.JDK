/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.util;

[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public abstract")]
public partial class Name
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.lang.model.element.Name
	, Dova.JDK.com.sun.tools.javac.jvm.PoolConstant
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Name()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/Name;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "table", "Lcom/sun/tools/javac/util/Name$Table;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name$Table;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(CLcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Lcom/sun/tools/javac/util/Name;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "charAt", "(I)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "([BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentEquals", "(Ljava/lang/CharSequence;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Lcom/sun/tools/javac/util/Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lastIndexOf", "(B)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "(Lcom/sun/tools/javac/util/Name$NameMapper;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subSequence", "(II)Ljava/lang/CharSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "poolTag", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subName", "(II)Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUtf", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteAt", "(I)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteArray", "()[B"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name$Table;", "public final")]
	public Dova.JDK.com.sun.tools.javac.util.Name.Table table_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name.Table>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Name(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name$Table;)V", "protected")]
	public Name(Dova.JDK.com.sun.tools.javac.util.Name.Table arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Name;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(CLcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/Name;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Name append(char arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/util/Name;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Name append(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)I", "public")]
	public int compareTo(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)C", "public")]
	public char charAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BI)V", "public")]
	public void getBytes(JavaArray<byte> arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Z", "public")]
	public bool contentEquals(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Z", "public")]
	public bool startsWith(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(B)I", "public")]
	public int lastIndexOf(byte arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name$NameMapper;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object map(Dova.JDK.com.sun.tools.javac.util.Name.NameMapper arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/CharSequence;", "public")]
	public Dova.JDK.java.lang.CharSequence subSequence(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int poolTag()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getByteLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getByteOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(II)Lcom/sun/tools/javac/util/Name;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.Name subName(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> toUtf()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)B", "public abstract")]
	public byte getByteAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "public abstract")]
	public JavaArray<byte> getByteArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name$Table;", "public abstract static")]
	public partial class Table
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Table()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/Name$Table;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Names;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "equals", "([BI[BII)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromString", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromChars", "([CII)Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromUtf", "([BII)Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromUtf", "([B)Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hashValue", "([BII)I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.Names names_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Table(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Names;)V", "")]
		public Table(Dova.JDK.com.sun.tools.javac.util.Names arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/Name$Table;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("([BI[BII)Z", "protected static")]
		public static bool equals(JavaArray<byte> arg0, int arg1, JavaArray<byte> arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("()V", "public abstract")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name fromString(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("([CII)Lcom/sun/tools/javac/util/Name;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.util.Name fromChars(JavaArray<char> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("([BII)Lcom/sun/tools/javac/util/Name;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.util.Name fromUtf(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("([B)Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name fromUtf(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("([BII)I", "protected static")]
		public static int hashValue(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name$NameMapper;", "public abstract static interface")]
	public partial interface NameMapper
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NameMapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/Name$NameMapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "map", "([BII)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("([BII)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object map(JavaArray<byte> arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
