using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ObjectWithLayeredMaterial 
{

	[NVP_Manifest(
		Id = "13F67451-A921-4F40-AACB-B5D8C6F556BC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.ObjectWithLayeredMaterial_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "_ObjectWithLayeredMaterial_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithLayeredMaterial_Constructor : INode 
	{
		public Renga.IObjectWithLayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectWithLayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "08429363-0DFE-4A3A-98BB-D464EE1150DB", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.ObjectWithLayeredMaterial_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "_ObjectWithLayeredMaterial_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectWithLayeredMaterial_ConstructorCast : INode 
	{
		public Renga.IObjectWithLayeredMaterial _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectWithLayeredMaterial;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "F6867AE5-BCE6-4173-BC38-B780F3C19AFC", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.GetLayeredMaterialIdGroupPair", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "GetLayeredMaterialIdGroupPair", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterialIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterialIdGroupPair);

		}
	}


	[NVP_Manifest(
		Id = "BA6A2EB7-5ECF-415A-81CF-17EE3223B567", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.HasLayeredMaterial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "HasLayeredMaterial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasLayeredMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasLayeredMaterial);

		}
	}


	[NVP_Manifest(
		Id = "DDEFB9D5-DDCF-4346-99A7-90344219FF21", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.GetLayers", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "GetLayers", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLayers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayers);

		}
	}


	[NVP_Manifest(
		Id = "6F36594D-8AF7-43CF-ABC0-3DE1462D9290", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectWithLayeredMaterial.LayeredMaterialId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectWithLayeredMaterial", 
		NodeName = "LayeredMaterialId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectWithLayeredMaterial", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LayeredMaterialId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayeredMaterialId);

		}
	}
}
