using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ReinforcementUnitUsageCollection 
{

	[NVP_Manifest(
		Id = "935F1156-A1D4-4299-9E5A-88EFB1F6F5FD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsageCollection.ReinforcementUnitUsageCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsageCollection", 
		NodeName = "_ReinforcementUnitUsageCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsageCollection_Constructor : INode 
	{
		public Renga.IReinforcementUnitUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "FC49C45D-C8CD-48E9-9FDD-919E0CA9A612", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsageCollection.ReinforcementUnitUsageCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsageCollection", 
		NodeName = "_ReinforcementUnitUsageCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitUsageCollection_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitUsageCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitUsageCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "687B85DA-6AE3-4399-BC81-8DF65C7CF33B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsageCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsageCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsageCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "AB876DD9-3AD0-4E50-9037-22353BBC6D6A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitUsageCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitUsageCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitUsageCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}
}
