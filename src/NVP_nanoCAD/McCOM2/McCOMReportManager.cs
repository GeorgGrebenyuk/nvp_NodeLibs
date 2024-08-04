using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMReportManager Interface
///</summary>
namespace McCOM2.McCOMReportManager 
{

	[NVP_Manifest(
		Id = "097EADA0-DA37-4908-B234-E409E4DEA7CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMReportManager.McCOMReportManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMReportManager", 
		NodeName = "_McCOMReportManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMReportManager_Constructor : INode 
	{
		public McCOM2.IMcCOMReportManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMReportManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "70224F1C-DBE8-4870-B3E0-51B4782E268F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMReportManager.McCOMReportManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMReportManager", 
		NodeName = "_McCOMReportManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMReportManager_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMReportManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMReportManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3BFD4CD7-DC90-4420-998F-36E7BE4AEF99", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMReportManager.AddKeyword", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMReportManager", 
		NodeName = "AddKeyword", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method AddKeyword", 
		ViewType = "Modifier")]
	[NodeInput("McCOMReportManager", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///method AddKeyword
	///</summary>
	public class AddKeyword : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddKeyword(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
