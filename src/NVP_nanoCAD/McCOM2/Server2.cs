using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///McCOM application object
///</summary>
namespace McCOM2.Server2 
{

	[NVP_Manifest(
		Id = "52300F22-0154-45FD-9EB5-EDFDDC12F594", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server2.Server2_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server2", 
		NodeName = "_Server2_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server2_Constructor : INode 
	{
		public McCOM2.IServer2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IServer2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "21EBC5BB-591F-4054-A1C3-63FAB127017D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server2.Server2_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server2", 
		NodeName = "_Server2_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server2_ConstructorCast : INode 
	{
		public McCOM2.IServer2 _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IServer2;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "E304DDD5-21D0-4418-9D85-1CCC0B954F85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server2.Message64", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server2", 
		NodeName = "Message64", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000607", 
		ViewType = "Data")]
	[NodeInput("Server2", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	[NodeInput("McCOM2.MessageIcon", typeof(System.Object))]
	[NodeInput("vParent", typeof(System.Object))]

	///<summary>
	///0x00000607
	///</summary>
	public class Message64 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Message64(inputs[1].Value,((McCOM2.MessageIcon)inputs[2].Value),inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "A10AD7EB-C756-4401-B208-AF5BE85239E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server2.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server2", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x00000608", 
		ViewType = "Modifier")]
	[NodeInput("Server2", typeof(object))]

	///<summary>
	///0x00000608
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}
}
