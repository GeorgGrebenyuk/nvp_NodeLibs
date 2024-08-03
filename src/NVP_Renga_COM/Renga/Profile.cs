using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Profile 
{

	[NVP_Manifest(
		Id = "7ED177A5-B7D1-49B4-9ABC-986E4E0FE392", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.Profile_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "_Profile_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Profile_Constructor : INode 
	{
		public Renga.IProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A9B56D67-9F2C-459D-A445-48826D40099A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.Profile_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "_Profile_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Profile_ConstructorCast : INode 
	{
		public Renga.IProfile _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProfile;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9A02B535-9664-4887-A6B8-BB7936506535", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.DescriptionId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "DescriptionId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Profile", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DescriptionId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DescriptionId);

		}
	}


	[NVP_Manifest(
		Id = "E3A2E6AC-5FF1-4174-A169-CF502368EEC1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.Regions", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "Regions", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Profile", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Regions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Regions);

		}
	}


	[NVP_Manifest(
		Id = "E77E9B9B-89DF-4B8F-B32B-4C4AF94BBC3C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.GetCenterOfMass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "GetCenterOfMass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Profile", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetCenterOfMass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCenterOfMass);

		}
	}


	[NVP_Manifest(
		Id = "08D4C797-A6E4-4F53-8F33-CFA8D01130A4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Profile.Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Profile", 
		NodeName = "Parameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Profile", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}
}
