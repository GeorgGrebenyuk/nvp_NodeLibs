using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Radius dimension
///</summary>
namespace McCOM2.SymDimRadius 
{

	[NVP_Manifest(
		Id = "7452E8FD-022C-40DD-8799-307F23BF7CD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.SymDimRadius_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "_SymDimRadius_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimRadius_Constructor : INode 
	{
		public McCOM2.ISymDimRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymDimRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C219E9FF-1F8E-4E41-ACD0-683E46E59F8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.SymDimRadius_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "_SymDimRadius_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymDimRadius_ConstructorCast : INode 
	{
		public McCOM2.ISymDimRadius _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymDimRadius;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "89465BC6-1289-48BC-B7D2-F981133BFBE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001f5", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001f5
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Id = "7037E2A7-34C9-4FF8-8943-B5BC6716E3F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Set_Position", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Set_Position", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001f5", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001f5
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A277DECF-D5A6-4AF0-A436-6601022F1DC0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001e6", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001e6
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "622AF5AD-CD02-46F8-B03B-C5144BE0D91F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001e6", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x000001e6
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DF9E9A65-705A-446D-9E12-2049351AABB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001e3", 
		ViewType = "Data")]
	[NodeInput("SymDimRadius", typeof(object))]

	///<summary>
	///0x000001e3
	///</summary>
	public class Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Arrow);

		}
	}


	[NVP_Manifest(
		Id = "AC6468EB-4BF0-4046-9DC9-2C7114142803", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymDimRadius.Set_Arrow", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymDimRadius", 
		NodeName = "Set_Arrow", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000001e3", 
		ViewType = "Modifier")]
	[NodeInput("SymDimRadius", typeof(object))]
	[NodeInput("McCOM2.ArrowType", typeof(System.Object))]

	///<summary>
	///0x000001e3
	///</summary>
	public class Set_Arrow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Arrow = ((McCOM2.ArrowType)inputs[1].Value);
			return null;
		}
	}
}
