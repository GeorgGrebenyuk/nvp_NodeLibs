using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSAxis Interface
///</summary>
namespace mdsURSLib.MDSAxis 
{

	[NVP_Manifest(
		Id = "2A5CD809-8D28-452D-A979-1DC6F91CBB8B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.MDSAxis_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "_MDSAxis_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxis_Constructor : INode 
	{
		public mdsURSLib.IMDSAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A5C647A0-D617-4E6A-9DCF-CDE34CCE36E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.MDSAxis_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "_MDSAxis_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSAxis_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "5F88E3CD-256B-4A76-8722-2DC3845B3263", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование сетки", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Наименование сетки
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "711914CD-48AF-4551-A9EB-FB548A505AF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование сетки", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование сетки
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C5167C4C-9E32-4F40-9153-7F5163FBF4E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Parameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры сетки", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Параметры сетки
	///</summary>
	public class Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Parameters);

		}
	}


	[NVP_Manifest(
		Id = "92E47E29-B19B-4532-9213-0BE4AA33147F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Set_Parameters", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Set_Parameters", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры сетки", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры сетки
	///</summary>
	public class Set_Parameters : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Parameters = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FAFA20A3-94F4-4D19-B2EC-CB8419718C62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начало координат", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Начало координат
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Id = "FF9DBF11-387C-47FF-B12D-DD8DA8B16106", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Set_Origin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Set_Origin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начало координат", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Начало координат
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "744B7383-72B8-407F-AEC5-F3D8E4569C03", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Стиль текста
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Id = "8E27A9EE-F104-4A61-8101-48C659489146", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Стиль текста
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "64FFDCAD-24F9-4132-BAB6-6C34AC1CC6C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер текста", 
		ViewType = "Data")]
	[NodeInput("MDSAxis", typeof(object))]

	///<summary>
	///Размер текста
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "6440D50C-E53E-49A1-8D86-9E54EA0CBDEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSAxis.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSAxis", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Размер текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Размер текста
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}
}
