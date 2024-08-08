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
