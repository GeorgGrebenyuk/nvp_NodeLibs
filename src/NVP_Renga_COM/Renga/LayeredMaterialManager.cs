using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LayeredMaterialManager 
{

	[NVP_Manifest(
		Id = "A4820F81-4CFC-450B-B8B9-2400F498046F", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterialManager.LayeredMaterialManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterialManager", 
		NodeName = "_LayeredMaterialManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_Constructor : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "45C8E04C-5B16-4CCA-9189-4F1873F11102", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterialManager.LayeredMaterialManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterialManager", 
		NodeName = "_LayeredMaterialManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayeredMaterialManager_ConstructorCast : INode 
	{
		public Renga.ILayeredMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayeredMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "50B396D2-D456-45F1-8617-BEE64D217A99", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterialManager.GetLayeredMaterialByIdGroupPair", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterialManager", 
		NodeName = "GetLayeredMaterialByIdGroupPair", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("LayeredMaterialIdGroupPair", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterialByIdGroupPair : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterialByIdGroupPair(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "76344762-9FDB-4D66-8B75-C7F5817FBAD1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayeredMaterialManager.GetLayeredMaterial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayeredMaterialManager", 
		NodeName = "GetLayeredMaterial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayeredMaterialManager", typeof(object))]
	[NodeInput("Id", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetLayeredMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLayeredMaterial(inputs[1].Value));

		}
	}
}
