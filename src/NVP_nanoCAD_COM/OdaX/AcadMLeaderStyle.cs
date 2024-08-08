using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///MLeaderStyle Interface
///</summary>
namespace OdaX.AcadMLeaderStyle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderStyle_Constructor : INode 
	{
		public OdaX.IAcadMLeaderStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLeaderStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadMLeaderStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLeaderStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the name of a multileader style.
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
		Text = "Specifies or returns the name of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a multileader style.
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
		Text = "Specifies or returns the description of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the description of a multileader style.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the description of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a multileader style.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the operation bit set of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the operation bit set of a multileader style.
	///</summary>
	public class BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BitFlags);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the operation bit set of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("bitFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the operation bit set of a multileader style.
	///</summary>
	public class Set_BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BitFlags = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the content type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the content type of a multileader style.
	///</summary>
	public class ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the content type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcMLeaderContentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the content type of a multileader style.
	///</summary>
	public class Set_ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentType = ((OdaX.AcMLeaderContentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of multileader creation for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the order of multileader creation for a multileader style.
	///</summary>
	public class DrawMLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawMLeaderOrderType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of multileader creation for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcDrawMLeaderOrderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of multileader creation for a multileader style.
	///</summary>
	public class Set_DrawMLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawMLeaderOrderType = ((OdaX.AcDrawMLeaderOrderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of leader creation for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the order of leader creation for a multileader of a multileader style.
	///</summary>
	public class DrawLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawLeaderOrderType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the order of leader creation for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcDrawLeaderOrderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of leader creation for a multileader of a multileader style.
	///</summary>
	public class Set_DrawLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawLeaderOrderType = ((OdaX.AcDrawLeaderOrderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the maximum number of segment points in multileader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
	///</summary>
	public class MaxLeaderSegmentsPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxLeaderSegmentsPoints);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the maximum number of segment points in multileader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("number", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
	///</summary>
	public class Set_MaxLeaderSegmentsPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxLeaderSegmentsPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the first segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class FirstSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FirstSegmentAngleConstraint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the first segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcSegmentAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class Set_FirstSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FirstSegmentAngleConstraint = ((OdaX.AcSegmentAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the second segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class SecondSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecondSegmentAngleConstraint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the second segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcSegmentAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class Set_SecondSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecondSegmentAngleConstraint = ((OdaX.AcSegmentAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the leader line type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the leader line type of a multileader style.
	///</summary>
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the leader line type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the leader line type of a multileader style.
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the color of leader lines for a multileader style.
	///</summary>
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of leader lines for a multileader style.
	///</summary>
	public class LeaderLineTypeId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineTypeId);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineTypeId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineTypeId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of leader lines for a multileader style.
	///</summary>
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcLineWeight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = ((OdaX.AcLineWeight)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the landing of leader lines is enabled for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
	///</summary>
	public class EnableLanding : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableLanding);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the landing of leader lines is enabled for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
	///</summary>
	public class Set_EnableLanding : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableLanding = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
	///</summary>
	public class LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LandingGap);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("LandingGap", typeof(System.Double))]

	///<summary>
	///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
	///</summary>
	public class Set_LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LandingGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dog legs are enabled for leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
	///</summary>
	public class EnableDogleg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableDogleg);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether dog legs are enabled for leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
	///</summary>
	public class Set_EnableDogleg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableDogleg = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the dog leg length for leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the dog leg length for leader lines of a multileader style.
	///</summary>
	public class DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoglegLength);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the dog leg length for leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("DoglegLength", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dog leg length for leader lines of a multileader style.
	///</summary>
	public class Set_DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoglegLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrow symbol of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the arrow symbol of a multileader style.
	///</summary>
	public class ArrowSymbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSymbol);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrow symbol of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the arrow symbol of a multileader style.
	///</summary>
	public class Set_ArrowSymbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSymbol = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrow size of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the arrow size of a multileader style.
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrow size of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the arrow size of a multileader style.
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text style of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text style of a multileader style.
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text style of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of a multileader style.
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how left-aligned text is positioned for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns how left-aligned text is positioned for a multileader style.
	///</summary>
	public class TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLeftAttachmentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how left-aligned text is positioned for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how left-aligned text is positioned for a multileader style.
	///</summary>
	public class Set_TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLeftAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how right-aligned text is positioned for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns how right-aligned text is positioned for a multileader style.
	///</summary>
	public class TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRightAttachmentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how right-aligned text is positioned for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how right-aligned text is positioned for a multileader style.
	///</summary>
	public class Set_TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRightAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multline text color of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multline text color of a multileader style.
	///</summary>
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multline text color of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the multline text color of a multileader style.
	///</summary>
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multline text height of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multline text height of a multileader style.
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multline text height of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the multline text height of a multileader style.
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a frame displays around multline text of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether a frame displays around multline text of a multileader style.
	///</summary>
	public class EnableFrameText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableFrameText);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a frame displays around multline text of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a frame displays around multline text of a multileader style.
	///</summary>
	public class Set_EnableFrameText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableFrameText = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the alignment space value of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the alignment space value of a multileader style.
	///</summary>
	public class AlignSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AlignSpace);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the alignment space value of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("AlignSpace", typeof(System.Double))]

	///<summary>
	///Specifies or returns the alignment space value of a multileader style.
	///</summary>
	public class Set_AlignSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AlignSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block content of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block content of a multileader style.
	///</summary>
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block content of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the block content of a multileader style.
	///</summary>
	public class Set_Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of block content for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the color of block content for a multileader style.
	///</summary>
	public class BlockColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of block content for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of block content for a multileader style.
	///</summary>
	public class Set_BlockColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the blocks are scaled for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the blocks are scaled for a multileader style.
	///</summary>
	public class EnableBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableBlockScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether the blocks are scaled for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the blocks are scaled for a multileader style.
	///</summary>
	public class Set_EnableBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBlockScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block scale value for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block scale value for a multileader style.
	///</summary>
	public class BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block scale value for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the block scale value for a multileader style.
	///</summary>
	public class Set_BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether blocks are rotated for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether blocks are rotated for a multileader style.
	///</summary>
	public class EnableBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableBlockRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether blocks are rotated for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether blocks are rotated for a multileader style.
	///</summary>
	public class Set_EnableBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBlockRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation value for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the rotation value for a multileader style.
	///</summary>
	public class BlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation value for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Rotation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rotation value for a multileader style.
	///</summary>
	public class Set_BlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block connection type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block connection type of a multileader style.
	///</summary>
	public class BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockConnectionType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block connection type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcBlockConnectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the block connection type of a multileader style.
	///</summary>
	public class Set_BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockConnectionType = ((OdaX.AcBlockConnectionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multileader scale of a specified multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multileader scale of a specified multileader style.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multileader scale of a specified multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the multileader scale of a specified multileader style.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns whether properties were changed for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Returns whether properties were changed for a multileader style.
	///</summary>
	public class OverwritePropChanged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OverwritePropChanged);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the annotative status of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the annotative status of a multileader style.
	///</summary>
	public class Annotative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Annotative);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the annotative status of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Annotative", typeof(System.Object))]

	///<summary>
	///Specifies or returns the annotative status of a multileader style.
	///</summary>
	public class Set_Annotative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Annotative = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gap size used for breaking leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the gap size used for breaking leader lines of a multileader style.
	///</summary>
	public class BreakSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the gap size used for breaking leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the gap size used for breaking leader lines of a multileader style.
	///</summary>
	public class Set_BreakSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multiline text text string of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multiline text text string of a multileader style.
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the multiline text text string of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Specifies or returns the multiline text text string of a multileader style.
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text angle type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text angle type of a multileader style.
	///</summary>
	public class TextAngleType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAngleType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text angle type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text angle type of a multileader style.
	///</summary>
	public class Set_TextAngleType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAngleType = ((OdaX.AcTextAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text alignment type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text alignment type of a multileader style.
	///</summary>
	public class TextAlignmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlignmentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text alignment type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAlignmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text alignment type of a multileader style.
	///</summary>
	public class Set_TextAlignmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlignmentType = ((OdaX.AcTextAlignmentType)inputs[1].Value);
			return null;
		}
	}
}
