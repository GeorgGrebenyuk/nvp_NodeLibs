using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IMDSViewportFrame Interface
///</summary>
namespace mdsUnitsLib.MDSViewportFrame 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportFrame_Constructor : INode 
	{
		public mdsUnitsLib.IMDSViewportFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsUnitsLib.IMDSViewportFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSViewportFrame_ConstructorCast : INode 
	{
		public mdsUnitsLib.IMDSViewportFrame _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsUnitsLib.IMDSViewportFrame;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Наименование вида", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Наименование вида
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
		Text = "Наименование вида", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Наименование вида
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
		Text = "Профиль", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Профиль
	///</summary>
	public class Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Profile);

		}
	}


	[NVP_Manifest(
		Text = "Профиль", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Профиль
	///</summary>
	public class Set_Profile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Profile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Центральная точка", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Центральная точка
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Text = "Центральная точка", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Центральная точка
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Направление", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Направление
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Text = "Направление", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Направление
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Цель", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Цель
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Text = "Цель", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Цель
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Ширина", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

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
		Text = "Ширина", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
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
		Text = "Высота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

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
		Text = "Высота", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
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
		Text = "Пользовательский масштаб", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Пользовательский масштаб
	///</summary>
	public class CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CustomScale);

		}
	}


	[NVP_Manifest(
		Text = "Пользовательский масштаб", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Пользовательский масштаб
	///</summary>
	public class Set_CustomScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CustomScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масштаб", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Масштаб
	///</summary>
	public class Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Scale);

		}
	}


	[NVP_Manifest(
		Text = "Масштаб", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Масштаб
	///</summary>
	public class Set_Scale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Scale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Угол поворота", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Угол поворота
	///</summary>
	public class TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TwistAngle);

		}
	}


	[NVP_Manifest(
		Text = "Угол поворота", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Угол поворота
	///</summary>
	public class Set_TwistAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TwistAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Обрезка по фронтальной плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Обрезка по фронтальной плоскости
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
		Text = "Обрезка по фронтальной плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Обрезка по фронтальной плоскости
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
		Text = "Расстояние до фронтальной плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Расстояние до фронтальной плоскости
	///</summary>
	public class FrontClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontClipDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до фронтальной плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до фронтальной плоскости
	///</summary>
	public class Set_FrontClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontClipDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Обрезка по задней плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Обрезка по задней плоскости
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
		Text = "Обрезка по задней плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Обрезка по задней плоскости
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
		Text = "Расстояние до задней плоскости", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Расстояние до задней плоскости
	///</summary>
	public class BackClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackClipDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние до задней плоскости", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Расстояние до задней плоскости
	///</summary>
	public class Set_BackClipDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackClipDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Файл внешней ссылки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Файл внешней ссылки
	///</summary>
	public class XRefName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XRefName);

		}
	}


	[NVP_Manifest(
		Text = "Файл внешней ссылки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Файл внешней ссылки
	///</summary>
	public class Set_XRefName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XRefName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Тип проекции", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Тип проекции
	///</summary>
	public class ProjectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProjectionType);

		}
	}


	[NVP_Manifest(
		Text = "Набор объектов", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Набор объектов
	///</summary>
	public class SelectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SelectionType);

		}
	}


	[NVP_Manifest(
		Text = "Набор объектов", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Набор объектов
	///</summary>
	public class Set_SelectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectionType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Фильтр объектов", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Фильтр объектов
	///</summary>
	public class ObjectFilter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectFilter);

		}
	}


	[NVP_Manifest(
		Text = "Фильтр объектов", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Фильтр объектов
	///</summary>
	public class Set_ObjectFilter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ObjectFilter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Качество", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Качество
	///</summary>
	public class Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Quality);

		}
	}


	[NVP_Manifest(
		Text = "Качество", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Качество
	///</summary>
	public class Set_Quality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Quality = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Уровень детализации", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Уровень детализации
	///</summary>
	public class LOD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LOD);

		}
	}


	[NVP_Manifest(
		Text = "Уровень детализации", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Уровень детализации
	///</summary>
	public class Set_LOD : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LOD = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Генерировать невидимые линии", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Генерировать невидимые линии
	///</summary>
	public class GenerateInvisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GenerateInvisibleLines);

		}
	}


	[NVP_Manifest(
		Text = "Генерировать невидимые линии", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Генерировать невидимые линии
	///</summary>
	public class Set_GenerateInvisibleLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerateInvisibleLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Включить надписывание", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Включить надписывание
	///</summary>
	public class LabelTextVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextVisible);

		}
	}


	[NVP_Manifest(
		Text = "Включить надписывание", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Включить надписывание
	///</summary>
	public class Set_LabelTextVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Текст", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Текст
	///</summary>
	public class LabelTextExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextExpression);

		}
	}


	[NVP_Manifest(
		Text = "Текст", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Текст
	///</summary>
	public class Set_LabelTextExpression : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextExpression = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Стиль текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Стиль текста
	///</summary>
	public class LabelTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextStyle);

		}
	}


	[NVP_Manifest(
		Text = "Стиль текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Стиль текста
	///</summary>
	public class Set_LabelTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Высота текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Высота текста
	///</summary>
	public class LabelTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextHeight);

		}
	}


	[NVP_Manifest(
		Text = "Высота текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Высота текста
	///</summary>
	public class Set_LabelTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Точка привязки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Точка привязки
	///</summary>
	public class LabelTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextPosition);

		}
	}


	[NVP_Manifest(
		Text = "Точка привязки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Точка привязки
	///</summary>
	public class Set_LabelTextPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Смещение текста по X", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Смещение текста по X
	///</summary>
	public class LabelTextOffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextOffsetX);

		}
	}


	[NVP_Manifest(
		Text = "Смещение текста по X", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение текста по X
	///</summary>
	public class Set_LabelTextOffsetX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextOffsetX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Смещение текста по Y", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Смещение текста по Y
	///</summary>
	public class LabelTextOffsetY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelTextOffsetY);

		}
	}


	[NVP_Manifest(
		Text = "Смещение текста по Y", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Смещение текста по Y
	///</summary>
	public class Set_LabelTextOffsetY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelTextOffsetY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Рамка вокруг текста", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Рамка вокруг текста
	///</summary>
	public class LabelFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrame);

		}
	}


	[NVP_Manifest(
		Text = "Рамка вокруг текста", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Рамка вокруг текста
	///</summary>
	public class Set_LabelFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrame = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Радиус или отступ по X для надписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Радиус или отступ по X для надписи
	///</summary>
	public class LabelFrameOffsX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrameOffsX);

		}
	}


	[NVP_Manifest(
		Text = "Радиус или отступ по X для надписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Радиус или отступ по X для надписи
	///</summary>
	public class Set_LabelFrameOffsX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrameOffsX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Отступ по Y для надписи", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Отступ по Y для надписи
	///</summary>
	public class LabelFrameOffsY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LabelFrameOffsY);

		}
	}


	[NVP_Manifest(
		Text = "Отступ по Y для надписи", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Отступ по Y для надписи
	///</summary>
	public class Set_LabelFrameOffsY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LabelFrameOffsY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Слой рамки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Слой рамки
	///</summary>
	public class FrameLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameLayer);

		}
	}


	[NVP_Manifest(
		Text = "Слой рамки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой рамки
	///</summary>
	public class Set_FrameLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Печать рамки", 
		ViewType = "Data")]
	[NodeInput("MDSViewportFrame", typeof(object))]

	///<summary>
	///Печать рамки
	///</summary>
	public class PrintFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PrintFrame);

		}
	}


	[NVP_Manifest(
		Text = "Печать рамки", 
		ViewType = "Modifier")]
	[NodeInput("MDSViewportFrame", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Печать рамки
	///</summary>
	public class Set_PrintFrame : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PrintFrame = inputs[1].Value;
			return null;
		}
	}
}
