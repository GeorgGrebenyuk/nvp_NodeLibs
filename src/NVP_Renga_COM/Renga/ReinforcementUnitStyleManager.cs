using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ReinforcementUnitStyleManager 
{

	[NVP_Manifest(
		Id = "2575B0AE-968A-48A1-B3A8-6036B1A8530D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.ReinforcementUnitStyleManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "_ReinforcementUnitStyleManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyleManager_Constructor : INode 
	{
		public Renga.IReinforcementUnitStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IReinforcementUnitStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "AFB1A6E7-640D-4333-A8D1-FAC7806ACDFD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.ReinforcementUnitStyleManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "_ReinforcementUnitStyleManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ReinforcementUnitStyleManager_ConstructorCast : INode 
	{
		public Renga.IReinforcementUnitStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IReinforcementUnitStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5FF0A7F6-C868-44BF-A194-70C0463A0EC9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.GetRebarStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "GetRebarStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("rebarStyleId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetRebarStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetRebarStyle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "661A1142-2519-40F0-8C76-E7D91C721B90", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.GetRebarStyleIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "GetRebarStyleIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetRebarStyleIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRebarStyleIds();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1080E408-4526-4303-9C07-33766DD803B7", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.RebarStyleExists", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "RebarStyleExists", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("rebarStyleId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class RebarStyleExists : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RebarStyleExists(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "2A0CEFD9-EF8A-4B63-B357-B0340DED7688", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.GetUnitStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "GetUnitStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("reinforcementUnitStyleId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetUnitStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetUnitStyle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "BB3D4B4F-6BC4-4DC1-A1E2-F72BFA7AEA8E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.UnitStyleExists", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "UnitStyleExists", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]
	[NodeInput("reinforcementUnitStyleId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class UnitStyleExists : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitStyleExists(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "77807932-FAE0-45DC-9543-0B4F84AC1871", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ReinforcementUnitStyleManager.GetReinforcementUnitStyleIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ReinforcementUnitStyleManager", 
		NodeName = "GetReinforcementUnitStyleIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("ReinforcementUnitStyleManager", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetReinforcementUnitStyleIds : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetReinforcementUnitStyleIds();
			return null;
		}
	}
}
