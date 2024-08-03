using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.GridWithMaterial 
{

	[NVP_Manifest(
		Id = "59883BCD-8D61-4B66-889D-4E5270A52593", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterial.GridWithMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterial", 
		NodeName = "_GridWithMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterial_Constructor : INode 
	{
		public Renga.IGridWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGridWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "96830155-18E0-476D-9330-89F1FEAF6408", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterial.GridWithMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterial", 
		NodeName = "_GridWithMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class GridWithMaterial_ConstructorCast : INode 
	{
		public Renga.IGridWithMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGridWithMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E58FB895-DDD3-49C9-B48D-2B2869ECAE27", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterial.Grid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterial", 
		NodeName = "Grid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridWithMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Grid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Grid);

		}
	}


	[NVP_Manifest(
		Id = "57232A5E-5E1B-4A7B-BDB0-32F5FC3942DA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.GridWithMaterial.Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.GridWithMaterial", 
		NodeName = "Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("GridWithMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Material);

		}
	}
}
