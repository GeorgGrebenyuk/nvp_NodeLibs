using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Layer 
{

	[NVP_Manifest(
		Id = "8F846B74-B599-494C-8939-DDEF262BBF46", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Layer.Layer_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Layer", 
		NodeName = "_Layer_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Layer_Constructor : INode 
	{
		public Renga.ILayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ILayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F43867A3-EBBB-476A-9CC8-900CF4208141", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Layer.Layer_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Layer", 
		NodeName = "_Layer_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Layer_ConstructorCast : INode 
	{
		public Renga.ILayer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ILayer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C1C00CD6-63C9-4106-B38D-69BE6F3946F4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Layer.MaterialId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Layer", 
		NodeName = "MaterialId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Layer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MaterialId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaterialId);

		}
	}


	[NVP_Manifest(
		Id = "DAEDB8F1-53EC-465E-ACA3-50C869341A14", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Layer.GetQuantities", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Layer", 
		NodeName = "GetQuantities", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Layer", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetQuantities : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetQuantities);

		}
	}
}
