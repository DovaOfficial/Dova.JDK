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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;", "public abstract interface")]
public partial interface SerializedFormWriter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SerializedFormWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHeader", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getClassContentHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addPackageSerializedTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerialUIDInfoHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerialFieldWriter", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialFieldWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializedSummariesHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getClassHeader", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageSerializedHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addSerializedContent", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addSerialUIDInfo", "(Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerialMethodWriter", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialMethodWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getClassSerializedHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addFooter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageHeader", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDocument", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMemberTree", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getHeader(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassContentHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	void addPackageSerializedTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerialUIDInfoHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialFieldWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter.SerialFieldWriter getSerialFieldWriter(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter.SerialFieldWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerializedSummariesHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassHeader(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getPackageSerializedHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	void addSerializedContent(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	void addSerialUIDInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialMethodWriter;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter.SerialMethodWriter getSerialMethodWriter(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.SerializedFormWriter.SerialMethodWriter>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getClassSerializedHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void addFooter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getPackageHeader(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
	void printDocument(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
	Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMemberTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialMethodWriter;", "public abstract static interface")]
	public partial interface SerialMethodWriter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SerialMethodWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialMethodWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberTags", "(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberHeader", "(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializableMethodsHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMethodsContentHeader", "(Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNoCustomizationMsg", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addDeprecatedMemberInfo", "(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberDescription", "(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializableMethods", "(Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberTags(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberHeader(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerializableMethodsHeader()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}

		[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getMethodsContentHeader(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getNoCustomizationMsg(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addDeprecatedMemberInfo(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberDescription(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerializableMethods(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialFieldWriter;", "public abstract static interface")]
	public partial interface SerialFieldWriter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SerialFieldWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/SerializedFormWriter$SerialFieldWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializableFields", "(Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "shouldPrintOverview", "(Ljavax/lang/model/element/VariableElement;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberDeprecatedInfo", "(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberTags", "(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberHeader", "(Ljavax/lang/model/type/TypeMirror;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFieldsContentHeader", "(Z)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberDescription", "(Ljavax/lang/model/element/VariableElement;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMemberDescription", "(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSerializableFieldsHeader", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerializableFields(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Z", "public abstract")]
		bool shouldPrintOverview(Dova.JDK.javax.lang.model.element.VariableElement arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberDeprecatedInfo(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberTags(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberHeader(Dova.JDK.javax.lang.model.type.TypeMirror arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getFieldsContentHeader(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberDescription(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljdk/javadoc/internal/doclets/toolkit/Content;)V", "public abstract")]
		void addMemberDescription(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "public abstract")]
		Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getSerializableFieldsHeader()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
		}
	}
}
