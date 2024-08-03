using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.GridMaterial 
{

	[NVP_Manifest(
		Id = "6900B2CF-B6F7-4971-AFEA-0475BC0856DD", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridMaterial.GridMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridMaterial", 
		NodeName = "_GridMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridMaterial_Constructor : INode 
	{
		public Renga.IGridMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGridMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5D315A6C-DD5D-42C9-B7D4-61FF87D11B25", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridMaterial.GridMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridMaterial", 
		NodeName = "_GridMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridMaterial_ConstructorCast : INode 
	{
		public Renga.IGridMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGridMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0ED8E34D-423A-43D0-8118-3122BAA3A784", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridMaterial.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridMaterial", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridMaterial", typeof(object))]

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
		Id = "E5ADE5A0-7638-460E-A294-C96966257572", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridMaterial.Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridMaterial", 
		NodeName = "Color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Color);

		}
	}


	[NVP_Manifest(
		Id = "7EF68E7A-E567-4B2F-A98B-823203BD1A56", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridMaterial.GetColorComponents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridMaterial", 
		NodeName = "GetColorComponents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("GridMaterial", typeof(object))]
	[NodeInput("short*", typeof(System.Object))]
	[NodeInput("short*", typeof(System.Object))]
	[NodeInput("short*", typeof(System.Object))]
	[NodeInput("short*", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetColorComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetColorComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}
}
