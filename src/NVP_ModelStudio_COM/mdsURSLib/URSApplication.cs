using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IURSApplication Interface
///</summary>
namespace mdsURSLib.URSApplication 
{

	[NVP_Manifest(
		Id = "E2FFA658-19C1-4CFE-AFC0-EC7EFCC0412E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.URSApplication_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "_URSApplication_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSApplication_Constructor : INode 
	{
		public mdsURSLib.IURSApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IURSApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "77535557-4ED1-4E1C-93BB-D0A568ED0443", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.URSApplication_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "_URSApplication_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class URSApplication_ConstructorCast : INode 
	{
		public mdsURSLib.IURSApplication _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IURSApplication;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "CFD3E0F5-96AF-4BAE-8DDE-E40D8B0C8C00", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.CreateReport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "CreateReport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method CreateReport", 
		ViewType = "Data")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("Profile", typeof(System.Object))]

	///<summary>
	///method CreateReport
	///</summary>
	public class CreateReport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateReport(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "0454BA1F-A229-46E6-B621-57EB3D6ADBF4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.BindData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "BindData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method BindData", 
		ViewType = "Modifier")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("DataSource", typeof(System.Object))]
	[NodeInput("DataOutputObject", typeof(System.Object))]
	[NodeInput("GraphicsBinding", typeof(System.Object))]

	///<summary>
	///method BindData
	///</summary>
	public class BindData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindData(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B16F6248-6C82-4041-97C0-EE8E3E2F0C0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.Query", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "Query", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method Query", 
		ViewType = "Data")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("pDataSource", typeof(System.Object))]
	[NodeInput("Query", typeof(System.String))]

	///<summary>
	///method Query
	///</summary>
	public class Query : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Query(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Id = "C858B6CA-A09C-4C99-90DB-20C41AF174B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.URSApplication.BindAttributeData", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.URSApplication", 
		NodeName = "BindAttributeData", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "method BindAttributeData", 
		ViewType = "Modifier")]
	[NodeInput("URSApplication", typeof(object))]
	[NodeInput("DataSource", typeof(System.Object))]
	[NodeInput("BlockReference", typeof(System.Object))]
	[NodeInput("AttrName", typeof(System.String))]
	[NodeInput("Query", typeof(System.String))]
	[NodeInput("GraphicsBinding", typeof(System.Object))]

	///<summary>
	///method BindAttributeData
	///</summary>
	public class BindAttributeData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BindAttributeData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}
}
