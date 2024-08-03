using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSViewportDef Interface
///</summary>
namespace mdsUnitsLib.MDSViewportDef 
{

	[NVP_Manifest(
		Id = "68B7E36D-C5BB-4305-9463-6E2A6A836C24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.MDSViewportDef_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "_MDSViewportDef_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportDef_Constructor : INode 
	{
		public mdsUnitsLib.IMDSViewportDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSViewportDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "C29FE188-71C8-4910-A4A1-82C1EA9310BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.MDSViewportDef_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "_MDSViewportDef_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportDef_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSViewportDef _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSViewportDef;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BC2CD3B5-AB86-4E17-A431-A812C3F897FD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование видового куба", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Наименование видового куба
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
		Id = "2B18B3CE-37F6-4D58-B5F4-F8C9C18BCA21", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование видового куба", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование видового куба
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
		Id = "680F9889-62C6-4C4F-B1CE-B32B41D56484", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.ViewportType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "ViewportType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип видового куба", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Тип видового куба
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
		Id = "34A9AE11-681F-4D83-904E-61F4D32FA580", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_ViewportType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_ViewportType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Тип видового куба", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип видового куба
	///</summary>
	public class Set_ViewportType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewportType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "52B5B9FE-6AA2-478B-895C-303179DC3DDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Базовая точка", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Базовая точка
	///</summary>
	public class BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BasePoint);

		}
	}


	[NVP_Manifest(
		Id = "5D05BAC7-BC3E-4EF9-82C3-F76411A9D8DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_BasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_BasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Базовая точка", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Базовая точка
	///</summary>
	public class Set_BasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "488BA9D0-D9F7-4AC5-9BF7-FFF3158C1364", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Ширина
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "9B4482A6-132C-4CCC-8F0F-79CE39381E72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Ширина", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Ширина
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DA2EC275-E48B-4006-8B2C-57DDE682EE60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Depth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Depth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Глубина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Глубина
	///</summary>
	public class Depth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Depth);

		}
	}


	[NVP_Manifest(
		Id = "02B0C402-2436-45AB-8DE8-BADBE969841C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_Depth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_Depth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Глубина", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Глубина
	///</summary>
	public class Set_Depth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Depth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DEA79913-A99E-4CCD-93C1-60996BE418C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Высота
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "A0DABF38-B3C8-454D-AF48-2864B85D5777", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4D3DCC77-95FB-4D39-B8D8-279FD3C6E426", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.FrontClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "FrontClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак обрезки вида по передней грани", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Признак обрезки вида по передней грани
	///</summary>
	public class FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontClip);

		}
	}


	[NVP_Manifest(
		Id = "6742FF9E-BBBD-447F-B7BB-0E9F1A33623E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_FrontClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_FrontClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак обрезки вида по передней грани", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак обрезки вида по передней грани
	///</summary>
	public class Set_FrontClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8B651FAB-59D1-477F-99E8-0529E4238D09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.BackClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "BackClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак обрезки вида по задней грани", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Признак обрезки вида по задней грани
	///</summary>
	public class BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackClip);

		}
	}


	[NVP_Manifest(
		Id = "B0BA2652-016E-465B-B809-800E972A04B5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_BackClip", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_BackClip", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Признак обрезки вида по задней грани", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Признак обрезки вида по задней грани
	///</summary>
	public class Set_BackClip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackClip = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E62420FB-0BEA-4B2E-AF76-B5263B01C02B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Текстовый стиль подписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Текстовый стиль подписи
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Id = "AA47B040-B7F2-42D1-8BAB-C118433F3075", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_TextStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_TextStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Текстовый стиль подписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Текстовый стиль подписи
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ADD91E29-62A1-41EA-8846-C5DB64657CAC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота текста подписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportDef", typeof(object))]

	///<summary>
	///Высота текста подписи
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
		Id = "F2BF8C80-BDCD-4AE3-9639-A0B239945DA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "mdsUnitsLib.MDSViewportDef.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.mdsUnitsLib.MDSViewportDef", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Высота текста подписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportDef", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота текста подписи
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
