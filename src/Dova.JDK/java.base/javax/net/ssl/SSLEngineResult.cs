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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult;", "public")]
public partial class SSLEngineResult
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLEngineResult()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/SSLEngineResult;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "status", "Ljavax/net/ssl/SSLEngineResult$Status;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handshakeStatus", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bytesConsumed", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bytesProduced", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sequenceNumber", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SSLEngineResult", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SSLEngineResult", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;IIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bytesConsumed", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "bytesProduced", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sequenceNumber", "()J"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "private final")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.Status status_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "private final")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus handshakeStatus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private final")]
	public int bytesConsumed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "private final")]
	public int bytesProduced_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("J", "private final")]
	public long sequenceNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SSLEngineResult(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V", "public")]
	public SSLEngineResult(Dova.JDK.javax.net.ssl.SSLEngineResult.Status arg0, Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;IIJ)V", "public")]
	public SSLEngineResult(Dova.JDK.javax.net.ssl.SSLEngineResult.Status arg0, Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3, long arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ssl/SSLEngineResult;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngineResult$Status;", "public final")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.Status getStatus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int bytesConsumed()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public final")]
	public int bytesProduced()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public final")]
	public Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
	}

	[JniSignatureAttribute("()J", "public final")]
	public long sequenceNumber()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "public static final")]
	public partial class Status
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Status()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/SSLEngineResult$Status;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OK", "Ljavax/net/ssl/SSLEngineResult$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljavax/net/ssl/SSLEngineResult$Status;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Status", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljavax/net/ssl/SSLEngineResult$Status;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljavax/net/ssl/SSLEngineResult$Status;"));
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.Status BUFFER_UNDERFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.Status BUFFER_OVERFLOW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.Status OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$Status;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.Status CLOSED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/net/ssl/SSLEngineResult$Status;", "private static final")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Status(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Status(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/net/ssl/SSLEngineResult$Status;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/net/ssl/SSLEngineResult$Status;", "public static")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;", "public static")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.Status valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/net/ssl/SSLEngineResult$Status;", "private static")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.Status>>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
	public partial class HandshakeStatus
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HandshakeStatus()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEED_UNWRAP_AGAIN", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HandshakeStatus", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;"));
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus FINISHED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_TASK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_WRAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static final")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP_AGAIN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "private static final")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HandshakeStatus(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public HandshakeStatus(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "public static")]
		public static Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", "private static")]
		public static JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.net.ssl.SSLEngineResult.HandshakeStatus>>(ret);
		}
	}
}
