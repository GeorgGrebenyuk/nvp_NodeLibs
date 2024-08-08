using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECSite Interface
///</summary>
namespace ironObjComLib.WrAECSite 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSite_Constructor : INode 
	{
		public ironObjComLib.IWrAECSite _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECSite;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECSite_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECSite _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECSite;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

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
	[NodeInput("WrAECSite", typeof(object))]
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
		Text = "Площадь площадки 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь площадки 3D,кв.м
	///</summary>
	public class SiteArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteArea);

		}
	}


	[NVP_Manifest(
		Text = "Площадь откосов 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь откосов 3D,кв.м
	///</summary>
	public class SiteAreaSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteAreaSlope);

		}
	}


	[NVP_Manifest(
		Text = "Площадь полная 3D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь полная 3D,кв.м
	///</summary>
	public class SiteAreaFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteAreaFull);

		}
	}


	[NVP_Manifest(
		Text = "Площадь полная 2D,кв.м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Площадь полная 2D,кв.м
	///</summary>
	public class SiteArea2DFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SiteArea2DFull);

		}
	}


	[NVP_Manifest(
		Text = "Периметр в плане,м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Периметр в плане,м
	///</summary>
	public class SitePerimeter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SitePerimeter);

		}
	}


	[NVP_Manifest(
		Text = "Периметр внешний в плане,м", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Периметр внешний в плане,м
	///</summary>
	public class SitePerimeterFull : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SitePerimeterFull);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать контур площадки", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать контур площадки
	///</summary>
	public class DrawSite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawSite);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать контур площадки", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать контур площадки
	///</summary>
	public class Set_DrawSite : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawSite = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Рисовать откосы", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать откосы
	///</summary>
	public class DrawSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawSlope);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать откосы", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать откосы
	///</summary>
	public class Set_DrawSlope : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawSlope = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Рисовать сетку", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Рисовать сетку
	///</summary>
	public class DrawGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawGrid);

		}
	}


	[NVP_Manifest(
		Text = "Рисовать сетку", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рисовать сетку
	///</summary>
	public class Set_DrawGrid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawGrid = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол откоса,град", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Угол откоса,град
	///</summary>
	public class SlopeAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SlopeAngle);

		}
	}


	[NVP_Manifest(
		Text = "Угол откоса,град", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол откоса,град
	///</summary>
	public class Set_SlopeAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SlopeAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол сетки в плане", 
		ViewType = "Data")]
	[NodeInput("WrAECSite", typeof(object))]

	///<summary>
	///Угол сетки в плане
	///</summary>
	public class GridAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridAngleXY);

		}
	}


	[NVP_Manifest(
		Text = "Угол сетки в плане", 
		ViewType = "Modifier")]
	[NodeInput("WrAECSite", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол сетки в плане
	///</summary>
	public class Set_GridAngleXY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GridAngleXY = inputs[1].Value;
			return null;
		}
	}
}
