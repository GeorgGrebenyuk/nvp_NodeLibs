using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMSLink Interface
///</summary>
namespace NVP_ModelStudio_COM._SchematiCSCOMLib.MSLink 
{

	[NVP_Manifest(
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
