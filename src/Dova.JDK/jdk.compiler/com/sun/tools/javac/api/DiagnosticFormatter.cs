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

namespace Dova.JDK.com.sun.tools.javac.api;

[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter;", "public abstract interface")]
public partial interface DiagnosticFormatter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DiagnosticFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/DiagnosticFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "format", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "formatKind", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "formatMessage", "(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "displaySource", "(Ljavax/tools/Diagnostic;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConfiguration", "()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "formatPosition", "(Ljavax/tools/Diagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "formatSource", "(Ljavax/tools/Diagnostic;ZLjava/util/Locale;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String format(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String formatKind(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Ljava/util/Locale;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String formatMessage(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;)Z", "public abstract")]
	bool displaySource(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;", "public abstract")]
	Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration getConfiguration()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;Ljava/util/Locale;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String formatPosition(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;ZLjava/util/Locale;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String formatSource(Dova.JDK.java.lang.Object arg0, bool arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;", "public abstract static interface")]
	public partial interface Configuration
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Configuration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setVisible", "(Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMultilineLimit", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMultilineLimit", "(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getVisible", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("(Ljava/util/Set;)V", "public abstract")]
		void setVisible(Dova.JDK.java.util.Set arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;)I", "public abstract")]
		int getMultilineLimit(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;I)V", "public abstract")]
		void setMultilineLimit(Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
		Dova.JDK.java.util.Set getVisible()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "public static final")]
		public partial class MultilineLimit
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MultilineLimit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEPTH", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LENGTH", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MultilineLimit", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit DEPTH_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit LENGTH_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MultilineLimit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public MultilineLimit(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$MultilineLimit;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.MultilineLimit>>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
		public partial class DiagnosticPart
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DiagnosticPart()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUMMARY", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DETAILS", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SOURCE", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUBDIAGNOSTICS", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JLS", "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DiagnosticPart", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart SUMMARY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart DETAILS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart SOURCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart SUBDIAGNOSTICS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart JLS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DiagnosticPart(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public DiagnosticPart(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$Configuration$DiagnosticPart;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.Configuration.DiagnosticPart>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
	public partial class PositionKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PositionKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START", "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "END", "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LINE", "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLUMN", "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OFFSET", "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PositionKind", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind START_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind END_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind LINE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind COLUMN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind OFFSET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PositionKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public PositionKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/api/DiagnosticFormatter$PositionKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.api.DiagnosticFormatter.PositionKind>>(ret);
		}
	}
}
