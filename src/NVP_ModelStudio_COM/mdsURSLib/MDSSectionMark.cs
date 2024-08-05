using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSSectionMark Interface
///</summary>
namespace mdsURSLib.MDSSectionMark 
{

	[NVP_Manifest(
		Id = "7606F641-4EBA-49C7-BC99-DE542D4A0C75", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.MDSSectionMark_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "_MDSSectionMark_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionMark_Constructor : INode 
	{
		public mdsURSLib.IMDSSectionMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsURSLib.IMDSSectionMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "E74DBEFC-4455-477C-9A25-CC5526A56F94", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.MDSSectionMark_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "_MDSSectionMark_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSSectionMark_ConstructorCast : INode 
	{
		public mdsURSLib.IMDSSectionMark _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsURSLib.IMDSSectionMark;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "EE937C34-4C81-48C4-A22D-C0653BB8BDB5", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.SectNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "SectNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер разреза", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Номер разреза
	///</summary>
	public class SectNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectNumber);

		}
	}


	[NVP_Manifest(
		Id = "0CE408BD-7A9D-4ACB-B5A2-67CCF00661D4", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_SectNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_SectNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер разреза", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Номер разреза
	///</summary>
	public class Set_SectNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SectNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A2A3661C-FD4E-4FC0-8800-933BDE661741", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.PageNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "PageNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер листа", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Номер листа
	///</summary>
	public class PageNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PageNumber);

		}
	}


	[NVP_Manifest(
		Id = "BE2BBA6C-AE48-4FD5-8112-6BFD88CE42F0", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_PageNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_PageNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер листа", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.String))]

	///<summary>
	///Номер листа
	///</summary>
	public class Set_PageNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PageNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "91CD3774-B10E-4F83-A9D5-688F92DC5990", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.ViewportType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "ViewportType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Тип
	///</summary>
	public class ViewportType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewportType);

		}
	}


	[NVP_Manifest(
		Id = "D8D43454-FEA8-4592-836A-F137BE56FA84", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

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
		Id = "960571E2-0131-42A8-B636-C2C469FDCD9C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Стиль текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.String))]

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
		Id = "A5EC4811-8934-4FF4-A04C-1971F309A2AB", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.NumbTxtHght", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "NumbTxtHght", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота номера разреза", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Высота номера разреза
	///</summary>
	public class NumbTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumbTxtHght);

		}
	}


	[NVP_Manifest(
		Id = "6CCAB4B4-A21D-43D3-A1BD-97C9BB9D47F9", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_NumbTxtHght", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_NumbTxtHght", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота номера разреза", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Высота номера разреза
	///</summary>
	public class Set_NumbTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumbTxtHght = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4390694D-3153-4153-8E8F-C4F62737BC3C", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.PageTxtHght", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "PageTxtHght", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота номера листа", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Высота номера листа
	///</summary>
	public class PageTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PageTxtHght);

		}
	}


	[NVP_Manifest(
		Id = "48CA0DD3-0E40-4802-B39B-1FD3DA79ADD1", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_PageTxtHght", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_PageTxtHght", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота номера листа", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Высота номера листа
	///</summary>
	public class Set_PageTxtHght : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PageTxtHght = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "350A44B5-2F04-498E-8B79-1470D7B864E8", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.StrokeLng", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "StrokeLng", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина штриха", 
		ViewType = "Data")]
	[NodeInput("MDSSectionMark", typeof(object))]

	///<summary>
	///Длина штриха
	///</summary>
	public class StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StrokeLng);

		}
	}


	[NVP_Manifest(
		Id = "CAF96606-15CC-4589-8795-CF3ECDAC2C35", 
		PathAssembly = "NVP_ModelStudio_COM.dll", 
		PathExecuteClass = "mdsURSLib.MDSSectionMark.Set_StrokeLng", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsURSLib.MDSSectionMark", 
		NodeName = "Set_StrokeLng", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Длина штриха", 
		ViewType = "Modifier")]
	[NodeInput("MDSSectionMark", typeof(object))]
	[NodeInput("pv", typeof(System.Double))]

	///<summary>
	///Длина штриха
	///</summary>
	public class Set_StrokeLng : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StrokeLng = inputs[1].Value;
			return null;
		}
	}
}
