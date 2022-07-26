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

[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter;", "public")]
public partial class BasicDiagnosticFormatter
	: Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicDiagnosticFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Options;Lcom/sun/tools/javac/util/JavacMessages;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/JavacMessages;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSourceLineIfNeeded", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectFormat", "(Lcom/sun/tools/javac/util/JCDiagnostic;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatMeta", "(CLcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatMessage", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatMessage", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatDiagnostic", "(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_0", "()Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_1", "()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConfiguration_2", "()Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicDiagnosticFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;Lcom/sun/tools/javac/util/JavacMessages;)V", "public")]
	public BasicDiagnosticFormatter(Dova.JDK.com.sun.tools.javac.util.Options arg0, Dova.JDK.com.sun.tools.javac.util.JavacMessages arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JavacMessages;)V", "public")]
	public BasicDiagnosticFormatter(Dova.JDK.com.sun.tools.javac.util.JavacMessages arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String addSourceLineIfNeeded(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String selectFormat(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(CLcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String formatMeta(char arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public volatile")]
	public Dova.JDK.java.lang.String formatMessage(Dova.JDK.javax.tools.Diagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatMessage(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/JCDiagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatDiagnostic(Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration getConfiguration_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;", "public volatile")]
	public Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration getConfiguration_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/AbstractDiagnosticFormatter$SimpleConfiguration;", "public volatile")]
	public Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration getConfiguration_2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration;", "public static")]
	public partial class BasicConfiguration
		: Dova.JDK.com.sun.tools.javac.util.AbstractDiagnosticFormatter.SimpleConfiguration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicConfiguration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indentationLevels", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "availableFormats", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourcePosition", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Options;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFormat", "(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormat", "(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndentation", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourcePosition", "()Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFormat", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initIndentation", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndentation", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initOldFormat", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFormats", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFormats", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSourcePosition", "(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected")]
		public Dova.JDK.java.util.Map indentationLevels_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected")]
		public Dova.JDK.java.util.Map availableFormats_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "protected")]
		public Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition sourcePosition_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Options;)V", "public")]
		public BasicConfiguration(Dova.JDK.com.sun.tools.javac.util.Options arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public BasicConfiguration() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;Ljava/lang/String;)V", "public")]
		public void setFormat(Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getFormat(Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;)I", "public")]
		public int getIndentation(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition getSourcePosition()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void initFormat()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void initIndentation()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;I)V", "public")]
		public void setIndentation(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "private")]
		public void initOldFormat()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
		public void initFormats(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public void initFormats(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;)V", "public")]
		public void setSourcePosition(Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public static final")]
		public partial class SourcePosition
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SourcePosition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOTTOM", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AFTER_SUMMARY", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition BOTTOM_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition AFTER_SUMMARY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SourcePosition(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public SourcePosition(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$SourcePosition;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.SourcePosition>>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static final")]
		public partial class BasicFormatKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BasicFormatKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_POS_FORMAT", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_NO_POS_FORMAT", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_CLASS_FORMAT", "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind DEFAULT_POS_FORMAT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind DEFAULT_NO_POS_FORMAT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind DEFAULT_CLASS_FORMAT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BasicFormatKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public BasicFormatKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/util/BasicDiagnosticFormatter$BasicConfiguration$BasicFormatKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.util.BasicDiagnosticFormatter.BasicConfiguration.BasicFormatKind>>(ret);
			}
		}
	}
}
