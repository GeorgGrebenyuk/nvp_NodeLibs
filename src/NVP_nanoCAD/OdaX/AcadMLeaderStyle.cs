using NVP.API.Nodes;

namespace OdaX.AcadMLeaderStyle 
{
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


		///<summary>
		///Specifies or returns the name of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the description of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///Specifies or returns the description of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Description", typeof(System.String))]
		public class Set_Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Description = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the operation bit set of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BitFlags : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BitFlags);

			}
		}


		///<summary>
		///Specifies or returns the operation bit set of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("bitFlag", typeof(System.Object))]
		public class Set_BitFlags : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BitFlags = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the content type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class ContentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContentType);

			}
		}


		///<summary>
		///Specifies or returns the content type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_ContentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ContentType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the order of multileader creation for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class DrawMLeaderOrderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DrawMLeaderOrderType);

			}
		}


		///<summary>
		///Specifies or returns the order of multileader creation for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_DrawMLeaderOrderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DrawMLeaderOrderType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the order of leader creation for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class DrawLeaderOrderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DrawLeaderOrderType);

			}
		}


		///<summary>
		///Specifies or returns the order of leader creation for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_DrawLeaderOrderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DrawLeaderOrderType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class MaxLeaderSegmentsPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaxLeaderSegmentsPoints);

			}
		}


		///<summary>
		///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("number", typeof(System.Int32))]
		public class Set_MaxLeaderSegmentsPoints : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MaxLeaderSegmentsPoints = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class FirstSegmentAngleConstraint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FirstSegmentAngleConstraint);

			}
		}


		///<summary>
		///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("constraint", typeof(System.Object))]
		public class Set_FirstSegmentAngleConstraint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FirstSegmentAngleConstraint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class SecondSegmentAngleConstraint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SecondSegmentAngleConstraint);

			}
		}


		///<summary>
		///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("constraint", typeof(System.Object))]
		public class Set_SecondSegmentAngleConstraint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SecondSegmentAngleConstraint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the leader line type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class LeaderLineType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineType);

			}
		}


		///<summary>
		///Specifies or returns the leader line type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_LeaderLineType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LeaderLineType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class LeaderLineColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineColor);

			}
		}


		///<summary>
		///Specifies or returns the color of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_LeaderLineColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LeaderLineColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the linetype of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class LeaderLineTypeId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineTypeId);

			}
		}


		///<summary>
		///Specifies or returns the linetype of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_LeaderLineTypeId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LeaderLineTypeId = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lineweight of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class LeaderLineWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineWeight);

			}
		}


		///<summary>
		///Specifies or returns the lineweight of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("weight", typeof(System.Object))]
		public class Set_LeaderLineWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LeaderLineWeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class EnableLanding : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EnableLanding);

			}
		}


		///<summary>
		///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("enabled", typeof(System.Object))]
		public class Set_EnableLanding : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableLanding = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class LandingGap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LandingGap);

			}
		}


		///<summary>
		///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("LandingGap", typeof(System.Double))]
		public class Set_LandingGap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LandingGap = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class EnableDogleg : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EnableDogleg);

			}
		}


		///<summary>
		///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("enabled", typeof(System.Object))]
		public class Set_EnableDogleg : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableDogleg = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the dog leg length for leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class DoglegLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DoglegLength);

			}
		}


		///<summary>
		///Specifies or returns the dog leg length for leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("DoglegLength", typeof(System.Double))]
		public class Set_DoglegLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DoglegLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the arrow symbol of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class ArrowSymbol : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrowSymbol);

			}
		}


		///<summary>
		///Specifies or returns the arrow symbol of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_ArrowSymbol : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArrowSymbol = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the arrow size of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class ArrowSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrowSize);

			}
		}


		///<summary>
		///Specifies or returns the arrow size of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("size", typeof(System.Double))]
		public class Set_ArrowSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArrowSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text style of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextStyle);

			}
		}


		///<summary>
		///Specifies or returns the text style of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_TextStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how left-aligned text is positioned for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextLeftAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextLeftAttachmentType);

			}
		}


		///<summary>
		///Specifies or returns how left-aligned text is positioned for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextLeftAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextLeftAttachmentType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how right-aligned text is positioned for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextRightAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextRightAttachmentType);

			}
		}


		///<summary>
		///Specifies or returns how right-aligned text is positioned for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextRightAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextRightAttachmentType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the multline text color of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextColor);

			}
		}


		///<summary>
		///Specifies or returns the multline text color of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_TextColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the multline text height of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextHeight);

			}
		}


		///<summary>
		///Specifies or returns the multline text height of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Height", typeof(System.Double))]
		public class Set_TextHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a frame displays around multline text of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class EnableFrameText : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EnableFrameText);

			}
		}


		///<summary>
		///Specifies or returns whether a frame displays around multline text of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("enabled", typeof(System.Object))]
		public class Set_EnableFrameText : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableFrameText = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the alignment space value of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class AlignSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AlignSpace);

			}
		}


		///<summary>
		///Specifies or returns the alignment space value of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("AlignSpace", typeof(System.Double))]
		public class Set_AlignSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AlignSpace = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the block content of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class Block : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Block);

			}
		}


		///<summary>
		///Specifies or returns the block content of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_Block : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Block = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of block content for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BlockColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockColor);

			}
		}


		///<summary>
		///Specifies or returns the color of block content for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_BlockColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BlockColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the blocks are scaled for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class EnableBlockScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EnableBlockScale);

			}
		}


		///<summary>
		///Specifies or returns whether the blocks are scaled for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("enabled", typeof(System.Object))]
		public class Set_EnableBlockScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableBlockScale = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the block scale value for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BlockScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockScale);

			}
		}


		///<summary>
		///Specifies or returns the block scale value for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Double))]
		public class Set_BlockScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BlockScale = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether blocks are rotated for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class EnableBlockRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EnableBlockRotation);

			}
		}


		///<summary>
		///Specifies or returns whether blocks are rotated for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("enabled", typeof(System.Object))]
		public class Set_EnableBlockRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EnableBlockRotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the rotation value for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BlockRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockRotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation value for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Rotation", typeof(System.Double))]
		public class Set_BlockRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BlockRotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the block connection type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BlockConnectionType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockConnectionType);

			}
		}


		///<summary>
		///Specifies or returns the block connection type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_BlockConnectionType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BlockConnectionType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the multileader scale of a specified multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the multileader scale of a specified multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("scale", typeof(System.Double))]
		public class Set_ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns whether properties were changed for a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class OverwritePropChanged : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OverwritePropChanged);

			}
		}


		///<summary>
		///Specifies or returns the annotative status of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class Annotative : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Annotative);

			}
		}


		///<summary>
		///Specifies or returns the annotative status of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Annotative", typeof(System.Object))]
		public class Set_Annotative : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Annotative = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the gap size used for breaking leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class BreakSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BreakSize);

			}
		}


		///<summary>
		///Specifies or returns the gap size used for breaking leader lines of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("size", typeof(System.Double))]
		public class Set_BreakSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BreakSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the multiline text text string of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextString);

			}
		}


		///<summary>
		///Specifies or returns the multiline text text string of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Text", typeof(System.String))]
		public class Set_TextString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextString = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text angle type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextAngleType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextAngleType);

			}
		}


		///<summary>
		///Specifies or returns the text angle type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextAngleType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextAngleType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text alignment type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		public class TextAlignmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextAlignmentType);

			}
		}


		///<summary>
		///Specifies or returns the text alignment type of a multileader style.
		///</summary>
		[NodeInput("AcadMLeaderStyle", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextAlignmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextAlignmentType = inputs[1];
				return null;
			}
		}
}
