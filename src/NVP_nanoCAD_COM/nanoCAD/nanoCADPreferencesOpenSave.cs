using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies open and save settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesOpenSave 
{

	[NVP_Manifest(
		Id = "B3D1C7C3-628F-45FC-90C0-0285A9885349", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.nanoCADPreferencesOpenSave_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "_nanoCADPreferencesOpenSave_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOpenSave_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesOpenSave _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesOpenSave;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "4352D25C-1554-4190-BBF0-6292E098C369", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.nanoCADPreferencesOpenSave_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "_nanoCADPreferencesOpenSave_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesOpenSave_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesOpenSave _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesOpenSave;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B0AD1921-C853-406F-9592-31FC93A42E6C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Gets the Application object.
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
		Id = "ACC8EE47-B791-46DD-8993-23F7A6BE4244", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_SavePreviewThumbnail", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_SavePreviewThumbnail", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether thumbnail preview images are saved with drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether thumbnail preview images are saved with drawings.
	///</summary>
	public class Set_SavePreviewThumbnail : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SavePreviewThumbnail = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4EC27E74-380F-4723-A454-1C7AF89BDF17", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.SavePreviewThumbnail", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "SavePreviewThumbnail", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether thumbnail preview images are saved with drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether thumbnail preview images are saved with drawings.
	///</summary>
	public class SavePreviewThumbnail : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SavePreviewThumbnail);

		}
	}


	[NVP_Manifest(
		Id = "8F7DA7B4-CD5C-4629-BF74-42CE70673EBD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_IncrementalSavePercent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_IncrementalSavePercent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns when a full save is performed instead of an incremental save.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns when a full save is performed instead of an incremental save.
	///</summary>
	public class Set_IncrementalSavePercent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IncrementalSavePercent = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F773E81-1367-45CF-8AAD-066D5E780144", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.IncrementalSavePercent", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "IncrementalSavePercent", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns when a full save is performed instead of an incremental save.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns when a full save is performed instead of an incremental save.
	///</summary>
	public class IncrementalSavePercent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IncrementalSavePercent);

		}
	}


	[NVP_Manifest(
		Id = "D08F4CE1-D727-4CAF-9E05-6E030D76DE89", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_AutoSaveInterval", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_AutoSaveInterval", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how often drawings are saved automatically.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Int32))]

	///<summary>
	///Specifies or returns how often drawings are saved automatically.
	///</summary>
	public class Set_AutoSaveInterval : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSaveInterval = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AD7D1E04-3B87-4BC2-9290-475EE80A968D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.AutoSaveInterval", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "AutoSaveInterval", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how often drawings are saved automatically.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how often drawings are saved automatically.
	///</summary>
	public class AutoSaveInterval : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSaveInterval);

		}
	}


	[NVP_Manifest(
		Id = "B7C0A918-321C-4D05-9B77-F7C6E84D16C7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_CreateBackup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_CreateBackup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether backup files are saved.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("CreateBackup", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether backup files are saved.
	///</summary>
	public class Set_CreateBackup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CreateBackup = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B30C53D-C368-4460-9EAE-C75429EC68F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.CreateBackup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "CreateBackup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether backup files are saved.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether backup files are saved.
	///</summary>
	public class CreateBackup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateBackup);

		}
	}


	[NVP_Manifest(
		Id = "C44AD381-5A78-47DC-8241-3A719CB00667", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_FullCRCValidation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_FullCRCValidation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether checking is turned on when hardware or software errors are suspected.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
	///</summary>
	public class Set_FullCRCValidation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FullCRCValidation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CE1321FE-B29D-44FB-8940-2869213FC6E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.FullCRCValidation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "FullCRCValidation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether checking is turned on when hardware or software errors are suspected.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether checking is turned on when hardware or software errors are suspected.
	///</summary>
	public class FullCRCValidation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullCRCValidation);

		}
	}


	[NVP_Manifest(
		Id = "7F579A7B-F8D6-4231-98A2-B962FF972D18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_LogFileOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_LogFileOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a log file is saved to capture text window contents.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a log file is saved to capture text window contents.
	///</summary>
	public class Set_LogFileOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LogFileOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA7F6552-A7C6-4EA0-86DE-F0244DBB6830", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.LogFileOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "LogFileOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a log file is saved to capture text window contents.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether a log file is saved to capture text window contents.
	///</summary>
	public class LogFileOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LogFileOn);

		}
	}


	[NVP_Manifest(
		Id = "5C3EB264-044B-43B9-AB25-43F7009F5CEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_TempFileExtension", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_TempFileExtension", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the file extension used for temporary files.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the file extension used for temporary files.
	///</summary>
	public class Set_TempFileExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TempFileExtension = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74EB479C-D512-41A8-A11E-C249F3EB5426", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.TempFileExtension", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "TempFileExtension", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the file extension used for temporary files.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns the file extension used for temporary files.
	///</summary>
	public class TempFileExtension : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TempFileExtension);

		}
	}


	[NVP_Manifest(
		Id = "E8FBFA37-9843-4862-8F49-4B1E3B86508F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_XrefDemandLoad", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_XrefDemandLoad", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how external references are loaded.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcXRefDemandLoad", typeof(System.Object))]

	///<summary>
	///Specifies or returns how external references are loaded.
	///</summary>
	public class Set_XrefDemandLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XrefDemandLoad = ((nanoCAD.AcXRefDemandLoad)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "112B5B4D-6819-49EB-BA58-008EE61D2F2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.XrefDemandLoad", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "XrefDemandLoad", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how external references are loaded.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how external references are loaded.
	///</summary>
	public class XrefDemandLoad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XrefDemandLoad);

		}
	}


	[NVP_Manifest(
		Id = "90753904-EBC5-48CA-B028-CF52C9F70800", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_DemandLoadARXApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_DemandLoadARXApp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcARXDemandLoad", typeof(System.Object))]

	///<summary>
	///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
	///</summary>
	public class Set_DemandLoadARXApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DemandLoadARXApp = ((nanoCAD.AcARXDemandLoad)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8A76B811-EEF5-4F6E-AFA6-82B4434CF9A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.DemandLoadARXApp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "DemandLoadARXApp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how third-party applications are loaded if a drawing contains custom objects created in that application.
	///</summary>
	public class DemandLoadARXApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DemandLoadARXApp);

		}
	}


	[NVP_Manifest(
		Id = "EF8018F4-7C8A-4E20-8C0B-0172A23FA25B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_ProxyImage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_ProxyImage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how objects that were created in a third-party application display in a drawing.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcProxyImage", typeof(System.Object))]

	///<summary>
	///Specifies or returns how objects that were created in a third-party application display in a drawing.
	///</summary>
	public class Set_ProxyImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProxyImage = ((nanoCAD.AcProxyImage)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C672D12-F036-4CB1-A37D-2A7AA63AABE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.ProxyImage", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "ProxyImage", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how objects that were created in a third-party application display in a drawing.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns how objects that were created in a third-party application display in a drawing.
	///</summary>
	public class ProxyImage : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProxyImage);

		}
	}


	[NVP_Manifest(
		Id = "AA304E13-95B8-4A57-AE6D-C393C4A8618C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_ShowProxyDialogBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_ShowProxyDialogBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a warning displays when opening a drawing that contains custom objects.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
	///</summary>
	public class Set_ShowProxyDialogBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowProxyDialogBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64E09B17-CBD8-43CB-886B-C89FE370569F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.ShowProxyDialogBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "ShowProxyDialogBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a warning displays when opening a drawing that contains custom objects.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether a warning displays when opening a drawing that contains custom objects.
	///</summary>
	public class ShowProxyDialogBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowProxyDialogBox);

		}
	}


	[NVP_Manifest(
		Id = "73E76D93-5ED3-4017-A2C3-42212C3B35A7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_AutoAudit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_AutoAudit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("bAudit", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
	///</summary>
	public class Set_AutoAudit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoAudit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9B95A823-1533-4EC4-842C-733EEFE8FF54", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.AutoAudit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "AutoAudit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns whether an audit is performed after you render a DXFIN or DXBIN interchange command.
	///</summary>
	public class AutoAudit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoAudit);

		}
	}


	[NVP_Manifest(
		Id = "F0DD7FAF-0CC8-4FFD-A7A9-B63141714823", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.Set_SaveAsType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "Set_SaveAsType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the default drawing type used for saving drawings.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]
	[NodeInput("nanoCAD.AcSaveAsType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the default drawing type used for saving drawings.
	///</summary>
	public class Set_SaveAsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SaveAsType = ((nanoCAD.AcSaveAsType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5A617358-6647-4571-8A66-634EF376B609", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.SaveAsType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "SaveAsType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the default drawing type used for saving drawings.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies or returns the default drawing type used for saving drawings.
	///</summary>
	public class SaveAsType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SaveAsType);

		}
	}


	[NVP_Manifest(
		Id = "74BC5B2A-F2D2-4ED7-B11B-18A46B335C16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesOpenSave.MRUNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesOpenSave", 
		NodeName = "MRUNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the number of recent files to track on the File menu.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesOpenSave", typeof(object))]

	///<summary>
	///Specifies the number of recent files to track on the File menu.
	///</summary>
	public class MRUNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MRUNumber);

		}
	}
}
