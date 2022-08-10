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

namespace Dova.JDK.com.sun.tools.javac.processing;

[JniSignatureAttribute("Lcom/sun/tools/javac/processing/PrintingProcessor;", "public")]
public partial class PrintingProcessor
	: Dova.JDK.javax.annotation.processing.AbstractProcessor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintingProcessor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/PrintingProcessor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "writer", "Ljava/io/PrintWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintingProcessor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "process", "(Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setWriter", "(Ljava/io/Writer;)V"));
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "")]
	public Dova.JDK.java.io.PrintWriter writer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrintingProcessor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PrintingProcessor() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/PrintingProcessor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)V", "")]
	public void print(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljavax/annotation/processing/RoundEnvironment;)Z", "public")]
	public bool process(Dova.JDK.java.util.Set arg0, Dova.JDK.javax.annotation.processing.RoundEnvironment arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "public")]
	public void setWriter(Dova.JDK.java.io.Writer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public static")]
	public partial class PrintingElementVisitor
		: Dova.JDK.javax.lang.model.util.SimpleElementVisitor14
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintingElementVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "indentation", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "writer", "Ljava/io/PrintWriter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "elementUtils", "Ljavax/lang/model/util/Elements;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "spaces", "[Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintingElementVisitor", "(Ljava/io/Writer;Ljavax/lang/model/util/Elements;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "indent", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitModule", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPackage", "(Ljavax/lang/model/element/PackageElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitPackage", "(Ljavax/lang/model/element/PackageElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRecordComponent", "(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRecordComponent", "(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitVariable", "(Ljavax/lang/model/element/VariableElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitVariable", "(Ljavax/lang/model/element/VariableElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitTypeParameter", "(Ljavax/lang/model/element/TypeParameterElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitTypeParameter", "(Ljavax/lang/model/element/TypeParameterElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printModifiers", "(Ljavax/lang/model/element/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printInterfaces", "(Ljavax/lang/model/element/TypeElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printPermittedSubclasses", "(Ljavax/lang/model/element/TypeElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDirective", "(Ljavax/lang/model/element/ModuleElement$Directive;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printParameters", "(Ljavax/lang/model/element/ExecutableElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printThrows", "(Ljavax/lang/model/element/ExecutableElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "annotationsToString", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printedContainerAnnotation", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDocComment", "(Ljavax/lang/model/element/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printFormalTypeParameters", "(Ljavax/lang/model/element/Parameterizable;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitType", "(Ljavax/lang/model/element/TypeElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExecutable", "(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultAction", "(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultAction", "(Ljavax/lang/model/element/Element;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printAnnotations", "(Ljavax/lang/model/element/Element;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int indentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljava/io/PrintWriter;", "final")]
		public Dova.JDK.java.io.PrintWriter writer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "final")]
		public Dova.JDK.javax.lang.model.util.Elements elementUtils_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.String> spaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintingElementVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/lang/model/util/Elements;)V", "public")]
		public PrintingElementVisitor(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.lang.model.util.Elements arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void indent()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitModule(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitModule(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitRecordComponent(Dova.JDK.javax.lang.model.element.RecordComponentElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/RecordComponentElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitRecordComponent(Dova.JDK.javax.lang.model.element.RecordComponentElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitVariable(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitVariable(Dova.JDK.javax.lang.model.element.VariableElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeParameterElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitTypeParameter(Dova.JDK.javax.lang.model.element.TypeParameterElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeParameterElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitTypeParameter(Dova.JDK.javax.lang.model.element.TypeParameterElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)V", "private")]
		public void printModifiers(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)V", "private")]
		public void printInterfaces(Dova.JDK.javax.lang.model.element.TypeElement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)V", "private")]
		public void printPermittedSubclasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$Directive;)V", "private")]
		public void printDirective(Dova.JDK.javax.lang.model.element.ModuleElement.Directive arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "private")]
		public void printParameters(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "private")]
		public void printThrows(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String annotationsToString(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Z", "private")]
		public bool printedContainerAnnotation(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)V", "private")]
		public void printDocComment(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Parameterizable;Z)V", "private")]
		public void printFormalTypeParameters(Dova.JDK.javax.lang.model.element.Parameterizable arg0, bool arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "public")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/Object;)Ljava/lang/Object;", "protected volatile")]
		public Dova.JDK.java.lang.Object defaultAction(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/Boolean;)Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor;", "protected")]
		public Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor defaultAction(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.Boolean arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.processing.PrintingProcessor.PrintingElementVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)V", "private")]
		public void printAnnotations(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor$PrintDirective;", "private static")]
		public partial class PrintDirective
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.lang.model.element.ModuleElement.DirectiveVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PrintDirective()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor$PrintDirective;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "writer", "Ljava/io/PrintWriter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrintDirective", "(Ljava/io/PrintWriter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRequires", "(Ljavax/lang/model/element/ModuleElement$RequiresDirective;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitRequires", "(Ljavax/lang/model/element/ModuleElement$RequiresDirective;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExports", "(Ljavax/lang/model/element/ModuleElement$ExportsDirective;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitExports", "(Ljavax/lang/model/element/ModuleElement$ExportsDirective;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitOpens", "(Ljavax/lang/model/element/ModuleElement$OpensDirective;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitOpens", "(Ljavax/lang/model/element/ModuleElement$OpensDirective;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printModuleList", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printNameableList", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitProvides", "(Ljavax/lang/model/element/ModuleElement$ProvidesDirective;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitProvides", "(Ljavax/lang/model/element/ModuleElement$ProvidesDirective;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitUses", "(Ljavax/lang/model/element/ModuleElement$UsesDirective;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitUses", "(Ljavax/lang/model/element/ModuleElement$UsesDirective;Ljava/lang/Void;)Ljava/lang/Void;"));
			}

			[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
			public Dova.JDK.java.io.PrintWriter writer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PrintDirective(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/io/PrintWriter;)V", "")]
			public PrintDirective(Dova.JDK.java.io.PrintWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/processing/PrintingProcessor$PrintingElementVisitor$PrintDirective;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$RequiresDirective;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitRequires(Dova.JDK.javax.lang.model.element.ModuleElement.RequiresDirective arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$RequiresDirective;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitRequires(Dova.JDK.javax.lang.model.element.ModuleElement.RequiresDirective arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$ExportsDirective;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitExports(Dova.JDK.javax.lang.model.element.ModuleElement.ExportsDirective arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$ExportsDirective;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitExports(Dova.JDK.javax.lang.model.element.ModuleElement.ExportsDirective arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$OpensDirective;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitOpens(Dova.JDK.javax.lang.model.element.ModuleElement.OpensDirective arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$OpensDirective;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitOpens(Dova.JDK.javax.lang.model.element.ModuleElement.OpensDirective arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
			public void printModuleList(Dova.JDK.java.util.List arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
			public void printNameableList(Dova.JDK.java.util.List arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$ProvidesDirective;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitProvides(Dova.JDK.javax.lang.model.element.ModuleElement.ProvidesDirective arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$ProvidesDirective;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitProvides(Dova.JDK.javax.lang.model.element.ModuleElement.ProvidesDirective arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$UsesDirective;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitUses(Dova.JDK.javax.lang.model.element.ModuleElement.UsesDirective arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement$UsesDirective;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitUses(Dova.JDK.javax.lang.model.element.ModuleElement.UsesDirective arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}
		}
	}
}
