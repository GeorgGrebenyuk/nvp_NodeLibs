using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ReinforcementUnitStyle 
{

	[NVP_Manifest(
		Id = "931B20BF-31B9-4AD9-8FE3-586145B8FBED", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.ReinforcementUnitStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "_ReinforcementUnitStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyle_Constructor : INode 
	{
		public Renga.IReinforcementUnitStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "57DB1321-688B-4992-99BD-9FCBDFA21229", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.ReinforcementUnitStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "_ReinforcementUnitStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyle_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "9973CF3F-D30D-431D-B7CB-6CBDBF107F1D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		Id = "A398E905-F99B-425C-B856-D8A14DC67F07", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "C7D2A9D1-AEDA-4325-80E3-1D6D4E3F0993", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.GetRebarUsages", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "GetRebarUsages", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyle", typeof(object))]

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
		Id = "6A0DFF70-7F3F-4EE0-9B73-B081D15B3DD6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyle.UnitType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyle", 
		NodeName = "UnitType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyle", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UnitType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitType);

		}
	}
}
