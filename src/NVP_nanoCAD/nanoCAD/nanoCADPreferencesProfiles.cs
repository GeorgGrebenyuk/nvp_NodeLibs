using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Specifies profile settings.
///</summary>
namespace nanoCAD.nanoCADPreferencesProfiles 
{

	[NVP_Manifest(
		Id = "433EDF1C-7421-45ED-A213-D5BAA9F59310", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.nanoCADPreferencesProfiles_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "_nanoCADPreferencesProfiles_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesProfiles_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesProfiles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesProfiles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "D6CC3AE8-94B8-4796-A89A-3CA7231CB754", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.nanoCADPreferencesProfiles_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "_nanoCADPreferencesProfiles_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesProfiles_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesProfiles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesProfiles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6D3C8A1D-D910-4657-AEF8-EFFB65030BD6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]

	///<summary>
	///Gets the Application object
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
		Id = "7DA8CAB3-82B9-4D0C-8A22-8335038B47D2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.Set_ActiveProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "Set_ActiveProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("Path", typeof(System.String))]

	///<summary>
	///Specifies or returns the current profile.
	///</summary>
	public class Set_ActiveProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ActiveProfile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E6C29DC8-26A1-4B38-8731-0F482F1E6696", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.ActiveProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "ActiveProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the current profile.", 
		ViewType = "Data")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]

	///<summary>
	///Specifies or returns the current profile.
	///</summary>
	public class ActiveProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ActiveProfile);

		}
	}


	[NVP_Manifest(
		Id = "8621C8F5-2278-43D4-94C9-E2AF1175725E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.ImportProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "ImportProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Imports a profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("ProfileName", typeof(System.String))]
	[NodeInput("RegFile", typeof(System.String))]
	[NodeInput("IncludePathInfo", typeof(System.Object))]

	///<summary>
	///Imports a profile.
	///</summary>
	public class ImportProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImportProfile(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A143B44D-B570-4053-ABE4-BE1AC89082A1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.ExportProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "ExportProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Exports the current profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("ProfileName", typeof(System.String))]
	[NodeInput("RegFile", typeof(System.String))]

	///<summary>
	///Exports the current profile.
	///</summary>
	public class ExportProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ExportProfile(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3B64A14B-B32A-4CC4-B74C-418FB8491C7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.DeleteProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "DeleteProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("ProfileName", typeof(System.String))]

	///<summary>
	///Deletes a profile.
	///</summary>
	public class DeleteProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteProfile(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "00E879FD-3B57-46DC-A367-8223D5B21E3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.ResetProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "ResetProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Resets profile values to their default values.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("Profile", typeof(System.String))]

	///<summary>
	///Resets profile values to their default values.
	///</summary>
	public class ResetProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetProfile(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F9377D9-3B1C-420B-9F2D-B2ABD0B42EE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.RenameProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "RenameProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Renames a profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("origProfileName", typeof(System.String))]
	[NodeInput("newProfileName", typeof(System.String))]

	///<summary>
	///Renames a profile.
	///</summary>
	public class RenameProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RenameProfile(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FF0A9045-8EDE-494C-AAEE-1698A7E4049B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.CopyProfile", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "CopyProfile", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Copies a profile.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("oldProfileName", typeof(System.String))]
	[NodeInput("newProfileName", typeof(System.String))]

	///<summary>
	///Copies a profile.
	///</summary>
	public class CopyProfile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CopyProfile(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1EC93510-989F-4837-B22C-CF6283758263", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADPreferencesProfiles.GetAllProfileNames", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADPreferencesProfiles", 
		NodeName = "GetAllProfileNames", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets all available profiles for the system", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADPreferencesProfiles", typeof(object))]
	[NodeInput("pNames", typeof(System.Object))]

	///<summary>
	///Gets all available profiles for the system
	///</summary>
	public class GetAllProfileNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetAllProfileNames(inputs[1].Value);
			return null;
		}
	}
}
