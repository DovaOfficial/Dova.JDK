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

namespace Dova.JDK.sun.net;

[JniSignatureAttribute("Lsun/net/ProgressSource;", "public")]
public partial class ProgressSource
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProgressSource()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/net/ProgressSource;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "url", "Ljava/net/URL;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "method", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "contentType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "progress", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "lastProgress", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "expected", "J"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "state", "Lsun/net/ProgressSource$State;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "connected", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "progressMonitor", "Lsun/net/ProgressMonitor;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProgressSource", "(Ljava/net/URL;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "ProgressSource", "(Ljava/net/URL;Ljava/lang/String;J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getMethod", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getState", "()Lsun/net/ProgressSource$State;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "close", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getURL", "()Ljava/net/URL;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "connected", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getProgress", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "updateProgress", "(JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setContentType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getContentType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getExpected", "()J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "beginTracking", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "finishTracking", "()V"));
	}

	[JniSignatureAttribute("Ljava/net/URL;", "private")]
	public Dova.JDK.java.net.URL url_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String method_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String contentType_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private")]
	public long progress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("J", "private")]
	public long lastProgress_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("J", "private")]
	public long expected_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "private")]
	public Dova.JDK.sun.net.ProgressSource.State state_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool connected_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int threshold_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("Lsun/net/ProgressMonitor;", "private")]
	public Dova.JDK.sun.net.ProgressMonitor progressMonitor_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressMonitor>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProgressSource(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;)V", "public")]
	public ProgressSource(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;J)V", "public")]
	public ProgressSource(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, long arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/ProgressSource;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getMethod()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lsun/net/ProgressSource$State;", "public")]
	public Dova.JDK.sun.net.ProgressSource.State getState()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getURL()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool connected()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long getProgress()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void updateProgress(long arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setContentType(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getContentType()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getExpected()
	{
		var ret = DovaJvm.Vm.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void beginTracking()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void finishTracking()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "public static final")]
	public partial class State
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static State()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/net/ProgressSource$State;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NEW", "Lsun/net/ProgressSource$State;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "CONNECTED", "Lsun/net/ProgressSource$State;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "UPDATE", "Lsun/net/ProgressSource$State;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "DELETE", "Lsun/net/ProgressSource$State;"));
			FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lsun/net/ProgressSource$State;"));
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "State", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lsun/net/ProgressSource$State;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lsun/net/ProgressSource$State;"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lsun/net/ProgressSource$State;"));
		}

		[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "public static final")]
		public static Dova.JDK.sun.net.ProgressSource.State NEW_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "public static final")]
		public static Dova.JDK.sun.net.ProgressSource.State CONNECTED_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "public static final")]
		public static Dova.JDK.sun.net.ProgressSource.State UPDATE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lsun/net/ProgressSource$State;", "public static final")]
		public static Dova.JDK.sun.net.ProgressSource.State DELETE_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lsun/net/ProgressSource$State;", "private static final")]
		public static JavaArray<Dova.JDK.sun.net.ProgressSource.State> VALUES_Property
		{
			get
			{
				var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ProgressSource.State>>(ret);
			}
			set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public State(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public State(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/net/ProgressSource$State;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lsun/net/ProgressSource$State;", "public static")]
		public static JavaArray<Dova.JDK.sun.net.ProgressSource.State> values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ProgressSource.State>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lsun/net/ProgressSource$State;", "public static")]
		public static Dova.JDK.sun.net.ProgressSource.State valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.net.ProgressSource.State>(ret);
		}

		[JniSignatureAttribute("()[Lsun/net/ProgressSource$State;", "private static")]
		public static JavaArray<Dova.JDK.sun.net.ProgressSource.State> _values()
		{
			var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.net.ProgressSource.State>>(ret);
		}
	}
}
