using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSLink Interface
///</summary>
namespace SchematiCSCOMLib.MSLink 
{

	[NVP_Manifest(
		Id = "4A3F55C5-7782-42D9-ACFA-3BDDFF1F3172", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.MSLink_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "_MSLink_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLink_Constructor : INode 
	{
		public SchematiCSCOMLib.IMSLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as SchematiCSCOMLib.IMSLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "3D099843-9A36-46A8-8B43-9C681268DF9B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.MSLink_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "_MSLink_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MSLink_ConstructorCast : INode 
	{
		public SchematiCSCOMLib.IMSLink _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as SchematiCSCOMLib.IMSLink;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "A8CE06D1-8603-4A8B-B7A4-02A8C723BFB3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Параметры
	///</summary>
	public class Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Element);

		}
	}


	[NVP_Manifest(
		Id = "A9C5B145-B771-4F48-B0A4-9E1655B78FDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_Element", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_Element", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2086F792-C48F-45E7-A652-1A2AA5F07A61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.StartPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "StartPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Id = "2485598C-55AC-4F58-B8C9-4BB3B3BBFC3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.EndPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "EndPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Id = "F84DCFB1-98F7-45C3-BF79-AE0048101D11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование связи", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Наименование связи
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
		Id = "7F32A979-80D2-4AE3-A2BB-DBEA3A4273DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование связи", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование связи
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
		Id = "1B84DA9F-123F-44CD-92E5-0D6A2E32BBDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.HasObjectStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "HasObjectStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли начальный объект", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Имеется ли начальный объект
	///</summary>
	public class HasObjectStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasObjectStart);

		}
	}


