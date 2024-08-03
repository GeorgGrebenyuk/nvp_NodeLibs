using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Material 
{

	[NVP_Manifest(
		Id = "F37E2ADD-E54D-452F-B9C8-BC6F3F330AAC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Material_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "_Material_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Material_Constructor : INode 
	{
		public Renga.IMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2D6139AD-DB88-4393-89F3-878891504249", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Material_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "_Material_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Material_ConstructorCast : INode 
	{
		public Renga.IMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0BD63E3A-E52E-4F1F-B803-FA4B0BDF2DB6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Material", typeof(object))]

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
		Id = "0CAEB326-320A-4A10-91DC-0DB6317C189E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Material", typeof(object))]

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
		Id = "B1A92D68-4D56-4374-AC2D-B018B454AF81", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Density", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "Density", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Material", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Density : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Density);

		}
	}


	[NVP_Manifest(
		Id = "82D427FA-0F7E-4D30-B4BD-87C2531CD5F5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Material.Color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Material", 
		NodeName = "Color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Material", typeof(object))]

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
}
