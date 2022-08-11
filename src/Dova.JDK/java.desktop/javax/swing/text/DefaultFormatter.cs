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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter;", "public")]
public partial class DefaultFormatter
	: Dova.JDK.javax.swing.JFormattedTextField.AbstractFormatter
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allowsInvalid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overwriteMode", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "commitOnEdit", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueClass", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "navigationFilter", "Ljavax/swing/text/NavigationFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "documentFilter", "Ljavax/swing/text/DocumentFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replaceHolder", "Ljavax/swing/text/DefaultFormatter$ReplaceHolder;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "install", "(Ljavax/swing/JFormattedTextField;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNavigationFilter", "()Ljavax/swing/text/NavigationFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValueClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueToString", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValueClass", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAllowsInvalid", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCommitsOnValidEdit", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOverwriteMode", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllowsInvalid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNavigatable", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateValue", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateValue", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repositionCursor", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringToValue", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplaceString", "(IILjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLegalInsertText", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "positionCursorAtInitialLocation", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOverwriteMode", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canReplace", "(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReplaceHolder", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)Ljavax/swing/text/DefaultFormatter$ReplaceHolder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitialVisualPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextNavigatableChar", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommitsOnValidEdit", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextCursorPosition", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValidEdit", "(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "commitEdit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocumentFilter", "()Ljavax/swing/text/DocumentFilter;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool allowsInvalid_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool overwriteMode_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool commitOnEdit_Property
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

	[JniSignatureAttribute("Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class valueClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/NavigationFilter;", "private")]
	public Dova.JDK.javax.swing.text.NavigationFilter navigationFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.NavigationFilter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DocumentFilter;", "private")]
	public Dova.JDK.javax.swing.text.DocumentFilter documentFilter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DocumentFilter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter$ReplaceHolder;", "transient")]
	public Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder replaceHolder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultFormatter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z", "")]
	public bool replace(Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "")]
	public void replace(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.AttributeSet arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I", "")]
	public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JFormattedTextField;)V", "public")]
	public void install(Dova.JDK.javax.swing.JFormattedTextField arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "")]
	public void setDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "")]
	public void moveDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/NavigationFilter;", "protected")]
	public Dova.JDK.javax.swing.text.NavigationFilter getNavigationFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.NavigationFilter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;", "static")]
	public static Dova.JDK.javax.swing.JFormattedTextField access_000(Dova.JDK.javax.swing.text.DefaultFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;", "static")]
	public static Dova.JDK.javax.swing.JFormattedTextField access_100(Dova.JDK.javax.swing.text.DefaultFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;", "static")]
	public static Dova.JDK.javax.swing.JFormattedTextField access_200(Dova.JDK.javax.swing.text.DefaultFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;", "static")]
	public static Dova.JDK.javax.swing.JFormattedTextField access_300(Dova.JDK.javax.swing.text.DefaultFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)Ljavax/swing/JFormattedTextField;", "static")]
	public static Dova.JDK.javax.swing.JFormattedTextField access_400(Dova.JDK.javax.swing.text.DefaultFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getValueClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String valueToString(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public void setValueClass(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAllowsInvalid(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setCommitsOnValidEdit(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setOverwriteMode(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAllowsInvalid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "")]
	public bool isNavigatable(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
	public void updateValue(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateValue()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
	}

	[JniSignatureAttribute("(II)V", "")]
	public void repositionCursor(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object stringToValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getReplaceString(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool isLegalInsertText(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void positionCursorAtInitialLocation()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getOverwriteMode()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z", "")]
	public bool canReplace(Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)Ljavax/swing/text/DefaultFormatter$ReplaceHolder;", "")]
	public Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder getReplaceHolder(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.AttributeSet arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getInitialVisualPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int getNextNavigatableChar(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getCommitsOnValidEdit()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "")]
	public int getNextCursorPosition(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter$ReplaceHolder;)Z", "")]
	public bool isValidEdit(Dova.JDK.javax.swing.text.DefaultFormatter.ReplaceHolder arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void commitEdit()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36]);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/DocumentFilter;", "protected")]
	public Dova.JDK.javax.swing.text.DocumentFilter getDocumentFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DocumentFilter>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter$DefaultDocumentFilter;", "private")]
	public partial class DefaultDocumentFilter
		: Dova.JDK.javax.swing.text.DocumentFilter
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultDocumentFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultFormatter$DefaultDocumentFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/DefaultFormatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/DefaultFormatter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljavax/swing/text/DocumentFilter$FilterBypass;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertString", "(Ljavax/swing/text/DocumentFilter$FilterBypass;ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter;", "final")]
		public Dova.JDK.javax.swing.text.DefaultFormatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultFormatter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultDocumentFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)V", "private")]
		public DefaultDocumentFilter(Dova.JDK.javax.swing.text.DefaultFormatter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultFormatter$DefaultDocumentFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;II)V", "public")]
		public void remove(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "public")]
		public void replace(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.AttributeSet arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "public")]
		public void insertString(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.text.AttributeSet arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter$DefaultNavigationFilter;", "private")]
	public partial class DefaultNavigationFilter
		: Dova.JDK.javax.swing.text.NavigationFilter
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultNavigationFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultFormatter$DefaultNavigationFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/DefaultFormatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/DefaultFormatter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveDot", "(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter;", "final")]
		public Dova.JDK.javax.swing.text.DefaultFormatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultFormatter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultNavigationFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultFormatter;)V", "private")]
		public DefaultNavigationFilter(Dova.JDK.javax.swing.text.DefaultFormatter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultFormatter$DefaultNavigationFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;ILjavax/swing/text/Position$Bias;I[Ljavax/swing/text/Position$Bias;)I", "public")]
		public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.JTextComponent arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "public")]
		public void setDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/NavigationFilter$FilterBypass;ILjavax/swing/text/Position$Bias;)V", "public")]
		public void moveDot(Dova.JDK.javax.swing.text.NavigationFilter.FilterBypass arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultFormatter$ReplaceHolder;", "static")]
	public partial class ReplaceHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReplaceHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultFormatter$ReplaceHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fb", "Ljavax/swing/text/DocumentFilter$FilterBypass;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cursorPosition", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DocumentFilter$FilterBypass;", "")]
		public Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass fb_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int length_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "")]
		public Dova.JDK.javax.swing.text.AttributeSet attrs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int cursorPosition_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReplaceHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ReplaceHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultFormatter$ReplaceHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/DocumentFilter$FilterBypass;IILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "")]
		public void reset(Dova.JDK.javax.swing.text.DocumentFilter.FilterBypass arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.AttributeSet arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		}
	}
}
