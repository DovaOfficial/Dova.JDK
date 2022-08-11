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

namespace Dova.JDK.java.beans;

[JniSignatureAttribute("Ljava/beans/MetaData;", "")]
public partial class MetaData
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetaData()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "internalPersistenceDelegates", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nullPersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "enumPersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitivePersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultPersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "arrayPersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "proxyPersistenceDelegate", "Ljava/beans/PersistenceDelegate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValid", "(Ljava/lang/reflect/Constructor;[Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBeanAttribute", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstructorProperties", "(Ljava/lang/Class;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAnnotationValue", "(Ljava/lang/reflect/Constructor;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPersistenceDelegate", "(Ljava/lang/Class;)Ljava/beans/PersistenceDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPrivateFieldValue", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map fields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private static")]
	public static Dova.JDK.java.util.Hashtable internalPersistenceDelegates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate nullPersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate enumPersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate primitivePersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate defaultPersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate arrayPersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PersistenceDelegate;", "private static")]
	public static Dova.JDK.java.beans.PersistenceDelegate proxyPersistenceDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetaData(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public MetaData() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/beans/MetaData;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/String;)Z", "private static")]
	public static bool isValid(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object getBeanAttribute(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> getConstructorProperties(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)[Ljava/lang/String;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.String> getAnnotationValue(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/beans/PersistenceDelegate;", "public static synchronized")]
	public static Dova.JDK.java.beans.PersistenceDelegate getPersistenceDelegate(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PersistenceDelegate>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object getPrivateFieldValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$ArrayPersistenceDelegate;", "static final")]
	public partial class ArrayPersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayPersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$ArrayPersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayPersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ArrayPersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$ArrayPersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$ProxyPersistenceDelegate;", "static final")]
	public partial class ProxyPersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProxyPersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$ProxyPersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProxyPersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ProxyPersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$ProxyPersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$NullPersistenceDelegate;", "static final")]
	public partial class NullPersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullPersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$NullPersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullPersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public NullPersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$NullPersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)V", "public")]
		public void writeObject(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$EnumPersistenceDelegate;", "static final")]
	public partial class EnumPersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EnumPersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$EnumPersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EnumPersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public EnumPersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$EnumPersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$PrimitivePersistenceDelegate;", "static final")]
	public partial class PrimitivePersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrimitivePersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$PrimitivePersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrimitivePersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public PrimitivePersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$PrimitivePersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_border_MatteBorder_PersistenceDelegate;", "static final")]
	public partial class javax_swing_border_MatteBorder_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_border_MatteBorder_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_border_MatteBorder_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_border_MatteBorder_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_border_MatteBorder_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_border_MatteBorder_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Font_PersistenceDelegate;", "static final")]
	public partial class java_awt_Font_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Font_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Font_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Font_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Font_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Font_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_AWTKeyStroke_PersistenceDelegate;", "static final")]
	public partial class java_awt_AWTKeyStroke_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_AWTKeyStroke_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_AWTKeyStroke_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_AWTKeyStroke_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_AWTKeyStroke_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_AWTKeyStroke_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Date_PersistenceDelegate;", "static")]
	public partial class java_util_Date_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_Date_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Date_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_Date_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_Date_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Date_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$sun_swing_PrintColorUIResource_PersistenceDelegate;", "static final")]
	public partial class sun_swing_PrintColorUIResource_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static sun_swing_PrintColorUIResource_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$sun_swing_PrintColorUIResource_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public sun_swing_PrintColorUIResource_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public sun_swing_PrintColorUIResource_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$sun_swing_PrintColorUIResource_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_JMenu_PersistenceDelegate;", "static final")]
	public partial class javax_swing_JMenu_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_JMenu_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_JMenu_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_JMenu_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_JMenu_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_JMenu_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_Box_PersistenceDelegate;", "static final")]
	public partial class javax_swing_Box_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_Box_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_Box_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAxis", "(Ljava/lang/Object;)Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_Box_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_Box_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_Box_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Integer;", "private")]
		public Dova.JDK.java.lang.Integer getAxis(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_JTabbedPane_PersistenceDelegate;", "static final")]
	public partial class javax_swing_JTabbedPane_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_JTabbedPane_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_JTabbedPane_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_JTabbedPane_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_JTabbedPane_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_JTabbedPane_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_ToolTipManager_PersistenceDelegate;", "static final")]
	public partial class javax_swing_ToolTipManager_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_ToolTipManager_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_ToolTipManager_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_ToolTipManager_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_ToolTipManager_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_ToolTipManager_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate;", "static final")]
	public partial class javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_tree_DefaultMutableTreeNode_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_DefaultComboBoxModel_PersistenceDelegate;", "static final")]
	public partial class javax_swing_DefaultComboBoxModel_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_DefaultComboBoxModel_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_DefaultComboBoxModel_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_DefaultComboBoxModel_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_DefaultComboBoxModel_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_DefaultComboBoxModel_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_DefaultListModel_PersistenceDelegate;", "static final")]
	public partial class javax_swing_DefaultListModel_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_DefaultListModel_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_DefaultListModel_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_DefaultListModel_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_DefaultListModel_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_DefaultListModel_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$javax_swing_JFrame_PersistenceDelegate;", "static final")]
	public partial class javax_swing_JFrame_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static javax_swing_JFrame_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$javax_swing_JFrame_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public javax_swing_JFrame_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public javax_swing_JFrame_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$javax_swing_JFrame_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_GridBagLayout_PersistenceDelegate;", "static final")]
	public partial class java_awt_GridBagLayout_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_GridBagLayout_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_GridBagLayout_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHashtable", "(Ljava/lang/Object;)Ljava/util/Hashtable;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_GridBagLayout_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_GridBagLayout_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_GridBagLayout_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/Hashtable;", "private static")]
		public static Dova.JDK.java.util.Hashtable getHashtable(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_CardLayout_PersistenceDelegate;", "static final")]
	public partial class java_awt_CardLayout_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_CardLayout_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_CardLayout_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVector", "(Ljava/lang/Object;)Ljava/util/Vector;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_CardLayout_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_CardLayout_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_CardLayout_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/util/Vector;", "private static")]
		public static Dova.JDK.java.util.Vector getVector(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_BorderLayout_PersistenceDelegate;", "static final")]
	public partial class java_awt_BorderLayout_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_BorderLayout_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_BorderLayout_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRAINTS", "[Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> CONSTRAINTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_BorderLayout_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_BorderLayout_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_BorderLayout_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_List_PersistenceDelegate;", "static final")]
	public partial class java_awt_List_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_List_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_List_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_List_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_List_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_List_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_MenuBar_PersistenceDelegate;", "static final")]
	public partial class java_awt_MenuBar_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_MenuBar_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_MenuBar_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_MenuBar_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_MenuBar_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_MenuBar_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Menu_PersistenceDelegate;", "static final")]
	public partial class java_awt_Menu_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Menu_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Menu_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Menu_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Menu_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Menu_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Choice_PersistenceDelegate;", "static final")]
	public partial class java_awt_Choice_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Choice_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Choice_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Choice_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Choice_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Choice_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Container_PersistenceDelegate;", "static final")]
	public partial class java_awt_Container_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Container_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Container_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Container_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Container_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Container_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Component_PersistenceDelegate;", "static final")]
	public partial class java_awt_Component_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Component_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Component_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Component_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Component_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Component_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_MenuShortcut_PersistenceDelegate;", "static final")]
	public partial class java_awt_MenuShortcut_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_MenuShortcut_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_MenuShortcut_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_MenuShortcut_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_MenuShortcut_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_MenuShortcut_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_font_TextAttribute_PersistenceDelegate;", "static final")]
	public partial class java_awt_font_TextAttribute_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.StaticFieldsPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_font_TextAttribute_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_font_TextAttribute_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_font_TextAttribute_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_font_TextAttribute_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_font_TextAttribute_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_SystemColor_PersistenceDelegate;", "static final")]
	public partial class java_awt_SystemColor_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.StaticFieldsPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_SystemColor_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_SystemColor_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_SystemColor_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_SystemColor_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_SystemColor_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$StaticFieldsPersistenceDelegate;", "static")]
	public partial class StaticFieldsPersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StaticFieldsPersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$StaticFieldsPersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installFields", "(Ljava/beans/Encoder;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StaticFieldsPersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StaticFieldsPersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$StaticFieldsPersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)V", "public")]
		public void writeObject(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/beans/Encoder;Ljava/lang/Class;)V", "protected")]
		public void installFields(Dova.JDK.java.beans.Encoder arg0, Dova.JDK.java.lang.Class arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_awt_Insets_PersistenceDelegate;", "static final")]
	public partial class java_awt_Insets_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_awt_Insets_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_awt_Insets_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_awt_Insets_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_awt_Insets_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_awt_Insets_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_beans_beancontext_BeanContextSupport_PersistenceDelegate;", "static final")]
	public partial class java_beans_beancontext_BeanContextSupport_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_Collection_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_beans_beancontext_BeanContextSupport_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_beans_beancontext_BeanContextSupport_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_beans_beancontext_BeanContextSupport_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_beans_beancontext_BeanContextSupport_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_beans_beancontext_BeanContextSupport_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Hashtable_PersistenceDelegate;", "static final")]
	public partial class java_util_Hashtable_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_Map_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_Hashtable_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Hashtable_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_Hashtable_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_Hashtable_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Hashtable_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_AbstractMap_PersistenceDelegate;", "static final")]
	public partial class java_util_AbstractMap_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_Map_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_AbstractMap_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_AbstractMap_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_AbstractMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_AbstractMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_AbstractMap_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_AbstractList_PersistenceDelegate;", "static final")]
	public partial class java_util_AbstractList_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_List_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_AbstractList_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_AbstractList_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_AbstractList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_AbstractList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_AbstractList_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_AbstractCollection_PersistenceDelegate;", "static final")]
	public partial class java_util_AbstractCollection_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_Collection_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_AbstractCollection_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_AbstractCollection_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_AbstractCollection_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_AbstractCollection_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_AbstractCollection_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Map_PersistenceDelegate;", "static")]
	public partial class java_util_Map_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_Map_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Map_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_Map_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_Map_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Map_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_List_PersistenceDelegate;", "static")]
	public partial class java_util_List_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_List_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_List_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_List_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_List_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_List_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collection_PersistenceDelegate;", "static")]
	public partial class java_util_Collection_PersistenceDelegate
		: Dova.JDK.java.beans.DefaultPersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_Collection_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collection_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_Collection_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_util_Collection_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collection_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections;", "private abstract static")]
	public partial class java_util_Collections
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_util_Collections()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_util_Collections(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public java_util_Collections() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedMap_PersistenceDelegate;", "static final")]
		public partial class SynchronizedSortedMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedSortedMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedSortedMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedSortedMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedMap_PersistenceDelegate;", "static final")]
		public partial class SynchronizedMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedSet_PersistenceDelegate;", "static final")]
		public partial class SynchronizedSortedSet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedSortedSet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedSet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedSortedSet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedSortedSet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedSortedSet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedSet_PersistenceDelegate;", "static final")]
		public partial class SynchronizedSet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedSet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedSet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedSet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedSet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedSet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedRandomAccessList_PersistenceDelegate;", "static final")]
		public partial class SynchronizedRandomAccessList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedRandomAccessList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedRandomAccessList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedRandomAccessList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedRandomAccessList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedRandomAccessList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedList_PersistenceDelegate;", "static final")]
		public partial class SynchronizedList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SynchronizedCollection_PersistenceDelegate;", "static final")]
		public partial class SynchronizedCollection_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SynchronizedCollection_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SynchronizedCollection_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SynchronizedCollection_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SynchronizedCollection_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SynchronizedCollection_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedMap_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableSortedMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableSortedMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableSortedMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableSortedMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableMap_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedSet_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableSortedSet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableSortedSet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedSet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableSortedSet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableSortedSet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableSortedSet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSet_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableSet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableSet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableSet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableSet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableSet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableSet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableRandomAccessList_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableRandomAccessList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableRandomAccessList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableRandomAccessList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableRandomAccessList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableRandomAccessList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableRandomAccessList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableList_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$UnmodifiableCollection_PersistenceDelegate;", "static final")]
		public partial class UnmodifiableCollection_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UnmodifiableCollection_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$UnmodifiableCollection_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UnmodifiableCollection_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public UnmodifiableCollection_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$UnmodifiableCollection_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SingletonMap_PersistenceDelegate;", "static final")]
		public partial class SingletonMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SingletonMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SingletonMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SingletonMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SingletonMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SingletonMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SingletonSet_PersistenceDelegate;", "static final")]
		public partial class SingletonSet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SingletonSet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SingletonSet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SingletonSet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SingletonSet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SingletonSet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$SingletonList_PersistenceDelegate;", "static final")]
		public partial class SingletonList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SingletonList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$SingletonList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SingletonList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public SingletonList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$SingletonList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$EmptyMap_PersistenceDelegate;", "static final")]
		public partial class EmptyMap_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EmptyMap_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$EmptyMap_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EmptyMap_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public EmptyMap_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$EmptyMap_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$EmptySet_PersistenceDelegate;", "static final")]
		public partial class EmptySet_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EmptySet_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$EmptySet_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EmptySet_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public EmptySet_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$EmptySet_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}

		[JniSignatureAttribute("Ljava/beans/MetaData$java_util_Collections$EmptyList_PersistenceDelegate;", "static final")]
		public partial class EmptyList_PersistenceDelegate
			: Dova.JDK.java.beans.MetaData.java_util_Collections
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EmptyList_PersistenceDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_util_Collections$EmptyList_PersistenceDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EmptyList_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "")]
			public EmptyList_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_util_Collections$EmptyList_PersistenceDelegate;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
			public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_sql_Timestamp_PersistenceDelegate;", "static final")]
	public partial class java_sql_Timestamp_PersistenceDelegate
		: Dova.JDK.java.beans.MetaData.java_util_Date_PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_sql_Timestamp_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_sql_Timestamp_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "getNanosMethod", "Ljava/lang/reflect/Method;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNanos", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNanosMethod", "()Ljava/lang/reflect/Method;"));
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
		public static Dova.JDK.java.lang.reflect.Method getNanosMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_sql_Timestamp_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_sql_Timestamp_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_sql_Timestamp_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Object;Ljava/beans/Encoder;)V", "protected")]
		public void initialize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.beans.Encoder arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "private static")]
		public static int getNanos(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "private static")]
		public static Dova.JDK.java.lang.reflect.Method getNanosMethod()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_lang_reflect_Method_PersistenceDelegate;", "static final")]
	public partial class java_lang_reflect_Method_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_lang_reflect_Method_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_lang_reflect_Method_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_lang_reflect_Method_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_lang_reflect_Method_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_lang_reflect_Method_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_lang_reflect_Field_PersistenceDelegate;", "static final")]
	public partial class java_lang_reflect_Field_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_lang_reflect_Field_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_lang_reflect_Field_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_lang_reflect_Field_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_lang_reflect_Field_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_lang_reflect_Field_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_lang_Class_PersistenceDelegate;", "static final")]
	public partial class java_lang_Class_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_lang_Class_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_lang_Class_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mutatesTo", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_lang_Class_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_lang_Class_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_lang_Class_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "protected")]
		public bool mutatesTo(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/beans/MetaData$java_lang_String_PersistenceDelegate;", "static final")]
	public partial class java_lang_String_PersistenceDelegate
		: Dova.JDK.java.beans.PersistenceDelegate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static java_lang_String_PersistenceDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/beans/MetaData$java_lang_String_PersistenceDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/lang/Object;Ljava/beans/Encoder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public java_lang_String_PersistenceDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public java_lang_String_PersistenceDelegate() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/beans/MetaData$java_lang_String_PersistenceDelegate;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)V", "public")]
		public void writeObject(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/beans/Encoder;)Ljava/beans/Expression;", "protected")]
		public Dova.JDK.java.beans.Expression instantiate(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.beans.Encoder arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.Expression>(ret);
		}
	}
}
