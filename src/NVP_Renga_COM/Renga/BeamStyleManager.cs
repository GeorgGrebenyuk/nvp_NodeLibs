using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.BeamStyleManager 
{

	[NVP_Manifest(
		Id = "E4FA3A00-F6BB-4CA7-B506-BFDA1FEA3577", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyleManager.BeamStyleManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyleManager", 
		NodeName = "_BeamStyleManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyleManager_Constructor : INode 
	{
		public Renga.IBeamStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IBeamStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5DC650EA-B61B-4176-B706-A0E459D9A128", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyleManager.BeamStyleManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyleManager", 
		NodeName = "_BeamStyleManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class BeamStyleManager_ConstructorCast : INode 
	{
		public Renga.IBeamStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IBeamStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B8380391-B948-4F68-A490-071891CBE529", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyleManager.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyleManager", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("BeamStyleManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C24F01BC-D060-43BE-8503-9546407AB0AE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyleManager.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyleManager", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "ECBDDF53-74A4-4051-93FB-5E30DBAE051F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.BeamStyleManager.GetBeamStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.BeamStyleManager", 
		NodeName = "GetBeamStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("BeamStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetBeamStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBeamStyle(inputs[1].Value));

		}
	}
}
