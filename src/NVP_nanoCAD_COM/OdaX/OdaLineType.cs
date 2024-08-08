using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///An additional TeighaX Interface to the line characteristics
///</summary>
namespace OdaX.OdaLineType 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLineType_Constructor : INode 
	{
		public OdaX.IOdaLineType _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaLineType;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLineType_ConstructorCast : INode 
	{
		public OdaX.IOdaLineType _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaLineType;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of dashes of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the number of dashes of a linetype.
	///</summary>
	public class NumDashes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumDashes);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of dashes of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Count", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of dashes of a linetype.
	///</summary>
	public class Set_NumDashes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NumDashes = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text to be included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text to be included as part of a linetype.
	///</summary>
	public class TextAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAt(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the text to be included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies or returns the text to be included as part of a linetype.
	///</summary>
	public class Set_TextAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAt[inputs[1]] = inputs[2];
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern length of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the pattern length of a linetype.
	///</summary>
	public class PatternLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PatternLength);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the pattern length of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the pattern length of a linetype.
	///</summary>
	public class Set_PatternLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PatternLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the dash length of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the dash length of a linetype.
	///</summary>
	public class DashLengthAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DashLengthAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the dash length of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dash length of a linetype.
	///</summary>
	public class Set_DashLengthAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DashLengthAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a shape that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the scale of a shape that is included as part of a linetype.
	///</summary>
	public class ShapeScaleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeScaleAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the scale of a shape that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the scale of a shape that is included as part of a linetype.
	///</summary>
	public class Set_ShapeScaleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeScaleAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the shape to be included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the shape to be included as part of a linetype.
	///</summary>
	public class ShapeNumberAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeNumberAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the shape to be included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the shape to be included as part of a linetype.
	///</summary>
	public class Set_ShapeNumberAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeNumberAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
	///</summary>
	public class ShapeRotationAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeRotationAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rotation angle of a shape or text that is included as part of a linetype.
	///</summary>
	public class Set_ShapeRotationAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeRotationAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the offset of a shape that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the offset of a shape that is included as part of a linetype.
	///</summary>
	public class ShapeOffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeOffsetAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the offset of a shape that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the offset of a shape that is included as part of a linetype.
	///</summary>
	public class Set_ShapeOffsetAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeOffsetAt = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style of a shape or text that is included as part of a linetype.", 
		ViewType = "Data")]
	[NodeInput("OdaLineType", typeof(object))]

	///<summary>
	///Specifies or returns the style of a shape or text that is included as part of a linetype.
	///</summary>
	public class ShapeStyleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShapeStyleAt);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the style of a shape or text that is included as part of a linetype.", 
		ViewType = "Modifier")]
	[NodeInput("OdaLineType", typeof(object))]
	[NodeInput("pStyle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the style of a shape or text that is included as part of a linetype.
	///</summary>
	public class Set_ShapeStyleAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShapeStyleAt = inputs[1].Value;
			return null;
		}
	}
}
