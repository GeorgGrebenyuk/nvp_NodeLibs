using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Графическое представление анкерной опоры
///</summary>
namespace NVP_ModelStudio_COM._mdsLINEComLib.MDSLAncerSketch 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAncerSketch_Constructor : INode 
	{
		public mdsLINEComLib.IMDSLAncerSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as mdsLINEComLib.IMDSLAncerSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class MDSLAncerSketch_ConstructorCast : INode 
	{
		public mdsLINEComLib.IMDSLAncerSketch _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as mdsLINEComLib.IMDSLAncerSketch;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Element
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
		Text = "property Element", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Element
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
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Position
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "property Position", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Position
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetPositionMM", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method GetPositionMM
	///</summary>
	public class GetPositionMM : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetPositionMM);

		}
	}


	[NVP_Manifest(
		Text = "property HeightMark", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property HeightMark
	///</summary>
	public class HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeightMark);

		}
	}


	[NVP_Manifest(
		Text = "property HeightMark", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property HeightMark
	///</summary>
	public class Set_HeightMark : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HeightMark = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Azimuth1", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Azimuth1
	///</summary>
	public class Azimuth1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Azimuth1);

		}
	}


	[NVP_Manifest(
		Text = "property Azimuth1", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Azimuth1
	///</summary>
	public class Set_Azimuth1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Azimuth1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Azimuth2", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Azimuth2
	///</summary>
	public class Azimuth2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Azimuth2);

		}
	}


	[NVP_Manifest(
		Text = "property Azimuth2", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Azimuth2
	///</summary>
	public class Set_Azimuth2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Azimuth2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Angle1", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Angle1
	///</summary>
	public class Angle1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle1);

		}
	}


	[NVP_Manifest(
		Text = "property Angle1", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Angle1
	///</summary>
	public class Set_Angle1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Angle2", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Angle2
	///</summary>
	public class Angle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle2);

		}
	}


	[NVP_Manifest(
		Text = "property Angle2", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Angle2
	///</summary>
	public class Set_Angle2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR_ListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleH_BTR_ListBox
	///</summary>
	public class ScaleH_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleH_BTR_ListBox);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR_ListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ScaleH_BTR_ListBox
	///</summary>
	public class Set_ScaleH_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleH_BTR_ListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleH_BTR);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleH_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleH_BTR
	///</summary>
	public class Set_ScaleH_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleH_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR_ListBox", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleV_BTR_ListBox
	///</summary>
	public class ScaleV_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleV_BTR_ListBox);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR_ListBox", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ScaleV_BTR_ListBox
	///</summary>
	public class Set_ScaleV_BTR_ListBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleV_BTR_ListBox = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleV_BTR);

		}
	}


	[NVP_Manifest(
		Text = "property ScaleV_BTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ScaleV_BTR
	///</summary>
	public class Set_ScaleV_BTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleV_BTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NameBTR", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NameBTR);

		}
	}


	[NVP_Manifest(
		Text = "property NameBTR", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property NameBTR
	///</summary>
	public class Set_NameBTR : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NameBTR = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NearLeft", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NearLeft
	///</summary>
	public class NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearLeft);

		}
	}


	[NVP_Manifest(
		Text = "property NearLeft", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearLeft
	///</summary>
	public class Set_NearLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearLeft = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property NearRight", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property NearRight
	///</summary>
	public class NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NearRight);

		}
	}


	[NVP_Manifest(
		Text = "property NearRight", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property NearRight
	///</summary>
	public class Set_NearRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NearRight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Точка вставки", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Точка вставки
	///</summary>
	public class PlanPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlanPoint);

		}
	}


	[NVP_Manifest(
		Text = "Центр масс проводов", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс проводов
	///</summary>
	public class WireAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WireAverageHeight);

		}
	}


	[NVP_Manifest(
		Text = "Центр масс тросов", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс тросов
	///</summary>
	public class TrosAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TrosAverageHeight);

		}
	}


	[NVP_Manifest(
		Text = "Центр масс ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Центр масс ВОК
	///</summary>
	public class OpticalAverageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OpticalAverageHeight);

		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на проводе
	///</summary>
	public class GarlandWireEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на проводе
	///</summary>
	public class Set_GarlandWireEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Количество гирлянд на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на проводе
	///</summary>
	public class GarlandWireCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireCount);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandWireInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireInsulatorType);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandWireInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на проводе
	///</summary>
	public class GarlandWireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на проводе
	///</summary>
	public class Set_GarlandWireLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на проводе
	///</summary>
	public class GarlandWireWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireWeight);

		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на проводе
	///</summary>
	public class Set_GarlandWireWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandWireDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandWireDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на проводе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на проводе
	///</summary>
	public class GarlandWireChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandWireChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на проводе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на проводе
	///</summary>
	public class Set_GarlandWireChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandWireChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на тросе
	///</summary>
	public class GarlandTrosEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Количество гирлянд на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на тросе
	///</summary>
	public class GarlandTrosCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosCount);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandTrosInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosInsulatorType);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandTrosInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на тросе
	///</summary>
	public class GarlandTrosLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на тросе
	///</summary>
	public class GarlandTrosWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosWeight);

		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandTrosDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandTrosDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на тросе", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на тросе
	///</summary>
	public class GarlandTrosChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandTrosChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на тросе", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на тросе
	///</summary>
	public class Set_GarlandTrosChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandTrosChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method HeightMinNode", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method HeightMinNode
	///</summary>
	public class HeightMinNode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HeightMinNode);

		}
	}


	[NVP_Manifest(
		Text = "method numInLine", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method numInLine
	///</summary>
	public class numInLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.numInLine);

		}
	}


	[NVP_Manifest(
		Text = "method hasGarlands", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///method hasGarlands
	///</summary>
	public class hasGarlands : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.hasGarlands);

		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Имеются гирлянды на ВОК
	///</summary>
	public class GarlandOpticalEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Имеются гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Имеются гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Количество гирлянд на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Количество гирлянд на ВОК
	///</summary>
	public class GarlandOpticalCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalCount);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class GarlandOpticalInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalInsulatorType);

		}
	}


	[NVP_Manifest(
		Text = "Тип изолятора", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Тип изолятора
	///</summary>
	public class Set_GarlandOpticalInsulatorType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalInsulatorType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Длина гирлянды на ВОК
	///</summary>
	public class GarlandOpticalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalLength);

		}
	}


	[NVP_Manifest(
		Text = "Длина гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Длина гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Масса гирлянды на ВОК
	///</summary>
	public class GarlandOpticalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalWeight);

		}
	}


	[NVP_Manifest(
		Text = "Масса гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Масса гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///мм)
	///</summary>
	public class GarlandOpticalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalDiameter);

		}
	}


	[NVP_Manifest(
		Text = "мм)", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///мм)
	///</summary>
	public class Set_GarlandOpticalDiameter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalDiameter = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Число цепей изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainCount);

		}
	}


	[NVP_Manifest(
		Text = "Число цепей изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Число цепей изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainCount = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainLayout);

		}
	}


	[NVP_Manifest(
		Text = "Расположение цепей изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Расположение цепей изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainLayout : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainLayout = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на ВОК", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на ВОК
	///</summary>
	public class GarlandOpticalChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GarlandOpticalChainDistance);

		}
	}


	[NVP_Manifest(
		Text = "Расстояние между цепями изоляторов гирлянды на ВОК", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Расстояние между цепями изоляторов гирлянды на ВОК
	///</summary>
	public class Set_GarlandOpticalChainDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GarlandOpticalChainDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Phi", 
		ViewType = "Data")]
	[NodeInput("MDSLAncerSketch", typeof(object))]

	///<summary>
	///property Phi
	///</summary>
	public class Phi : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Phi);

		}
	}


	[NVP_Manifest(
		Text = "property Phi", 
		ViewType = "Modifier")]
	[NodeInput("MDSLAncerSketch", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Phi
	///</summary>
	public class Set_Phi : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Phi = inputs[1].Value;
			return null;
		}
	}
}
