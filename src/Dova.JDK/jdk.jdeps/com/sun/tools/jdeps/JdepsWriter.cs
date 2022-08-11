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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter;", "public abstract")]
public partial class JdepsWriter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JdepsWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showProfile", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showModule", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/Analyzer$Type;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProfile", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/Profile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateOutput", "(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showProfileOrModule", "(Lcom/sun/tools/jdeps/Module;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newDotWriter", "(Ljava/nio/file/Path;Lcom/sun/tools/jdeps/Analyzer$Type;)Lcom/sun/tools/jdeps/JdepsWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newSimpleWriter", "(Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;)Lcom/sun/tools/jdeps/JdepsWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTag", "(Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "final")]
	public Dova.JDK.com.sun.tools.jdeps.Analyzer.Type type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool showProfile_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "final")]
	public bool showModule_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JdepsWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Analyzer$Type;ZZ)V", "")]
	public JdepsWriter(Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg0, bool arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/Profile;", "")]
	public Dova.JDK.com.sun.tools.jdeps.Profile getProfile(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Profile>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V", "abstract")]
	public void generateOutput(Dova.JDK.java.util.Collection arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Module;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String showProfileOrModule(Dova.JDK.com.sun.tools.jdeps.Module arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/jdeps/Analyzer$Type;)Lcom/sun/tools/jdeps/JdepsWriter;", "public static")]
	public static Dova.JDK.com.sun.tools.jdeps.JdepsWriter newDotWriter(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;)Lcom/sun/tools/jdeps/JdepsWriter;", "public static")]
	public static Dova.JDK.com.sun.tools.jdeps.JdepsWriter newSimpleWriter(Dova.JDK.java.io.PrintWriter arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String toTag(Dova.JDK.com.sun.tools.jdeps.Archive arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.tools.jdeps.Archive arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;", "static")]
	public partial class DotFileWriter
		: Dova.JDK.com.sun.tools.jdeps.JdepsWriter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DotFileWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showLabel", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputDir", "Ljava/nio/file/Path;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Lcom/sun/tools/jdeps/Analyzer$Type;ZZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateOutput", "(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateSummaryDotFile", "(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V"));
		}

		[JniSignatureAttribute("Z", "final")]
		public bool showLabel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "final")]
		public Dova.JDK.java.nio.file.Path outputDir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DotFileWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Lcom/sun/tools/jdeps/Analyzer$Type;ZZZ)V", "")]
		public DotFileWriter(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg1, bool arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V", "")]
		public void generateOutput(Dova.JDK.java.util.Collection arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V", "private")]
		public void generateSummaryDotFile(Dova.JDK.java.util.Collection arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$SummaryDotFile;", "")]
		public partial class SummaryDotFile
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor
			, Dova.JDK.java.lang.AutoCloseable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SummaryDotFile()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$SummaryDotFile;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljava/io/PrintWriter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "edges", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDependence", "(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "labelBuilder", "()Lcom/sun/tools/jdeps/Analyzer$Visitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Archive;)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
			public Dova.JDK.java.io.PrintWriter writer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "private final")]
			public Dova.JDK.com.sun.tools.jdeps.Analyzer.Type type_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map edges_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;", "final")]
			public Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SummaryDotFile(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;)V", "")]
			public SummaryDotFile(Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter arg0, Dova.JDK.java.io.PrintWriter arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$SummaryDotFile;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "public")]
			public void visitDependence(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Analyzer$Visitor;", "")]
			public Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor labelBuilder()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Archive;)Ljava/lang/String;", "")]
			public Dova.JDK.java.lang.String getLabel(Dova.JDK.com.sun.tools.jdeps.Archive arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$DotFileFormatter;", "")]
		public partial class DotFileFormatter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor
			, Dova.JDK.java.lang.AutoCloseable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DotFileFormatter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$DotFileFormatter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljava/io/PrintWriter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Archive;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDependence", "(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
			}

			[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
			public Dova.JDK.java.io.PrintWriter writer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String name_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;", "final")]
			public Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DotFileFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter;Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Archive;)V", "")]
			public DotFileFormatter(Dova.JDK.com.sun.tools.jdeps.JdepsWriter.DotFileWriter arg0, Dova.JDK.java.io.PrintWriter arg1, Dova.JDK.com.sun.tools.jdeps.Archive arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$DotFileWriter$DotFileFormatter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "public")]
			public void visitDependence(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;", "static")]
	public partial class SimpleWriter
		: Dova.JDK.com.sun.tools.jdeps.JdepsWriter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljava/io/PrintWriter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateOutput", "(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V"));
		}

		[JniSignatureAttribute("Ljava/io/PrintWriter;", "final")]
		public Dova.JDK.java.io.PrintWriter writer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/PrintWriter;Lcom/sun/tools/jdeps/Analyzer$Type;ZZ)V", "")]
		public SimpleWriter(Dova.JDK.java.io.PrintWriter arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg1, bool arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Collection;Lcom/sun/tools/jdeps/Analyzer;)V", "")]
		public void generateOutput(Dova.JDK.java.util.Collection arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawOutputFormatter;", "")]
		public partial class RawOutputFormatter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RawOutputFormatter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawOutputFormatter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljava/io/PrintWriter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pkg", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;Ljava/io/PrintWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDependence", "(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
			}

			[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
			public Dova.JDK.java.io.PrintWriter writer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String pkg_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;", "final")]
			public Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RawOutputFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;Ljava/io/PrintWriter;)V", "")]
			public RawOutputFormatter(Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter arg0, Dova.JDK.java.io.PrintWriter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawOutputFormatter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "public")]
			public void visitDependence(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawSummaryFormatter;", "")]
		public partial class RawSummaryFormatter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RawSummaryFormatter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawSummaryFormatter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writer", "Ljava/io/PrintWriter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;Ljava/io/PrintWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDependence", "(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printModuleDescriptor", "(Lcom/sun/tools/jdeps/Module;)V"));
			}

			[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
			public Dova.JDK.java.io.PrintWriter writer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;", "final")]
			public Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RawSummaryFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter;Ljava/io/PrintWriter;)V", "")]
			public RawSummaryFormatter(Dova.JDK.com.sun.tools.jdeps.JdepsWriter.SimpleWriter arg0, Dova.JDK.java.io.PrintWriter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsWriter$SimpleWriter$RawSummaryFormatter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "public")]
			public void visitDependence(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Module;)V", "public")]
			public void printModuleDescriptor(Dova.JDK.com.sun.tools.jdeps.Module arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}
	}
}
