using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Polyline based symbol
///</summary>
namespace McCOM2.SymPolyline 
{

	[NVP_Manifest(
		Id = "A584690E-EB74-465E-A5A1-D59AAE1A9373", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.SymPolyline_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "_SymPolyline_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPolyline_Constructor : INode 
	{
		public McCOM2.ISymPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.ISymPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E2B7EC3A-A551-4D8C-A43A-88B1490D151C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.SymPolyline_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "_SymPolyline_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class SymPolyline_ConstructorCast : INode 
	{
		public McCOM2.ISymPolyline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.ISymPolyline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A687E954-DE0B-4A96-8216-0E6BE8D37A9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057c", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]

	///<summary>
	///0x0000057c
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
		Id = "635A3F87-D7B3-4D90-8688-0B123195EA93", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Set_Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Set_Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057c", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("pnValue", typeof(System.Object))]

	///<summary>
	///0x0000057c
	///</summary>
	public class Set_Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Count = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9DEECB25-2DE2-4900-A6A7-5A944209197A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Points", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Points", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057d", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000057d
	///</summary>
	public class Points : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Points(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "05E751F8-AB41-41A1-A3AB-DD5AD132DAEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Set_Points", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Set_Points", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057d", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("pvPoint", typeof(System.Object))]

	///<summary>
	///0x0000057d
	///</summary>
	public class Set_Points : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Points[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4905E85A-1EE1-4476-AFD7-3E8B0974497F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Bulges", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Bulges", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057e", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///0x0000057e
	///</summary>
	public class Bulges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bulges(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "786DDB4C-2E56-4F06-A682-0145FC333EE0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Set_Bulges", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Set_Bulges", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057e", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("prValue", typeof(System.Double))]

	///<summary>
	///0x0000057e
	///</summary>
	public class Set_Bulges : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bulges[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B825C29C-2C89-4618-93FF-0F9E869EF300", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057f", 
		ViewType = "Data")]
	[NodeInput("SymPolyline", typeof(object))]

	///<summary>
	///0x0000057f
	///</summary>
	public class Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Closed);

		}
	}


	[NVP_Manifest(
		Id = "CD190A69-7DF4-4E95-87C4-10BE3243CA23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.SymPolyline.Set_Closed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.SymPolyline", 
		NodeName = "Set_Closed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x0000057f", 
		ViewType = "Modifier")]
	[NodeInput("SymPolyline", typeof(object))]
	[NodeInput("pvbValue", typeof(System.Object))]

	///<summary>
	///0x0000057f
	///</summary>
	public class Set_Closed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Closed = inputs[1].Value;
			return null;
		}
	}
}
