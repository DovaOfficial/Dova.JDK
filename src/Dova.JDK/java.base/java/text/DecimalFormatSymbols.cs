/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.text;

[JniSignatureAttribute("Ljava/text/DecimalFormatSymbols;", "public")]
public partial class DecimalFormatSymbols
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DecimalFormatSymbols()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/text/DecimalFormatSymbols;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "zeroDigit", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "groupingSeparator", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "decimalSeparator", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "perMill", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "percent", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "digit", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "patternSeparator", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "infinity", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "NaN", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minusSign", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "currencySymbol", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "intlCurrencySymbol", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "monetarySeparator", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exponential", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "exponentialSeparator", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "locale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "perMillText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "percentText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minusSignText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "monetaryGroupingSeparator", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "currency", "Ljava/util/Currency;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "currencyInitialized", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hashCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "currentSerialVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "serialVersionOnStream", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DecimalFormatSymbols", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DecimalFormatSymbols", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getInstance", "()Ljava/text/DecimalFormatSymbols;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "initialize", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNaN", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInfinity", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getZeroDigit", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMonetaryGroupingSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getGroupingSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMonetaryDecimalSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDecimalSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExponentSeparator", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinusSignText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInternationalCurrencySymbol", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCurrencySymbol", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPercentText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPerMillText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDigit", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPatternSeparator", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPercent", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPerMill", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinusSign", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCurrency", "()Ljava/util/Currency;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCurrency", "(Ljava/util/Currency;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "initializeCurrency", "(Ljava/util/Locale;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findNonFormatChar", "(Ljava/lang/String;C)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setZeroDigit", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setGroupingSeparator", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDecimalSeparator", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPerMill", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPercent", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDigit", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPatternSeparator", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInfinity", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setNaN", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMinusSign", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCurrencySymbol", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInternationalCurrencySymbol", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMonetaryDecimalSeparator", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setExponentSeparator", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMonetaryGroupingSeparator", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getExponentialSymbol", "()C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setExponentialSymbol", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPerMillText", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPercentText", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setMinusSignText", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("C", "private")]
	public char zeroDigit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char groupingSeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char decimalSeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char perMill_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char percent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char digit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char patternSeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String infinity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String NaN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char minusSign_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String currencySymbol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String intlCurrencySymbol_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char monetarySeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char exponential_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String exponentialSeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private")]
	public Dova.JDK.java.util.Locale locale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String perMillText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String percentText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String minusSignText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char monetaryGroupingSeparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Currency;", "private transient")]
	public Dova.JDK.java.util.Currency currency_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Currency>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private transient volatile")]
	public bool currencyInitialized_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private transient volatile")]
	public int hashCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int currentSerialVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int serialVersionOnStream_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DecimalFormatSymbols(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DecimalFormatSymbols() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "public")]
	public DecimalFormatSymbols(Dova.JDK.java.util.Locale arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/text/DecimalFormatSymbols;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/text/DecimalFormatSymbols;", "public static final")]
	public static Dova.JDK.java.text.DecimalFormatSymbols getInstance(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormatSymbols>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/DecimalFormatSymbols;", "public static final")]
	public static Dova.JDK.java.text.DecimalFormatSymbols getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DecimalFormatSymbols>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "private")]
	public void initialize(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public static")]
	public static JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getNaN()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getInfinity()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()C", "public")]
	public char getZeroDigit()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getMonetaryGroupingSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getGroupingSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getMonetaryDecimalSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getDecimalSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getExponentSeparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getMinusSignText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getInternationalCurrencySymbol()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCurrencySymbol()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getPercentText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getPerMillText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()C", "public")]
	public char getDigit()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getPatternSeparator()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getPercent()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getPerMill()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()C", "public")]
	public char getMinusSign()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Currency;", "public")]
	public Dova.JDK.java.util.Currency getCurrency()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Currency>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Currency;)V", "public")]
	public void setCurrency(Dova.JDK.java.util.Currency arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)V", "private")]
	public void initializeCurrency(Dova.JDK.java.util.Locale arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;C)C", "private")]
	public char findNonFormatChar(Dova.JDK.java.lang.String arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setZeroDigit(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setGroupingSeparator(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setDecimalSeparator(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setPerMill(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setPercent(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setDigit(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setPatternSeparator(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setInfinity(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setNaN(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setMinusSign(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setCurrencySymbol(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setInternationalCurrencySymbol(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setMonetaryDecimalSeparator(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setExponentSeparator(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void setMonetaryGroupingSeparator(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("()C", "")]
	public char getExponentialSymbol()
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("(C)V", "")]
	public void setExponentialSymbol(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setPerMillText(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setPercentText(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setMinusSignText(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
	}
}
