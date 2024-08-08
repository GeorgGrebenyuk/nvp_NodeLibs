using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrCSInsulationDesignation Interface
///</summary>
namespace mdsUnitsLib.WrCSInsulationDesignation 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrCSInsulationDesignation_Constructor : INode 
	{
		public mdsUnitsLib.IWrCSInsulationDesignation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IWrCSInsulationDesignation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrCSInsulationDesignation_ConstructorCast : INode 
	{
		public mdsUnitsLib.IWrCSInsulationDesignation _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IWrCSInsulationDesignation;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Шаг штриховки", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Шаг штриховки
	///</summary>
	public class Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Step);

		}
	}


	[NVP_Manifest(
		Text = "Шаг штриховки", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Шаг штриховки
	///</summary>
	public class Set_Step : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Step = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол штриховки", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Угол штриховки
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Text = "Угол штриховки", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол штриховки
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип узора
	///</summary>
	public class TraceryType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TraceryType);

		}
	}


	[NVP_Manifest(
		Text = "Тип узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип узора
	///</summary>
	public class Set_TraceryType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TraceryType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Показывать верхнюю границу?", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Показывать верхнюю границу?
	///</summary>
	public class IsViewUpLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsViewUpLine);

		}
	}


	[NVP_Manifest(
		Text = "Показывать верхнюю границу?", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать верхнюю границу?
	///</summary>
	public class Set_IsViewUpLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsViewUpLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между границами", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Расстояние между границами
	///</summary>
	public class DistBetweenPlines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DistBetweenPlines);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между границами", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние между границами
	///</summary>
	public class Set_DistBetweenPlines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DistBetweenPlines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Показывать нижнюю границу?", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Показывать нижнюю границу?
	///</summary>
	public class IsViewDownLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsViewDownLine);

		}
	}


	[NVP_Manifest(
		Text = "Показывать нижнюю границу?", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Показывать нижнюю границу?
	///</summary>
	public class Set_IsViewDownLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsViewDownLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии верхней границы
	///</summary>
	public class LineTypeUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeUp);

		}
	}


	[NVP_Manifest(
		Text = "Тип линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии верхней границы
	///</summary>
	public class Set_LineTypeUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии нижней границы
	///</summary>
	public class LineTypeDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeDown);

		}
	}


	[NVP_Manifest(
		Text = "Тип линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии нижней границы
	///</summary>
	public class Set_LineTypeDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Тип линии узора
	///</summary>
	public class LineTypeTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeTracery);

		}
	}


	[NVP_Manifest(
		Text = "Тип линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип линии узора
	///</summary>
	public class Set_LineTypeTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии верхней границы
	///</summary>
	public class LineTypeScaleUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleUp);

		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии верхней границы
	///</summary>
	public class Set_LineTypeScaleUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии нижней границы
	///</summary>
	public class LineTypeScaleDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleDown);

		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии нижней границы
	///</summary>
	public class Set_LineTypeScaleDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Масштаб линии узора
	///</summary>
	public class LineTypeScaleTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineTypeScaleTracery);

		}
	}


	[NVP_Manifest(
		Text = "Масштаб линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Масштаб линии узора
	///</summary>
	public class Set_LineTypeScaleTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineTypeScaleTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вес линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии верхней границы
	///</summary>
	public class LineWeightUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightUp);

		}
	}


	[NVP_Manifest(
		Text = "Вес линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии верхней границы
	///</summary>
	public class Set_LineWeightUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вес линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии нижней границы
	///</summary>
	public class LineWeightDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightDown);

		}
	}


	[NVP_Manifest(
		Text = "Вес линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии нижней границы
	///</summary>
	public class Set_LineWeightDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Вес линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Вес линии узора
	///</summary>
	public class LineWeightTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LineWeightTracery);

		}
	}


	[NVP_Manifest(
		Text = "Вес линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Вес линии узора
	///</summary>
	public class Set_LineWeightTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LineWeightTracery = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Цвет линии верхней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии верхней границы
	///</summary>
	public class ColorUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorUp);

		}
	}


	[NVP_Manifest(
		Text = "Цвет линии верхней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии верхней границы
	///</summary>
	public class Set_ColorUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorUp = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Цвет линии нижней границы", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии нижней границы
	///</summary>
	public class ColorDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorDown);

		}
	}


	[NVP_Manifest(
		Text = "Цвет линии нижней границы", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии нижней границы
	///</summary>
	public class Set_ColorDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorDown = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Цвет линии узора", 
		ViewType = "Data")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]

	///<summary>
	///Цвет линии узора
	///</summary>
	public class ColorTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorTracery);

		}
	}


	[NVP_Manifest(
		Text = "Цвет линии узора", 
		ViewType = "Modifier")]
	[NodeInput("WrCSInsulationDesignation", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цвет линии узора
	///</summary>
	public class Set_ColorTracery : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorTracery = inputs[1].Value;
			return null;
		}
	}
}
