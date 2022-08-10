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

namespace Dova.JDK.javax.tools;

[JniSignatureAttribute("Ljavax/tools/DocumentationTool;", "public abstract interface")]
public partial interface DocumentationTool
	: IJavaObject
	, Dova.JDK.javax.tools.Tool
	, Dova.JDK.javax.tools.OptionChecker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocumentationTool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/DocumentationTool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStandardFileManager", "(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTask", "(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/DocumentationTool$DocumentationTask;"));
	}

	[JniSignatureAttribute("(Ljavax/tools/DiagnosticListener;Ljava/util/Locale;Ljava/nio/charset/Charset;)Ljavax/tools/StandardJavaFileManager;", "public abstract")]
	Dova.JDK.javax.tools.StandardJavaFileManager getStandardFileManager(Dova.JDK.javax.tools.DiagnosticListener arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.nio.charset.Charset arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/tools/JavaFileManager;Ljavax/tools/DiagnosticListener;Ljava/lang/Class;Ljava/lang/Iterable;Ljava/lang/Iterable;)Ljavax/tools/DocumentationTool$DocumentationTask;", "public abstract")]
	Dova.JDK.javax.tools.DocumentationTool.DocumentationTask getTask(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.tools.JavaFileManager arg1, Dova.JDK.javax.tools.DiagnosticListener arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.lang.Iterable arg4, Dova.JDK.java.lang.Iterable arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.DocumentationTask>(ret);
	}

	[JniSignatureAttribute("Ljavax/tools/DocumentationTool$Location;", "public static final")]
	public partial class Location
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.javax.tools.JavaFileManager.Location
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Location()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/DocumentationTool$Location;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DOCUMENTATION_OUTPUT", "Ljavax/tools/DocumentationTool$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DOCLET_PATH", "Ljavax/tools/DocumentationTool$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TAGLET_PATH", "Ljavax/tools/DocumentationTool$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SNIPPET_PATH", "Ljavax/tools/DocumentationTool$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljavax/tools/DocumentationTool$Location;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Location", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljavax/tools/DocumentationTool$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljavax/tools/DocumentationTool$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljavax/tools/DocumentationTool$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isOutputLocation", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/tools/DocumentationTool$Location;", "public static final")]
		public static Dova.JDK.javax.tools.DocumentationTool.Location DOCUMENTATION_OUTPUT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.Location>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/tools/DocumentationTool$Location;", "public static final")]
		public static Dova.JDK.javax.tools.DocumentationTool.Location DOCLET_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.Location>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/tools/DocumentationTool$Location;", "public static final")]
		public static Dova.JDK.javax.tools.DocumentationTool.Location TAGLET_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.Location>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/tools/DocumentationTool$Location;", "public static final")]
		public static Dova.JDK.javax.tools.DocumentationTool.Location SNIPPET_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.Location>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/tools/DocumentationTool$Location;", "private static final")]
		public static JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Location(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Location(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/tools/DocumentationTool$Location;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/tools/DocumentationTool$Location;", "public static")]
		public static JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/tools/DocumentationTool$Location;", "public static")]
		public static Dova.JDK.javax.tools.DocumentationTool.Location valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DocumentationTool.Location>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/tools/DocumentationTool$Location;", "private static")]
		public static JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.tools.DocumentationTool.Location>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isOutputLocation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/tools/DocumentationTool$DocumentationTask;", "public abstract static interface")]
	public partial interface DocumentationTask
		: IJavaObject
		, Dova.JDK.java.util.concurrent.Callable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DocumentationTask()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/DocumentationTool$DocumentationTask;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addModules", "(Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLocale", "(Ljava/util/Locale;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "call_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "call_1", "()Ljava/lang/Boolean;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "public abstract")]
		void addModules(Dova.JDK.java.lang.Iterable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)V", "public abstract")]
		void setLocale(Dova.JDK.java.util.Locale arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		Dova.JDK.java.lang.Object call_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Boolean;", "public abstract")]
		Dova.JDK.java.lang.Boolean call_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
	}
}
