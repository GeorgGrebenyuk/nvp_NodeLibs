using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrInLine Interface
///</summary>
namespace NVP_ModelStudio_COM._vCSViperCSObjComLib.WrInLine 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInLine_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrInLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrInLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrInLine_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrInLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrInLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PipeLayer);

		}
	}


	[NVP_Manifest(
		Text = "Слой по умолчанию", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Слой по умолчанию
	///</summary>
	public class Set_PipeLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PipeLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Element", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

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
	[NodeInput("WrInLine", typeof(object))]
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
		Text = "property OwnerSegId", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerSegId);

		}
	}


	[NVP_Manifest(
		Text = "property OwnerSegId", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property OwnerSegId
	///</summary>
	public class Set_OwnerSegId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OwnerSegId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ViewMode);

		}
	}


	[NVP_Manifest(
		Text = "property ViewMode", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ViewMode
	///</summary>
	public class Set_ViewMode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ViewMode = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ElementAxis", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElementAxis);

		}
	}


	[NVP_Manifest(
		Text = "property ElementAxis", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ElementAxis
	///</summary>
	public class Set_ElementAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElementAxis = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Reverse", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Reverse);

		}
	}


	[NVP_Manifest(
		Text = "property Reverse", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Reverse
	///</summary>
	public class Set_Reverse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Reverse = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Angle", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Angle
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
		Text = "property Angle", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Angle
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
		Text = "property TeeType", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property TeeType
	///</summary>
	public class TeeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TeeType);

		}
	}


	[NVP_Manifest(
		Text = "property TeeType", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property TeeType
	///</summary>
	public class Set_TeeType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TeeType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property FlowDependence", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property FlowDependence
	///</summary>
	public class FlowDependence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FlowDependence);

		}
	}


	[NVP_Manifest(
		Text = "property FlowDependence", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FlowDependence
	///</summary>
	public class Set_FlowDependence : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FlowDependence = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property FixAngle", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property FixAngle
	///</summary>
	public class FixAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FixAngle);

		}
	}


	[NVP_Manifest(
		Text = "property FixAngle", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property FixAngle
	///</summary>
	public class Set_FixAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FixAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Name);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Name", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Name
	///</summary>
	public class Set_Part_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Tag", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Tag);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Tag", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Tag
	///</summary>
	public class Set_Part_Tag : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Tag = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Manufacturer", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Manufacturer);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Manufacturer", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Manufacturer
	///</summary>
	public class Set_Part_Manufacturer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Manufacturer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Standard", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Standard);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Standard
	///</summary>
	public class Set_Part_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Refdrawing", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Refdrawing);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Refdrawing", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Refdrawing
	///</summary>
	public class Set_Part_Refdrawing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Refdrawing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Material", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Material", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material
	///</summary>
	public class Set_Part_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Material_Standard", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Material_Standard);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Material_Standard", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Material_Standard
	///</summary>
	public class Set_Part_Material_Standard : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Material_Standard = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight
	///</summary>
	public class Set_Part_Weight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Comment);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Comment
	///</summary>
	public class Set_Part_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Начальная точка", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Начальная точка
	///</summary>
	public class PointStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointStart);

		}
	}


	[NVP_Manifest(
		Text = "Конечная точка", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Конечная точка
	///</summary>
	public class PointEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PointEnd);

		}
	}


	[NVP_Manifest(
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Номер на линии
	///</summary>
	public class OrderOnLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrderOnLine);

		}
	}


	[NVP_Manifest(
		Text = "Объект изоляции", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Insulation);

		}
	}


	[NVP_Manifest(
		Text = "Объект изоляции", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Объект изоляции
	///</summary>
	public class Set_Insulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Insulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Наличие изоляции", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///Наличие изоляции
	///</summary>
	public class HasInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasInsulation);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_PN", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_PN);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_PN", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_PN
	///</summary>
	public class Set_PartPipe_PN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_PN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN
	///</summary>
	public class Set_PartPipe_DN : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam
	///</summary>
	public class Set_PartPipe_Diam : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN1);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN1
	///</summary>
	public class Set_PartPipe_DN1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam1);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam1
	///</summary>
	public class Set_PartPipe_Diam1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_DN2
	///</summary>
	public class PartPipe_DN2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_DN2);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_DN2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_DN2
	///</summary>
	public class Set_PartPipe_DN2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_DN2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Diam2
	///</summary>
	public class PartPipe_Diam2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Diam2);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Diam2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PartPipe_Diam2
	///</summary>
	public class Set_PartPipe_Diam2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Diam2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness
	///</summary>
	public class Set_PartPipe_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness1", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness1
	///</summary>
	public class PartPipe_Thickness1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness1);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness1", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness1
	///</summary>
	public class Set_PartPipe_Thickness1 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness1 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness2", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Thickness2
	///</summary>
	public class PartPipe_Thickness2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Thickness2);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Thickness2", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property PartPipe_Thickness2
	///</summary>
	public class Set_PartPipe_Thickness2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Thickness2 = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Length);

		}
	}


	[NVP_Manifest(
		Text = "property PartPipe_Length", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property PartPipe_Length
	///</summary>
	public class Set_PartPipe_Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Length = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Group);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Group
	///</summary>
	public class Set_Part_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Type", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Type);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Type", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Type
	///</summary>
	public class Set_Part_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Type = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Reference", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Reference);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Reference", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Reference
	///</summary>
	public class Set_Part_Reference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Reference = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight_Netto", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Netto);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight_Netto", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Netto
	///</summary>
	public class Set_Part_Weight_Netto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Netto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight_Bruto", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Weight_Bruto);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Weight_Bruto", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Part_Weight_Bruto
	///</summary>
	public class Set_Part_Weight_Bruto : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Weight_Bruto = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Part_Insulation_Thickness
	///</summary>
	public class Set_Part_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Part_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Text = "property Part_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Part_Insulation_Disableview
	///</summary>
	public class Set_Part_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Part_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Thickness);

		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property Axis_Insulation_Thickness
	///</summary>
	public class Set_Axis_Insulation_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_Disableview);

		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_Disableview", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_Disableview
	///</summary>
	public class Set_Axis_Insulation_Disableview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_Disableview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineInsulation);

		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_LineInsulation", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineInsulation
	///</summary>
	public class Set_Axis_Insulation_LineInsulation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineInsulation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Axis_Insulation_LineTrace);

		}
	}


	[NVP_Manifest(
		Text = "property Axis_Insulation_LineTrace", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Axis_Insulation_LineTrace
	///</summary>
	public class Set_Axis_Insulation_LineTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Axis_Insulation_LineTrace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetAxisParamValue", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("ParameterName", typeof(System.String))]

	///<summary>
	///method GetAxisParamValue
	///</summary>
	public class GetAxisParamValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAxisParamValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "property Explication_Include", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Include);

		}
	}


	[NVP_Manifest(
		Text = "property Explication_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Explication_Include
	///</summary>
	public class Set_Explication_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Explication_Number", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Number);

		}
	}


	[NVP_Manifest(
		Text = "property Explication_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Number
	///</summary>
	public class Set_Explication_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Explication_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Group);

		}
	}


	[NVP_Manifest(
		Text = "property Explication_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Group
	///</summary>
	public class Set_Explication_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Explication_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explication_Comment);

		}
	}


	[NVP_Manifest(
		Text = "property Explication_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Explication_Comment
	///</summary>
	public class Set_Explication_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Explication_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bom_Include", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Include);

		}
	}


	[NVP_Manifest(
		Text = "property Bom_Include", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property Bom_Include
	///</summary>
	public class Set_Bom_Include : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Include = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bom_Number", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Number);

		}
	}


	[NVP_Manifest(
		Text = "property Bom_Number", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Number
	///</summary>
	public class Set_Bom_Number : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Number = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bom_Group", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Group);

		}
	}


	[NVP_Manifest(
		Text = "property Bom_Group", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Group
	///</summary>
	public class Set_Bom_Group : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Group = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bom_Qty", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Qty);

		}
	}


	[NVP_Manifest(
		Text = "property Bom_Qty", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Qty
	///</summary>
	public class Set_Bom_Qty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Qty = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property Bom_Comment", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Bom_Comment);

		}
	}


	[NVP_Manifest(
		Text = "property Bom_Comment", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///property Bom_Comment
	///</summary>
	public class Set_Bom_Comment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Bom_Comment = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property BranchAxis", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property BranchAxis
	///</summary>
	public class BranchAxis : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BranchAxis);

		}
	}


	[NVP_Manifest(
		Text = "property HasBranch", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property HasBranch
	///</summary>
	public class HasBranch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasBranch);

		}
	}


	[NVP_Manifest(
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PartPipe_Lock);

		}
	}


	[NVP_Manifest(
		Text = "property LockComponent", 
		ViewType = "Modifier")]
	[NodeInput("WrInLine", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property LockComponent
	///</summary>
	public class Set_PartPipe_Lock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PartPipe_Lock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "method GetArea", 
		ViewType = "Data")]
	[NodeInput("WrInLine", typeof(object))]
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
	[NodeInput("WrInLine", typeof(object))]
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
