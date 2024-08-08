using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Property 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_Constructor : INode 
	{
		public Renga.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Property_ConstructorCast : INode 
	{
		public Renga.IProperty _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IProperty;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class SetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetDoubleValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetStringValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetDoubleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetDoubleValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetStringValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetStringValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResetValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResetValue();
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
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
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.AngleUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAngleValue(inputs[1].Value,((Renga.AngleUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetAreaValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetAreaValue(inputs[1].Value,((Renga.AreaUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetBooleanValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetBooleanValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class SetEnumerationValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetEnumerationValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class SetIntegerValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetIntegerValue(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetLengthValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLengthValue(inputs[1].Value,((Renga.LengthUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.Logical", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetLogicalValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetLogicalValue(((Renga.Logical)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetMassValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetMassValue(inputs[1].Value,((Renga.MassUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("value_", typeof(System.Double))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class SetVolumeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetVolumeValue(inputs[1].Value,((Renga.VolumeUnit)inputs[2].Value));
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.AngleUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetAngleValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAngleValue(((Renga.AngleUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.AreaUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetAreaValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetAreaValue(((Renga.AreaUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetBooleanValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetBooleanValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetEnumerationValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetEnumerationValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetIntegerValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetIntegerValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.LengthUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetLengthValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLengthValue(((Renga.LengthUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GetLogicalValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetLogicalValue);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.MassUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetMassValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetMassValue(((Renga.MassUnit)inputs[1].Value)));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Property", typeof(object))]
	[NodeInput("Renga.VolumeUnit", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetVolumeValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVolumeValue(((Renga.VolumeUnit)inputs[1].Value)));

		}
	}
}
