using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.ObjectOnRoutePlacement 
{

	[NVP_Manifest(
		Id = "70FB43F3-C9AB-4FF5-83BF-58A95B0ACB0B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectOnRoutePlacement.ObjectOnRoutePlacement_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectOnRoutePlacement", 
		NodeName = "_ObjectOnRoutePlacement_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectOnRoutePlacement_Constructor : INode 
	{
		public Renga.IObjectOnRoutePlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IObjectOnRoutePlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "334102A5-7B94-45C6-9751-632E4A66DA3A", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectOnRoutePlacement.ObjectOnRoutePlacement_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectOnRoutePlacement", 
		NodeName = "_ObjectOnRoutePlacement_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class ObjectOnRoutePlacement_ConstructorCast : INode 
	{
		public Renga.IObjectOnRoutePlacement _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IObjectOnRoutePlacement;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "85C08467-4A3B-4F2C-8064-FBC7F2A7176E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectOnRoutePlacement.Id", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectOnRoutePlacement", 
		NodeName = "Id", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectOnRoutePlacement", typeof(object))]

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
		Id = "685B7C4F-ED04-4C8A-AD33-6B106A433653", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.ObjectOnRoutePlacement.parameter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.ObjectOnRoutePlacement", 
		NodeName = "parameter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("ObjectOnRoutePlacement", typeof(object))]

	///<summary>
	///
	///</summary>
	public class parameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.parameter);

		}
	}
}
