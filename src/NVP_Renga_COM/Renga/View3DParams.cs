using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.View3DParams 
{

	[NVP_Manifest(
		Id = "1E8C3828-3EAC-4503-813F-F8B2FD94D8A5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View3DParams.View3DParams_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View3DParams", 
		NodeName = "_View3DParams_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class View3DParams_Constructor : INode 
	{
		public Renga.IView3DParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IView3DParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "82514584-D63A-4271-BA74-D9E0AD3CF47C", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View3DParams.View3DParams_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View3DParams", 
		NodeName = "_View3DParams_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class View3DParams_ConstructorCast : INode 
	{
		public Renga.IView3DParams _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IView3DParams;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C8CC9C9F-EDCE-4571-A0B1-0D125C190DB1", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.View3DParams.Camera", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.View3DParams", 
		NodeName = "Camera", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("View3DParams", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Camera : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Camera);

		}
	}
}
