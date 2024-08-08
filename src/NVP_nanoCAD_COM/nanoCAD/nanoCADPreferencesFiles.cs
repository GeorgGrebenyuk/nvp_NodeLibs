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
