using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.MaterialManager 
{

	[NVP_Manifest(
		Id = "6A751D16-7B60-4623-8220-E029085CBFBE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialManager.MaterialManager_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialManager", 
		NodeName = "_MaterialManager_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialManager_Constructor : INode 
	{
		public Renga.IMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E8518289-A9E0-4D7D-9446-4270EB8C0CEE", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialManager.MaterialManager_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialManager", 
		NodeName = "_MaterialManager_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MaterialManager_ConstructorCast : INode 
	{
		public Renga.IMaterialManager _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IMaterialManager;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "44F7AA02-0E75-4E58-85FC-756BEC439455", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.MaterialManager.GetMaterial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.MaterialManager", 
		NodeName = "GetMaterial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("MaterialManager", typeof(object))]
	[NodeInput("MaterialId", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetMaterial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMaterial(inputs[1].Value));

		}
	}
}
