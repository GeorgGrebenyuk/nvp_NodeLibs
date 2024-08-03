using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ObjectReinforcementModel 
{

	[NVP_Manifest(
		Id = "857F566F-1D62-4F1C-BFBD-803C0DE4E40E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectReinforcementModel.ObjectReinforcementModel_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectReinforcementModel", 
		NodeName = "_ObjectReinforcementModel_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectReinforcementModel_Constructor : INode 
	{
		public Renga.IObjectReinforcementModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectReinforcementModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "9C2F5E12-DFA3-48AB-98A9-0EF114858290", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectReinforcementModel.ObjectReinforcementModel_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectReinforcementModel", 
		NodeName = "_ObjectReinforcementModel_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectReinforcementModel_ConstructorCast : INode 
	{
		public Renga.IObjectReinforcementModel _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectReinforcementModel;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "25FB56B4-7224-4274-BF13-2AB3B4858CCD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectReinforcementModel.GetRebarUsages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectReinforcementModel", 
		NodeName = "GetRebarUsages", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectReinforcementModel", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRebarUsages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarUsages);

		}
	}


	[NVP_Manifest(
		Id = "157FFB6D-47E1-4FB7-912E-BC56A8C1FDC3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectReinforcementModel.GetReinforcementUnitUsages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectReinforcementModel", 
		NodeName = "GetReinforcementUnitUsages", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectReinforcementModel", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetReinforcementUnitUsages : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReinforcementUnitUsages);

		}
	}
}
