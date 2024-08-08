using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of an instance of a block definition inserted into a drawing
///</summary>
namespace OdaX.AcadBlockReference 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlockReference_Constructor : INode 
	{
		public OdaX.IAcadBlockReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadBlockReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadBlockReference_ConstructorCast : INode 
	{
		public OdaX.IAcadBlockReference _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadBlockReference;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates for the insertion point of a block or external reference.
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the name of a block or external reference.
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
		Text = "Specifies or returns the name of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a block or external reference.
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
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the rotation angle of a block or external reference.
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the rotation angle of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the rotation angle of a block or external reference.
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the XScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the XScale factor of a block or external reference.
	///</summary>
	public class XScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the XScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the XScale factor of a block or external reference.
	///</summary>
	public class Set_XScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the YScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the YScale factor of a block or external reference.
	///</summary>
	public class YScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the YScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the YScale factor of a block or external reference.
	///</summary>
	public class Set_YScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ZScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the ZScale factor of a block or external reference.
	///</summary>
	public class ZScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the ZScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the ZScale factor of a block or external reference.
	///</summary>
	public class Set_ZScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Explodes the block or external reference and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Explodes the block or external reference and returns the individual entities as an array of the object.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	[NVP_Manifest(
		Text = "Returns the attributes of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the attributes of a block or external reference.
	///</summary>
	public class GetAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAttributes);

		}
	}


	[NVP_Manifest(
		Text = "Returns the constant attributes of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the constant attributes of a block or external reference.
	///</summary>
	public class GetConstantAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetConstantAttributes);

		}
	}


	[NVP_Manifest(
		Text = "Returns if a block or external reference has any attributes associated with it.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns if a block or external reference has any attributes associated with it.
	///</summary>
	public class HasAttributes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasAttributes);

		}
	}


	[NVP_Manifest(
		Text = "Returns the original name of a block reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the original name of a block reference.
	///</summary>
	public class EffectiveName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EffectiveName);

		}
	}


	[NVP_Manifest(
		Text = "Returns if a block reference is dynamic.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns if a block reference is dynamic.
	///</summary>
	public class IsDynamicBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsDynamicBlock);

		}
	}


	[NVP_Manifest(
		Text = "Returns the properties of a dynamic block reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the properties of a dynamic block reference.
	///</summary>
	public class GetDynamicBlockProperties : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDynamicBlockProperties);

		}
	}


	[NVP_Manifest(
		Text = "Changes a dynamic block reference to its original state.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Changes a dynamic block reference to its original state.
	///</summary>
	public class ResetBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetBlock();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Converts a dynamic block reference to a regular block reference with no name.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Converts a dynamic block reference to a regular block reference with no name.
	///</summary>
	public class ConvertToAnonymousBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConvertToAnonymousBlock();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Converts a dynamic block reference to a regular block reference with a name.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("newBlockName", typeof(System.String))]

	///<summary>
	///Converts a dynamic block reference to a regular block reference with a name.
	///</summary>
	public class ConvertToStaticBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ConvertToStaticBlock(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective XScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective XScale factor of a block or external reference.
	///</summary>
	public class XEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.XEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective XScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective XScale factor of a block or external reference.
	///</summary>
	public class Set_XEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.XEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective YScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective YScale factor of a block or external reference.
	///</summary>
	public class YEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.YEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective YScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective YScale factor of a block or external reference.
	///</summary>
	public class Set_YEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.YEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective ZScale factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Specifies or returns the effective ZScale factor of a block or external reference.
	///</summary>
	public class ZEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ZEffectiveScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the effective ZScale factor of a block or external reference.", 
		ViewType = "Modifier")]
	[NodeInput("AcadBlockReference", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the effective ZScale factor of a block or external reference.
	///</summary>
	public class Set_ZEffectiveScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ZEffectiveScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the insertion units of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the insertion units of a block or external reference.
	///</summary>
	public class InsUnits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsUnits);

		}
	}


	[NVP_Manifest(
		Text = "Returns the insertion units factor of a block or external reference.", 
		ViewType = "Data")]
	[NodeInput("AcadBlockReference", typeof(object))]

	///<summary>
	///Returns the insertion units factor of a block or external reference.
	///</summary>
	public class InsUnitsFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsUnitsFactor);

		}
	}
}
