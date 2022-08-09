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

namespace Dova.JDK.java.rmi.server;

[JniSignatureAttribute("Ljava/rmi/server/ObjID;", "public final")]
public partial class ObjID
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjID()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/rmi/server/ObjID;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "REGISTRY_ID", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "ACTIVATOR_ID", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DGC_ID", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "nextObjNum", "Ljava/util/concurrent/atomic/AtomicLong;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "mySpace", "Ljava/rmi/server/UID;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "secureRandom", "Ljava/security/SecureRandom;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "objNum", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "space", "Ljava/rmi/server/UID;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ObjID", "(JLjava/rmi/server/UID;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ObjID", "(I)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ObjID", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/ObjectInput;)Ljava/rmi/server/ObjID;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "useRandomIDs", "()Z"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int REGISTRY_ID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ACTIVATOR_ID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DGC_ID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicLong;", "private static final")]
	public static Dova.JDK.java.util.concurrent.atomic.AtomicLong nextObjNum_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicLong>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/rmi/server/UID;", "private static final")]
	public static Dova.JDK.java.rmi.server.UID mySpace_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.UID>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/security/SecureRandom;", "private static final")]
	public static Dova.JDK.java.security.SecureRandom secureRandom_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.SecureRandom>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private final")]
	public long objNum_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("Ljava/rmi/server/UID;", "private final")]
	public Dova.JDK.java.rmi.server.UID space_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.UID>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ObjID(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JLjava/rmi/server/UID;)V", "private")]
	public ObjID(long arg0, Dova.JDK.java.rmi.server.UID arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public ObjID(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ObjID() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/rmi/server/ObjID;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "public")]
	public void write(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/rmi/server/ObjID;", "public static")]
	public static Dova.JDK.java.rmi.server.ObjID read(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.ObjID>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool useRandomIDs()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5]);
		return ret;
	}
}