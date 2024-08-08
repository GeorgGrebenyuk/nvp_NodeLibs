using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Multi-Leader Interface
///</summary>
namespace OdaX.AcadMLeader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies or returns the scale factor of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the scale factor of a multileader.
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
		Text = "Specifies or returns the scale factor of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale factor of a multileader.
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
		Text = "Specifies or returns the type of multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the type of multileader.
	///</summary>
	public class LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of multileader.
	///</summary>
	public class Set_LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the color of a multileader.
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
		Text = "Specifies or returns the color of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a multileader.
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
		Text = "Specifies or returns the linetype of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a multileader.
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
		Text = "Specifies or returns the linetype of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype of a multileader.
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a multileader.
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
		Text = "Specifies or returns the lineweight of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a multileader.
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead type of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead type of a multileader.
	///</summary>
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead type of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the arrowhead type of a multileader.
	///</summary>
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead size of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the arrowhead size of a multileader.
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the arrowhead size of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the arrowhead size of a multileader.
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a dog leg is used for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a dog leg is used for a multileader.
	///</summary>
	public class DogLegged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DogLegged);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a dog leg is used for a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("val", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a dog leg is used for a multileader.
	///</summary>
	public class Set_DogLegged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DogLegged = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the dog leg length of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the dog leg length of a multileader.
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
		Text = "Specifies or returns the dog leg length of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("DoglegLength", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dog leg length of a multileader.
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
		Text = "Specifies or returns the block name of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the block name of a multileader.
	///</summary>
	public class ContentBlockName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentBlockName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block name of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the block name of a multileader.
	///</summary>
	public class Set_ContentBlockName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentBlockName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how a block connects with lines of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how a block connects with lines of a multileader.
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
		Text = "Specifies or returns how a block connects with lines of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcBlockConnectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how a block connects with lines of a multileader.
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
		Text = "Specify how leaders connect with content block", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specify how leaders connect with content block
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
		Text = "Specify how leaders connect with content block", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specify how leaders connect with content block
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
		Text = "Specifies or returns the text string of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the text string of a multileader.
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
		Text = "Specifies or returns the text string of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text string of a multileader.
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
		Text = "Specifies or returns the style for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the style for text of a multileader.
	///</summary>
	public class TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the style for text of a multileader.
	///</summary>
	public class Set_TextStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the attachment point for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the attachment point for text of a multileader.
	///</summary>
	public class TextJustify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextJustify);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the attachment point for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcAttachmentPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the attachment point for text of a multileader.
	///</summary>
	public class Set_TextJustify : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextJustify = ((OdaX.AcAttachmentPoint)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text direction for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the text direction for text of a multileader.
	///</summary>
	public class TextDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextDirection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text direction for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcDrawingDirection", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text direction for text of a multileader.
	///</summary>
	public class Set_TextDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextDirection = ((OdaX.AcDrawingDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns text width for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns text width for text of a multileader.
	///</summary>
	public class TextWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextWidth);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns text width for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies or returns text width for text of a multileader.
	///</summary>
	public class Set_TextWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns text height for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns text height for text of a multileader.
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
		Text = "Specifies or returns text height for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns text height for text of a multileader.
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
		Text = "Specifies or returns the rotation for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the rotation for text of a multileader.
	///</summary>
	public class TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation for text of a multileader.
	///</summary>
	public class Set_TextRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing factor for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing factor for text of a multileader.
	///</summary>
	public class TextLineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing factor for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("factor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing factor for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing distance for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing distance for text of a multileader.
	///</summary>
	public class TextLineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingDistance);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing distance for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Value", typeof(System.Double))]

	///<summary>
	///Specifies or returns the line spacing distance for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing style for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the line spacing style for text of a multileader.
	///</summary>
	public class TextLineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLineSpacingStyle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the line spacing style for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcLineSpacingStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the line spacing style for text of a multileader.
	///</summary>
	public class Set_TextLineSpacingStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLineSpacingStyle = ((OdaX.AcLineSpacingStyle)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a background is used used for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a background is used used for text of a multileader.
	///</summary>
	public class TextBackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextBackgroundFill);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a background is used used for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("bUseBackgroundFill", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a background is used used for text of a multileader.
	///</summary>
	public class Set_TextBackgroundFill : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextBackgroundFill = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies if leaders connect with the text horizontally or vertically", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies if leaders connect with the text horizontally or vertically
	///</summary>
	public class TextAttachmentDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAttachmentDirection);

		}
	}


	[NVP_Manifest(
		Text = "Specifies if leaders connect with the text horizontally or vertically", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentDirection", typeof(System.Object))]

	///<summary>
	///Specifies if leaders connect with the text horizontally or vertically
	///</summary>
	public class Set_TextAttachmentDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAttachmentDirection = ((OdaX.AcTextAttachmentDirection)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns how leaders on the left connect with text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how leaders on the left connect with text of a multileader.
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
		Text = "Specifies or returns how leaders on the left connect with text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how leaders on the left connect with text of a multileader.
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
		Text = "Specifies or returns how leaders on the right connect with text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns how leaders on the right connect with text of a multileader.
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
		Text = "Specifies or returns how leaders on the right connect with text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how leaders on the right connect with text of a multileader.
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
		Text = "Specifies how leaders on the top connect with the text", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies how leaders on the top connect with the text
	///</summary>
	public class TextTopAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextTopAttachmentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies how leaders on the top connect with the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcVerticalTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies how leaders on the top connect with the text
	///</summary>
	public class Set_TextTopAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextTopAttachmentType = ((OdaX.AcVerticalTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies how leaders on the bottom connect with the text", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies how leaders on the bottom connect with the text
	///</summary>
	public class TextBottomAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextBottomAttachmentType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies how leaders on the bottom connect with the text", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcVerticalTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies how leaders on the bottom connect with the text
	///</summary>
	public class Set_TextBottomAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextBottomAttachmentType = ((OdaX.AcVerticalTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specify or returns the landing gap for text of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specify or returns the landing gap for text of a multileader.
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
		Text = "Specify or returns the landing gap for text of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("gap", typeof(System.Double))]

	///<summary>
	///Specify or returns the landing gap for text of a multileader.
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
		Text = "Specifies or returns the block to use as the custom arrowhead of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the block to use as the custom arrowhead of a multileader.
	///</summary>
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block to use as the custom arrowhead of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies or returns the block to use as the custom arrowhead of a multileader.
	///</summary>
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of block used as the custom arrowhead of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the type of block used as the custom arrowhead of a multileader.
	///</summary>
	public class ContentBlockType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentBlockType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the type of block used as the custom arrowhead of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcPredefBlockType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of block used as the custom arrowhead of a multileader.
	///</summary>
	public class Set_ContentBlockType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentBlockType = ((OdaX.AcPredefBlockType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the number of leader lines for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Returns the number of leader lines for a multileader.
	///</summary>
	public class LeaderCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderCount);

		}
	}


	[NVP_Manifest(
		Text = "Adds a new cluster of leader lines to a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Adds a new cluster of leader lines to a multileader.
	///</summary>
	public class AddLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeader);

		}
	}


	[NVP_Manifest(
		Text = "Deletes a cluster of leader lines from a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Deletes a cluster of leader lines from a multileader.
	///</summary>
	public class RemoveLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveLeader(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Adds a leader line to the leader cluster of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Adds a leader line to the leader cluster of a multileader.
	///</summary>
	public class AddLeaderLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeaderLine(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Adds a new leader line to a multileader using a start vertex for the leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Adds a new leader line to a multileader using a start vertex for the leader line.
	///</summary>
	public class AddLeaderLineEx : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddLeaderLineEx(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Deletes a leader line from a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Deletes a leader line from a multileader.
	///</summary>
	public class RemoveLeaderLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveLeaderLine(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the vertices for a leader line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]
	[NodeInput("pointArray", typeof(System.Object))]

	///<summary>
	///Specifies the vertices for a leader line.
	///</summary>
	public class SetLeaderLineVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLeaderLineVertices(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the vertices for a leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Specifies the vertices for a leader line.
	///</summary>
	public class GetLeaderLineVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderLineVertices(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the content type of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderContentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the content type of a multileader.
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
		Text = "Specifies or returns the content type of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the content type of a multileader.
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
		Text = "Returns the index of the leader cluster to which a specified leader line belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Returns the index of the leader cluster to which a specified leader line belongs.
	///</summary>
	public class GetLeaderIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderIndex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the index of a leader line.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Returns the index of a leader line.
	///</summary>
	public class GetLeaderLineIndexes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLeaderLineIndexes(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the number of vertices in a leader line of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderLineIndex", typeof(System.Int32))]

	///<summary>
	///Returns the number of vertices in a leader line of a multileader.
	///</summary>
	public class GetVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVertexCount(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a text frame displays for a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns whether a text frame displays for a multileader.
	///</summary>
	public class TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextFrameDisplay);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a text frame displays for a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a text frame displays for a multileader.
	///</summary>
	public class Set_TextFrameDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextFrameDisplay = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style name of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]

	///<summary>
	///Specifies or returns the style name of a multileader.
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style name of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the style name of a multileader.
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the dog leg direction of a multileader.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]

	///<summary>
	///Returns the dog leg direction of a multileader.
	///</summary>
	public class GetDoglegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoglegDirection(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the dog leg direction of a multileader.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("leaderIndex", typeof(System.Int32))]
	[NodeInput("dirVec", typeof(System.Object))]

	///<summary>
	///Specifies the dog leg direction of a multileader.
	///</summary>
	public class SetDoglegDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoglegDirection(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the attribute value of a block.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("attdefId", typeof(System.Object))]

	///<summary>
	///Returns the attribute value of a block.
	///</summary>
	public class GetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBlockAttributeValue(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the attribute value of a block.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeader", typeof(object))]
	[NodeInput("attdefId", typeof(System.Object))]
	[NodeInput("Value", typeof(System.String))]

	///<summary>
	///Specifies the attribute value of a block.
	///</summary>
	public class SetBlockAttributeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBlockAttributeValue(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
