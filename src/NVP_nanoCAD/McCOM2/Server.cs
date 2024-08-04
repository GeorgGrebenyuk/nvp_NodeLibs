using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///McCOM application object
///</summary>
namespace McCOM2.Server 
{

	[NVP_Manifest(
		Id = "D145767D-1496-4760-8546-66A291B3FFB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Server_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "_Server_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server_Constructor : INode 
	{
		public McCOM2.IServer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as McCOM2.IServer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B08574ED-CE8A-4F99-82C2-B80A82D654E1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Server_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "_Server_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Server_ConstructorCast : INode 
	{
		public McCOM2.IServer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as McCOM2.IServer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "0CA43938-069D-4330-9582-BE9F83C82337", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Properties", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Properties", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000ca", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000ca
	///</summary>
	public class Properties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Properties);

		}
	}


	[NVP_Manifest(
		Id = "129A0BFA-7684-4E4C-B7AE-533C05B7D2AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Title", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Title", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000cc", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cc
	///</summary>
	public class Title : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Title);

		}
	}


	[NVP_Manifest(
		Id = "7C2A65ED-FFC9-4400-B9DC-1CA630E9AE2A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.DimScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "DimScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c8", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000c8
	///</summary>
	public class DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimScale);

		}
	}


	[NVP_Manifest(
		Id = "3433F9E4-12D7-41EE-A06E-D6F0914E7ABD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Set_DimScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Set_DimScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c8", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("prDimScale", typeof(System.Double))]

	///<summary>
	///0x000000c8
	///</summary>
	public class Set_DimScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9F860C4E-BAA5-4E1B-879A-FDEF53A7A80A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.ViewScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "ViewScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000cd", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cd
	///</summary>
	public class ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewScale);

		}
	}


	[NVP_Manifest(
		Id = "6B8E4C97-DC64-4EA5-858A-C038E23B9C7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Set_ViewScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Set_ViewScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000cd", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("prViewScale", typeof(System.Double))]

	///<summary>
	///0x000000cd
	///</summary>
	public class Set_ViewScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E73CAF3A-1CA3-4BC7-AF29-CEDF8BC1539D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Scales", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Scales", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000cb", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]

	///<summary>
	///0x000000cb
	///</summary>
	public class Scales : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scales);

		}
	}


	[NVP_Manifest(
		Id = "6B03FD92-9DC1-46DA-BA85-122FA932A50F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.ScaleToStr", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "ScaleToStr", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c6", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("rScale", typeof(System.Double))]

	///<summary>
	///0x000000c6
	///</summary>
	public class ScaleToStr : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleToStr(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "03F301D6-4612-45B6-BD92-353B3D36A6AB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.ScaleFromStr", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "ScaleFromStr", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c5", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrScale", typeof(System.String))]

	///<summary>
	///0x000000c5
	///</summary>
	public class ScaleFromStr : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFromStr(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "F3B3B1B5-0DF1-4ED1-BF05-4D488EA3E85C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Object", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Object", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c9", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("vID", typeof(System.Object))]

	///<summary>
	///0x000000c9
	///</summary>
	public class Object : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Object(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "B98A93D5-D8EE-47AA-B9A9-229CC1AE17FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.CreateObject", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "CreateObject", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c1", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrClass", typeof(System.String))]

	///<summary>
	///0x000000c1
	///</summary>
	public class CreateObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D7E58D2F-532A-491B-ADA8-41824C3D952C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Query", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Query", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c3", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrClasses", typeof(System.Object))]
	[NodeInput("vProps", typeof(System.Object))]
	[NodeInput("rBoundBlock", typeof(System.Object))]

	///<summary>
	///0x000000c3
	///</summary>
	public class Query : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Query(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "9CE01C22-221B-4E64-B178-3D59F3F489D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Select", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Select", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c7", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrPropmt", typeof(System.String))]
	[NodeInput("bSingleObject", typeof(System.Object))]

	///<summary>
	///0x000000c7
	///</summary>
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Select(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "590A1898-4019-4826-9D37-5F671065A70D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.RegisterCalculator", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "RegisterCalculator", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c4", 
		ViewType = "Modifier")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]
	[NodeInput("bstrSubName", typeof(System.String))]
	[NodeInput("vScriptId", typeof(System.Object))]
	[NodeInput("bstrCLSID", typeof(System.String))]

	///<summary>
	///0x000000c4
	///</summary>
	public class RegisterCalculator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RegisterCalculator(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "381CE11F-72CC-45A6-8C99-C342CFA91BC6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.Server.Message", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.Server", 
		NodeName = "Message", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "0x000000c2", 
		ViewType = "Data")]
	[NodeInput("Server", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]
	[NodeInput("McCOM2.MessageIcon", typeof(System.Object))]
	[NodeInput("idParent", typeof(System.Object))]

	///<summary>
	///0x000000c2
	///</summary>
	public class Message : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Message(inputs[1].Value,((McCOM2.MessageIcon)inputs[2].Value),inputs[3].Value));

		}
	}
}
