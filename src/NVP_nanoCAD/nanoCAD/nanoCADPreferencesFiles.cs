using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies the settings that affect the use of various external files.
///</summary>
namespace nanoCAD.nanoCADPreferencesFiles 
{

	[NVP_Manifest(
		Id = "6F8562C6-137E-45EB-8014-B3FA0CB203B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.nanoCADPreferencesFiles_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "_nanoCADPreferencesFiles_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesFiles_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesFiles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesFiles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "ED03CF35-4E4E-4903-9923-5375C2B1C4EF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.nanoCADPreferencesFiles_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "_nanoCADPreferencesFiles_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesFiles_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesFiles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesFiles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "479B8378-E84A-48FA-842D-8B0294B46C6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "D00DE0B9-4CE0-4A15-93F8-4E407DD45179", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_SupportPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_SupportPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for extra support files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("orient", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for extra support files.
	///</summary>
	public class Set_SupportPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SupportPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C3D37E93-B913-4869-9264-3CA90616C1FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.SupportPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "SupportPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for extra support files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for extra support files.
	///</summary>
	public class SupportPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SupportPath);

		}
	}


	[NVP_Manifest(
		Id = "1BB6F873-7F76-4B32-BE9F-78E76855ED65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_DriversPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_DriversPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for drivers.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for drivers.
	///</summary>
	public class Set_DriversPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DriversPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C018A0F9-7445-45E4-A8AF-1997812295CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.DriversPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "DriversPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for drivers.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for drivers.
	///</summary>
	public class DriversPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DriversPath);

		}
	}


	[NVP_Manifest(
		Id = "6DC389C3-97E0-42B3-B8FB-404B12003BB9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_MenuFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_MenuFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for menu files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for menu files.
	///</summary>
	public class Set_MenuFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MenuFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ECA7994D-5290-44CD-A75D-2B87172A9C36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.MenuFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "MenuFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for menu files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for menu files.
	///</summary>
	public class MenuFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MenuFile);

		}
	}


	[NVP_Manifest(
		Id = "200F0C28-7956-449B-BA41-0A1BE829ED76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_HelpFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_HelpFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for help files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for help files.
	///</summary>
	public class Set_HelpFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HelpFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AEE1C127-4A30-4547-8C53-37BDA6B4C674", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.HelpFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "HelpFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for help files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for help files.
	///</summary>
	public class HelpFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HelpFilePath);

		}
	}


	[NVP_Manifest(
		Id = "A927F886-A453-4E77-8AEB-F5E606F1A4D1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_DefaultInternetURL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_DefaultInternetURL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for the default Internet address.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for the default Internet address.
	///</summary>
	public class Set_DefaultInternetURL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DefaultInternetURL = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "465001D3-B357-4255-8CA9-B0D64BA8D924", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.DefaultInternetURL", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "DefaultInternetURL", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for the default Internet address.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for the default Internet address.
	///</summary>
	public class DefaultInternetURL : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DefaultInternetURL);

		}
	}


	[NVP_Manifest(
		Id = "D240A8B2-BBC9-4318-81B2-4A16296EEAAD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.ConfigFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "ConfigFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the path of the configuration file.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Returns the path of the configuration file.
	///</summary>
	public class ConfigFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConfigFile);

		}
	}


	[NVP_Manifest(
		Id = "BB891358-02A4-4D4F-950C-EB273790B33B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.LicenseServer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "LicenseServer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns a list of servers available for use by the network license manager.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Returns a list of servers available for use by the network license manager.
	///</summary>
	public class LicenseServer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LicenseServer);

		}
	}


	[NVP_Manifest(
		Id = "3BBE44A6-5336-431F-8E53-ADEFCA3C8556", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_TextEditor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_TextEditor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the text editor used for multiline text.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of the text editor used for multiline text.
	///</summary>
	public class Set_TextEditor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextEditor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "04C3C5EF-59F8-4FAB-8CC2-0CC0DE0E9CCA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.TextEditor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "TextEditor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the text editor used for multiline text.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of the text editor used for multiline text.
	///</summary>
	public class TextEditor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextEditor);

		}
	}


	[NVP_Manifest(
		Id = "DFF4890C-D102-46E3-9484-4F56A168747A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_MainDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_MainDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the dictionary to use with spell checking.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of the dictionary to use with spell checking.
	///</summary>
	public class Set_MainDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MainDictionary = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A62D6282-0C8F-4E8F-A8C2-36B9B084AEBB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.MainDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "MainDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the dictionary to use with spell checking.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of the dictionary to use with spell checking.
	///</summary>
	public class MainDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MainDictionary);

		}
	}


	[NVP_Manifest(
		Id = "037A969D-2A09-4191-8116-5E946E5BC040", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_CustomDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_CustomDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.
	///</summary>
	public class Set_CustomDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomDictionary = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "26A46730-4AD1-4DA6-9FC6-48BDFB3754BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.CustomDictionary", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "CustomDictionary", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.
	///</summary>
	public class CustomDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomDictionary);

		}
	}


	[NVP_Manifest(
		Id = "12ACEAE5-10CB-401E-8903-C45A1E995F7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_AltFontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_AltFontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of an alternate font file.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("fontFile", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of an alternate font file.
	///</summary>
	public class Set_AltFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltFontFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C99535BA-4BE3-42BF-830A-C1CE2BE956B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.AltFontFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "AltFontFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of an alternate font file.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of an alternate font file.
	///</summary>
	public class AltFontFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltFontFile);

		}
	}


	[NVP_Manifest(
		Id = "6BCA021F-AD33-499F-8885-027300AF85A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_FontFileMap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_FontFileMap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of a font map file.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of a font map file.
	///</summary>
	public class Set_FontFileMap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FontFileMap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D98EF2A7-38C4-4E31-9D65-93C8D0678A55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.FontFileMap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "FontFileMap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of a font map file.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of a font map file.
	///</summary>
	public class FontFileMap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FontFileMap);

		}
	}


	[NVP_Manifest(
		Id = "A09730AD-5642-4F0E-A756-2F4AC1256E7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrintFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrintFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the temporary print file name that is used when printing drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the temporary print file name that is used when printing drawings.
	///</summary>
	public class Set_PrintFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrintFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "912349A2-EB33-45AB-AD34-DE1D90952155", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrintFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrintFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the temporary print file name that is used when printing drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the temporary print file name that is used when printing drawings.
	///</summary>
	public class PrintFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrintFile);

		}
	}


	[NVP_Manifest(
		Id = "10E5D3D2-A95F-47CA-A5D8-60BFFA9766AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrintSpoolExecutable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrintSpoolExecutable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the application used for print spooling.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of the application used for print spooling.
	///</summary>
	public class Set_PrintSpoolExecutable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrintSpoolExecutable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B492995-6CBC-4D72-893A-E625BB6A3245", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrintSpoolExecutable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrintSpoolExecutable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the application used for print spooling.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of the application used for print spooling.
	///</summary>
	public class PrintSpoolExecutable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrintSpoolExecutable);

		}
	}


	[NVP_Manifest(
		Id = "42491BCF-392D-4346-9BBE-268EA9E7711B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PostScriptPrologFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PostScriptPrologFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the prolog section used when printing to a PostScript file.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the prolog section used when printing to a PostScript file.
	///</summary>
	public class Set_PostScriptPrologFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PostScriptPrologFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "119CFAF1-58D5-4E94-A776-6D9EC0F62697", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PostScriptPrologFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PostScriptPrologFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the prolog section used when printing to a PostScript file.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the name of the prolog section used when printing to a PostScript file.
	///</summary>
	public class PostScriptPrologFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PostScriptPrologFile);

		}
	}


	[NVP_Manifest(
		Id = "04ACABC8-B1D5-4F72-BDBA-9B237EC8BD1D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrintSpoolerPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrintSpoolerPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path used for print spool output when printing drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path used for print spool output when printing drawings.
	///</summary>
	public class Set_PrintSpoolerPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrintSpoolerPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D41A91D0-917E-40DE-BD12-7E67A64A4887", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrintSpoolerPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrintSpoolerPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path used for print spool output when printing drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path used for print spool output when printing drawings.
	///</summary>
	public class PrintSpoolerPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrintSpoolerPath);

		}
	}


	[NVP_Manifest(
		Id = "F2F261C4-4250-48E9-83F0-034DD8350E9F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_AutoSavePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_AutoSavePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for the file saved when saving a drawing automatically.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("AutoSavePath", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for the file saved when saving a drawing automatically.
	///</summary>
	public class Set_AutoSavePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSavePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0FB356BD-CFF2-4560-B13A-0DCA354C9BEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.AutoSavePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "AutoSavePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for the file saved when saving a drawing automatically.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for the file saved when saving a drawing automatically.
	///</summary>
	public class AutoSavePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSavePath);

		}
	}


	[NVP_Manifest(
		Id = "A75F5B0C-5E1A-4C40-BFB3-8156A95E05E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_TemplateDwgPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_TemplateDwgPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for template files when using a new drawing wizard.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the paths where the application searches for template files when using a new drawing wizard.
	///</summary>
	public class Set_TemplateDwgPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TemplateDwgPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D7E8855C-EB3A-4E01-BF3B-01267CB27566", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.TemplateDwgPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "TemplateDwgPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the paths where the application searches for template files when using a new drawing wizard.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the paths where the application searches for template files when using a new drawing wizard.
	///</summary>
	public class TemplateDwgPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TemplateDwgPath);

		}
	}


	[NVP_Manifest(
		Id = "5C031067-FFAF-49A0-8A3D-FDC600ACDD00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_LogFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_LogFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the log file.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path and name of the log file.
	///</summary>
	public class Set_LogFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LogFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E4CC061D-E910-4C35-B376-E63B3F94DAF3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.LogFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "LogFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path and name of the log file.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path and name of the log file.
	///</summary>
	public class LogFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LogFilePath);

		}
	}


	[NVP_Manifest(
		Id = "9F0C527D-5A69-4592-9283-006EA56FB95A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_TempFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_TempFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application stores temporary files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path where the application stores temporary files.
	///</summary>
	public class Set_TempFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TempFilePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4A2DDADE-A299-4B4F-8E91-295AB3576FAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.TempFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "TempFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application stores temporary files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path where the application stores temporary files.
	///</summary>
	public class TempFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TempFilePath);

		}
	}


	[NVP_Manifest(
		Id = "014E355A-4DEC-44F2-B994-6383946ADC85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_TempXrefPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_TempXrefPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application stores external reference files that are loaded on demand.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path where the application stores external reference files that are loaded on demand.
	///</summary>
	public class Set_TempXrefPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TempXrefPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8FF1483A-D11B-4799-AA22-A98E7904830C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.TempXrefPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "TempXrefPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application stores external reference files that are loaded on demand.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path where the application stores external reference files that are loaded on demand.
	///</summary>
	public class TempXrefPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TempXrefPath);

		}
	}


	[NVP_Manifest(
		Id = "33A41409-4AD1-4942-908E-235F315C33BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_TextureMapPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_TextureMapPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for texture maps used for rendering.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for texture maps used for rendering.
	///</summary>
	public class Set_TextureMapPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextureMapPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CCC59861-F795-48A3-91FF-3B0A4C14CAD0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.TextureMapPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "TextureMapPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for texture maps used for rendering.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for texture maps used for rendering.
	///</summary>
	public class TextureMapPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextureMapPath);

		}
	}


	[NVP_Manifest(
		Id = "51363D02-3FB4-4E03-BE71-8DD7454F4BAE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_AltTabletMenuFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_AltTabletMenuFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for an alternate menu to replace the tablet menu.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("MenuFile", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for an alternate menu to replace the tablet menu.
	///</summary>
	public class Set_AltTabletMenuFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AltTabletMenuFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D429AD72-4B94-4585-BF60-E3070F1C51BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.AltTabletMenuFile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "AltTabletMenuFile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for an alternate menu to replace the tablet menu.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for an alternate menu to replace the tablet menu.
	///</summary>
	public class AltTabletMenuFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AltTabletMenuFile);

		}
	}


	[NVP_Manifest(
		Id = "2AEAF9F9-852C-4DDD-9742-346C301D6D49", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.SetProjectFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "SetProjectFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application searches for external reference files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("ProjectName", typeof(System.String))]
	[NodeInput("ProjectFilePath", typeof(System.String))]

	///<summary>
	///Specifies or returns the path where the application searches for external reference files.
	///</summary>
	public class SetProjectFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetProjectFilePath(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1ABA5620-3E1F-4A21-9DA9-00852D221D2C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.GetProjectFilePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "GetProjectFilePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path where the application searches for external reference files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("ProjectName", typeof(System.String))]

	///<summary>
	///Specifies or returns the path where the application searches for external reference files.
	///</summary>
	public class GetProjectFilePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetProjectFilePath(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "B46C5EA3-1655-4519-92C6-0B24B4FC8B9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrinterConfigPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrinterConfigPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for configuration files used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for configuration files used for printing.
	///</summary>
	public class Set_PrinterConfigPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterConfigPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FAE412DA-91CC-4E77-B860-6F995A9404A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrinterConfigPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrinterConfigPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for configuration files used for printing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for configuration files used for printing.
	///</summary>
	public class PrinterConfigPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterConfigPath);

		}
	}


	[NVP_Manifest(
		Id = "97FC66EF-7AA3-4B2D-95B9-12687C7DF196", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrinterDescPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrinterDescPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for description files used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for description files used for printing.
	///</summary>
	public class Set_PrinterDescPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterDescPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D7BCA5B9-D727-4CD2-9699-540984AF3894", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrinterDescPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrinterDescPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for description files used for printing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for description files used for printing.
	///</summary>
	public class PrinterDescPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterDescPath);

		}
	}


	[NVP_Manifest(
		Id = "BC75D9F1-D9C6-4A20-BCDF-D77CDC28D80F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_PrinterStyleSheetPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_PrinterStyleSheetPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for style sheets used for printing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for style sheets used for printing.
	///</summary>
	public class Set_PrinterStyleSheetPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrinterStyleSheetPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F90CE619-6681-48DA-8F71-9D8D42E1B0DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.PrinterStyleSheetPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "PrinterStyleSheetPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for style sheets used for printing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for style sheets used for printing.
	///</summary>
	public class PrinterStyleSheetPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrinterStyleSheetPath);

		}
	}


	[NVP_Manifest(
		Id = "E7A45CA7-8E4B-4135-904E-E1DBEC85A8D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_WorkspacePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_WorkspacePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for workspace files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for workspace files.
	///</summary>
	public class Set_WorkspacePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WorkspacePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6685A6F-B926-43FC-A849-4738122B4EE5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.WorkspacePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "WorkspacePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for workspace files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for workspace files.
	///</summary>
	public class WorkspacePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WorkspacePath);

		}
	}


	[NVP_Manifest(
		Id = "64D510C8-B7E8-43B9-8842-EE711BDF86FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_ObjectARXPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_ObjectARXPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for TX applications.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for TX applications.
	///</summary>
	public class Set_ObjectARXPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectARXPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "910CE018-F009-429F-90C5-F5BBFEFB8841", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.ObjectARXPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "ObjectARXPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for TX applications.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for TX applications.
	///</summary>
	public class ObjectARXPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectARXPath);

		}
	}


	[NVP_Manifest(
		Id = "8176E2DC-6EDE-424C-B08A-608ECA12B995", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_ColorBookPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_ColorBookPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for color books.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for color books.
	///</summary>
	public class Set_ColorBookPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorBookPath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "81F99CDE-5581-47ED-9D20-ECF626CB869E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.ColorBookPath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "ColorBookPath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for color books.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for color books.
	///</summary>
	public class ColorBookPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorBookPath);

		}
	}


	[NVP_Manifest(
		Id = "18BFCAB5-6BA6-4228-9428-A8F2983DE800", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.Set_ToolPalettePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "Set_ToolPalettePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for tool palettes.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the path for tool palettes.
	///</summary>
	public class Set_ToolPalettePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToolPalettePath = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D62C2A48-F8C2-4159-A01C-C137A442C9C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesFiles.ToolPalettePath", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesFiles", 
		NodeName = "ToolPalettePath", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the path for tool palettes.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesFiles", typeof(object))]

	///<summary>
	///Specifies or returns the path for tool palettes.
	///</summary>
	public class ToolPalettePath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToolPalettePath);

		}
	}
}
