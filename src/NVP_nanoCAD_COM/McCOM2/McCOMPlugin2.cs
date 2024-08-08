using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMcCOMPlugin Interface
///</summary>
namespace McCOM2.McCOMPlugin2 
{

	[NVP_Manifest(
		Id = "D00EBA58-50EB-455E-BD7D-06ED51BE60D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMPlugin2.McCOMPlugin2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMPlugin2", 
		NodeName = "_McCOMPlugin2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMPlugin2_Constructor : INode 
	{
		public McCOM2.IMcCOMPlugin2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IMcCOMPlugin2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "280631E3-5EEE-4122-99E9-374A3AD67B8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMPlugin2.McCOMPlugin2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMPlugin2", 
		NodeName = "_McCOMPlugin2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class McCOMPlugin2_ConstructorCast : INode 
	{
		public McCOM2.IMcCOMPlugin2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IMcCOMPlugin2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "768ECC5C-9631-4398-A677-D49FBB9F0FED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.McCOMPlugin2.Activate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.McCOMPlugin2", 
		NodeName = "Activate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Activate", 
		ViewType = "Modifier")]
	[NodeInput("McCOMPlugin2", typeof(object))]
	[NodeInput("pServer", typeof(System.Object))]

	///<summary>
	///method Activate
	///</summary>
	public class Activate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Activate(inputs[1].Value);
			return null;
		}
	}
}