	[NVP_Manifest(
		Id = "111098C4-66F4-47F7-956D-30CC0131BC4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.HasObjectEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "HasObjectEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли конечный объект", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Имеется ли конечный объект
	///</summary>
	public class HasObjectEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasObjectEnd);

		}
	}


	[NVP_Manifest(
		Id = "6F2FFA71-60DC-4F68-A331-911B3EDF28FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.NodeStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "NodeStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальный узел", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Начальный узел
	///</summary>
	public class NodeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeStart);

		}
	}


	[NVP_Manifest(
		Id = "6F1776E8-BB9C-4795-9BAA-05B56DA555AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.NodeEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "NodeEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечный узел", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Конечный узел
	///</summary>
	public class NodeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NodeEnd);

		}
	}


	[NVP_Manifest(
		Id = "C18B83D8-BCF8-4E62-9078-1D80A0BAA7FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.InlineNodes", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "InlineNodes", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Узлы на связи", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Узлы на связи
	///</summary>
	public class InlineNodes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InlineNodes);

		}
	}


	[NVP_Manifest(
		Id = "F08C15C4-497E-4A79-AF9F-2F97E826E70A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.InlineObjects", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "InlineObjects", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Арматура на связи", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Арматура на связи
	///</summary>
	public class InlineObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InlineObjects);

		}
	}


	[NVP_Manifest(
		Id = "E2066A88-C7EF-4A57-A620-028247292856", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.ObjectStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "ObjectStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "оборудование, узел, связь)", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///оборудование, узел, связь)
	///</summary>
	public class ObjectStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectStart);

		}
	}


	[NVP_Manifest(
		Id = "850783A3-E300-4B05-A9D4-23B53A1A6F38", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.ObjectEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "ObjectEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "оборудование, узел, связь)", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///оборудование, узел, связь)
	///</summary>
	public class ObjectEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectEnd);

		}
	}


	[NVP_Manifest(
		Id = "A8A9F94A-4007-4DDA-B0F7-481B5DB5FB13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.HasUnitStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "HasUnitStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли начальное оборудование", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Имеется ли начальное оборудование
	///</summary>
	public class HasUnitStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasUnitStart);

		}
	}


	[NVP_Manifest(
		Id = "06841E2A-54DE-4079-ACAC-9571A0F8C5AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.UnitStart", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "UnitStart", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Начальное оборудование", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Начальное оборудование
	///</summary>
	public class UnitStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitStart);

		}
	}


	[NVP_Manifest(
		Id = "B27BE101-2C53-4F06-B25A-8F3543398050", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.HasUnitEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "HasUnitEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Имеется ли конечное оборудование", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Имеется ли конечное оборудование
	///</summary>
	public class HasUnitEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasUnitEnd);

		}
	}


	[NVP_Manifest(
		Id = "C8B86863-380F-43C4-A583-B1C2191935B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.UnitEnd", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "UnitEnd", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Конечное оборудование", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Конечное оборудование
	///</summary>
	public class UnitEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UnitEnd);

		}
	}


	[NVP_Manifest(
		Id = "097051CE-1694-4517-BC65-D7B5391876E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.SourceObjectID", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "SourceObjectID", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "ID исходного объекта", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///ID исходного объекта
	///</summary>
	public class SourceObjectID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceObjectID);

		}
	}


	[NVP_Manifest(
		Id = "28A9F61D-B154-4C8E-A7E3-47AA9701F078", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер линии", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Номер линии
	///</summary>
	public class LineNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineNumber);

		}
	}


	[NVP_Manifest(
		Id = "6431B3AE-FF23-45C7-B068-53F4D99204B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Номер линии", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Номер линии
	///</summary>
	public class Set_LineNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CF3FA25E-0503-48A9-8BF3-949090A97296", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineSegmentNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineSegmentNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Участок", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Участок
	///</summary>
	public class LineSegmentNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineSegmentNumber);

		}
	}


	[NVP_Manifest(
		Id = "E4F12CC5-8081-417E-8C7F-1010D2264FD8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineSegmentNumber", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineSegmentNumber", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Участок", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Участок
	///</summary>
	public class Set_LineSegmentNumber : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineSegmentNumber = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "09088C70-F1F8-4128-AC07-85601172D010", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineCategory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineCategory", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_CATEGORY", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_CATEGORY
	///</summary>
	public class LineCategory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineCategory);

		}
	}


	[NVP_Manifest(
		Id = "B7840CEC-FF0C-40C2-9F87-1C019B513A73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineCategory", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineCategory", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_CATEGORY", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_CATEGORY
	///</summary>
	public class Set_LineCategory : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineCategory = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "55CDAD87-EA24-4008-8D16-7F7245D859D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineClass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineClass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_CLASS", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_CLASS
	///</summary>
	public class LineClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineClass);

		}
	}


	[NVP_Manifest(
		Id = "3F0DBCC6-1526-4958-A42C-B247CBF81055", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineClass", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineClass", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_CLASS", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_CLASS
	///</summary>
	public class Set_LineClass : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineClass = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7C6188CE-8BAE-4C44-8F42-56A6EC0043BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineComments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineComments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_COMMENTS", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_COMMENTS
	///</summary>
	public class LineComments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineComments);

		}
	}


	[NVP_Manifest(
		Id = "05BBC1A9-FAFE-44D6-9F19-9CFB7B33F8E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineComments", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineComments", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_COMMENTS", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_COMMENTS
	///</summary>
	public class Set_LineComments : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineComments = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AFB7172B-1B68-40F4-AB1D-1BA7D3135845", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineDiameterDN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineDiameterDN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_DIAMETER_DN", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_DIAMETER_DN
	///</summary>
	public class LineDiameterDN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineDiameterDN);

		}
	}


	[NVP_Manifest(
		Id = "6B90EFAA-DD68-4853-9310-1980D669D9A5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineDiameterDN", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineDiameterDN", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_DIAMETER_DN", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///LINE_DIAMETER_DN
	///</summary>
	public class Set_LineDiameterDN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineDiameterDN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5DB127D3-1647-472F-9346-E2A3B88F704E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_INSULATION", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_INSULATION
	///</summary>
	public class LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineInsulation);

		}
	}


	[NVP_Manifest(
		Id = "F9513757-B124-4910-82AE-B6C76D6691F7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineInsulation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineInsulation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_INSULATION", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_INSULATION
	///</summary>
	public class Set_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineInsulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A9C8829B-81CA-493E-BB75-E6FA73D938D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineService", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineService", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_SERVICE", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_SERVICE
	///</summary>
	public class LineService : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineService);

		}
	}


	[NVP_Manifest(
		Id = "873FE95A-49F2-4C85-80DC-37D62284D948", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineService", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineService", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_SERVICE", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_SERVICE
	///</summary>
	public class Set_LineService : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineService = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A6AD940E-1115-4216-8A32-BE326DD6274D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_TRACE", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_TRACE
	///</summary>
	public class LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTrace);

		}
	}


	[NVP_Manifest(
		Id = "9034C243-36E4-4099-93A8-AAFE5D28D76D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_TRACE", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_TRACE
	///</summary>
	public class Set_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTrace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E88CF2D5-FD6A-4F14-AE35-049E19A385FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.LineWorktype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "LineWorktype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_WORKTYPE", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///LINE_WORKTYPE
	///</summary>
	public class LineWorktype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWorktype);

		}
	}


	[NVP_Manifest(
		Id = "0FD560C5-ADFD-4206-BA0A-276C559493B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_LineWorktype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_LineWorktype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "LINE_WORKTYPE", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///LINE_WORKTYPE
	///</summary>
	public class Set_LineWorktype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWorktype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "17B624D2-52FA-4E2E-8DA3-19DA487D07AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechCommodity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechCommodity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование среды", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Наименование среды
	///</summary>
	public class TechCommodity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechCommodity);

		}
	}


	[NVP_Manifest(
		Id = "B088DE08-C5DC-4C06-947A-8D1AC36CA3FF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechCommodity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechCommodity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Наименование среды", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование среды
	///</summary>
	public class Set_TechCommodity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechCommodity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E14CE05-FE36-4A43-8A28-A7D1C80EF94A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechCommodityPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechCommodityPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "жидкость, газ,…)", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///жидкость, газ,…)
	///</summary>
	public class TechCommodityPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechCommodityPhase);

		}
	}


	[NVP_Manifest(
		Id = "30D3B7BF-3FFA-4B74-B4EA-2973C4E2AA84", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechCommodityPhase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechCommodityPhase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "жидкость, газ,…)", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///жидкость, газ,…)
	///</summary>
	public class Set_TechCommodityPhase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechCommodityPhase = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F868368D-561F-480F-A927-1372E41BB883", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechPressureDesign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechPressureDesign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_DESIGN", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_PRESSURE_DESIGN
	///</summary>
	public class TechPressureDesign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechPressureDesign);

		}
	}


	[NVP_Manifest(
		Id = "BD34BF07-E81B-4697-8A1B-DBECC8174C6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechPressureDesign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechPressureDesign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_DESIGN", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_PRESSURE_DESIGN
	///</summary>
	public class Set_TechPressureDesign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechPressureDesign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1B25B2BD-D8D4-44A1-AB1E-B4F9B2C0672B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechPressureWork", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechPressureWork", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_PRESSURE_WORK
	///</summary>
	public class TechPressureWork : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechPressureWork);

		}
	}


	[NVP_Manifest(
		Id = "C8BC52AB-6B4E-48F6-85A5-BDC089F7539C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechPressureWork", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechPressureWork", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_PRESSURE_WORK
	///</summary>
	public class Set_TechPressureWork : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechPressureWork = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "47314421-5162-4EED-8AA7-9CDA46A3BCB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechPressureWorkMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechPressureWorkMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK_MAX", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_PRESSURE_WORK_MAX
	///</summary>
	public class TechPressureWorkMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechPressureWorkMax);

		}
	}


	[NVP_Manifest(
		Id = "875593EE-22CA-455A-ABD2-682821E265F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechPressureWorkMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechPressureWorkMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK_MAX", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_PRESSURE_WORK_MAX
	///</summary>
	public class Set_TechPressureWorkMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechPressureWorkMax = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2C95B31D-53F1-4BA5-BB4F-6500FFEB54AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechPressureWorkMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechPressureWorkMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK_MIN", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_PRESSURE_WORK_MIN
	///</summary>
	public class TechPressureWorkMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechPressureWorkMin);

		}
	}


	[NVP_Manifest(
		Id = "61B217F3-CACE-49F8-A114-A3C0E5A0C2CB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechPressureWorkMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechPressureWorkMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_PRESSURE_WORK_MIN", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_PRESSURE_WORK_MIN
	///</summary>
	public class Set_TechPressureWorkMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechPressureWorkMin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CC33BB84-E3EB-482E-9C60-3FDC2E0C77E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechTempDesign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechTempDesign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_DESIGN", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_TEMP_DESIGN
	///</summary>
	public class TechTempDesign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechTempDesign);

		}
	}


	[NVP_Manifest(
		Id = "9D3C08B1-9336-416A-A170-00D3B0BF79FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechTempDesign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechTempDesign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_DESIGN", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_TEMP_DESIGN
	///</summary>
	public class Set_TechTempDesign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechTempDesign = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "14221059-364C-4A20-8E42-21F219FFBC4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechTempWork", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechTempWork", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_TEMP_WORK
	///</summary>
	public class TechTempWork : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechTempWork);

		}
	}


	[NVP_Manifest(
		Id = "3DC00463-0CC8-4D88-8ABB-A99E319BB800", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechTempWork", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechTempWork", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_TEMP_WORK
	///</summary>
	public class Set_TechTempWork : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechTempWork = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "DB5E48C1-497F-4D1C-BFF7-49AAAF0859BD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechTempWorkMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechTempWorkMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK_MAX", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_TEMP_WORK_MAX
	///</summary>
	public class TechTempWorkMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechTempWorkMax);

		}
	}


	[NVP_Manifest(
		Id = "EEE2F39C-40F7-4E2F-9015-BF886AD58DB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechTempWorkMax", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechTempWorkMax", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK_MAX", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_TEMP_WORK_MAX
	///</summary>
	public class Set_TechTempWorkMax : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechTempWorkMax = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "512D3943-8BBB-4985-B438-3BFF59E3BA35", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechTempWorkMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechTempWorkMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK_MIN", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_TEMP_WORK_MIN
	///</summary>
	public class TechTempWorkMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechTempWorkMin);

		}
	}


	[NVP_Manifest(
		Id = "CAD61977-DBEE-4086-894B-0A6275E46D86", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechTempWorkMin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechTempWorkMin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_TEMP_WORK_MIN", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_TEMP_WORK_MIN
	///</summary>
	public class Set_TechTempWorkMin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechTempWorkMin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "013FC12F-1237-48F2-AD48-F21F059FC0AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechDebit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechDebit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расход", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Расход
	///</summary>
	public class TechDebit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechDebit);

		}
	}


	[NVP_Manifest(
		Id = "B1B53940-3067-40B3-9482-63CE2D52C034", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechDebit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechDebit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Расход", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расход
	///</summary>
	public class Set_TechDebit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechDebit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93C3C469-AFB5-4C18-999C-F3EFF18ECF63", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вязкость", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Вязкость
	///</summary>
	public class TechDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechDensity);

		}
	}


	[NVP_Manifest(
		Id = "B19B94FD-79EC-4FED-807D-1E04674DDACF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Вязкость", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Вязкость
	///</summary>
	public class Set_TechDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0398A468-E575-4700-96BB-71E369F10825", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechVelocity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechVelocity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_VELOCITY", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_VELOCITY
	///</summary>
	public class TechVelocity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechVelocity);

		}
	}


	[NVP_Manifest(
		Id = "BDBB3B6A-016D-4BD6-A8E6-ED2D0A88080B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechVelocity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechVelocity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_VELOCITY", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_VELOCITY
	///</summary>
	public class Set_TechVelocity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechVelocity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3467A1BD-A4C7-4268-8954-A6429A38D582", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.TechViscosity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "TechViscosity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_VISCOSITY", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///TECH_VISCOSITY
	///</summary>
	public class TechViscosity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TechViscosity);

		}
	}


	[NVP_Manifest(
		Id = "0741FADA-7CCB-46A6-947D-6AE195A1EB13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_TechViscosity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_TechViscosity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "TECH_VISCOSITY", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///TECH_VISCOSITY
	///</summary>
	public class Set_TechViscosity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TechViscosity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "99A83E7C-C51F-4618-BF5A-42954E680DA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.GetSegment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "GetSegment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Получение сегмента связи по точке на связи, номеру сегмента или параметрическому положению", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("at", typeof(System.Object))]

	///<summary>
	///Получение сегмента связи по точке на связи, номеру сегмента или параметрическому положению
	///</summary>
	public class GetSegment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegment(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "3EBB93E6-2D28-411E-940D-B7BCBA1AE503", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.GetSegmentAtPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "GetSegmentAtPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Получение сегмента связи по координатам точки на связи", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("x", typeof(System.Double))]
	[NodeInput("y", typeof(System.Double))]
	[NodeInput("z", typeof(System.Double))]

	///<summary>
	///Получение сегмента связи по координатам точки на связи
	///</summary>
	public class GetSegmentAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetSegmentAtPoint(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "40EC4EED-D4F0-46B5-9AB0-B3020FC54BDE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.IsStartParamsBound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "IsStartParamsBound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связаны ли параметры начала линии", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Связаны ли параметры начала линии
	///</summary>
	public class IsStartParamsBound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsStartParamsBound);

		}
	}


	[NVP_Manifest(
		Id = "BCCBDCC4-D168-4719-AE9B-EC0DC7953195", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_IsStartParamsBound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_IsStartParamsBound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связаны ли параметры начала линии", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Связаны ли параметры начала линии
	///</summary>
	public class Set_IsStartParamsBound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsStartParamsBound = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B71FA76D-E03D-4E9D-8990-79D9DC5DDAB7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.IsEndParamsBound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "IsEndParamsBound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связаны ли параметры конца линии", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Связаны ли параметры конца линии
	///</summary>
	public class IsEndParamsBound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsEndParamsBound);

		}
	}


	[NVP_Manifest(
		Id = "70A50991-AA7C-4FE2-AAE7-E2748E6D6642", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_IsEndParamsBound", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_IsEndParamsBound", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Связаны ли параметры конца линии", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Связаны ли параметры конца линии
	///</summary>
	public class Set_IsEndParamsBound : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsEndParamsBound = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "053ADCA3-69B1-4501-BD10-89C0792B02E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.DataSegmentsColoring", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "DataSegmentsColoring", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Выделение участков цветом", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Выделение участков цветом
	///</summary>
	public class DataSegmentsColoring : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DataSegmentsColoring);

		}
	}


	[NVP_Manifest(
		Id = "CFCAB73C-BB9F-4926-9F67-7F988B6B3001", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.Set_DataSegmentsColoring", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "Set_DataSegmentsColoring", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Выделение участков цветом", 
		ViewType = "Modifier")]
	[NodeInput("MSLink", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Выделение участков цветом
	///</summary>
	public class Set_DataSegmentsColoring : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DataSegmentsColoring = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "375B6012-83ED-4E68-9356-75C3E088AD79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "SchematiCSCOMLib.MSLink.IsNonPipe", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.SchematiCSCOMLib.MSLink", 
		NodeName = "IsNonPipe", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Нетрубопроводная связь", 
		ViewType = "Data")]
	[NodeInput("MSLink", typeof(object))]

	///<summary>
	///Нетрубопроводная связь
	///</summary>
	public class IsNonPipe : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsNonPipe);

		}
	}
}
