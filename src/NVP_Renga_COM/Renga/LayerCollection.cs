using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.LayerCollection 
{

	[NVP_Manifest(
		Id = "BEBB8AF0-E3E5-4DD4-85FC-FA78057AD537", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayerCollection.LayerCollection_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayerCollection", 
		NodeName = "_LayerCollection_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayerCollection_Constructor : INode 
	{
		public Renga.ILayerCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayerCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B5C500C9-F855-43B6-94CC-729F4595FB84", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayerCollection.LayerCollection_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayerCollection", 
		NodeName = "_LayerCollection_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class LayerCollection_ConstructorCast : INode 
	{
		public Renga.ILayerCollection _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayerCollection;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "B6E02BE0-3FF6-4A52-8770-11B30490B167", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayerCollection.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayerCollection", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayerCollection", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "02EA0B24-4C39-499D-8870-27A183E6247D", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.LayerCollection.Get", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.LayerCollection", 
		NodeName = "Get", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("LayerCollection", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}
}
