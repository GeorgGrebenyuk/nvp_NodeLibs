using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECTrench Interface
///</summary>
namespace ironObjComLib.WrAECTrench 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECTrench_Constructor : INode 
	{
		public ironObjComLib.IWrAECTrench _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECTrench;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECTrench_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECTrench _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECTrench;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Вызов диалога свойств", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Вызов диалога свойств
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
		Text = "Вызов диалога свойств", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вызов диалога свойств
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
		Text = "Объем выемки в м3", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Объем выемки в м3
	///</summary>
	public class TVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TVolume);

		}
	}


	[NVP_Manifest(
		Text = "Объем засыпки в м3", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Объем засыпки в м3
	///</summary>
	public class TDigVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TDigVolume);

		}
	}


	[NVP_Manifest(
		Text = "Длина в м", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Длина в м
	///</summary>
	public class TLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TLength);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать начальный откос", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать начальный откос
	///</summary>
	public class DrawStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawStartSlope);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать начальный откос", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать начальный откос
	///</summary>
	public class Set_DrawStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawStartSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол начального откоса", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Угол начального откоса
	///</summary>
	public class AngleStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleStartSlope);

		}
	}


	[NVP_Manifest(
		Text = "Угол начального откоса", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол начального откоса
	///</summary>
	public class Set_AngleStartSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleStartSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Рисовать конечный откос", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать конечный откос
	///</summary>
	public class DrawEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawEndSlope);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать конечный откос", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать конечный откос
	///</summary>
	public class Set_DrawEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawEndSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол конечного откоса", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Угол конечного откоса
	///</summary>
	public class AngleEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleEndSlope);

		}
	}


	[NVP_Manifest(
		Text = "Угол конечного откоса", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол конечного откоса
	///</summary>
	public class Set_AngleEndSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleEndSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Проектная поверхность присутствует или нет", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Проектная поверхность присутствует или нет
	///</summary>
	public class ProjectPresent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectPresent);

		}
	}


	[NVP_Manifest(
		Text = "По какой поверхности считать выемку", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///По какой поверхности считать выемку
	///</summary>
	public class DigOutOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DigOutOver);

		}
	}


	[NVP_Manifest(
		Text = "По какой поверхности считать выемку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///По какой поверхности считать выемку
	///</summary>
	public class Set_DigOutOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DigOutOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "По какой поверхности считать засыпку", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///По какой поверхности считать засыпку
	///</summary>
	public class FillingOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FillingOver);

		}
	}


	[NVP_Manifest(
		Text = "По какой поверхности считать засыпку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///По какой поверхности считать засыпку
	///</summary>
	public class Set_FillingOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FillingOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Рисовать по линии поверхности или по проектной поверхности", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Рисовать по линии поверхности или по проектной поверхности
	///</summary>
	public class DrawOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawOver);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать по линии поверхности или по проектной поверхности", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать по линии поверхности или по проектной поверхности
	///</summary>
	public class Set_DrawOver : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawOver = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Построение по геоданным", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Построение по геоданным
	///</summary>
	public class GeoMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeoMode);

		}
	}


	[NVP_Manifest(
		Text = "Требуется обновление геоданных", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Требуется обновление геоданных
	///</summary>
	public class GeoBad : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GeoBad);

		}
	}


	[NVP_Manifest(
		Text = "Строить сечения по рельефу или шагам", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Строить сечения по рельефу или шагам
	///</summary>
	public class DrawOverStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawOverStep);

		}
	}


	[NVP_Manifest(
		Text = "Строить сечения по рельефу или шагам", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Строить сечения по рельефу или шагам
	///</summary>
	public class Set_DrawOverStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawOverStep = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Шаг сечений", 
		ViewType = "Data")]
	[NodeInput("WrAECTrench", typeof(object))]

	///<summary>
	///Шаг сечений
	///</summary>
	public class PathStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PathStep);

		}
	}


	[NVP_Manifest(
		Text = "Шаг сечений", 
		ViewType = "Modifier")]
	[NodeInput("WrAECTrench", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Шаг сечений
	///</summary>
	public class Set_PathStep : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PathStep = inputs[1].Value;
			return null;
		}
	}
}
