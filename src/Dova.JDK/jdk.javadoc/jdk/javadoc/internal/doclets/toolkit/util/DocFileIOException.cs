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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException;", "public")]
public partial class DocFileIOException
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.DocletException
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocFileIOException()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileName", "Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;Ljava/io/IOException;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile fileName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocFileIOException(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/DocFile;Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;Ljava/io/IOException;)V", "public")]
	public DocFileIOException(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFile arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode arg1, Dova.JDK.java.io.IOException arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public static final")]
	public partial class Mode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Mode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "READ", "Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRITE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode READ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode WRITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Mode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Mode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/DocFileIOException$Mode;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocFileIOException.Mode>>(ret);
		}
	}
}
