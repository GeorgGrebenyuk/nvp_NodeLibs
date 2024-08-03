using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.EquipmentStyleManager 
{

	[NVP_Manifest(
		Id = "56A99930-1936-4127-82C1-045605C015B3", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyleManager.EquipmentStyleManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyleManager", 
		NodeName = "_EquipmentStyleManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyleManager_Constructor : INode 
	{
		public Renga.IEquipmentStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IEquipmentStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "CB133064-67C4-436C-835A-03FA8579DCF9", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyleManager.EquipmentStyleManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyleManager", 
		NodeName = "_EquipmentStyleManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class EquipmentStyleManager_ConstructorCast : INode 
	{
		public Renga.IEquipmentStyleManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IEquipmentStyleManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "8E83A31D-F9F5-4763-B0E0-449128AFE611", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyleManager.GetIds", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyleManager", 
		NodeName = "GetIds", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("EquipmentStyleManager", typeof(object))]

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
		Id = "6D19534C-D711-47AA-8F63-1BE1C4CD9701", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyleManager.Contains", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyleManager", 
		NodeName = "Contains", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("EquipmentStyleManager", typeof(object))]
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
		Id = "091A60A9-D29C-408F-AFC3-5375001FB964", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.EquipmentStyleManager.GetEquipmentStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.EquipmentStyleManager", 
		NodeName = "GetEquipmentStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("EquipmentStyleManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetEquipmentStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEquipmentStyle(inputs[1].Value));

		}
	}
}
