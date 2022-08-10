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

namespace Dova.JDK.java.nio.file.attribute;

[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public final")]
public partial class PosixFilePermission
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PosixFilePermission()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/nio/file/attribute/PosixFilePermission;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OWNER_READ", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OWNER_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OWNER_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GROUP_READ", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GROUP_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GROUP_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OTHERS_READ", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OTHERS_WRITE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OTHERS_EXECUTE", "Ljava/nio/file/attribute/PosixFilePermission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljava/nio/file/attribute/PosixFilePermission;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PosixFilePermission", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljava/nio/file/attribute/PosixFilePermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/PosixFilePermission;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljava/nio/file/attribute/PosixFilePermission;"));
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OWNER_READ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OWNER_WRITE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OWNER_EXECUTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission GROUP_READ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission GROUP_WRITE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission GROUP_EXECUTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OTHERS_READ_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OTHERS_WRITE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/nio/file/attribute/PosixFilePermission;", "public static final")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission OTHERS_EXECUTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/nio/file/attribute/PosixFilePermission;", "private static final")]
	public static JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PosixFilePermission(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public PosixFilePermission(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/nio/file/attribute/PosixFilePermission;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/nio/file/attribute/PosixFilePermission;", "public static")]
	public static JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/file/attribute/PosixFilePermission;", "public static")]
	public static Dova.JDK.java.nio.file.attribute.PosixFilePermission valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFilePermission>(ret);
	}

	[JniSignatureAttribute("()[Ljava/nio/file/attribute/PosixFilePermission;", "private static")]
	public static JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.nio.file.attribute.PosixFilePermission>>(ret);
	}
}
