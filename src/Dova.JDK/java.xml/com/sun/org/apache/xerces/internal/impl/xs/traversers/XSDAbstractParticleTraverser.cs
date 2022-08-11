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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser;", "abstract")]
public partial class XSDAbstractParticleTraverser
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractTraverser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDAbstractParticleTraverser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPArray", "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser$ParticleArray;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSeqChoice", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;IZLcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAllContent", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseChoice", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSequence", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseAll", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser$ParticleArray;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractParticleTraverser.ParticleArray fPArray_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractParticleTraverser.ParticleArray>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDAbstractParticleTraverser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V", "")]
	public XSDAbstractParticleTraverser(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;IZLcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl traverseSeqChoice(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2, int arg3, bool arg4, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)Z", "protected")]
	public bool hasAllContent(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl traverseChoice(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2, int arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl traverseSequence(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2, int arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;ILcom/sun/org/apache/xerces/internal/xs/XSObject;)Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl traverseAll(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2, int arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser$ParticleArray;", "protected static")]
	public partial class ParticleArray
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParticleArray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser$ParticleArray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fParticles", "[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fPos", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fContextCount", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushContext", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popContext", "()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addParticle", "(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParticleCount", "()I"));
		}

		[JniSignatureAttribute("[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl> fParticles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> fPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int fContextCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParticleArray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public ParticleArray() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDAbstractParticleTraverser$ParticleArray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "")]
		public void pushContext()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()[Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;", "")]
		public JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl> popContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/XSParticleDecl;)V", "")]
		public void addParticle(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.XSParticleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()I", "")]
		public int getParticleCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}
