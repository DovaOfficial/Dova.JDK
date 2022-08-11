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

[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction;", "public")]
public partial class Instruction
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Instruction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Instruction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytes", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pc", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/classfile/Instruction$KindVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpcode", "()Lcom/sun/tools/classfile/Opcode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnsignedShort", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnsignedByte", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPC", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMnemonic", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "align", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/tools/classfile/Instruction$Kind;"));
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> bytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int pc_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Instruction(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([BI)V", "public")]
	public Instruction(JavaArray<byte> arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Instruction;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction$KindVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.tools.classfile.Instruction.KindVisitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Opcode;", "public")]
	public Dova.JDK.com.sun.tools.classfile.Opcode getOpcode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Opcode>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getUnsignedShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getUnsignedByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPC()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getMnemonic()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)I", "private static")]
	public static int align(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Instruction$Kind;", "public")]
	public Dova.JDK.com.sun.tools.classfile.Instruction.Kind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
	public partial class Kind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Kind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Instruction$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_OPERANDS", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATYPE", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRANCH", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRANCH_W", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPREF", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPREF_W", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPREF_W_UBYTE", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPREF_W_UBYTE_ZERO", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DYNAMIC", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_BYTE", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE_NO_OPERANDS", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE_LOCAL", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE_CPREF_W", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE_CPREF_W_SHORT", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDE_LOCAL_SHORT", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Lcom/sun/tools/classfile/Instruction$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/classfile/Instruction$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/classfile/Instruction$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Instruction$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/classfile/Instruction$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind NO_OPERANDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind ATYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind BRANCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind BRANCH_W_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind CPREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind CPREF_W_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind CPREF_W_UBYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind CPREF_W_UBYTE_ZERO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind DYNAMIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind LOCAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind LOCAL_BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind WIDE_NO_OPERANDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind WIDE_LOCAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind WIDE_CPREF_W_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind WIDE_CPREF_W_SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind WIDE_LOCAL_SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$Kind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind UNKNOWN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public final")]
		public int length_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/Instruction$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Instruction$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Instruction$Kind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Instruction$Kind;", "public static")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Instruction$Kind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.Kind>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$KindVisitor;", "public abstract static interface")]
	public partial interface KindVisitor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KindVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Instruction$KindVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/classfile/Instruction;Lcom/sun/tools/classfile/Instruction$TypeKind;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLookupSwitch", "(Lcom/sun/tools/classfile/Instruction;II[I[ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknown", "(Lcom/sun/tools/classfile/Instruction;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBranch", "(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNoOperands", "(Lcom/sun/tools/classfile/Instruction;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalAndValue", "(Lcom/sun/tools/classfile/Instruction;IILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTableSwitch", "(Lcom/sun/tools/classfile/Instruction;III[ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocal", "(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantPoolRef", "(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantPoolRefAndValue", "(Lcom/sun/tools/classfile/Instruction;IILjava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;Lcom/sun/tools/classfile/Instruction$TypeKind;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.classfile.Instruction arg0, Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;II[I[ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitLookupSwitch(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, int arg2, JavaArray<int> arg3, JavaArray<int> arg4, Dova.JDK.java.lang.Object arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitUnknown(Dova.JDK.com.sun.tools.classfile.Instruction arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitBranch(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitNoOperands(Dova.JDK.com.sun.tools.classfile.Instruction arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;IILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitLocalAndValue(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;III[ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitTableSwitch(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, int arg2, int arg3, JavaArray<int> arg4, Dova.JDK.java.lang.Object arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitLocal(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitConstantPoolRef(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;IILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitConstantPoolRefAndValue(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, int arg2, Dova.JDK.java.lang.Object arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Instruction;ILjava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object visitValue(Dova.JDK.com.sun.tools.classfile.Instruction arg0, int arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
	public partial class TypeKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Instruction$TypeKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_BOOLEAN", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_CHAR", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_FLOAT", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_DOUBLE", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_BYTE", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_SHORT", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_INT", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T_LONG", "Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(I)Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Instruction$TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/classfile/Instruction$TypeKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_INT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind T_LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public final")]
		public int value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/classfile/Instruction$TypeKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;)V", "private")]
		public TypeKind(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Instruction$TypeKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind get(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Instruction$TypeKind;", "public static")]
		public static Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/classfile/Instruction$TypeKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.classfile.Instruction.TypeKind>>(ret);
		}
	}
}
