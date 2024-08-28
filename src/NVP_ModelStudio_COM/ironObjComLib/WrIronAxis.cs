using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrIronAxis Interface
///</summary>
namespace NVP_ModelStudio_COM._ironObjComLib.WrIronAxis 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronAxis_Constructor : INode 
	{
		public ironObjComLib.IWrIronAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrIronAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrIronAxis_ConstructorCast : INode 
	{
		public ironObjComLib.IWrIronAxis _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrIronAxis;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

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
	[NodeInput("WrIronAxis", typeof(object))]
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
		Text = "A)", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///A)
	///</summary>
	public class OffsetStartZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartZ);

		}
	}


	[NVP_Manifest(
		Text = "A)", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///A)
	///</summary>
	public class Set_OffsetStartZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "B)", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///B)
	///</summary>
	public class OffsetEndZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndZ);

		}
	}


	[NVP_Manifest(
		Text = "B)", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///B)
	///</summary>
	public class Set_OffsetEndZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Угол вращения", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Угол вращения
	///</summary>
	public class AngleRotationDegrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AngleRotationDegrees);

		}
	}


	[NVP_Manifest(
		Text = "property Угол вращения", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Угол вращения
	///</summary>
	public class Set_AngleRotationDegrees : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AngleRotationDegrees = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property StartPoint", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property StartPoint
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
		Text = "property StartPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property StartPoint
	///</summary>
	public class Set_StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property EndPoint", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property EndPoint
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
		Text = "property EndPoint", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property EndPoint
	///</summary>
	public class Set_EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Длина оси", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Длина оси
	///</summary>
	public class AxisLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisLength);

		}
	}


	[NVP_Manifest(
		Text = "property Длина оси", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Длина оси
	///</summary>
	public class Set_AxisLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Длина стороительная", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Длина стороительная
	///</summary>
	public class ConstructionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConstructionLength);

		}
	}


	[NVP_Manifest(
		Text = "property Длина стороительная", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Длина стороительная
	///</summary>
	public class Set_ConstructionLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConstructionLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Режим смещения", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Режим смещения
	///</summary>
	public class OffsetMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetMode);

		}
	}


	[NVP_Manifest(
		Text = "property Режим смещения", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Режим смещения
	///</summary>
	public class Set_OffsetMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Режим привязки", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Режим привязки
	///</summary>
	public class SnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapMode);

		}
	}


	[NVP_Manifest(
		Text = "property Режим привязки", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Режим привязки
	///</summary>
	public class Set_SnapMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Привязка Start", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Привязка Start
	///</summary>
	public class SnapStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapStart);

		}
	}


	[NVP_Manifest(
		Text = "property Привязка Start", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Привязка Start
	///</summary>
	public class Set_SnapStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Привязка End", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Привязка End
	///</summary>
	public class SnapEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapEnd);

		}
	}


	[NVP_Manifest(
		Text = "property Привязка End", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Привязка End
	///</summary>
	public class Set_SnapEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение Start X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение Start X
	///</summary>
	public class OffsetStartX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartX);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение Start X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение Start X
	///</summary>
	public class Set_OffsetStartX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение Start Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение Start Y
	///</summary>
	public class OffsetStartY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartY);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение Start Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение Start Y
	///</summary>
	public class Set_OffsetStartY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение End X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение End X
	///</summary>
	public class OffsetEndX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndX);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение End X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение End X
	///</summary>
	public class Set_OffsetEndX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение End Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение End Y
	///</summary>
	public class OffsetEndY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndY);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение End Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение End Y
	///</summary>
	public class Set_OffsetEndY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RelativeStart", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeStart
	///</summary>
	public class RelativeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeStart);

		}
	}


	[NVP_Manifest(
		Text = "property RelativeStart", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property RelativeStart
	///</summary>
	public class Set_RelativeStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RelativeDistStart", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeDistStart
	///</summary>
	public class RelativeDistStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeDistStart);

		}
	}


	[NVP_Manifest(
		Text = "property RelativeDistStart", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RelativeDistStart
	///</summary>
	public class Set_RelativeDistStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeDistStart = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки Start X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки Start X
	///</summary>
	public class OffsetStartPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartPtX);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки Start X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки Start X
	///</summary>
	public class Set_OffsetStartPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartPtX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки Start Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки Start Y
	///</summary>
	public class OffsetStartPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetStartPtY);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки Start Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки Start Y
	///</summary>
	public class Set_OffsetStartPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetStartPtY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RelativeEnd", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeEnd
	///</summary>
	public class RelativeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeEnd);

		}
	}


	[NVP_Manifest(
		Text = "property RelativeEnd", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property RelativeEnd
	///</summary>
	public class Set_RelativeEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property RelativeDistEnd", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property RelativeDistEnd
	///</summary>
	public class RelativeDistEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RelativeDistEnd);

		}
	}


	[NVP_Manifest(
		Text = "property RelativeDistEnd", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property RelativeDistEnd
	///</summary>
	public class Set_RelativeDistEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RelativeDistEnd = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки End X", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки End X
	///</summary>
	public class OffsetEndPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndPtX);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки End X", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки End X
	///</summary>
	public class Set_OffsetEndPtX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndPtX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки End Y", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property Смещение точки End Y
	///</summary>
	public class OffsetEndPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OffsetEndPtY);

		}
	}


	[NVP_Manifest(
		Text = "property Смещение точки End Y", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Смещение точки End Y
	///</summary>
	public class Set_OffsetEndPtY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OffsetEndPtY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NumDependencies", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]

	///<summary>
	///property NumDependencies
	///</summary>
	public class NumDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumDependencies);

		}
	}


	[NVP_Manifest(
		Text = "property NumDependencies", 
		ViewType = "Modifier")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property NumDependencies
	///</summary>
	public class Set_NumDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumDependencies = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetArea
	///</summary>
	public class GetArea : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetArea(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "method GetVolume", 
		ViewType = "Data")]
	[NodeInput("WrIronAxis", typeof(object))]
	[NodeInput("Element", typeof(System.Object))]
	[NodeInput("bodyOptions", typeof(System.Object))]

	///<summary>
	///method GetVolume
	///</summary>
	public class GetVolume : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolume(inputs[1].Value,inputs[2].Value));

		}
	}
}
