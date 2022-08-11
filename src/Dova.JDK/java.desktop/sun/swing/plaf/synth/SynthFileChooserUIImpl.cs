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

namespace Dova.JDK.sun.swing.plaf.synth;

[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "public")]
public partial class SynthFileChooserUIImpl
	: Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthFileChooserUIImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookInLabel", "Ljavax/swing/JLabel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directoryComboBox", "Ljavax/swing/JComboBox;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directoryComboBoxModel", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directoryComboBoxAction", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filterComboBoxModel", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileNameTextField", "Ljavax/swing/JTextField;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filePane", "Lsun/swing/FilePane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listViewButton", "Ljavax/swing/JToggleButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detailsViewButton", "Ljavax/swing/JToggleButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readOnly", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buttonPanel", "Ljavax/swing/JPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bottomPanel", "Ljavax/swing/JPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filterComboBox", "Ljavax/swing/JComboBox;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "hstrut5", "Ljava/awt/Dimension;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "shrinkwrap", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIST_PREF_SIZE", "Ljava/awt/Dimension;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookInLabelMnemonic", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookInLabelText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "saveInLabelText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileNameLabelMnemonic", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileNameLabelText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folderNameLabelMnemonic", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folderNameLabelText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filesOfTypeLabelMnemonic", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filesOfTypeLabelText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upFolderToolTipText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upFolderAccessibleName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "homeFolderToolTipText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "homeFolderAccessibleName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newFolderToolTipText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "newFolderAccessibleName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listViewButtonToolTipText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listViewButtonAccessibleName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detailsViewButtonToolTipText", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detailsViewButtonAccessibleName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileNameLabel", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modeListener", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "space", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/JFileChooser;Ljavax/swing/JList;)Ljava/awt/event/MouseListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAccessoryChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createActionMap", "()Ljavax/swing/ActionMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectoryComboBoxAction", "()Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rescanCurrentDirectory", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMnemonic", "(Ljava/lang/String;Ljava/util/Locale;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installComponents", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDirectoryComboBoxModel", "(Ljavax/swing/JFileChooser;)Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDirectoryComboBoxRenderer", "(Ljavax/swing/JFileChooser;)Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "populateFileNameLabel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fileNameString", "(Ljava/io/File;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fileNameString", "([Ljava/io/File;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFileName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilterComboBoxModel", "()Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFilterComboBoxRenderer", "()Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addControlButtons", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "groupLabels", "([Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installStrings", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doSelectedFileChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doSelectedFilesChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDirectoryChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectoryComboBox", "()Ljavax/swing/JComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doFileSelectionModeChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doControlButtonsChanged", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeControlButtons", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
	public Dova.JDK.javax.swing.JLabel lookInLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox;", "private")]
	public Dova.JDK.javax.swing.JComboBox directoryComboBox_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;", "private")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxModel directoryComboBoxModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action directoryComboBoxAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;", "private")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxModel filterComboBoxModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTextField;", "private")]
	public Dova.JDK.javax.swing.JTextField fileNameTextField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/FilePane;", "private")]
	public Dova.JDK.sun.swing.FilePane filePane_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.FilePane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JToggleButton;", "private")]
	public Dova.JDK.javax.swing.JToggleButton listViewButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToggleButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JToggleButton;", "private")]
	public Dova.JDK.javax.swing.JToggleButton detailsViewButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToggleButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool readOnly_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JPanel;", "private")]
	public Dova.JDK.javax.swing.JPanel buttonPanel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JPanel;", "private")]
	public Dova.JDK.javax.swing.JPanel bottomPanel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox;", "private")]
	public Dova.JDK.javax.swing.JComboBox filterComboBox_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Dimension;", "private static final")]
	public static Dova.JDK.java.awt.Dimension hstrut5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets shrinkwrap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Dimension;", "private static")]
	public static Dova.JDK.java.awt.Dimension LIST_PREF_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lookInLabelMnemonic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String lookInLabelText_Property
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
	public Dova.JDK.java.lang.String saveInLabelText_Property
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

	[JniSignatureAttribute("I", "private")]
	public int fileNameLabelMnemonic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fileNameLabelText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int folderNameLabelMnemonic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String folderNameLabelText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int filesOfTypeLabelMnemonic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String filesOfTypeLabelText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String upFolderToolTipText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String upFolderAccessibleName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String homeFolderToolTipText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String homeFolderAccessibleName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String newFolderToolTipText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String newFolderAccessibleName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String listViewButtonToolTipText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String listViewButtonAccessibleName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String detailsViewButtonToolTipText_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String detailsViewButtonAccessibleName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;", "private")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.AlignedLabel fileNameLabel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.AlignedLabel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private final")]
	public Dova.JDK.java.beans.PropertyChangeListener modeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int space_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SynthFileChooserUIImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "public")]
	public SynthFileChooserUIImpl(Dova.JDK.javax.swing.JFileChooser arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFileName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)Z", "static")]
	public static bool access_000(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)Ljava/io/File;", "static")]
	public static Dova.JDK.java.io.File access_100(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/JFileChooser;Ljavax/swing/JList;)Ljava/awt/event/MouseListener;", "static")]
	public static Dova.JDK.java.awt.@event.MouseListener access_200(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0, Dova.JDK.javax.swing.JFileChooser arg1, Dova.JDK.javax.swing.JList arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doAccessoryChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ActionMap;", "protected")]
	public Dova.JDK.javax.swing.ActionMap createActionMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionMap>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/Action;", "protected")]
	public Dova.JDK.javax.swing.Action getDirectoryComboBoxAction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "public")]
	public void rescanCurrentDirectory(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)I", "private")]
	public int getMnemonic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "protected")]
	public void installDefaults(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "public")]
	public void installComponents(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;", "protected")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxModel createDirectoryComboBoxModel(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxRenderer;", "protected")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxRenderer createDirectoryComboBoxRenderer(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.DirectoryComboBoxRenderer>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void populateFileNameLabel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fileNameString(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/io/File;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String fileNameString(JavaArray<Dova.JDK.java.io.File> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setFileName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;", "protected")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxModel createFilterComboBoxModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxModel>(ret);
	}

	[JniSignatureAttribute("()Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxRenderer;", "protected")]
	public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxRenderer createFilterComboBoxRenderer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.FilterComboBoxRenderer>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void addControlButtons()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("([Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;)V", "private static")]
	public static void groupLabels(JavaArray<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.AlignedLabel> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "protected")]
	public void installListeners(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "protected")]
	public void uninstallListeners(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "protected")]
	public void installStrings(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doSelectedFileChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doSelectedFilesChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doDirectoryChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JComponent;", "protected")]
	public Dova.JDK.javax.swing.JComponent getDirectoryComboBox()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doFileSelectionModeChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void doControlButtonsChanged(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void removeControlButtons()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30]);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;", "private static")]
	public partial class AlignedLabel
		: Dova.JDK.javax.swing.JLabel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AlignedLabel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "[Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxWidth", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperPreferredWidth", "()I"));
		}

		[JniSignatureAttribute("[Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;", "private")]
		public JavaArray<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.AlignedLabel> group_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.AlignedLabel>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int maxWidth_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AlignedLabel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public AlignedLabel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public AlignedLabel(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$AlignedLabel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()I", "private")]
		public int getMaxWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "private")]
		public int getSuperPreferredWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxAction;", "protected")]
	public partial class DirectoryComboBoxAction
		: Dova.JDK.javax.swing.AbstractAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryComboBoxAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "final")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryComboBoxAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V", "protected")]
		public DirectoryComboBoxAction(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;", "protected")]
	public partial class DirectoryComboBoxModel
		: Dova.JDK.javax.swing.AbstractListModel
		, Dova.JDK.javax.swing.ComboBoxModel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryComboBoxModel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directories", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depths", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedDirectory", "Ljava/io/File;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chooser", "Ljavax/swing/JFileChooser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fsv", "Ljavax/swing/filechooser/FileSystemView;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedItem", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addItem", "(Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedItem", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementAt_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementAt_1", "(I)Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateDepths", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDepth", "(I)I"));
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "")]
		public Dova.JDK.java.util.Vector directories_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> depths_Property
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

		[JniSignatureAttribute("Ljava/io/File;", "")]
		public Dova.JDK.java.io.File selectedDirectory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFileChooser;", "")]
		public Dova.JDK.javax.swing.JFileChooser chooser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFileChooser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/filechooser/FileSystemView;", "")]
		public Dova.JDK.javax.swing.filechooser.FileSystemView fsv_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.filechooser.FileSystemView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "final")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryComboBoxModel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V", "public")]
		public DirectoryComboBoxModel(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxModel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getSelectedItem()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
		public void addItem(Dova.JDK.java.io.File arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void setSelectedItem(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getElementAt_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File getElementAt_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void calculateDepths()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getDepth(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxRenderer;", "private")]
	public partial class DirectoryComboBoxRenderer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.ListCellRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryComboBoxRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljavax/swing/ListCellRenderer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ii", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$IndentIcon;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/ListCellRenderer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListCellRendererComponent", "(Ljavax/swing/JList;Ljava/io/File;IZZ)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListCellRendererComponent", "(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("Ljavax/swing/ListCellRenderer;", "private")]
		public Dova.JDK.javax.swing.ListCellRenderer @delegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListCellRenderer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$IndentIcon;", "")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.IndentIcon ii_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl.IndentIcon>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "final")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryComboBoxRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/ListCellRenderer;)V", "private")]
		public DirectoryComboBoxRenderer(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0, Dova.JDK.javax.swing.ListCellRenderer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$DirectoryComboBoxRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JList;Ljava/io/File;IZZ)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getListCellRendererComponent(Dova.JDK.javax.swing.JList arg0, Dova.JDK.java.io.File arg1, int arg2, bool arg3, bool arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;", "public volatile")]
		public Dova.JDK.java.awt.Component getListCellRendererComponent(Dova.JDK.javax.swing.JList arg0, Dova.JDK.java.lang.Object arg1, int arg2, bool arg3, bool arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$SynthFileChooserUIAccessor;", "private")]
	public partial class SynthFileChooserUIAccessor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.sun.swing.FilePane.FileChooserUIAccessor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynthFileChooserUIAccessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$SynthFileChooserUIAccessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getApproveSelectionAction", "()Ljavax/swing/Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createListSelectionListener", "()Ljavax/swing/event/ListSelectionListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDetailsView", "()Ljavax/swing/JPanel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createList", "()Ljavax/swing/JPanel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDoubleClickListener", "(Ljavax/swing/JList;)Ljava/awt/event/MouseListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectory", "()Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectorySelected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileChooser", "()Ljavax/swing/JFileChooser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChangeToParentDirectoryAction", "()Ljavax/swing/Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNewFolderAction", "()Ljavax/swing/Action;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModel", "()Ljavax/swing/plaf/basic/BasicDirectoryModel;"));
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "final")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SynthFileChooserUIAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V", "private")]
		public SynthFileChooserUIAccessor(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$SynthFileChooserUIAccessor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/Action;", "public")]
		public Dova.JDK.javax.swing.Action getApproveSelectionAction()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/event/ListSelectionListener;", "public")]
		public Dova.JDK.javax.swing.@event.ListSelectionListener createListSelectionListener()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ListSelectionListener>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JPanel;", "public")]
		public Dova.JDK.javax.swing.JPanel createDetailsView()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JPanel;", "public")]
		public Dova.JDK.javax.swing.JPanel createList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JList;)Ljava/awt/event/MouseListener;", "public")]
		public Dova.JDK.java.awt.@event.MouseListener createDoubleClickListener(Dova.JDK.javax.swing.JList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File getDirectory()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDirectorySelected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/JFileChooser;", "public")]
		public Dova.JDK.javax.swing.JFileChooser getFileChooser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFileChooser>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/Action;", "public")]
		public Dova.JDK.javax.swing.Action getChangeToParentDirectoryAction()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/Action;", "public")]
		public Dova.JDK.javax.swing.Action getNewFolderAction()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/plaf/basic/BasicDirectoryModel;", "public")]
		public Dova.JDK.javax.swing.plaf.basic.BasicDirectoryModel getModel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.basic.BasicDirectoryModel>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;", "protected")]
	public partial class FilterComboBoxModel
		: Dova.JDK.javax.swing.AbstractListModel
		, Dova.JDK.javax.swing.ComboBoxModel
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FilterComboBoxModel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filters", "[Ljavax/swing/filechooser/FileFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/swing/plaf/synth/SynthFileChooserUIImpl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedItem", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedItem", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementAt_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementAt_1", "(I)Ljavax/swing/filechooser/FileFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("[Ljavax/swing/filechooser/FileFilter;", "protected")]
		public JavaArray<Dova.JDK.javax.swing.filechooser.FileFilter> filters_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.filechooser.FileFilter>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl;", "final")]
		public Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FilterComboBoxModel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;)V", "protected")]
		public FilterComboBoxModel(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxModel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getSelectedItem()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void setSelectedItem(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getElementAt_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Ljavax/swing/filechooser/FileFilter;", "public")]
		public Dova.JDK.javax.swing.filechooser.FileFilter getElementAt_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.filechooser.FileFilter>(ret);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxRenderer;", "public")]
	public partial class FilterComboBoxRenderer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.ListCellRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FilterComboBoxRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljavax/swing/ListCellRenderer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/ListCellRenderer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListCellRendererComponent", "(Ljavax/swing/JList;Ljavax/swing/filechooser/FileFilter;IZZ)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListCellRendererComponent", "(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("Ljavax/swing/ListCellRenderer;", "private")]
		public Dova.JDK.javax.swing.ListCellRenderer @delegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListCellRenderer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FilterComboBoxRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/swing/plaf/synth/SynthFileChooserUIImpl;Ljavax/swing/ListCellRenderer;)V", "private")]
		public FilterComboBoxRenderer(Dova.JDK.sun.swing.plaf.synth.SynthFileChooserUIImpl arg0, Dova.JDK.javax.swing.ListCellRenderer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$FilterComboBoxRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JList;Ljavax/swing/filechooser/FileFilter;IZZ)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getListCellRendererComponent(Dova.JDK.javax.swing.JList arg0, Dova.JDK.javax.swing.filechooser.FileFilter arg1, int arg2, bool arg3, bool arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JList;Ljava/lang/Object;IZZ)Ljava/awt/Component;", "public volatile")]
		public Dova.JDK.java.awt.Component getListCellRendererComponent(Dova.JDK.javax.swing.JList arg0, Dova.JDK.java.lang.Object arg1, int arg2, bool arg3, bool arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$ButtonAreaLayout;", "private static")]
	public partial class ButtonAreaLayout
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.LayoutManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ButtonAreaLayout()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$ButtonAreaLayout;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hGap", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topMargin", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeLayoutComponent", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLayoutComponent", "(Ljava/lang/String;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutContainer", "(Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int hGap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int topMargin_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ButtonAreaLayout(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ButtonAreaLayout() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$ButtonAreaLayout;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
		public void removeLayoutComponent(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/Component;)V", "public")]
		public void addLayoutComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.Component arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)V", "public")]
		public void layoutContainer(Dova.JDK.java.awt.Container arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension preferredLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Container;)Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension minimumLayoutSize(Dova.JDK.java.awt.Container arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$IndentIcon;", "static")]
	public partial class IndentIcon
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.Icon
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IndentIcon()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/swing/plaf/synth/SynthFileChooserUIImpl$IndentIcon;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "icon", "Ljavax/swing/Icon;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "depth", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintIcon", "(Ljava/awt/Component;Ljava/awt/Graphics;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconWidth", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIconHeight", "()I"));
		}

		[JniSignatureAttribute("Ljavax/swing/Icon;", "")]
		public Dova.JDK.javax.swing.Icon icon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Icon>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int depth_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IndentIcon(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public IndentIcon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/swing/plaf/synth/SynthFileChooserUIImpl$IndentIcon;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;II)V", "public")]
		public void paintIcon(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconWidth()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIconHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}
}
