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

namespace Dova.JDK.com.sun.tools.sjavac;

[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log;", "public")]
public partial class Log
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Log()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/sjavac/Log;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "stdOutErr", "Lcom/sun/tools/sjavac/Log;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "loggers", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "err", "Ljava/io/PrintWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/PrintWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "level", "Lcom/sun/tools/sjavac/Log$Level;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/Writer;Ljava/io/Writer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "()Lcom/sun/tools/sjavac/Log;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "log", "(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "log", "(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "trace", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "debug", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "error", "(Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDebugging", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLogForCurrentThread", "(Lcom/sun/tools/sjavac/Log;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLogLevel", "(Lcom/sun/tools/sjavac/Log$Level;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLogLevel", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printLogMsg", "(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLevelLogged", "(Lcom/sun/tools/sjavac/Log$Level;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log;", "private static")]
	public static Dova.JDK.com.sun.tools.sjavac.Log stdOutErr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static")]
	public static Dova.JDK.java.lang.ThreadLocal loggers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "protected")]
	public Dova.JDK.java.io.PrintWriter err_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "protected")]
	public Dova.JDK.java.io.PrintWriter @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "protected")]
	public Dova.JDK.com.sun.tools.sjavac.Log.Level level_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Log(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljava/io/Writer;)V", "public")]
	public Log(Dova.JDK.java.io.Writer arg0, Dova.JDK.java.io.Writer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/sjavac/Log;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/tools/sjavac/Log;", "public static")]
	public static Dova.JDK.com.sun.tools.sjavac.Log get()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/Throwable;)V", "public static")]
	public static void log(Dova.JDK.com.sun.tools.sjavac.Log.Level arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/String;)V", "public static")]
	public static void log(Dova.JDK.com.sun.tools.sjavac.Log.Level arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void info(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void trace(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public static")]
	public static void debug(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void debug(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public static")]
	public static void error(Dova.JDK.java.lang.Throwable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void error(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void warn(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDebugging()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log;)V", "public static")]
	public static void setLogForCurrentThread(Dova.JDK.com.sun.tools.sjavac.Log arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log$Level;)V", "public static")]
	public static void setLogLevel(Dova.JDK.com.sun.tools.sjavac.Log.Level arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void setLogLevel(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log$Level;Ljava/lang/String;)V", "protected")]
	public void printLogMsg(Dova.JDK.com.sun.tools.sjavac.Log.Level arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/sjavac/Log$Level;)Z", "protected")]
	public bool isLevelLogged(Dova.JDK.com.sun.tools.sjavac.Log.Level arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
	public partial class Level
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Level()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/sjavac/Log$Level;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Lcom/sun/tools/sjavac/Log$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WARN", "Lcom/sun/tools/sjavac/Log$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INFO", "Lcom/sun/tools/sjavac/Log$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Lcom/sun/tools/sjavac/Log$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRACE", "Lcom/sun/tools/sjavac/Log$Level;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/sjavac/Log$Level;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/sjavac/Log$Level;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/sjavac/Log$Level;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/sjavac/Log$Level;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level ERROR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level WARN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level DEBUG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/sjavac/Log$Level;", "public static final")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level TRACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/sjavac/Log$Level;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Level(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Level(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/sjavac/Log$Level;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/sjavac/Log$Level;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/sjavac/Log$Level;", "public static")]
		public static Dova.JDK.com.sun.tools.sjavac.Log.Level valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.sjavac.Log.Level>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/sjavac/Log$Level;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.sjavac.Log.Level>>(ret);
		}
	}
}
