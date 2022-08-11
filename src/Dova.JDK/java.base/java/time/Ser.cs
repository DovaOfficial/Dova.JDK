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

namespace Dova.JDK.java.time;

[JniSignatureAttribute("Ljava/time/Ser;", "final")]
public partial class Ser
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Externalizable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Ser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/Ser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DURATION_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANT_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_DATE_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_TIME_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_DATE_TIME_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZONE_DATE_TIME_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZONE_REGION_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZONE_OFFSET_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_TIME_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OFFSET_DATE_TIME_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YEAR_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YEAR_MONTH_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONTH_DAY_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERIOD_TYPE", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "object", "Ljava/io/Serializable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(BLjava/io/Serializable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/ObjectInput;)Ljava/io/Serializable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readResolve", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "writeInternal", "(BLjava/lang/Object;Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readInternal", "(BLjava/io/ObjectInput;)Ljava/io/Serializable;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte DURATION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte INSTANT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte LOCAL_DATE_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte LOCAL_TIME_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte LOCAL_DATE_TIME_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte ZONE_DATE_TIME_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte ZONE_REGION_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte ZONE_OFFSET_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte OFFSET_TIME_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte OFFSET_DATE_TIME_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte YEAR_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte YEAR_MONTH_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte MONTH_DAY_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("B", "static final")]
	public static byte PERIOD_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticByteField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticByteField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("B", "private")]
	public byte type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Ljava/io/Serializable;", "private")]
	public Dova.JDK.java.io.Serializable @object_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.Serializable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Ser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Ser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(BLjava/io/Serializable;)V", "")]
	public Ser(byte arg0, Dova.JDK.java.io.Serializable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/Ser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/io/Serializable;", "static")]
	public static Dova.JDK.java.io.Serializable read(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Serializable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object readResolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "public")]
	public void writeExternal(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)V", "public")]
	public void readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(BLjava/lang/Object;Ljava/io/ObjectOutput;)V", "static")]
	public static void writeInternal(byte arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.io.ObjectOutput arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(BLjava/io/ObjectInput;)Ljava/io/Serializable;", "private static")]
	public static Dova.JDK.java.io.Serializable readInternal(byte arg0, Dova.JDK.java.io.ObjectInput arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Serializable>(ret);
	}
}
