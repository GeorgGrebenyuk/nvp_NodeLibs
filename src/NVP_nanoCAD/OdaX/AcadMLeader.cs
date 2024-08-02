using NVP.API.Nodes;

namespace OdaX.AcadMLeader 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadMLeader_Constructor : INode 
		{
		public OdaX.IAcadMLeader _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadMLeader;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadMLeader_ConstructorCast : INode 
		{
		public OdaX.IAcadMLeader _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadMLeader;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the scale factor of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the scale factor of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies or returns the type of multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LeaderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderType);

			}
		}


		///<summary>
		///Specifies or returns the type of multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_LeaderType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LeaderType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the color of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LeaderLineColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineColor);

			}
		}


		///<summary>
		///Specifies or returns the color of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
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
		///Specifies or returns the linetype of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LeaderLineType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineType);

			}
		}


		///<summary>
		///Specifies or returns the linetype of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Linetype", typeof(System.Object))]
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
		///Specifies or returns the lineweight of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LeaderLineWeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderLineWeight);

			}
		}


		///<summary>
		///Specifies or returns the lineweight of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Lineweight", typeof(System.Object))]
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
		///Specifies or returns the arrowhead type of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ArrowheadType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrowheadType);

			}
		}


		///<summary>
		///Specifies or returns the arrowhead type of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("BlockName", typeof(System.Object))]
		public class Set_ArrowheadType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArrowheadType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the arrowhead size of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ArrowheadSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrowheadSize);

			}
		}


		///<summary>
		///Specifies or returns the arrowhead size of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("size", typeof(System.Double))]
		public class Set_ArrowheadSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArrowheadSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a dog leg is used for a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class DogLegged : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DogLegged);

			}
		}


		///<summary>
		///Specifies or returns whether a dog leg is used for a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_DogLegged : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DogLegged = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the dog leg length of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class DoglegLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DoglegLength);

			}
		}


		///<summary>
		///Specifies or returns the dog leg length of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies or returns the block name of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ContentBlockName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContentBlockName);

			}
		}


		///<summary>
		///Specifies or returns the block name of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("BlockName", typeof(System.String))]
		public class Set_ContentBlockName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ContentBlockName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how a block connects with lines of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class BlockConnectionType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockConnectionType);

			}
		}


		///<summary>
		///Specifies or returns how a block connects with lines of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specify how leaders connect with content block
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class BlockScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BlockScale);

			}
		}


		///<summary>
		///Specify how leaders connect with content block
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("factor", typeof(System.Object))]
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
		///Specifies or returns the text string of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextString : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextString);

			}
		}


		///<summary>
		///Specifies or returns the text string of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("bstrText", typeof(System.String))]
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
		///Specifies or returns the style for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextStyleName);

			}
		}


		///<summary>
		///Specifies or returns the style for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_TextStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextStyleName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the attachment point for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextJustify : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextJustify);

			}
		}


		///<summary>
		///Specifies or returns the attachment point for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("attPoint", typeof(System.Object))]
		public class Set_TextJustify : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextJustify = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the text direction for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextDirection);

			}
		}


		///<summary>
		///Specifies or returns the text direction for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("drawDir", typeof(System.Object))]
		public class Set_TextDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextDirection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns text width for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextWidth);

			}
		}


		///<summary>
		///Specifies or returns text width for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Width", typeof(System.Double))]
		public class Set_TextWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns text height for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextHeight);

			}
		}


		///<summary>
		///Specifies or returns text height for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies or returns the rotation for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextRotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("rotAngle", typeof(System.Object))]
		public class Set_TextRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextRotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the line spacing factor for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextLineSpacingFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextLineSpacingFactor);

			}
		}


		///<summary>
		///Specifies or returns the line spacing factor for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("factor", typeof(System.Double))]
		public class Set_TextLineSpacingFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextLineSpacingFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the line spacing distance for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextLineSpacingDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextLineSpacingDistance);

			}
		}


		///<summary>
		///Specifies or returns the line spacing distance for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Value", typeof(System.Double))]
		public class Set_TextLineSpacingDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextLineSpacingDistance = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the line spacing style for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextLineSpacingStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextLineSpacingStyle);

			}
		}


		///<summary>
		///Specifies or returns the line spacing style for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("style", typeof(System.Object))]
		public class Set_TextLineSpacingStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextLineSpacingStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether a background is used used for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextBackgroundFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextBackgroundFill);

			}
		}


		///<summary>
		///Specifies or returns whether a background is used used for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("bUseBackgroundFill", typeof(System.Object))]
		public class Set_TextBackgroundFill : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextBackgroundFill = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies if leaders connect with the text horizontally or vertically
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextAttachmentDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextAttachmentDirection);

			}
		}


		///<summary>
		///Specifies if leaders connect with the text horizontally or vertically
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("dir", typeof(System.Object))]
		public class Set_TextAttachmentDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextAttachmentDirection = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns how leaders on the left connect with text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextLeftAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextLeftAttachmentType);

			}
		}


		///<summary>
		///Specifies or returns how leaders on the left connect with text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies or returns how leaders on the right connect with text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextRightAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextRightAttachmentType);

			}
		}


		///<summary>
		///Specifies or returns how leaders on the right connect with text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies how leaders on the top connect with the text
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextTopAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextTopAttachmentType);

			}
		}


		///<summary>
		///Specifies how leaders on the top connect with the text
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextTopAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextTopAttachmentType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies how leaders on the bottom connect with the text
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextBottomAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextBottomAttachmentType);

			}
		}


		///<summary>
		///Specifies how leaders on the bottom connect with the text
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_TextBottomAttachmentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextBottomAttachmentType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specify or returns the landing gap for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LandingGap : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LandingGap);

			}
		}


		///<summary>
		///Specify or returns the landing gap for text of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("gap", typeof(System.Double))]
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
		///Specifies or returns the block to use as the custom arrowhead of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ArrowheadBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArrowheadBlock);

			}
		}


		///<summary>
		///Specifies or returns the block to use as the custom arrowhead of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("BlockName", typeof(System.String))]
		public class Set_ArrowheadBlock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArrowheadBlock = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the type of block used as the custom arrowhead of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ContentBlockType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContentBlockType);

			}
		}


		///<summary>
		///Specifies or returns the type of block used as the custom arrowhead of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Type", typeof(System.Object))]
		public class Set_ContentBlockType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ContentBlockType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the number of leader lines for a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class LeaderCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LeaderCount);

			}
		}


		///<summary>
		///Adds a new cluster of leader lines to a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class AddLeader : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddLeader);

			}
		}


		///<summary>
		///Deletes a cluster of leader lines from a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderIndex", typeof(System.Int32))]
		public class RemoveLeader : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveLeader(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Adds a leader line to the leader cluster of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderIndex", typeof(System.Int32))]
		[NodeInput("pointArray", typeof(System.Object))]
		public class AddLeaderLine : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddLeaderLine(inputs[1],inputs[2]));

			}
		}


		///<summary>
		///Adds a new leader line to a multileader using a start vertex for the leader line.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("pointArray", typeof(System.Object))]
		public class AddLeaderLineEx : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddLeaderLineEx(inputs[1]));

			}
		}


		///<summary>
		///Deletes a leader line from a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderLineIndex", typeof(System.Int32))]
		public class RemoveLeaderLine : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveLeaderLine(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Specifies the vertices for a leader line.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderLineIndex", typeof(System.Int32))]
		[NodeInput("pointArray", typeof(System.Object))]
		public class SetLeaderLineVertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetLeaderLineVertices(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Specifies the vertices for a leader line.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderLineIndex", typeof(System.Int32))]
		public class GetLeaderLineVertices : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLeaderLineVertices(inputs[1]));

			}
		}


		///<summary>
		///Specifies or returns the content type of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
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
		///Specifies or returns the content type of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class ContentType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ContentType);

			}
		}


		///<summary>
		///Returns the index of the leader cluster to which a specified leader line belongs.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderLineIndex", typeof(System.Int32))]
		public class GetLeaderIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLeaderIndex(inputs[1]));

			}
		}


		///<summary>
		///Returns the index of a leader line.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderIndex", typeof(System.Int32))]
		public class GetLeaderLineIndexes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLeaderLineIndexes(inputs[1]));

			}
		}


		///<summary>
		///Returns the number of vertices in a leader line of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderLineIndex", typeof(System.Int32))]
		public class GetVertexCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetVertexCount(inputs[1]));

			}
		}


		///<summary>
		///Specifies or returns whether a text frame displays for a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class TextFrameDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextFrameDisplay);

			}
		}


		///<summary>
		///Specifies or returns whether a text frame displays for a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_TextFrameDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TextFrameDisplay = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the style name of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		public class StyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleName);

			}
		}


		///<summary>
		///Specifies or returns the style name of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_StyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StyleName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the dog leg direction of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderIndex", typeof(System.Int32))]
		public class GetDoglegDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetDoglegDirection(inputs[1]));

			}
		}


		///<summary>
		///Specifies the dog leg direction of a multileader.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("leaderIndex", typeof(System.Int32))]
		[NodeInput("dirVec", typeof(System.Object))]
		public class SetDoglegDirection : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetDoglegDirection(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Returns the attribute value of a block.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("attdefId", typeof(System.Object))]
		public class GetBlockAttributeValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBlockAttributeValue(inputs[1]));

			}
		}


		///<summary>
		///Specifies the attribute value of a block.
		///</summary>
		[NodeInput("AcadMLeader", typeof(object))]
		[NodeInput("attdefId", typeof(System.Object))]
		[NodeInput("Value", typeof(System.String))]
		public class SetBlockAttributeValue : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetBlockAttributeValue(inputs[1],inputs[2]);
				return null;
			}
		}
}
