using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrNodeTerminator Interface
///</summary>
namespace vCSViperCSObjComLib.WrNodeTerminator 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeTerminator_Constructor : INode 
	{
		public vCSViperCSObjComLib.IWrNodeTerminator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as vCSViperCSObjComLib.IWrNodeTerminator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrNodeTerminator_ConstructorCast : INode 
	{
		public vCSViperCSObjComLib.IWrNodeTerminator _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as vCSViperCSObjComLib.IWrNodeTerminator;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Слой по умолчанию", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVar", typeof(System.Object))]

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
		Text = "property ViewMode", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property Position", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

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
		Text = "property PositionIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PositionIsFixed);

		}
	}


	[NVP_Manifest(
		Text = "property PositionIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property PositionIsFixed
	///</summary>
	public class Set_PositionIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PositionIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property VectorIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property VectorIsFixed
	///</summary>
	public class VectorIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VectorIsFixed);

		}
	}


	[NVP_Manifest(
		Text = "property VectorIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property VectorIsFixed
	///</summary>
	public class Set_VectorIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VectorIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ProfileIsFixed", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ProfileIsFixed
	///</summary>
	public class ProfileIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ProfileIsFixed);

		}
	}


	[NVP_Manifest(
		Text = "property ProfileIsFixed", 
		ViewType = "Modifier")]
	[NodeInput("WrNodeTerminator", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property ProfileIsFixed
	///</summary>
	public class Set_ProfileIsFixed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ProfileIsFixed = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Номер на линии", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
		Text = "property Part_Name", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property PartPipe_DN", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property PartPipe_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property PartPipe_Length", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property Axis_Insulation_Thickness", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
		Text = "property HasConnectionJoin", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoin
	///</summary>
	public class HasConnectionJoin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoin);

		}
	}


	[NVP_Manifest(
		Text = "property ConnectionJoin", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoin
	///</summary>
	public class ConnectionJoin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoin);

		}
	}


	[NVP_Manifest(
		Text = "property HasConnectionJoinStart", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoinStart
	///</summary>
	public class HasConnectionJoinStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoinStart);

		}
	}


	[NVP_Manifest(
		Text = "property ConnectionJoinStart", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoinStart
	///</summary>
	public class ConnectionJoinStart : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoinStart);

		}
	}


	[NVP_Manifest(
		Text = "property HasConnectionJoinEnd", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property HasConnectionJoinEnd
	///</summary>
	public class HasConnectionJoinEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasConnectionJoinEnd);

		}
	}


	[NVP_Manifest(
		Text = "property ConnectionJoinEnd", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

	///<summary>
	///property ConnectionJoinEnd
	///</summary>
	public class ConnectionJoinEnd : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ConnectionJoinEnd);

		}
	}


	[NVP_Manifest(
		Text = "property LockComponent", 
		ViewType = "Data")]
	[NodeInput("WrNodeTerminator", typeof(object))]

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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
	[NodeInput("WrNodeTerminator", typeof(object))]
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
