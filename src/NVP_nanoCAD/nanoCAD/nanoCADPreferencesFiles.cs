using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesFiles 
{
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


		///<summary>
		///Returns the Application object.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class Application : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Application);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for extra support files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("orient", typeof(System.String))]
		public class Set_SupportPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SupportPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for extra support files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class SupportPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SupportPath);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for drivers.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DriversPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DriversPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for drivers.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class DriversPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DriversPath);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for menu files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_MenuFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MenuFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for menu files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class MenuFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MenuFile);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for help files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_HelpFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HelpFilePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for help files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class HelpFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HelpFilePath);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for the default Internet address.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_DefaultInternetURL : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DefaultInternetURL = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for the default Internet address.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class DefaultInternetURL : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DefaultInternetURL);

			}
		}


		///<summary>
		///Returns the path of the configuration file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class ConfigFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ConfigFile);

			}
		}


		///<summary>
		///Returns a list of servers available for use by the network license manager.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class LicenseServer : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LicenseServer);

			}
		}


		///<summary>
		///Specifies or returns the path and name of the text editor used for multiline text.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TextEditor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextEditor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of the text editor used for multiline text.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class TextEditor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextEditor);

			}
		}


		///<summary>
		///Specifies or returns the path and name of the dictionary to use with spell checking.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_MainDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MainDictionary = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of the dictionary to use with spell checking.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class MainDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MainDictionary);

			}
		}


		///<summary>
		///Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_CustomDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CustomDictionary = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of the custom dictionary to use when checking the spelling of text.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class CustomDictionary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CustomDictionary);

			}
		}


		///<summary>
		///Specifies or returns the path and name of an alternate font file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("fontFile", typeof(System.String))]
		public class Set_AltFontFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AltFontFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of an alternate font file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class AltFontFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AltFontFile);

			}
		}


		///<summary>
		///Specifies or returns the path and name of a font map file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_FontFileMap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FontFileMap = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of a font map file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class FontFileMap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FontFileMap);

			}
		}


		///<summary>
		///Specifies or returns the temporary print file name that is used when printing drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrintFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrintFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the temporary print file name that is used when printing drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrintFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrintFile);

			}
		}


		///<summary>
		///Specifies or returns the path and name of the application used for print spooling.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrintSpoolExecutable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrintSpoolExecutable = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of the application used for print spooling.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrintSpoolExecutable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrintSpoolExecutable);

			}
		}


		///<summary>
		///Specifies or returns the name of the prolog section used when printing to a PostScript file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PostScriptPrologFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PostScriptPrologFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the name of the prolog section used when printing to a PostScript file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PostScriptPrologFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PostScriptPrologFile);

			}
		}


		///<summary>
		///Specifies or returns the path used for print spool output when printing drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrintSpoolerPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrintSpoolerPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path used for print spool output when printing drawings.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrintSpoolerPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrintSpoolerPath);

			}
		}


		///<summary>
		///Specifies or returns the path for the file saved when saving a drawing automatically.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("AutoSavePath", typeof(System.String))]
		public class Set_AutoSavePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AutoSavePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for the file saved when saving a drawing automatically.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class AutoSavePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AutoSavePath);

			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for template files when using a new drawing wizard.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TemplateDwgPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TemplateDwgPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the paths where the application searches for template files when using a new drawing wizard.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class TemplateDwgPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TemplateDwgPath);

			}
		}


		///<summary>
		///Specifies or returns the path and name of the log file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_LogFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LogFilePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path and name of the log file.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class LogFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LogFilePath);

			}
		}


		///<summary>
		///Specifies or returns the path where the application stores temporary files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TempFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TempFilePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path where the application stores temporary files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class TempFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TempFilePath);

			}
		}


		///<summary>
		///Specifies or returns the path where the application stores external reference files that are loaded on demand.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TempXrefPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TempXrefPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path where the application stores external reference files that are loaded on demand.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class TempXrefPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TempXrefPath);

			}
		}


		///<summary>
		///Specifies or returns the path for texture maps used for rendering.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_TextureMapPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextureMapPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for texture maps used for rendering.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class TextureMapPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextureMapPath);

			}
		}


		///<summary>
		///Specifies or returns the path for an alternate menu to replace the tablet menu.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("MenuFile", typeof(System.String))]
		public class Set_AltTabletMenuFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AltTabletMenuFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for an alternate menu to replace the tablet menu.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class AltTabletMenuFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AltTabletMenuFile);

			}
		}


		///<summary>
		///Specifies or returns the path where the application searches for external reference files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("ProjectName", typeof(System.String))]
		[NodeInput("ProjectFilePath", typeof(System.String))]
		public class SetProjectFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetProjectFilePath(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path where the application searches for external reference files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("ProjectName", typeof(System.String))]
		public class GetProjectFilePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetProjectFilePath(inputs[1]));

			}
		}


		///<summary>
		///Specifies or returns the path for configuration files used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrinterConfigPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterConfigPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for configuration files used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrinterConfigPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterConfigPath);

			}
		}


		///<summary>
		///Specifies or returns the path for description files used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrinterDescPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterDescPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for description files used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrinterDescPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterDescPath);

			}
		}


		///<summary>
		///Specifies or returns the path for style sheets used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_PrinterStyleSheetPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PrinterStyleSheetPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for style sheets used for printing.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class PrinterStyleSheetPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PrinterStyleSheetPath);

			}
		}


		///<summary>
		///Specifies or returns the path for workspace files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_WorkspacePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WorkspacePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for workspace files.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class WorkspacePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WorkspacePath);

			}
		}


		///<summary>
		///Specifies or returns the path for TX applications.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_ObjectARXPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ObjectARXPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for TX applications.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class ObjectARXPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectARXPath);

			}
		}


		///<summary>
		///Specifies or returns the path for color books.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_ColorBookPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ColorBookPath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for color books.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class ColorBookPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ColorBookPath);

			}
		}


		///<summary>
		///Specifies or returns the path for tool palettes.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		[NodeInput("Path", typeof(System.String))]
		public class Set_ToolPalettePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ToolPalettePath = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path for tool palettes.
		///</summary>
		[NodeInput("nanoCADPreferencesFiles", typeof(object))]
		public class ToolPalettePath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ToolPalettePath);

			}
		}
}
